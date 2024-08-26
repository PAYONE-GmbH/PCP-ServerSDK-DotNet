using System.Net;
using Moq;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet;
using PCPServerSDKDotNet.Endpoints;
using PCPServerSDKDotNetTests.TestUtils;

namespace PCPServerSDKDotNetTests.Endpoints;

public class OrderManagementCheckoutActionsApiClientTests
{
    private readonly CommunicatorConfiguration COMMUNICATOR_CONFIGURATION = new("KEY",
        "Super duper Ethan Hunt level secret",
        "awesome-api.com", null);

    [Fact]
    public async Task CreateOrderSuccessful()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        OrderResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new OrderResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        OrderRequest payload = new();
        OrderResponse result = await mockClient.Object.CreateOrderAsync("1", "2", "3", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task CreateOrderUnsuccessful()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        OrderRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.CreateOrderAsync("1", "2", "3", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task CreateOrderUnsuccessful500()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        OrderRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.CreateOrderAsync("1", "2", "3", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }

    [Fact]
    public async Task DeliverOrderSuccessful()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        DeliverResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new DeliverResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        DeliverRequest payload = new();
        DeliverResponse result = await mockClient.Object.DeliverOrderAsync("1", "2", "3", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task DeliverOrderUnsuccessful()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        DeliverRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.DeliverOrderAsync("1", "2", "3", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task DeliverOrderUnsuccessful500()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        DeliverRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.DeliverOrderAsync("1", "2", "3", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }

    [Fact]
    public async Task ReturnOrderSuccessful()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        ReturnResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new ReturnResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ReturnRequest payload = new();
        ReturnResponse result = await mockClient.Object.ReturnOrderAsync("1", "2", "3", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task ReturnOrderUnsuccessful()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ReturnRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.ReturnOrderAsync("1", "2", "3", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task ReturnOrderUnsuccessful500()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ReturnRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.ReturnOrderAsync("1", "2", "3", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }

    [Fact]
    public async Task CancelOrderSuccessful()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CancelResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new CancelResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CancelRequest payload = new();
        CancelResponse result = await mockClient.Object.CancelOrderAsync("1", "2", "3", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task CancelOrderUnsuccessful()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CancelRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.CancelOrderAsync("1", "2", "3", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task CancelOrderUnsuccessful500()
    {
        Mock<OrderManagementCheckoutActionsApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);


        CancelRequest payload = new();
        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.CancelOrderAsync("1", "2", "3", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }
}
