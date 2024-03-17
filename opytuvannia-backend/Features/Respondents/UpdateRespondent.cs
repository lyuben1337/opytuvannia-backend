using Carter;
using FluentValidation;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using opytuvannia_backend.Contracts.Respondents.Requests;
using opytuvannia_backend.Contracts.Respondents.Responses;
using opytuvannia_backend.Database;
using opytuvannia_backend.Shared;
using opytuvannia_backend.Shared.Constants;

namespace opytuvannia_backend.Features.Respondents;

public static class UpdateRespondent
{
    public class Command : IRequest<Result<RespondentResponse>>
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
                .Must(g => Enum.TryParse<Gender>(value: g, ignoreCase: true, out _))
                .WithMessage("Invalid gender")
                .When(c => c.Gender is not null);

            RuleFor(c => c.BirthDate)
                .NotEmpty()
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Invalid birthdate")
                .When(c => c.BirthDate is not null);
        }
    }

    internal sealed class Handler : IRequestHandler<Command, Result<RespondentResponse>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IValidator<Command> _validator;

        public Handler(ApplicationDbContext dbContext, IValidator<Command> validator)
        {
            _dbContext = dbContext;
            _validator = validator;
        }

        public async Task<Result<RespondentResponse>> Handle(Command request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                return Result.Failure<RespondentResponse>(new Error("UpdateRespondent.Validation",
                    validationResult.ToString()));
            }

            var respondentToUpdate = await _dbContext.Respondents.FindAsync(request.Id, cancellationToken);

            if (respondentToUpdate is null)
            {
                return Result.Failure<RespondentResponse>(Error.RespondentNotFound);
            }

            if (request.Name != null) respondentToUpdate.Name = request.Name;
            if (request.Gender != null) respondentToUpdate.Gender = Enum.Parse<Gender>(request.Gender);
            if (request.BirthDate != null) respondentToUpdate.BirthDate = request.BirthDate;
            if (request.Address != null) respondentToUpdate.Address = request.Address;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return respondentToUpdate.Adapt<RespondentResponse>();
        }
    }
}

public class UpdateRespondentEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPatch("api/v1/respondents/{id}", UpdateRespondentHandler);
    }

    [HttpPatch]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Error))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Error))]
    private async Task<IResult> UpdateRespondentHandler(UpdateRespondentRequest request, string id,
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