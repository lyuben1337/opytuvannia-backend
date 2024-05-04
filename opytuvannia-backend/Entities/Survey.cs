namespace opytuvannia_backend.Entities;

public class Survey
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; }
    public string CompanyId { get; set; }
    public Company Company { get; set; }
    public string Description { get; set; }
    public List<Question> Questions { get; set; }
    public string RewardId { get; set; }
    public Reward Reward { get; set; }
}