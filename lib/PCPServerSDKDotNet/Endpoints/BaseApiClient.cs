namespace PCPServerSDKDotNet.Endpoints;

using System.Net.Http.Headers;

using Newtonsoft.Json;
using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;

public class BaseApiClient
{
    protected static readonly string MERCHANTIDREQUIREDERROR = "Merchant ID is required";
    protected static readonly string COMMERCECASEIDREQUIREDERROR = "Commerce Case ID is required";
    protected static readonly string CHECKOUTIDREQUIREDERROR = "Checkout ID is required";
    protected static readonly string PAYLOADREQUIREDERROR = "Payload is required";

    protected static readonly string HTTPSSCHEME = "https";
    protected static readonly string PCPPATHSEGMENTVERSION = "v1";
    protected static readonly string PCPPATHSEGMENTCOMMERCECASES = "commerce-cases";
    protected static readonly string PCPPATHSEGMENTCHECKOUTS = "checkouts";

    protected static readonly string CONTENT_TYPE_HEADER_NAME = "Content-Type";
    protected static readonly string JSONCONTENTTYPE = "application/json";
    protected static readonly MediaTypeHeaderValue JSONMEDIATYPE = new(JSONCONTENTTYPE) { CharSet = "utf-8" };

    private static readonly string JSONPARSEERROR = "Expected valid JSON response, but failed to parse";

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
        request = this.GetRequestHeaderGenerator().GenerateAdditionalRequestHeaders(request);
        HttpResponseMessage response = await this.GetResponseAsync(request);
        await this.HandleErrorAsync(response);
    }

    protected async Task<T> MakeApiCallAsync<T>(HttpRequestMessage request)
    {
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
            throw new InvalidOperationException(JSONPARSEERROR, e);
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
}
