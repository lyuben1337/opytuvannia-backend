using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Carter;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using opytuvannia_backend.Contracts.Respondents.Responses;
using opytuvannia_backend.Contracts.Surveys.Response;
using opytuvannia_backend.Database;
using opytuvannia_backend.Shared;

namespace opytuvannia_backend.Features.Surveys;

public static class GetAllSurveys
{
    public class Query : IRequest<Result<SurveysResponse>>;
    
    internal sealed class Handler : IRequestHandler<Query, Result<SurveysResponse>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Handler(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
        }
        
        public async Task<Result<SurveysResponse>> Handle(Query request, CancellationToken cancellationToken)
        {
            var respondentId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            var surveys = await _dbContext.Surveys
                .Include(s => s.Company)
                .Where(s => !_dbContext.RespondentSurveys.Any(rs => rs.SurveyId == s.Id && rs.RespondentId == respondentId))
                .ToListAsync(cancellationToken);

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