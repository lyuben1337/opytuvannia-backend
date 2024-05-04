namespace opytuvannia_backend.Entities;

public class RespondentSurveyAnswer
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string RespondentSurveyId { get; set; }
    public RespondentSurvey RespondentSurvey { get; set; }
    public string QuestionId { get; set; }
    public Question Question { get; set; }
    public string AnswerId { get; set; }
    public Answer Answer { get; set; }
}