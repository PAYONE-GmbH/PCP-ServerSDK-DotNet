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

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public async Task CreatePaymentIntent_WithoutMerchantId_ThrowsArgumentException(string merchantId)
    {
        PaymentIntentApiClient client = new(this.communicatorConfiguration);

        ArgumentException exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            client.CreatePaymentIntentAsync(merchantId, new CreatePaymentIntentRequest()));

        Assert.Equal("Merchant ID is required", exception.Message);
    }

    [Fact]
    public async Task CreatePaymentIntent_WithoutPayload_ThrowsArgumentException()
    {
        PaymentIntentApiClient client = new(this.communicatorConfiguration);

        ArgumentException exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            client.CreatePaymentIntentAsync("merchant", null!));

        Assert.Equal("Payload is required", exception.Message);
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

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public async Task GetPaymentIntent_WithoutMerchantId_ThrowsArgumentException(string merchantId)
    {
        PaymentIntentApiClient client = new(this.communicatorConfiguration);

        ArgumentException exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            client.GetPaymentIntentAsync(merchantId, "intent"));

        Assert.Equal("Merchant ID is required", exception.Message);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public async Task GetPaymentIntent_WithoutPaymentIntentId_ThrowsArgumentException(string paymentIntentId)
    {
        PaymentIntentApiClient client = new(this.communicatorConfiguration);

        ArgumentException exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            client.GetPaymentIntentAsync("merchant", paymentIntentId));

        Assert.Equal("Payment Intent ID is required", exception.Message);
    }
}
