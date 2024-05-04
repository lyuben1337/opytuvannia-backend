namespace opytuvannia_backend.Entities;

public class Company
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public string LogoSrc { get; set; }
}