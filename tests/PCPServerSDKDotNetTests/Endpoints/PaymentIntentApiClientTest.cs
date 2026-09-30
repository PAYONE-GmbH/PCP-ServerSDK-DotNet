using System.Net;
using Newtonsoft.Json.Linq;
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

        await mockClient.Object.CreatePaymentIntentAsync("merchant", CreateRequest());

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
            client.CreatePaymentIntentAsync(merchantId, CreateRequest()));

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

    [Fact]
    public async Task PatchPaymentIntent_SendsSchemaPayloadAndReadsUpdatedResponse()
    {
        Mock<PaymentIntentApiClient> mockClient = new(this.communicatorConfiguration);
        HttpRequestMessage? sentRequest = null;
        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>()))
            .Callback<HttpRequestMessage>(request => sentRequest = request)
            .ReturnsAsync(ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new PatchPaymentIntentResponse
            {
                PaymentIntentOutput = new PaymentIntentOutput { PaymentIntentId = "intent" },
            }));

        PatchPaymentIntentResponse result = await mockClient.Object.PatchPaymentIntentAsync("merchant", "intent", new PatchPaymentIntentRequest
        {
            AmountOfMoney = new AmountOfMoney { Amount = 2500, CurrencyCode = "EUR" },
            ShoppingCart = new ShoppingCartData { Items = [] },
        });

        Assert.NotNull(sentRequest);
        Assert.Equal(HttpMethod.Patch, sentRequest.Method);
        Assert.Equal("/v1/merchant/payment-intents/intent", sentRequest.RequestUri!.AbsolutePath);
        Assert.Equal("application/json", sentRequest.Content!.Headers.ContentType!.MediaType);
        JObject body = JObject.Parse(await sentRequest.Content.ReadAsStringAsync());
        Assert.Equal(2500, (long?)body["amountOfMoney"]?["amount"]);
        Assert.Equal("EUR", (string?)body["amountOfMoney"]?["currencyCode"]);
        Assert.NotNull(body["shoppingCart"]?["items"]);
        Assert.Equal("intent", result.PaymentIntentOutput?.PaymentIntentId);
    }

    [Theory]
    [InlineData(null, "intent", "Merchant ID is required")]
    [InlineData("", "intent", "Merchant ID is required")]
    [InlineData("merchant", null, "Payment Intent ID is required")]
    [InlineData("merchant", "", "Payment Intent ID is required")]
    public async Task PatchPaymentIntent_WithoutPathParameter_ThrowsArgumentException(string merchantId, string paymentIntentId, string expectedMessage)
    {
        PaymentIntentApiClient client = new(this.communicatorConfiguration);

        ArgumentException exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            client.PatchPaymentIntentAsync(merchantId, paymentIntentId, new PatchPaymentIntentRequest()));

        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public async Task PatchPaymentIntent_WithoutPayload_ThrowsArgumentException()
    {
        PaymentIntentApiClient client = new(this.communicatorConfiguration);

        ArgumentException exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            client.PatchPaymentIntentAsync("merchant", "intent", null!));

        Assert.Equal("Payload is required", exception.Message);
    }

    private static CreatePaymentIntentRequest CreateRequest()
    {
        return new CreatePaymentIntentRequest
        {
            References = new PaymentReferencesForPaymentIntent { MerchantReference = "order-1" },
        };
    }
}
