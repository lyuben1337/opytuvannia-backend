using System.ComponentModel.DataAnnotations;

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
    
    [MaxLength(10)]
    public string? Gender { get; set; }
    
    public DateOnly? BirthDate { get; set; }
    
    [MaxLength(255)]
    public string? Address { get; set; }
}