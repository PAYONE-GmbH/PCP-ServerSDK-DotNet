namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Utils;

public class PaymentInformationApiClient : BaseApiClient
{
    public PaymentInformationApiClient(CommunicatorConfiguration config) : base(config) { }

    public async Task<PaymentInformationResponse> CreatePaymentInformationAsync(string merchantId, string commerceCaseId, string checkoutId, PaymentInformationRequest payload)
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
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/payment-informations"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSON_CONTENT_TYPE)
        };
        request.Content.Headers.ContentType = JSON_MEDIA_TYPE;

        return await MakeApiCallAsync<PaymentInformationResponse>(request);
    }

    public async Task<PaymentInformationResponse> GetPaymentInformationAsync(string merchantId, string commerceCaseId, string checkoutId, string paymentInformationId)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(commerceCaseId))
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(checkoutId))
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(paymentInformationId))
            throw new ArgumentException("Payment Information ID is required");

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/payment-informations/{paymentInformationId}"
        }.Uri;

        HttpRequestMessage request = new(HttpMethod.Get, url);

        return await MakeApiCallAsync<PaymentInformationResponse>(request);
    }
}
