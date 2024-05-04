using System.Security.Claims;
using Carter;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using opytuvannia_backend.Contracts.Surveys.Request;
using opytuvannia_backend.Contracts.Surveys.Response;
using opytuvannia_backend.Database;
using opytuvannia_backend.Entities;
using opytuvannia_backend.Features.Respondents;
using opytuvannia_backend.Shared;

namespace opytuvannia_backend.Features.Surveys;

public static class CompleteSurvey
{
    public class Command : IRequest<Result<CompleteSurveyResponse>>
    {
        public string SurveyId { get; set; }
        public List<AnsweredQuestion> AnsweredQuestions { get; set; }
    }
    
    internal sealed class Handler : IRequestHandler<Command, Result<CompleteSurveyResponse>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Handler(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Result<CompleteSurveyResponse>> Handle(Command request, CancellationToken cancellationToken)
        {
            var respondentId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var existingRespondentSurvey = await _dbContext.RespondentSurveys
                .FirstOrDefaultAsync(rs => rs.RespondentId == respondentId && rs.SurveyId == request.SurveyId, cancellationToken);

            if (existingRespondentSurvey != null)
            {
                return Result.Failure<CompleteSurveyResponse>(new Error("CompleteSurvey.Forbidden",
                    "You have already completed this survey."));
            }
            
            var survey = await _dbContext.Surveys
                .Include(s => s.Questions)
                .ThenInclude(question => question.Answers)
                .Include(s => s.Reward)
                .FirstOrDefaultAsync(s => s.Id == request.SurveyId, cancellationToken);

            if (survey is null)
            {
                return Result.Failure<CompleteSurveyResponse>(Error.SurveyNotFound);
            }

            if (survey.Questions.Count != request.AnsweredQuestions.Count)
            {
                return Result.Failure<CompleteSurveyResponse>(new Error("CompleteSurvey.BadRequest",
                    "Invalid question count!"));
            }

            foreach (var question in survey.Questions)
            {
                var answeredQuestion = request.AnsweredQuestions.Find(q => q.QuestionId == question.Id);
                if (answeredQuestion is null)
                {
                    return Result.Failure<CompleteSurveyResponse>(new Error("CompleteSurvey.BadRequest",
                        "Invalid question id!"));
                }

                if (answeredQuestion.AnswerIds.Count < 1)
                {
                    return Result.Failure<CompleteSurveyResponse>(new Error("CompleteSurvey.BadRequest",
                        "At least one answer for one question!"));
                }

                if (answeredQuestion.AnswerIds.Select(givenAnswerId => question.Answers
                        .Find(a => a.Id == givenAnswerId)).Any(existedAnswer => existedAnswer is null))
                {
                    return Result.Failure<CompleteSurveyResponse>(new Error("CompleteSurvey.BadRequest",
                        "Invalid answer id!"));
                }
            }

            var completedSurvey = new RespondentSurvey()
            {
                RespondentId = respondentId,
                SurveyId = survey.Id
            };
            
            var answers = new List<RespondentSurveyAnswer>();

            foreach (var question in request.AnsweredQuestions)
            {
                foreach (var answerId in question.AnswerIds)
                {
                    answers.Add(new RespondentSurveyAnswer
                    {
                        QuestionId = question.QuestionId,
                        AnswerId = answerId,
                        RespondentSurveyId = completedSurvey.Id
                    });
                }
            }

            var respondentReward = new RespondentReward
            {
                RespondentId = respondentId,
                RewardId = survey.Reward.Id
            };
            
            _dbContext.RespondentSurveys.Add(completedSurvey);
            _dbContext.RespondentSurveyAnswers.AddRange(answers);
            _dbContext.RespondentRewards.Add(respondentReward);
            await _dbContext.SaveChangesAsync(cancellationToken);
            
            return new CompleteSurveyResponse { Reward = survey.Reward.Content };
        }
    }
}

public class CompleteSurveyEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/v1/surveys/complete", Handler);
    }

    [HttpPost]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CompleteSurveyResponse))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Error))]
    private async Task<IResult> Handler(CompleteSurveyRequest request, ISender sender)
    {
        var command = request.Adapt<CompleteSurvey.Command>();
        var result = await sender.Send(command);
        
        if (result.IsSuccess)
        {
            return Results.Ok(result.Value);
        }

        if (result.Error == Error.SurveyNotFound)
        {
            return Results.NotFound(result.Error);
        }
        
        return Results.BadRequest(result.Error);
    }
}