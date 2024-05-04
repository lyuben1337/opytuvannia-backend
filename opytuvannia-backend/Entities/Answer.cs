namespace opytuvannia_backend.Entities;

public class Answer
{
     public string Id { get; set; } = Guid.NewGuid().ToString();
     public string QuestionId { get; set; }
     public Question Question { get; set; }
     public string Content { get; set; }
}