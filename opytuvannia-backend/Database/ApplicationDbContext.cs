using Microsoft.EntityFrameworkCore;
using opytuvannia_backend.Entities;

namespace opytuvannia_backend.Database;

public class ApplicationDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public ApplicationDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    // Entities
    public DbSet<Respondent> Respondents { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql(_configuration.GetConnectionString("Database"))
            .UseSnakeCaseNamingConvention();
    }
}