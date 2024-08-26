using System.Net;
using Moq;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet;
using PCPServerSDKDotNet.Endpoints;
using PCPServerSDKDotNetTests.TestUtils;

namespace PCPServerSDKDotNetTests.Endpoints;

public class CheckoutApiClientTests
{
    private readonly CommunicatorConfiguration COMMUNICATOR_CONFIGURATION = new("KEY",
        "Super duper Ethan Hunt level secret",
        "awesome-api.com", null);

    [Fact]
    public async Task CreateCheckoutRequestSuccessful()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CreateCheckoutResponse expected = new()
        {
            CheckoutId = "123"
        };
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new CreateCheckoutResponse()
        {
            CheckoutId = "123"
        });

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CreateCheckoutRequest payload = new();
        CreateCheckoutResponse result = await mockClient.Object.CreateCheckoutRequestAsync("1", "2", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task CreateCheckoutRequestUnsuccessful()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CreateCheckoutRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.CreateCheckoutRequestAsync("1", "2", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task CreateCheckoutRequestUnsuccessful500()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CreateCheckoutRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.CreateCheckoutRequestAsync("1", "2", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }

    [Fact]
    public async Task GetCheckoutRequestSuccessful()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CheckoutResponse expected = new()
        {
            CheckoutId = "123"
        };
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new CheckoutResponse()
        {
            CheckoutId = "123"
        });

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CheckoutResponse result = await mockClient.Object.GetCheckoutRequestAsync("1", "2", "3");

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task GetCheckoutRequestUnsuccessful()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.GetCheckoutRequestAsync("1", "2", "3");
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task GetCheckoutRequestUnsuccessful500()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.GetCheckoutRequestAsync("1", "2", "3");
        });

        Assert.Equal(500, e.StatusCode);
    }


    [Fact]
    public async Task GetCheckoutsRequestSuccessful()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CheckoutsResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new CheckoutsResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CheckoutsResponse result = await mockClient.Object.GetCheckoutsRequestAsync("1");

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task GetCheckoutsRequestUnsuccessful()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.GetCheckoutsRequestAsync("1");
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task GetCheckoutsRequestUnsuccessful500()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.GetCheckoutsRequestAsync("1");
        });

        Assert.Equal(500, e.StatusCode);
    }




    [Fact]
    public async Task UpdateCheckoutRequestSuccessful()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PatchCheckoutRequest payload = new();

        await mockClient.Object.UpdateCheckoutRequestAsync("1", "2", "3", payload);

        Assert.True(true);
    }

    [Fact]
    public async Task UpdateCheckoutRequestUnsuccessful()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PatchCheckoutRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.UpdateCheckoutRequestAsync("1", "2", "3", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task UpdateCheckoutRequestUnsuccessful500()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PatchCheckoutRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.UpdateCheckoutRequestAsync("1", "2", "3", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }


    [Fact]
    public async Task RemoveCheckoutRequestSuccessful()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        await mockClient.Object.RemoveCheckoutRequestAsync("1", "2", "3");

        Assert.True(true);
    }

    [Fact]
    public async Task RemoveCheckoutRequestUnsuccessful()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.RemoveCheckoutRequestAsync("1", "2", "3");
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task RemoveCheckoutRequestUnsuccessful500()
    {
        Mock<CheckoutApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.RemoveCheckoutRequestAsync("1", "2", "3");
        });

        Assert.Equal(500, e.StatusCode);
    }







}
