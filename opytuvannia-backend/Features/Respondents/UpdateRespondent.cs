using System.Security.Claims;
using Carter;
using FluentValidation;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using opytuvannia_backend.Contracts.Respondents.Requests;
using opytuvannia_backend.Contracts.Respondents.Responses;
using opytuvannia_backend.Database;
using opytuvannia_backend.Shared;
using opytuvannia_backend.Shared.Constants;

namespace opytuvannia_backend.Features.Respondents;

public static class UpdateRespondent
{
    public class Command : IRequest<Result>
    {
        public required string Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? Address { get; set; }
    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator()
        {
            RuleFor(c => c.Id)
                .NotEmpty()
                .Must(id => Guid.TryParse(id, out _))
                .WithMessage("Invalid id format");

            RuleFor(c => c.Name)
                .NotEmpty()
                .MaximumLength(255)
                .WithMessage("Invalid name format")
                .When(c => c.Name is not null);

            RuleFor(c => c.Gender)
                .NotEmpty()
                .MaximumLength(255)
                .Must(g => Enum.TryParse<Gender>(g, out _))
                .WithMessage("Invalid gender")
                .When(c => c.Gender is not null);

            RuleFor(c => c.BirthDate)
                .NotEmpty()
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Invalid birthdate")
                .When(c => c.BirthDate is not null);
        }
    }

    internal sealed class Handler : IRequestHandler<Command, Result>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IValidator<Command> _validator;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Handler(ApplicationDbContext dbContext, IValidator<Command> validator, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _validator = validator;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Result> Handle(Command request, CancellationToken cancellationToken)
        {
            var currentRespondentId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (currentRespondentId != request.Id)
            {
                return Result.Failure(new Error("UpdateRespondent.Forbidden",
                    "You cannot update someone else's account"));
            }
            
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                return Result.Failure(new Error("UpdateRespondent.Validation",
                    validationResult.ToString()));
            }

            var respondent = await _dbContext.Respondents.FindAsync(request.Id, cancellationToken);

            if (respondent is null)
            {
                return Result.Failure(Error.RespondentNotFound);
            }

            if (request.Name != null) respondent.Name = request.Name;
            if (request.Gender != null) respondent.Gender = Enum.Parse<Gender>(request.Gender);
            if (request.BirthDate != null) respondent.BirthDate = request.BirthDate;
            if (request.Address != null) respondent.Address = request.Address;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }
}

public class UpdateRespondentEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPatch("api/v1/respondents/{id}", Handler);
    }

    [Authorize]
    [HttpPatch]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Error))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Error))]
    private async Task<IResult> Handler(UpdateRespondentRequest request, string id,
        ISender sender)
    {
        var command = new UpdateRespondent.Command
        {
            Id = id,
            Name = request.Name,
            Gender = request.Gender,
            Address = request.Address,
            BirthDate = request.BirthDate
        };

        var result = await sender.Send(command);

        if (result.IsSuccess)
        {
            return Results.NoContent();
        }

        if (result.Error.Equals(Error.RespondentNotFound))
        {
            return Results.NotFound(result.Error);
        }

        return Results.BadRequest(result.Error);
    }
}