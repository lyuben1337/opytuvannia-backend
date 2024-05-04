using System.Security.Claims;
using Carter;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using opytuvannia_backend.Contracts.Surveys.Response;
using opytuvannia_backend.Database;
using opytuvannia_backend.Features.Respondents;
using opytuvannia_backend.Shared;

namespace opytuvannia_backend.Features.Surveys;

public static class GetSurveyById
{
    public class Query : IRequest<Result<SurveyResponse>>
    {
        public string Id { get; set; }
    }
    
    internal sealed class Handler : IRequestHandler<Query, Result<SurveyResponse>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Handler(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
        }
        
        public async Task<Result<SurveyResponse>> Handle(Query request, CancellationToken cancellationToken)
        {
            var survey = await _dbContext.Surveys
                .Include(s => s.Company)
                .Include(s => s.Questions)
                .ThenInclude(question => question.Answers)
                .FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken);
            
            if (survey is null)
            {
                return Result.Failure<SurveyResponse>(Error.SurveyNotFound);
            }
            
            var respondentId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            var existingRespondentSurvey = await _dbContext.RespondentSurveys
                .FirstOrDefaultAsync(rs => rs.RespondentId == respondentId && rs.SurveyId == survey.Id, cancellationToken);

            if (existingRespondentSurvey != null)
            {
                return Result.Failure<SurveyResponse>(
                    new Error("Survey.AlreadyResponded", "You have already responded this survey!"));
            }
            
            var questions = survey.Questions.ConvertAll(q =>
            {
                return new QuestionResponse
                {
                    Id = q.Id,
                    Title = q.Title,
                    Answers = q.Answers.ConvertAll(a => a.Adapt<AnswerResponse>())
                };
            });

            return new SurveyResponse
            {
                Id = survey.Id,
                Company = survey.Company,
                Description = survey.Description,
                Title = survey.Title,
                Questions = questions
            };
        }
    }
}

public class GetSurveyByIdEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("api/v1/surveys/{id}", Handler);
    }

    [Authorize]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SurveyResponse))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Error))]
    private async Task<IResult> Handler(string id, ISender sender)
    {
        var query = new GetSurveyById.Query
        {
            Id = id
        };
        
        var result = await sender.Send(query);

        if (result.IsSuccess)
        {
            return Results.Ok(result.Value);
        }

        return Results.NotFound(result.Error);
    }
}

