namespace opytuvannia_backend.Contracts.Surveys.Request;

public class CompleteSurveyRequest
{
    public string SurveyId { get; set; }
    public List<AnsweredQuestion> AnsweredQuestions { get; set; }
}