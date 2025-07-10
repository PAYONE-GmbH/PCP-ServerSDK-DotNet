using System.Net;
using Moq;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet;
using PCPServerSDKDotNet.Endpoints;
using PCPServerSDKDotNetTests.TestUtils;

namespace PCPServerSDKDotNetTests.Endpoints;

public class AuthenticationApiClientTest
{
    private readonly CommunicatorConfiguration COMMUNICATOR_CONFIGURATION = new("KEY",
        "Super duper Ethan Hunt level secret",
        "awesome-api.com", null);

    [Fact]
    public async Task GetAuthenticationTokensSuccessful()
    {
        Mock<AuthenticationApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        AuthenticationToken expected = new() { Id = "id", Token = "token" };
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, expected);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        AuthenticationToken result = await mockClient.Object.GetAuthenticationTokensAsync("1");

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task GetAuthenticationTokensUnsuccessful()
    {
        Mock<AuthenticationApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.GetAuthenticationTokensAsync("1");
        });
    }

    [Fact]
    public async Task GetAuthenticationTokensUnsuccessful500()
    {
        Mock<AuthenticationApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.GetAuthenticationTokensAsync("1");
        });
    }

    [Fact]
    public async Task ThrowsOnMissingMerchantId()
    {
        var client = new AuthenticationApiClient(COMMUNICATOR_CONFIGURATION);
        await Assert.ThrowsAsync<ArgumentException>(() => client.GetAuthenticationTokensAsync(null!));
    }
}
