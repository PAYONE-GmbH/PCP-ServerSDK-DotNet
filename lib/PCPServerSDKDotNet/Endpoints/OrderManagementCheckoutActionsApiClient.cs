namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Utils;

public class OrderManagementCheckoutActionsApiClient : BaseApiClient
{
    public OrderManagementCheckoutActionsApiClient(CommunicatorConfiguration config) : base(config) { }

    public async Task<OrderResponse> CreateOrderAsync(string merchantId, string commerceCaseId, string checkoutId, OrderRequest payload)
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
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/order"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<OrderResponse>(request);
    }

    public async Task<DeliverResponse> DeliverOrderAsync(string merchantId, string commerceCaseId, string checkoutId, DeliverRequest payload)
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
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/deliver"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<DeliverResponse>(request);
    }

    public async Task<ReturnResponse> ReturnOrderAsync(string merchantId, string commerceCaseId, string checkoutId, ReturnRequest payload)
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
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/return"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<ReturnResponse>(request);
    }

    public async Task<CancelResponse> CancelOrderAsync(string merchantId, string commerceCaseId, string checkoutId, CancelRequest payload)
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
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/cancel"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<CancelResponse>(request);
    }
}
