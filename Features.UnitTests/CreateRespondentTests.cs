using System.Net;
using System.Net.Http.Json;
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
    
    [Fact]
    public async Task Handler_ReturnsStatusCreated_WhenCreatedAccount()
    {
        // arrange
        var client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5033/")
        };
        var random = new Random();
        List<string> randomEmails = ["zxç", "qwe", "dd", "ww", "qweqwe", "qweqwe", "dfsjkalf", "dflksaf", "qweqwe"];
        var model = new CreateRespondent.Command { Email = $"exam{randomEmails[random.Next(randomEmails.Count)]}p{randomEmails[random.Next(randomEmails.Count)]}le@email.com", Password = "Qwerty228_", Name = "zdarova vlados" };
        
        // act
        HttpResponseMessage response = await client.PostAsJsonAsync("api/v1/respondents", model);

        // assert 
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.Created, response.StatusCode);
    }
}

