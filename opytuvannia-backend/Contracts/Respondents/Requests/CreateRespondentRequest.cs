namespace opytuvannia_backend.Contracts.Respondents.Requests;

public class CreateRespondentRequest
{
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Name { get; set; }
}