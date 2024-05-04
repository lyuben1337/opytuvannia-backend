using opytuvannia_backend.Entities;

namespace opytuvannia_backend.Contracts.Respondents.Responses;

public class RespondentResponse
{
    public string Id { get; set; }
    
    public string Email { get; set; }
    
    public string Name { get; set; }
    
    public string? Gender { get; set; }
    
    public DateTime? BirthDate { get; set; }
    
    public string? Address { get; set; }

    public List<Reward> Rewards { get; set; }
}