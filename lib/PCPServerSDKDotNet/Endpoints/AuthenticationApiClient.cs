namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using PCPServerSDKDotNet.Models;

public class AuthenticationApiClient : BaseApiClient
{
    public AuthenticationApiClient(CommunicatorConfiguration config)
        : base(config)
    {
    }

    public async Task<AuthenticationToken> GetAuthenticationTokensAsync(string merchantId, string? requestId = null)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/authentication-tokens",
        }.Uri;

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent("{}", System.Text.Encoding.UTF8, JSON_CONTENT_TYPE),
        };
        request.Content.Headers.ContentType = JSON_MEDIA_TYPE;
        if (!string.IsNullOrEmpty(requestId))
        {
            request.Headers.Add("X-Request-ID", requestId);
        }

        return await this.MakeApiCallAsync<AuthenticationToken>(request);
    }
}
