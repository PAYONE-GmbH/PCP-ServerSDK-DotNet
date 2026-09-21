using System.Net;
using Moq;
using PCPServerSDKDotNet;
using PCPServerSDKDotNet.Endpoints;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNetTests.TestUtils;

namespace PCPServerSDKDotNetTests.Endpoints;

public class PayByLinkApiClientTests
{
    private readonly CommunicatorConfiguration COMMUNICATOR_CONFIGURATION = new(
        "KEY", "Super duper Ethan Hunt level secret", "awesome-api.com", null);

    [Fact]
    public async Task CreatePayByLinkRequestSuccessful()
    {
        Mock<PayByLinkApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CreatePayByLinkResponse expected = new() { PaymentLinkId = "123" };
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.Created, expected);
        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CreatePayByLinkRequest payload = new()
        {
            PaymentLinkSpecificInput = new()
            {
                AuthorizationMode = AuthorizationMode.Sale,
                PaymentMethods = ["840"],
            },
            OrderType = OrderType.Full,
            OrderReferences = new() { MerchantReference = "order-1" },
        };

        CreatePayByLinkResponse result = await mockClient.Object.CreatePayByLinkRequestAsync("1", "2", "3", payload);

        Assert.Equivalent(expected, result);
    }
}
