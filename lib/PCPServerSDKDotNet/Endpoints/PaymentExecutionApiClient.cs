namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Utils;

public class PaymentExecutionApiClient : BaseApiClient
{
    private const string PAYMENT_EXECUTION_ID_REQUIRED_ERROR = "Payment Execution ID is required";
    private const string PCP_PATH_SEGMENT_PAYMENT_EXECUTIONS = "payment-executions";

    public PaymentExecutionApiClient(CommunicatorConfiguration config) : base(config) { }

    public async Task<CreatePaymentResponse> CreatePaymentAsync(string merchantId, string commerceCaseId, string checkoutId, PaymentExecutionRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(commerceCaseId))
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(checkoutId))
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        if (payload == null)
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/{PCP_PATH_SEGMENT_PAYMENT_EXECUTIONS}"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<CreatePaymentResponse>(request);
    }

    public async Task<CapturePaymentResponse> CapturePaymentAsync(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId, CapturePaymentRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(commerceCaseId))
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(checkoutId))
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(paymentExecutionId))
            throw new ArgumentException(PAYMENT_EXECUTION_ID_REQUIRED_ERROR);
        if (payload == null)
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/{PCP_PATH_SEGMENT_PAYMENT_EXECUTIONS}/{paymentExecutionId}/capture"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<CapturePaymentResponse>(request);
    }

    public async Task<CancelPaymentResponse> CancelPaymentAsync(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId, CancelPaymentRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(commerceCaseId))
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(checkoutId))
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(paymentExecutionId))
            throw new ArgumentException(PAYMENT_EXECUTION_ID_REQUIRED_ERROR);
        if (payload == null)
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/{PCP_PATH_SEGMENT_PAYMENT_EXECUTIONS}/{paymentExecutionId}/cancel"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<CancelPaymentResponse>(request);
    }

    public async Task<RefundPaymentResponse> RefundPaymentAsync(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId, RefundRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(commerceCaseId))
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(checkoutId))
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(paymentExecutionId))
            throw new ArgumentException(PAYMENT_EXECUTION_ID_REQUIRED_ERROR);
        if (payload == null)
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/{PCP_PATH_SEGMENT_PAYMENT_EXECUTIONS}/{paymentExecutionId}/refund"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<RefundPaymentResponse>(request);
    }

    public async Task<CompletePaymentResponse> CompletePaymentAsync(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId, CompletePaymentRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(commerceCaseId))
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(checkoutId))
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(paymentExecutionId))
            throw new ArgumentException(PAYMENT_EXECUTION_ID_REQUIRED_ERROR);
        if (payload == null)
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/{PCP_PATH_SEGMENT_PAYMENT_EXECUTIONS}/{paymentExecutionId}/complete"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<CompletePaymentResponse>(request);
    }
}
