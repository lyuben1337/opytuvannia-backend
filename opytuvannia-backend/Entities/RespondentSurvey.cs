namespace opytuvannia_backend.Entities;

public class RespondentSurvey
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string RespondentId { get; set; }
    public Respondent Respondent { get; set; }
    public string SurveyId { get; set; }
    public Survey Survey { get; set; }
    public DateTime CompletionDate { get; set; } = DateTime.UtcNow;
    public List<RespondentSurveyAnswer> Answers { get; set; }
}