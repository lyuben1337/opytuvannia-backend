namespace opytuvannia_backend.Entities;

public class Question
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public Survey Survey { get; set; }
    public string SurveyId { get; set; }
    public string Title { get; set; }
    public List<Answer> Answers { get; set; }
}