using Carter;
using FluentValidation;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using opytuvannia_backend.Contracts.Respondents.Responses;
using opytuvannia_backend.Database;
using opytuvannia_backend.Shared;

namespace opytuvannia_backend.Features.Respondents;

public static class GetRespondentById
{
    public class Query : IRequest<Result<RespondentResponse>>
    {
        public required string Id { get; set; }
    }

    public class Validator : AbstractValidator<Query>
    {
        public Validator()
        {
            RuleFor(c => c.Id)
                .Must(id => Guid.TryParse(id, out _))
                .WithMessage("Invalid id format");
        }
    }

    internal sealed class Handler : IRequestHandler<Query, Result<RespondentResponse>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IValidator<Query> _validator;

        public Handler(ApplicationDbContext dbContext, IValidator<Query> validator)
        {
            _dbContext = dbContext;
            _validator = validator;
        }

        public async Task<Result<RespondentResponse>> Handle(Query request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            
            if (!validationResult.IsValid)
            {
                return Result.Failure<RespondentResponse>(new Error("GetTodoById.Validation",
                    validationResult.ToString()));
            }

            var respondent = await _dbContext.Respondents.FindAsync(request.Id);

            if (respondent is null)
            {
                return Result.Failure<RespondentResponse>(Error.RespondentNotFound);
            }
            
            return respondent.Adapt<RespondentResponse>();
        }
    }
}

public class GetRespondentByIdEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("api/v1/respondents/{id}", Handler);
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RespondentResponse))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Error))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Error))]
    private async Task<IResult> Handler(string id, ISender sender)
    {
        var query = new GetRespondentById.Query
        {
            Id = id
        };
        
        var result = await sender.Send(query);

        if (result.IsSuccess)
        {
            return Results.Ok(result.Value);
        }

        if (result.Error.Equals(Error.RespondentNotFound))
        {
            return Results.NotFound(result.Error);
        }

        return Results.BadRequest(result.Error);
    }
}