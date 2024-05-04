namespace opytuvannia_backend.Contracts.Surveys.Response;

public class QuestionResponse
{
    public string Id { get; set; }
    public string Title { get; set; }
    public List<AnswerResponse> Answers { get; set; }
}