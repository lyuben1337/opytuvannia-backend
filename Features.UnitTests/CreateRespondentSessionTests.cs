using System.Net;
using System.Net.Http.Json;
using opytuvannia_backend.Features.Respondents;

namespace Features.UnitTests;

public class CreateRespondentSessionTests
{
    [Fact]
    public async Task Validator_ShouldFailOnInvalidEmail()
    {
        // arrange
        var model = new CreateRespondentSession.Command { Email = "invalid", Password = "sOm3password_" };
        var validator = new CreateRespondentSession.Validator();
        
        // act
        var result = await validator.ValidateAsync(model);

        // assert
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == nameof(CreateRespondentSession.Command.Email));
    }
    
    [Fact]
    public async Task Validator_ShouldFailOnInvalidPassword()
    {
        // arrange
        var model = new CreateRespondentSession.Command { Email = "example@email.com", Password = "invalid" };
        var validator = new CreateRespondentSession.Validator();

        // act
        var result = await validator.ValidateAsync(model);

        // assert
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == nameof(CreateRespondentSession.Command.Password));
    }
    
    [Fact]
    public async Task Handler_ReturnsStatusOk_WhenLoggedIn()
    {
        // arrange
        var client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5033/")
        };
        var random = new Random();
        List<string> randomEmails = ["zxç", "qwe", "dd", "ww", "qweqwe", "qweqwe", "dfsjkalf", "dflksaf", "qweqwe"];
        var randomEmail =
            $"exam{randomEmails[random.Next(randomEmails.Count)]}p{randomEmails[random.Next(randomEmails.Count)]}le@email.com";
        var password = "Qwerty228_";

        var newAccount = new CreateRespondent.Command
            { Email = randomEmail, Password = "Qwerty228_", Name = "Zxc Lord" };
        
        await client.PostAsJsonAsync("api/v1/respondents", newAccount);
        
        var account = new CreateRespondentSession.Command { Email = randomEmail, Password = "Qwerty228_" };
        
        // act
        HttpResponseMessage response = await client.PostAsJsonAsync("api/v1/respondents/sessions", account);

        // assert 
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}