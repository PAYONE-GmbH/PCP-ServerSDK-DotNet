using System.Net;
using Moq;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet;
using PCPServerSDKDotNet.Endpoints;
using PCPServerSDKDotNetTests.TestUtils;

namespace PCPServerSDKDotNetTests.Endpoints;

public class PaymentExecutionApiClientTests
{
    private readonly CommunicatorConfiguration COMMUNICATOR_CONFIGURATION = new("KEY",
        "Super duper Ethan Hunt level secret",
        "awesome-api.com", null);

    [Fact]
    public async Task CreatePaymentRequestSuccessful()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CreatePaymentResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new CreatePaymentResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PaymentExecutionRequest payload = new();
        CreatePaymentResponse result = await mockClient.Object.CreatePaymentAsync("1", "2", "3", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task CreatePaymentRequestUnsuccessful400()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PaymentExecutionRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.CreatePaymentAsync("1", "2", "3", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task CreatePaymentRequestUnsuccessful500()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PaymentExecutionRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.CreatePaymentAsync("1", "2", "3", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }



    [Fact]
    public async Task CapturePaymentRequestSuccessful()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CapturePaymentResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new CapturePaymentResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CapturePaymentRequest payload = new();
        CapturePaymentResponse result = await mockClient.Object.CapturePaymentAsync("1", "2", "3", "4", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task CapturePaymentRequestUnsuccessful400()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CapturePaymentRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.CapturePaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task CapturePaymentRequestUnsuccessful500()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CapturePaymentRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.CapturePaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }

    [Fact]
    public async Task CancelPaymentRequestSuccessful()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CancelPaymentResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new CancelPaymentResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CancelPaymentRequest payload = new();
        CancelPaymentResponse result = await mockClient.Object.CancelPaymentAsync("1", "2", "3", "4", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task CancelPaymentRequestUnsuccessful400()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CancelPaymentRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.CancelPaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task CancelPaymentRequestUnsuccessful500()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CancelPaymentRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.CancelPaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }



    [Fact]
    public async Task CompletePaymentRequestSuccessful()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CompletePaymentResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new CompletePaymentResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CompletePaymentRequest payload = new();
        CompletePaymentResponse result = await mockClient.Object.CompletePaymentAsync("1", "2", "3", "4", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task CompletePaymentRequestUnsuccessful400()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CompletePaymentRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.CompletePaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task CompletePaymentRequestUnsuccessful500()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CompletePaymentRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.CompletePaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }


    [Fact]
    public async Task RefundPaymentRequestSuccessful()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        RefundPaymentResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new RefundPaymentResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        RefundRequest payload = new();
        RefundPaymentResponse result = await mockClient.Object.RefundPaymentAsync("1", "2", "3", "4", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task RefundPaymentRequestUnsuccessful400()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        RefundRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.RefundPaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task RefundPaymentRequestUnsuccessful500()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        RefundRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.RefundPaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }
}
