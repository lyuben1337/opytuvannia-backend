namespace opytuvannia_backend.Shared;

public record Error(string Code, string Message)
{
    // Default
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error NullValue = new("Error.NullValue", string.Empty);

    // Respondent
    public static readonly Error EmailOccupied =
        new("Respondent.EmailOccupied", "Account with given email already exists");
    public static readonly Error RespondentNotFound =
        new("Respondent.NotFound", "Respondent with specified id does not exist");
    
    // Survey
    public static readonly Error SurveyNotFound = new("Survey.NotFound", "Survey with specified id does not exist");
}