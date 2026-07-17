using System.Net;
using Moq;
using PCPServerSDKDotNet;
using PCPServerSDKDotNet.Endpoints;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNetTests.TestUtils;

namespace PCPServerSDKDotNetTests.Endpoints;

public class PaymentIntentApiClientTests
{
    private readonly CommunicatorConfiguration communicatorConfiguration = new("KEY", "secret", "awesome-api.com", null);

    [Fact]
    public async Task CreatePaymentIntent_UsesThePaymentIntentsRoute()
    {
        Mock<PaymentIntentApiClient> mockClient = new(this.communicatorConfiguration);
        HttpRequestMessage? sentRequest = null;
        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>()))
            .Callback<HttpRequestMessage>(request => sentRequest = request)
            .ReturnsAsync(ApiResponseMocks.CreateResponse(HttpStatusCode.Created, new CreatePaymentIntentResponse()));

        await mockClient.Object.CreatePaymentIntentAsync("merchant", new CreatePaymentIntentRequest());

        Assert.NotNull(sentRequest);
        Assert.Equal(HttpMethod.Post, sentRequest.Method);
        Assert.Equal("/v1/merchant/payment-intents", sentRequest.RequestUri!.AbsolutePath);
    }

    [Fact]
    public async Task GetPaymentIntent_UsesThePaymentIntentIdRoute()
    {
        Mock<PaymentIntentApiClient> mockClient = new(this.communicatorConfiguration);
        HttpRequestMessage? sentRequest = null;
        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>()))
            .Callback<HttpRequestMessage>(request => sentRequest = request)
            .ReturnsAsync(ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new PaymentIntentResponse()));

        await mockClient.Object.GetPaymentIntentAsync("merchant", "intent");

        Assert.NotNull(sentRequest);
        Assert.Equal(HttpMethod.Get, sentRequest.Method);
        Assert.Equal("/v1/merchant/payment-intents/intent", sentRequest.RequestUri!.AbsolutePath);
    }
}
