namespace opytuvannia_backend.Contracts.Respondents.Responses;

public class RespondentResponse
{
    public required string Id { get; set; }
    
    public required string Email { get; set; }
    
    public required string Name { get; set; }
    
    public string? Gender { get; set; }
    
    public DateOnly? BirthDate { get; set; }
    
    public string? Address { get; set; }
}