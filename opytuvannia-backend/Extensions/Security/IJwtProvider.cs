using opytuvannia_backend.Entities;

namespace opytuvannia_backend.Extensions.Security;

public interface IJwtProvider
{
    string Generate(Respondent respondent);
    DateTime ExpirationDate { get; }
}