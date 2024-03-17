namespace opytuvannia_backend.Extensions.Security;

public interface IPasswordEncoder
{
    string Encode(string password);

    bool Verify(string encryptedPassword, string password);
}