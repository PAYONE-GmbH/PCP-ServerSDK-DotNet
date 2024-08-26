namespace PCPServerSDKDotNet.Endpoints;

using System.Net.Http.Headers;

using Newtonsoft.Json;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;


public class BaseApiClient
{
    private static readonly string JSON_PARSE_ERROR = "Expected valid JSON response, but failed to parse";
    protected static readonly string MERCHANT_ID_REQUIRED_ERROR = "Merchant ID is required";
    protected static readonly string COMMERCE_CASE_ID_REQUIRED_ERROR = "Commerce Case ID is required";
    protected static readonly string CHECKOUT_ID_REQUIRED_ERROR = "Checkout ID is required";
    protected static readonly string PAYLOAD_REQUIRED_ERROR = "Payload is required";

    protected static readonly string HTTPS_SCHEME = "https";
    protected static readonly string PCP_PATH_SEGMENT_VERSION = "v1";
    protected static readonly string PCP_PATH_SEGMENT_COMMERCE_CASES = "commerce-cases";
    protected static readonly string PCP_PATH_SEGMENT_CHECKOUTS = "checkouts";

    protected static readonly string CONTENT_TYPE_HEADER_NAME = "Content-Type";
    protected static readonly string JSON_CONTENT_TYPE = "application/json";
    protected static readonly MediaTypeHeaderValue JSON_MEDIA_TYPE = new(JSON_CONTENT_TYPE) { CharSet = "utf-8" };

    private readonly HttpClient client;
    private readonly RequestHeaderGenerator requestHeaderGenerator;
    private readonly CommunicatorConfiguration config;

    public BaseApiClient(CommunicatorConfiguration c)
    {
        config = c;
        requestHeaderGenerator = new RequestHeaderGenerator(config);
        client = new HttpClient();
    }



    protected RequestHeaderGenerator GetRequestHeaderGenerator()
    {
        return requestHeaderGenerator;
    }

    protected HttpClient GetClient()
    {
        return client;
    }

    protected CommunicatorConfiguration GetConfig()
    {
        return config;
    }

    protected async Task MakeApiCallAsync(HttpRequestMessage request)
    {
        request = GetRequestHeaderGenerator().GenerateAdditionalRequestHeaders(request);
        HttpResponseMessage response = await GetResponseAsync(request);
        await HandleErrorAsync(response);
    }

    protected async Task<T> MakeApiCallAsync<T>(HttpRequestMessage request)
    {
        request = GetRequestHeaderGenerator().GenerateAdditionalRequestHeaders(request);
        HttpResponseMessage response = await GetResponseAsync(request);
        Console.WriteLine(response.ToString());
        await HandleErrorAsync(response);
        try
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            return JsonConvert.DeserializeObject<T>(responseBody)!;
        }
        catch (JsonException e)
        {
            throw new InvalidOperationException(JSON_PARSE_ERROR, e);
        }
    }

    private async Task HandleErrorAsync(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode)
        {
            return;
        }

        string responseBody = await response.Content.ReadAsStringAsync();
        if (string.IsNullOrEmpty(responseBody))
        {
            throw new ApiResponseRetrievalException((int)response.StatusCode, responseBody);
        }

        try
        {
            ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseBody)!;
            throw new ApiErrorResponseException((int)response.StatusCode, responseBody, error.Errors);
        }
        catch (JsonException)
        {
            throw new ApiResponseRetrievalException((int)response.StatusCode, responseBody);
        }
    }


    // Virtual needed for testing (moq)
    public virtual async Task<HttpResponseMessage> GetResponseAsync(HttpRequestMessage request)
    {
        return await GetClient().SendAsync(request);
    }
}

