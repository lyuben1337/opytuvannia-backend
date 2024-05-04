namespace opytuvannia_backend.Extensions.Security;

public class JwtOptions
{
    public string Issuer { get; set; } = "Vladyslav";
    public string Audience { get; set; } = "NURE";
    public string SecretKey { get; set; } = "SUPER-SECRET-LONG-VERY-LONG-KEY-XXXXX-DOOOM-DFFFFFF";
}