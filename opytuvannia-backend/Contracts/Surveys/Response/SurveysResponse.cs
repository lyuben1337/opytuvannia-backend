using opytuvannia_backend.Entities;

namespace opytuvannia_backend.Contracts.Surveys.Response;

public class SurveysResponse
{
    public List<SurveyShortResponse> Surveys { get; set; }
}