namespace opytuvannia_backend.Entities;

public class Reward
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Content { get; set; }
}