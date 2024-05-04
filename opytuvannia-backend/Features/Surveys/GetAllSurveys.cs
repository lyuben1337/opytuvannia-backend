using Carter;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using opytuvannia_backend.Contracts.Respondents.Responses;
using opytuvannia_backend.Contracts.Surveys.Response;
using opytuvannia_backend.Database;
using opytuvannia_backend.Shared;

namespace opytuvannia_backend.Features.Surveys;

public static class GetAllSurveys
{
    public class Query : IRequest<Result<SurveysResponse>>
    {
        // TODO: Output for account
    }
    
    internal sealed class Handler : IRequestHandler<Query, Result<SurveysResponse>>
    {
        private readonly ApplicationDbContext _dbContext;

        public Handler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<Result<SurveysResponse>> Handle(Query request, CancellationToken cancellationToken)
        {
            var surveys = await _dbContext.Surveys.Include(s => s.Company).ToListAsync(cancellationToken);
            var surveysResponses = surveys.ConvertAll(s => s.Adapt<SurveyShortResponse>());
            return new SurveysResponse { Surveys = surveysResponses };
        }
    }
}

public class GetAllSurveysByIdEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("api/v1/surveys", Handler);
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SurveysResponse))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Error))]
    private async Task<IResult> Handler(ISender sender)
    {
        var query = new GetAllSurveys.Query();
        var result = await sender.Send(query);
        if (result.IsSuccess)
        {
            return Results.Ok(result.Value);
        }
        return Results.BadRequest(result.Error);
    }
}