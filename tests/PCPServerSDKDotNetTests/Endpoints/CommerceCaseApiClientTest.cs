using System.Net;
using Moq;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet;
using PCPServerSDKDotNet.Endpoints;
using PCPServerSDKDotNetTests.TestUtils;

namespace PCPServerSDKDotNetTests.Endpoints;

public class CommerceCaseApiClientTests
{
    private readonly CommunicatorConfiguration COMMUNICATOR_CONFIGURATION = new("KEY",
        "Super duper Ethan Hunt level secret",
        "awesome-api.com", null);

    [Fact]
    public async Task CreateCommerceCaseRequestSuccessful()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CreateCommerceCaseResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new CreateCommerceCaseResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CreateCommerceCaseRequest payload = new();
        CreateCommerceCaseResponse result = await mockClient.Object.CreateCommerceCaseRequestAsync("1", payload);

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task CreateCommerceCaseRequestUnsuccessful()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CreateCommerceCaseRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.CreateCommerceCaseRequestAsync("1", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task CreateCommerceCaseRequestUnsuccessful500()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CreateCommerceCaseRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.CreateCommerceCaseRequestAsync("1", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }

    [Fact]
    public async Task GetCommerceCaseRequestSuccessful()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        CommerceCaseResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new CommerceCaseResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        CommerceCaseResponse result = await mockClient.Object.GetCommerceCaseRequestAsync("1", "2");

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task GetCommerceCaseRequestUnsuccessful()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.GetCommerceCaseRequestAsync("1", "2");
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task GetCommerceCaseRequestUnsuccessful500()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.GetCommerceCaseRequestAsync("1", "2");
        });

        Assert.Equal(500, e.StatusCode);
    }

    [Fact]
    public async Task GetCommerceCasesRequestSuccessful()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        List<CommerceCaseResponse> expected = new() { new CommerceCaseResponse() };
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, expected);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        List<CommerceCaseResponse> result = await mockClient.Object.GetCommerceCasesRequestAsync("1");

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public async Task GetCommerceCasesRequestUnsuccessful()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.GetCommerceCasesRequestAsync("1");
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task GetCommerceCasesRequestUnsuccessful500()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.GetCommerceCasesRequestAsync("1");
        });

        Assert.Equal(500, e.StatusCode);
    }

    [Fact]
    public async Task UpdateCommerceCaseRequestSuccessful()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        Customer payload = new();

        await mockClient.Object.UpdateCommerceCaseRequestAsync("1", "2", payload);

        Assert.True(true);
    }

    [Fact]
    public async Task UpdateCommerceCaseRequestUnsuccessful()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        Customer payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.UpdateCommerceCaseRequestAsync("1", "2", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task UpdateCommerceCaseRequestUnsuccessful500()
    {
        Mock<CommerceCaseApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        Customer payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.UpdateCommerceCaseRequestAsync("1", "2", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }
}
