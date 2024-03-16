namespace opytuvannia_backend.Shared;

public record Error(string Code, string Message)
{
    // Default
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error NullValue = new("Error.NullValue", string.Empty);

    // Respondent
    public static readonly Error EmailOccupied =
        new("Respondent.EmailOccupied", "Account with given email already exists");
}