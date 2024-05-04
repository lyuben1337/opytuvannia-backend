using Carter;
using FluentValidation;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using opytuvannia_backend.Contracts.Respondents.Requests;
using opytuvannia_backend.Contracts.Respondents.Responses;
using opytuvannia_backend.Database;
using opytuvannia_backend.Extensions.Security;
using opytuvannia_backend.Shared;

namespace opytuvannia_backend.Features.Respondents;

public static class CreateRespondentSession
{
    public class Command : IRequest<Result<RespondentSessionResponse>>
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
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
        }
    }
    
    internal sealed class Handler : IRequestHandler<Command, Result<RespondentSessionResponse>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IValidator<Command> _validator;
        private readonly IPasswordEncoder _passwordEncoder;
        private readonly IJwtProvider _jwtProvider;

        public Handler(ApplicationDbContext dbContext, IValidator<Command> validator, IPasswordEncoder passwordEncoder, 
            IJwtProvider jwtProvider)
        {
            _dbContext = dbContext;
            _validator = validator;
            _passwordEncoder = passwordEncoder;
            _jwtProvider = jwtProvider;
        }

        public async Task<Result<RespondentSessionResponse>> Handle(Command request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                return Result.Failure<RespondentSessionResponse>(new Error("CreateRespondentSession.Validation",
                    validationResult.ToString()));
            }

            var respondent = await _dbContext.Respondents
                .FirstOrDefaultAsync(r => r.Email == request.Email, cancellationToken);

            if (respondent is null || !_passwordEncoder.Verify(respondent.Password, request.Password))
            {
                return Result.Failure<RespondentSessionResponse>(new Error("CreateRespondentSession.InvalidPasswordOrLogin",
                    "Given login or password invalid!"));
            }

            var token = _jwtProvider.Generate(respondent);

            return new RespondentSessionResponse
            {
                Id = respondent.Id,
                Token = token,
                ExpirationDate = _jwtProvider.ExpirationDate
            };
        }
    }
}

public class CreateRespondentSessionEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/v1/respondents/sessions", Handler);
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RespondentSessionResponse))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Error))]
    private async Task<IResult> Handler(CreateRespondentSessionRequest request, ISender sender)
    {
        var command = request.Adapt<CreateRespondentSession.Command>();
        var result = await sender.Send(command);

        if (result.IsFailure)
        {
            return Results.BadRequest(result.Error);
        }

        return Results.Ok(result.Value);
    }
}