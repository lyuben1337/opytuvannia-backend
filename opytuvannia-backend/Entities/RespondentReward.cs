namespace opytuvannia_backend.Entities;

public class RespondentReward
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string RespondentId { get; set; }
    public string RewardId { get; set; }
    public Reward Reward { get; set; }
    public Respondent Respondent { get; set; }
}