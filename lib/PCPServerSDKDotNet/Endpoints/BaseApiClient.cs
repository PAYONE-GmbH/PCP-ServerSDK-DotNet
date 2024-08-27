namespace PCPServerSDKDotNet.Endpoints;

using System.Net.Http.Headers;

using Newtonsoft.Json;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;

public class BaseApiClient
{
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

    private static readonly string JSON_PARSE_ERROR = "Expected valid JSON response, but failed to parse";

    private readonly HttpClient client;
    private readonly RequestHeaderGenerator requestHeaderGenerator;
    private readonly CommunicatorConfiguration config;

    public BaseApiClient(CommunicatorConfiguration c)
    {
        this.config = c;
        this.requestHeaderGenerator = new RequestHeaderGenerator(this.config);
        this.client = new HttpClient();
    }

    // Virtual needed for testing (moq)
    public virtual async Task<HttpResponseMessage> GetResponseAsync(HttpRequestMessage request)
    {
        return await this.GetClient().SendAsync(request);
    }

    protected RequestHeaderGenerator GetRequestHeaderGenerator()
    {
        return this.requestHeaderGenerator;
    }

    protected HttpClient GetClient()
    {
        return this.client;
    }

    protected CommunicatorConfiguration GetConfig()
    {
        return this.config;
    }

    protected async Task MakeApiCallAsync(HttpRequestMessage request)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        request = this.GetRequestHeaderGenerator().GenerateAdditionalRequestHeaders(request);
        HttpResponseMessage response = await this.GetResponseAsync(request);
        await this.HandleErrorAsync(response);
    }

    protected async Task<T> MakeApiCallAsync<T>(HttpRequestMessage request)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        request = this.GetRequestHeaderGenerator().GenerateAdditionalRequestHeaders(request);
        HttpResponseMessage response = await this.GetResponseAsync(request);
        await this.HandleErrorAsync(response);
        try
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseBody)!;
        }
        catch (JsonException e)
        {
            throw new InvalidOperationException(JSON_PARSE_ERROR, e);
        }
    }

    private async Task HandleErrorAsync(HttpResponseMessage response)
    {
        if (response == null)
        {
            throw new ArgumentNullException(nameof(response));
        }

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
}
