namespace opytuvannia_backend.Contracts.Surveys.Request;

public class AnsweredQuestion
{
    public string QuestionId { get; set; }
    public List<string> AnswerIds { get; set; }
}