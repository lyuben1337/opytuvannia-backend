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
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Survey> Surveys { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<RespondentSurvey> RespondentSurveys { get; set; }
    public DbSet<RespondentSurveyAnswer> RespondentSurveyAnswers { get; set; }
    public DbSet<Reward> Rewards { get; set; }
    public DbSet<RespondentReward> RespondentRewards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql(_configuration.GetConnectionString("Database"))
            .UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
        base.OnModelCreating(modelBuilder);
    }
}