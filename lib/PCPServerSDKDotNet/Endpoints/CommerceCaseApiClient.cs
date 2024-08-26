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
using PCPServerSDKDotNet.Utils;

public class CommerceCaseApiClient : BaseApiClient
{
    public CommerceCaseApiClient(CommunicatorConfiguration config) : base(config) { }

    public async Task<CreateCommerceCaseResponse> CreateCommerceCaseRequestAsync(string merchantId, CreateCommerceCaseRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (payload == null)
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        return await MakeApiCallAsync<CreateCommerceCaseResponse>(request);
    }

    public async Task<CommerceCaseResponse> GetCommerceCaseRequestAsync(string merchantId, string commerceCaseId)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        if (string.IsNullOrEmpty(commerceCaseId))
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}"
        }.Uri;

        HttpRequestMessage request = new(HttpMethod.Get, url);

        return await MakeApiCallAsync<CommerceCaseResponse>(request);
    }

    public async Task<List<CommerceCaseResponse>> GetCommerceCasesRequestAsync(string merchantId, GetCommerceCasesQuery? queryParams = null)
    {
        if (string.IsNullOrEmpty(merchantId))
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);

        UriBuilder uriBuilder = new()
        {
            Scheme = HTTPS_SCHEME,
            Host = GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}"
        };

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

        HttpRequestMessage request = new(HttpMethod.Get, uriBuilder.Uri);

        return await MakeApiCallAsync<List<CommerceCaseResponse>>(request);
    }

    public async Task UpdateCommerceCaseRequestAsync(string merchantId, string commerceCaseId, Customer payload)
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
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}"
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Patch, url)
        {
            Content = new StringContent("{\"customer\":" + jsonString + "}", System.Text.Encoding.UTF8, "application/json")
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        await MakeApiCallAsync(request);
    }
}
