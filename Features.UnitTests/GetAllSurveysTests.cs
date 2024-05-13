using System.Net;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Moq;
using Moq.Protected;
using opytuvannia_backend.Contracts.Surveys.Response;
using opytuvannia_backend.Features.Surveys;
using opytuvannia_backend.Shared;

namespace Features.UnitTests;

public class GetAllSurveyTests
{
    [Fact]
    public async Task Handler_ReturnsStatusOk_WhenIsSuccessIsTrue()
    {
        // arrange
        var client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5033/")
        };

        // act
        HttpResponseMessage response = await client.GetAsync("api/v1/surveys");

        // assert 
        response.EnsureSuccessStatusCode(); // Status200OK
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
    
    // Mock
    [Fact]
    public async Task Handler_ReturnsStatusOk_WhenIsSuccessIsTrue_Mocked()
    {
        // arrange
        var handlerMock = new Mock<HttpMessageHandler>();
        var response = new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.OK,
            Content = new StringContent("[{'id':1,'value':'1'}]"),
        };

        handlerMock
            .Protected()
            // Setup the PROTECTED method to mock
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>()
            )
            .ReturnsAsync(response)
            .Verifiable();

        var httpClient = new HttpClient(handlerMock.Object)
        {
            BaseAddress = new Uri("http://localhost:5033/"),
        };
        var clientFactoryMock = new Mock<IHttpClientFactory>();
        clientFactoryMock.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(httpClient);

        // act
        HttpResponseMessage result = await httpClient.GetAsync("api/v1/surveys");

        // assert
        result.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, result.StatusCode);

        handlerMock.Protected().Verify(
            "SendAsync",
            Times.Exactly(1),
            ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Get 
                    && req.RequestUri == new Uri("http://localhost:5033/api/v1/surveys")
            ),
            ItExpr.IsAny<CancellationToken>()
        );
    }
}