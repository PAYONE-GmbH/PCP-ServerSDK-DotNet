using System.Net;
using Newtonsoft.Json;
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

    [Theory]
    [InlineData(null, "2", "3")] // Merchant ID is null
    [InlineData("1", null, "3")] // Commerce Case ID is null
    [InlineData("1", "2", null)] // Checkout ID is null
    public async Task CreatePayment_NullParams_ShouldThrowArgumentException(string merchantId, string commerceCaseId, string checkoutId)
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);

        PaymentExecutionRequest payload = new();

        ArgumentException e = await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await mockClient.Object.CreatePaymentAsync(merchantId, commerceCaseId, checkoutId, payload);
        });

        Assert.IsType<ArgumentException>(e);
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

    [Theory]
    [InlineData(null, "2", "3", "4")] // Merchant ID is null
    [InlineData("1", null, "3", "4")] // Commerce Case ID is null
    [InlineData("1", "2", null, "4")] // Checkout ID is null
    [InlineData("1", "2", "3", null)] // PaymentExecution ID is null
    public async Task CapturePayment_NullParams_ShouldThrowArgumentException(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId)
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);

        CapturePaymentRequest payload = new();

        ArgumentException e = await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await mockClient.Object.CapturePaymentAsync(merchantId, commerceCaseId, checkoutId, paymentExecutionId, payload);
        });

        Assert.IsType<ArgumentException>(e);
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
        HttpRequestMessage? requestMessage = null;

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>()))
            .Callback<HttpRequestMessage>(request => requestMessage = request)
            .ReturnsAsync(response);

        CancelPaymentRequest payload = new()
        {
            Amount = 123L,
        };
        CancelPaymentResponse result = await mockClient.Object.CancelPaymentAsync("1", "2", "3", "4", payload);

        Assert.Equivalent(expected, result);
        string requestBody = await requestMessage!.Content!.ReadAsStringAsync();
        CancelPaymentRequest? serializedPayload = JsonConvert.DeserializeObject<CancelPaymentRequest>(requestBody);
        Assert.NotNull(serializedPayload);
        Assert.Equal(123L, serializedPayload!.Amount);
    }


    [Theory]
    [InlineData(null, "2", "3", "4")] // Merchant ID is null
    [InlineData("1", null, "3", "4")] // Commerce Case ID is null
    [InlineData("1", "2", null, "4")] // Checkout ID is null
    [InlineData("1", "2", "3", null)] // PaymentExecution ID is null
    public async Task CancelPayment_NullParams_ShouldThrowArgumentException(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId)
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);

        CancelPaymentRequest payload = new();

        ArgumentException e = await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await mockClient.Object.CancelPaymentAsync(merchantId, commerceCaseId, checkoutId, paymentExecutionId, payload);
        });

        Assert.IsType<ArgumentException>(e);
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

        CompletePaymentRequest payload = new()
        {
            RedirectPaymentMethodSpecificInput = new CompleteRedirectPaymentMethodSpecificInput
            {
                PaymentProduct840SpecificInput = new CompletePaymentProduct840SpecificInput
                {
                    Action = "CONFIRM_ORDER_STATUS",
                    JavaScriptSdkFlow = true,
                },
            },
        };
        CompletePaymentResponse result = await mockClient.Object.CompletePaymentAsync("1", "2", "3", "4", payload);

        Assert.Equivalent(expected, result);
    }


    [Theory]
    [InlineData(null, "2", "3", "4")] // Merchant ID is null
    [InlineData("1", null, "3", "4")] // Commerce Case ID is null
    [InlineData("1", "2", null, "4")] // Checkout ID is null
    [InlineData("1", "2", "3", null)] // PaymentExecution ID is null
    public async Task CompletePayment_NullParams_ShouldThrowArgumentException(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId)
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);

        CompletePaymentRequest payload = new();

        ArgumentException e = await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await mockClient.Object.CompletePaymentAsync(merchantId, commerceCaseId, checkoutId, paymentExecutionId, payload);
        });

        Assert.IsType<ArgumentException>(e);
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

    [Theory]
    [InlineData(null, "2", "3", "4")] // Merchant ID is null
    [InlineData("1", null, "3", "4")] // Commerce Case ID is null
    [InlineData("1", "2", null, "4")] // Checkout ID is null
    [InlineData("1", "2", "3", null)] // PaymentExecution ID is null
    public async Task RefundPayment_NullParams_ShouldThrowArgumentException(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId)
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);

        RefundRequest payload = new();

        ArgumentException e = await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await mockClient.Object.RefundPaymentAsync(merchantId, commerceCaseId, checkoutId, paymentExecutionId, payload);
        });

        Assert.IsType<ArgumentException>(e);
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

    [Fact]
    public async Task PausePaymentRequestSuccessful()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        PausePaymentResponse expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new PausePaymentResponse());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PausePaymentRequest payload = new();
        PausePaymentResponse result = await mockClient.Object.PausePaymentAsync("1", "2", "3", "4", payload);

        Assert.Equivalent(expected, result);
    }

    [Theory]
    [InlineData(null, "2", "3", "4")] // Merchant ID is null
    [InlineData("1", null, "3", "4")] // Commerce Case ID is null
    [InlineData("1", "2", null, "4")] // Checkout ID is null
    [InlineData("1", "2", "3", null)] // PaymentExecution ID is null
    public async Task PausePayment_NullParams_ShouldThrowArgumentException(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId)
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);

        PausePaymentRequest payload = new();

        ArgumentException e = await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await mockClient.Object.PausePaymentAsync(merchantId, commerceCaseId, checkoutId, paymentExecutionId, payload);
        });

        Assert.IsType<ArgumentException>(e);
    }

    [Fact]
    public async Task PausePaymentRequestUnsuccessful400()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PausePaymentRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.PausePaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task PausePaymentRequestUnsuccessful500()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        PausePaymentRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.PausePaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }


    [Fact]
    public async Task RefreshPaymentRequestSuccessful()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        PaymentExecution expected = new();
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.OK, new PaymentExecution());

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        RefreshPaymentRequest payload = new();
        PaymentExecution result = await mockClient.Object.RefreshPaymentAsync("1", "2", "3", "4", payload);

        Assert.Equivalent(expected, result);
    }

    [Theory]
    [InlineData(null, "2", "3", "4")] // Merchant ID is null
    [InlineData("1", null, "3", "4")] // Commerce Case ID is null
    [InlineData("1", "2", null, "4")] // Checkout ID is null
    [InlineData("1", "2", "3", null)] // PaymentExecution ID is null
    public async Task RefreshPayment_NullParams_ShouldThrowArgumentException(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId)
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);

        RefreshPaymentRequest payload = new();

        ArgumentException e = await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await mockClient.Object.RefreshPaymentAsync(merchantId, commerceCaseId, checkoutId, paymentExecutionId, payload);
        });

        Assert.IsType<ArgumentException>(e);
    }

    [Fact]
    public async Task RefreshPaymentRequestUnsuccessful400()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        RefreshPaymentRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.RefreshPaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task RefreshPaymentRequestUnsuccessful500()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        RefreshPaymentRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.RefreshPaymentAsync("1", "2", "3", "4", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }

    [Fact]
    public async Task CreatePaymentRequestSerializesRedirectPaymentProduct900SpecificInput()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.Created, new CreatePaymentResponse());
        HttpRequestMessage? requestMessage = null;

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>()))
            .Callback<HttpRequestMessage>(request => requestMessage = request)
            .ReturnsAsync(response);

        PaymentExecutionRequest payload = new()
        {
            PaymentMethodSpecificInput = new PaymentMethodSpecificInput
            {
                RedirectPaymentMethodSpecificInput = new RedirectPaymentMethodSpecificInput
                {
                    PaymentProductId = 900,
                    PaymentProduct900SpecificInput = new RedirectPaymentProduct900SpecificInput
                    {
                        CaptureTrigger = CaptureTrigger.ServiceFulfillment,
                    },
                },
            },
        };

        await mockClient.Object.CreatePaymentAsync("1", "2", "3", payload);

        string requestBody = await requestMessage!.Content!.ReadAsStringAsync();
        PaymentExecutionRequest? serializedPayload = JsonConvert.DeserializeObject<PaymentExecutionRequest>(requestBody);
        Assert.NotNull(serializedPayload?.PaymentMethodSpecificInput?.RedirectPaymentMethodSpecificInput?.PaymentProduct900SpecificInput);
        Assert.Equal(CaptureTrigger.ServiceFulfillment, serializedPayload!.PaymentMethodSpecificInput!.RedirectPaymentMethodSpecificInput!.PaymentProduct900SpecificInput!.CaptureTrigger);
    }

    [Fact]
    public async Task CreateFundSplitRequestSuccessful()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        FundSplitResponse expected = new()
        {
            FundSplitId = "fs-1",
            PaymentExecutionId = "4",
            EventId = "5",
            FundSplit = new FundSplit
            {
                Id = "fs-1",
                PaymentEventId = "5",
                FundDistributions = new List<FundDistribution>
                {
                    new()
                    {
                        AccountId = "seller-1",
                        Amount = 1000L,
                        Type = FundDistributionType.SellerRevenue,
                    },
                },
            },
        };
        HttpResponseMessage response = ApiResponseMocks.CreateResponse(HttpStatusCode.Created, expected);
        HttpRequestMessage? requestMessage = null;

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>()))
            .Callback<HttpRequestMessage>(request => requestMessage = request)
            .ReturnsAsync(response);

        FundSplitRequest payload = new()
        {
            FundSplit = new FundSplit
            {
                FundDistributions = new List<FundDistribution>
                {
                    new()
                    {
                        AccountId = "seller-1",
                        Amount = 1000L,
                        Type = FundDistributionType.SellerRevenue,
                    },
                },
            },
        };

        FundSplitResponse result = await mockClient.Object.CreateFundSplitAsync("1", "2", "3", "4", "5", payload);

        Assert.Equivalent(expected, result);
        Assert.NotNull(requestMessage);
        Assert.Equal("https://awesome-api.com/v1/1/commerce-cases/2/checkouts/3/payment-executions/4/events/5/fund-splits", requestMessage!.RequestUri!.ToString());

        string requestBody = await requestMessage.Content!.ReadAsStringAsync();
        FundSplitRequest? serializedPayload = JsonConvert.DeserializeObject<FundSplitRequest>(requestBody);
        Assert.NotNull(serializedPayload?.FundSplit?.FundDistributions);
        Assert.Single(serializedPayload!.FundSplit!.FundDistributions!);
        Assert.Equal(FundDistributionType.SellerRevenue, serializedPayload.FundSplit.FundDistributions![0].Type);
    }

    [Theory]
    [InlineData(null, "2", "3", "4", "5")]
    [InlineData("1", null, "3", "4", "5")]
    [InlineData("1", "2", null, "4", "5")]
    [InlineData("1", "2", "3", null, "5")]
    [InlineData("1", "2", "3", "4", null)]
    public async Task CreateFundSplit_NullParams_ShouldThrowArgumentException(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId, string eventId)
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);

        FundSplitRequest payload = new();

        ArgumentException e = await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await mockClient.Object.CreateFundSplitAsync(merchantId, commerceCaseId, checkoutId, paymentExecutionId, eventId, payload);
        });

        Assert.IsType<ArgumentException>(e);
    }

    [Fact]
    public async Task CreateFundSplitRequestUnsuccessful400()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateErrorResponse(HttpStatusCode.BadRequest);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        FundSplitRequest payload = new();

        ApiErrorResponseException e = await Assert.ThrowsAsync<ApiErrorResponseException>(async () =>
        {
            await mockClient.Object.CreateFundSplitAsync("1", "2", "3", "4", "5", payload);
        });

        Assert.Equal(400, e.StatusCode);
    }

    [Fact]
    public async Task CreateFundSplitRequestUnsuccessful500()
    {
        Mock<PaymentExecutionApiClient> mockClient = new(COMMUNICATOR_CONFIGURATION);
        HttpResponseMessage response = ApiResponseMocks.CreateEmptyErrorResponse(HttpStatusCode.InternalServerError);

        mockClient.Setup(x => x.GetResponseAsync(It.IsAny<HttpRequestMessage>())).ReturnsAsync(response);

        FundSplitRequest payload = new();

        ApiResponseRetrievalException e = await Assert.ThrowsAsync<ApiResponseRetrievalException>(async () =>
        {
            await mockClient.Object.CreateFundSplitAsync("1", "2", "3", "4", "5", payload);
        });

        Assert.Equal(500, e.StatusCode);
    }

}
