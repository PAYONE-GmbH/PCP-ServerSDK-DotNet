namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Queries;
// using PCPServerSDKDotNet.Queries;
using PCPServerSDKDotNet.Utils;


public class CheckoutApiClient : BaseApiClient
{
    public CheckoutApiClient(CommunicatorConfiguration config) : base(config) { }


    public async Task<CreateCheckoutResponse> CreateCheckoutRequestAsync(string merchantId, string commerceCaseId, CreateCheckoutRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(commerceCaseId))
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        if (payload == null)
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        Console.WriteLine(jsonString);
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<CreateCheckoutResponse>(request);
    }

    public async Task<CheckoutResponse> GetCheckoutRequestAsync(string merchantId, string commerceCaseId, string checkoutId)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(commerceCaseId))
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(checkoutId))
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}"
        }.Uri;

        HttpRequestMessage request = new(HttpMethod.Get, url);

        return await MakeApiCallAsync<CheckoutResponse>(request);
    }

    public async Task<CheckoutsResponse> GetCheckoutsRequestAsync(string merchantId, GetCheckoutsQuery? queryParams = null)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);

        UriBuilder uriBuilder = new()
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_CHECKOUTS}"
        };

        Console.WriteLine(uriBuilder);

        var queryParameters = queryParams?.ToQueryMap();
        if (queryParameters != null)
        {
            var query = System.Web.HttpUtility.ParseQueryString(string.Empty);
            foreach (var param in queryParameters)
            {
                query[param.Key] = param.Value;
            }
            uriBuilder.Query = query.ToString();
        }


        Console.WriteLine(uriBuilder.Uri);

        HttpRequestMessage request = new(HttpMethod.Get, uriBuilder.Uri);

        return await MakeApiCallAsync<CheckoutsResponse>(request);
    }

    public async Task UpdateCheckoutRequestAsync(string merchantId, string commerceCaseId, string checkoutId, PatchCheckoutRequest payload)
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
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Patch, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        await MakeApiCallAsync(request);
    }

    public async Task RemoveCheckoutRequestAsync(string merchantId, string commerceCaseId, string checkoutId)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(commerceCaseId))
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(checkoutId))
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}"
        }.Uri;

        HttpRequestMessage request = new(HttpMethod.Delete, url);

        await MakeApiCallAsync(request);
    }
}

