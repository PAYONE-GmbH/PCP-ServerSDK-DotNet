namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Models;

public class PaymentIntentApiClient : BaseApiClient
{
    public PaymentIntentApiClient(CommunicatorConfiguration config)
        : base(config)
    {
    }

    public async Task<CreatePaymentIntentResponse> CreatePaymentIntentAsync(string merchantId, CreatePaymentIntentRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        }

        if (payload == null)
        {
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/payment-intents",
        }.Uri;

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(JsonConvert.SerializeObject(payload), System.Text.Encoding.UTF8, JSON_CONTENT_TYPE),
        };
        request.Content.Headers.ContentType = JSON_MEDIA_TYPE;

        return await this.MakeApiCallAsync<CreatePaymentIntentResponse>(request);
    }

    public async Task<PaymentIntentResponse> GetPaymentIntentAsync(string merchantId, string paymentIntentId)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(paymentIntentId))
        {
            throw new ArgumentException("Payment Intent ID is required");
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/payment-intents/{paymentIntentId}",
        }.Uri;

        return await this.MakeApiCallAsync<PaymentIntentResponse>(new HttpRequestMessage(HttpMethod.Get, url));
    }
}
