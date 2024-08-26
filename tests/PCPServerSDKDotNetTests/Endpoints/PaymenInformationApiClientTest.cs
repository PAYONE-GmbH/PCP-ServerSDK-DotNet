using System.Net;
using Moq;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet;
using PCPServerSDKDotNet.Endpoints;
using PCPServerSDKDotNetTests.TestUtils;

namespace PCPServerSDKDotNetTests.Endpoints;

public class PaymentInformationApiClientTests
{
    private readonly CommunicatorConfiguration COMMUNICATOR_CONFIGURATION = new("KEY",
        "Super duper Ethan Hunt level secret",
        "awesome-api.com", null);

    [Fact]
    public async Task CreatePaymentInformationSuccessful()
    {
        Mock<PaymentInformationApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        PaymentInformationResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.Created, new PaymentInformationResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PaymentInformationRequest payload = new();
        PaymentInformationResponse result = await mockClient.Object.CreatePaymentInformationAsync("1", "2", "3", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task CreatePaymentInformationUnsuccessful()
    {
        Mock<PaymentInformationApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PaymentInformationRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.CreatePaymentInformationAsync("1", "2", "3", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task CreatePaymentInformationUnsuccessful500()
    {
        Mock<PaymentInformationApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PaymentInformationRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.CreatePaymentInformationAsync("1", "2", "3", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }

    [Fact]
    public async Task GetPaymentInformationSuccessful()
    {
        Mock<PaymentInformationApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        PaymentInformationResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new PaymentInformationResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PaymentInformationResponse result = await mockClient.Object.GetPaymentInformationAsync("1", "2", "3", "4");

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task GetPaymentInformationRequestUnsuccessful400()
    {
        Mock<PaymentInformationApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.GetPaymentInformationAsync("1", "2", "3", "4");
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task GetPaymentInformationRequestUnsuccessful500()
    {
        Mock<PaymentInformationApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.GetPaymentInformationAsync("1", "2", "3", "4");
        });

        Assert.Equal(500, e.StatusCode);
    }
}
