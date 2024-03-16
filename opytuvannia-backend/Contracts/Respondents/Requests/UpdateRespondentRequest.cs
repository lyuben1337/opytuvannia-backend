namespace opytuvannia_backend.Contracts.Respondents.Requests;

public class UpdateRespondentRequest
{
    public string? Name { get; set; }
    
    public string? Gender { get; set; }
    
    public DateOnly? BirthDate { get; set; }
    
    public string? Address { get; set; }
}