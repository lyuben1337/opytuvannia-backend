namespace opytuvannia_backend.Contracts.Respondents.Responses;

public class RespondentSessionResponse
{
    public string Token { get; set; }
    public DateTime ExpirationDate { get; set; }
}