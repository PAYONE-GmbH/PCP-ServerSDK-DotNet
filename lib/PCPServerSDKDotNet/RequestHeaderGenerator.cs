namespace PCPServerSDKDotNet;

using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;

public class RequestHeaderGenerator
{
    public const string SERVER_META_INFO_HEADER_NAME = "X-GCS-ServerMetaInfo";
    public const string CLIENT_META_INFO_HEADER_NAME = "X-GCS-ClientMetaInfo";
    public const string DATE_HEADER_NAME = "Date";
    public const string AUTHORIZATION_HEADER_NAME = "Authorization";
    public const string CONTENT_TYPE_HEADER_NAME = "Content-Type";
    private const string WHITESPACE_REGEX = "\\r?\\n[\\h]*";

    private readonly CommunicatorConfiguration config;
    private readonly HMACSHA256 hmac;

    public RequestHeaderGenerator(CommunicatorConfiguration config)
    {
        this.config = config;
        hmac = new HMACSHA256(Encoding.UTF8.GetBytes(config.ApiSecret));
    }

    public HttpRequestMessage GenerateAdditionalRequestHeaders(HttpRequestMessage request)
    {
        Debug.WriteLine("Generating headers for request");
        if (!request.Headers.Contains(DATE_HEADER_NAME))
        {
            request.Headers.Add(DATE_HEADER_NAME, DateTime.UtcNow.ToString("r", CultureInfo.InvariantCulture));
        }
        if (!request.Headers.Contains(SERVER_META_INFO_HEADER_NAME))
        {
            request.Headers.Add(SERVER_META_INFO_HEADER_NAME, GetServerMetaInfo());
        }
        if (!request.Headers.Contains(CLIENT_META_INFO_HEADER_NAME))
        {
            request.Headers.Add(CLIENT_META_INFO_HEADER_NAME, GetClientMetaInfo());
        }
        if (!request.Headers.Contains(AUTHORIZATION_HEADER_NAME))
        {
            request.Headers.Add(AUTHORIZATION_HEADER_NAME, GetAuthHeader(request));
        }

        return request;
    }

    private string GetStringToSign(HttpRequestMessage request)
    {
        // 1. method
        var stringToSign = new StringBuilder(request.Method.Method);
        stringToSign.Append('\n');

        // 2. Content-Type
        if (request.Content?.Headers.ContentType != null)
        {
            stringToSign.Append(request.Content.Headers.ContentType);
        }
        stringToSign.Append('\n');

        // 3. Date
        if (request.Headers.Contains(DATE_HEADER_NAME))
        {
            stringToSign
                .Append(request.Headers.GetValues(DATE_HEADER_NAME).First())
                .Append('\n');
        }

        // 4. Canonicalized Headers (starting with X-GCS, sorted by names)
        if (request.Headers.Contains(CLIENT_META_INFO_HEADER_NAME))
        {
            stringToSign
                .Append(CLIENT_META_INFO_HEADER_NAME.ToLower())
                .Append(':')
                .Append(request.Headers.GetValues(CLIENT_META_INFO_HEADER_NAME).First().Replace(WHITESPACE_REGEX, " ").Trim())
                .Append('\n');
        }
        if (request.Headers.Contains(SERVER_META_INFO_HEADER_NAME))
        {
            stringToSign.Append(SERVER_META_INFO_HEADER_NAME.ToLower())
                .Append(':')
                .Append(request.Headers.GetValues(SERVER_META_INFO_HEADER_NAME).First().Replace(WHITESPACE_REGEX, " ").Trim())
                .Append('\n');
        }

        // 5. Canonicalized Resource (has to include query parameters)
        stringToSign.Append(request.RequestUri!.AbsolutePath);
        if (!string.IsNullOrEmpty(request.RequestUri.Query))
        {
            stringToSign
                .Append('?')
                .Append(request.RequestUri.Query);
        }
        stringToSign.Append('\n');

        return stringToSign.ToString();
    }

    private string GetAuthHeader(HttpRequestMessage request)
    {
        string stringToSign = GetStringToSign(request);
        string signature = Sign(stringToSign.ToString());
        return $"GCS v1HMAC:{config.ApiKey}:{signature}";
    }

    private string Sign(string target)
    {
        byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(target));
        return Convert.ToBase64String(hash);
    }

    private string GetServerMetaInfo()
    {
        ServerMetaInfo meta = config.ServerMetaInfo;
        try
        {
            string jsonString = JsonConvert.SerializeObject(meta);
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonString));
        }
        catch (JsonException e)
        {
            throw new InvalidOperationException("Server Meta Info must be encodable as JSON, this is likely an internal bug of the .NET SDK", e);
        }
    }

    private string GetClientMetaInfo()
    {
        return Convert.ToBase64String(Encoding.UTF8.GetBytes("\"[]\""));
    }
}
