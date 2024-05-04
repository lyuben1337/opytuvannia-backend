using opytuvannia_backend.Entities;

namespace opytuvannia_backend.Contracts.Surveys.Response;

public class SurveyResponse
{
    public string Id { get; set; }
    public string Title { get; set; }
    public Company Company { get; set; }
    public string Description { get; set; }
    public List<QuestionResponse> Questions { get; set; }
}