namespace PCPServerSDKDotNetTests;

using System.Text;
using PCPServerSDKDotNet;
using Xunit.Abstractions;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Utils;

public class RequestHeaderGeneratorTest
{
    private readonly ITestOutputHelper _output;
    private const string TEST_KEY = "KEY";
    private const string TEST_SECRET = "Super duper Ethan Hunt level secret";
    private readonly CommunicatorConfiguration CONFIG = new(TEST_KEY, TEST_SECRET, "awesome-api.com", null);
    private readonly RequestHeaderGenerator HEADER_GENERATOR;

    public RequestHeaderGeneratorTest(ITestOutputHelper output)
    {
        HEADER_GENERATOR = new RequestHeaderGenerator(CONFIG);
        _output = output;
    }

    [Fact]
    public void TestSignatureGenerationForGet()
    {
        DateTime date = DateTimeOffset.FromUnixTimeMilliseconds(1720520499000).UtcDateTime;
        var request = new HttpRequestMessage(HttpMethod.Get, "http://awesome-api.com/v1/commerce_cases");
        request.Headers.Add(RequestHeaderGenerator.DATE_HEADER_NAME, date.ToString("r"));
        request.Headers.Add(RequestHeaderGenerator.SERVER_META_INFO_HEADER_NAME, "server fixed");
        request.Headers.Add(RequestHeaderGenerator.CLIENT_META_INFO_HEADER_NAME, "client fixed");

        HttpRequestMessage updatedRequest = HEADER_GENERATOR.GenerateAdditionalRequestHeaders(request);

        Assert.Equal("GCS v1HMAC:KEY:ZSq7H19dyhyNGSPY5UgyPwITc5n4QG+zHnNDExIa6A8=", updatedRequest.Headers.Authorization!.ToString());
    }

    [Fact]
    public void TestSignatureGenerationWithContentType()
    {
        DateTime date = DateTimeOffset.FromUnixTimeMilliseconds(1720520499000).UtcDateTime;
        var request = new HttpRequestMessage(HttpMethod.Post, "http://awesome-api.com/v1/commerce_cases")
        {
            Content = new StringContent("", Encoding.UTF8, "application/json")
        };
        request.Headers.Add(RequestHeaderGenerator.DATE_HEADER_NAME, date.ToString("r"));
        request.Headers.Add(RequestHeaderGenerator.SERVER_META_INFO_HEADER_NAME, "server fixed");
        request.Headers.Add(RequestHeaderGenerator.CLIENT_META_INFO_HEADER_NAME, "client fixed");

        HttpRequestMessage updatedRequest = HEADER_GENERATOR.GenerateAdditionalRequestHeaders(request);

        Assert.Equal("GCS v1HMAC:KEY:c5aNDw4AUxRChugRyN0OmTCs38YLA9E/tR+k0bOQzyk=", updatedRequest.Headers.Authorization!.ToString());
    }

    [Fact]
    public void AddADateHeaderIfMissingTest()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "http://api.somewhere.com/route/to/thing");

        HttpRequestMessage updatedRequest = HEADER_GENERATOR.GenerateAdditionalRequestHeaders(request);

        Assert.NotNull(updatedRequest.Headers.Date);
    }

    [Fact]
    public void AddServerMetaInfoIfMissingTest()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "http://api.somewhere.com/route/to/thing");

        HttpRequestMessage updatedRequest = HEADER_GENERATOR.GenerateAdditionalRequestHeaders(request);
        var serverMetaInfoBase64 = updatedRequest.Headers.GetValues(RequestHeaderGenerator.SERVER_META_INFO_HEADER_NAME).FirstOrDefault();
        _output.WriteLine(serverMetaInfoBase64);
        Assert.NotNull(serverMetaInfoBase64);

        string serverMetaInfoAsJson = Encoding.UTF8.GetString(Convert.FromBase64String(serverMetaInfoBase64));
        _output.WriteLine(serverMetaInfoAsJson);
        ServerMetaInfo serverMetaInfo = JsonConvert.DeserializeObject<ServerMetaInfo>(serverMetaInfoAsJson)!;
        _output.WriteLine(ServerMetaInfo.WithDefaults(null).SdkCreator);

        Assert.Equal(ServerMetaInfo.WithDefaults(null), serverMetaInfo);
    }

    [Fact]
    public void AddServerClientInfoIfMissingTest()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "http://api.somewhere.com/route/to/thing");

        HttpRequestMessage updatedRequest = HEADER_GENERATOR.GenerateAdditionalRequestHeaders(request);
        var clientMetaInfo = updatedRequest.Headers.GetValues(RequestHeaderGenerator.CLIENT_META_INFO_HEADER_NAME).FirstOrDefault();
        Assert.NotNull(clientMetaInfo);

        var metaInfoAsJson = Encoding.UTF8.GetString(Convert.FromBase64String(clientMetaInfo));
        Assert.Equal("\"[]\"", metaInfoAsJson);
    }
}
