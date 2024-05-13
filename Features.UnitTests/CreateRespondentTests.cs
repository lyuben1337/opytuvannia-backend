using opytuvannia_backend.Features.Respondents;

namespace Features.UnitTests;

public class CreateRespondentTests
{
    [Fact]
    public async Task Validator_ShouldFailOnInvalidEmail()
    {
        // arrange
        var model = new CreateRespondent.Command { Email = "invalid", Password = "sOm3password_", Name = "Name" };
        var validator = new CreateRespondent.Validator();
        
        // act
        var result = await validator.ValidateAsync(model);

        // assert
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == nameof(CreateRespondent.Command.Email));
    }
    
        
    [Fact]
    public async Task Validator_ShouldFailOnInvalidPassword()
    {
        // arrange
        var model = new CreateRespondent.Command { Email = "example@email.com", Password = "invalid", Name = "Name" };
        var validator = new CreateRespondent.Validator();

        // act
        var result = await validator.ValidateAsync(model);

        // assert
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == nameof(CreateRespondent.Command.Password));
    }
    
    [Fact]
    public async Task Validator_ShouldFailOnInvalidName()
    {
        // arrange
        var model = new CreateRespondent.Command { Email = "example@email.com", Password = "sOm3password_", Name = "" };
        var validator = new CreateRespondent.Validator();

        // act
        var result = await validator.ValidateAsync(model);

        // assert
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == nameof(CreateRespondent.Command.Name));
    }
}

