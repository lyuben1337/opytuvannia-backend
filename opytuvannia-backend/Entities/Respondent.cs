using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using opytuvannia_backend.Shared;
using opytuvannia_backend.Shared.Constants;

namespace opytuvannia_backend.Entities;

public class Respondent
{
    [MaxLength(36)]
    public string Id { get; init; } = Guid.NewGuid().ToString();
    
    [MaxLength(320)]
    public required string Email { get; set; }
    
    [MaxLength(255)]
    public required string Password { get; set; }
    
    [MaxLength(255)]
    public required string Name { get; set; }
    
    [Column(TypeName = "character varying(10)")]
    public Gender? Gender { get; set; }
    
    public DateTime? BirthDate { get; set; }
    
    [MaxLength(255)]
    public string? Address { get; set; }

    public List<RespondentSurvey> CompletedSurveys { get; set; }

    public List<RespondentReward> Rewards { get; set; }
}