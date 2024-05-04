using Carter;
using FluentValidation;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using opytuvannia_backend.Contracts.Respondents.Requests;
using opytuvannia_backend.Contracts.Respondents.Responses;
using opytuvannia_backend.Database;
using opytuvannia_backend.Entities;
using opytuvannia_backend.Extensions.Security;
using opytuvannia_backend.Shared;
using opytuvannia_backend.Shared.Constants;

namespace opytuvannia_backend.Features.Respondents;

public static class CreateRespondent
{
    public class Command : IRequest<Result<RespondentResponse>>
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Name { get; set; }
    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                .MaximumLength(320)
                .EmailAddress()
                .WithMessage("Invalid email format");
            
            RuleFor(c => c.Password)
                .NotEmpty()
                .MaximumLength(320)
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")
                .WithMessage("Invalid password format");

            RuleFor(c => c.Name)
                .NotEmpty()
                .MaximumLength(255)
                .WithMessage("Invalid name format");
        }
    }

    internal sealed class Handler : IRequestHandler<Command, Result<RespondentResponse>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IValidator<Command> _validator;
        private readonly IPasswordEncoder _passwordEncoder;

        public Handler(ApplicationDbContext dbContext, IValidator<Command> validator, IPasswordEncoder passwordEncoder)
        {
            _dbContext = dbContext;
            _validator = validator;
            _passwordEncoder = passwordEncoder;
        }

        public async Task<Result<RespondentResponse>> Handle(Command request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                return Result.Failure<RespondentResponse>(new Error("CreateRespondent.Validation",
                    validationResult.ToString()));
            }

            var isOccupiedEmail = _dbContext.Respondents.Any(a => a.Email == request.Email);

            if (isOccupiedEmail)
            {
                return Result.Failure<RespondentResponse>(Error.EmailOccupied);
            }

            var encryptedPassword = _passwordEncoder.Encode(request.Password);
            
            var respondent = new Respondent
            {
                Email = request.Email,
                Password = encryptedPassword,
                Name = request.Name,
                Gender = Gender.Unknown
            };

            _dbContext.Add(respondent);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return respondent.Adapt<RespondentResponse>();
        }
    }
}

public class CreateRespondentEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/v1/respondents", Handler);
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(RespondentResponse))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Error))]
    private async Task<IResult> Handler(CreateRespondentRequest request, ISender sender)
    {
        var command = request.Adapt<CreateRespondent.Command>();
        var result = await sender.Send(command);

        if (result.IsFailure)
        {
            return Results.BadRequest(result.Error);
        }

        return Results.Created($"api/v1/respondents/{result.Value.Id}", result.Value);
    }
}