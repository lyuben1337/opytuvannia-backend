using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using opytuvannia_backend.Entities;

namespace opytuvannia_backend.Extensions.Security;

public class JwtProvider : IJwtProvider
{
    private const int ExpirationTimeMinutes = 60;
    private readonly JwtOptions _options;

    public JwtProvider(IOptions<JwtOptions> options)
    {
        _options = options.Value;
    }

    public string Generate(Respondent respondent)
    {
        var claims = new Claim[]
        {
            new(JwtRegisteredClaimNames.Sub, respondent.Id),
            new(JwtRegisteredClaimNames.Name, respondent.Name),
            new(JwtRegisteredClaimNames.Email, respondent.Email),
        };
        
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_options.SecretKey)
            ), SecurityAlgorithms.HmacSha256
        );
        
        var token = new JwtSecurityToken(
            _options.Issuer,
            _options.Audience,
            claims,
            null,
            ExpirationDate,
            signingCredentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public DateTime ExpirationDate { get; } = DateTime.UtcNow.AddHours(ExpirationTimeMinutes);
}