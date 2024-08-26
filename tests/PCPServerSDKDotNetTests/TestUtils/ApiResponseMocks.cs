using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;
using PCPServerSDKDotNet.Models;

namespace PCPServerSDKDotNetTests.TestUtils;

public static class ApiResponseMocks
{
    public static HttpResponseMessage CreateResponse<T>(HttpStatusCode statusCode, T obj)
    {
        string jsonString = JsonConvert.SerializeObject(obj);
        return new HttpResponseMessage(statusCode)
        {
            Content = new StringContent(jsonString, Encoding.UTF8, "application/json"),
            RequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://some-url.com"),
            Version = HttpVersion.Version20
        };
    }

    public static HttpResponseMessage CreateResponse(HttpStatusCode statusCode)
    {
        return new HttpResponseMessage(statusCode)
        {
            RequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://some-url.com"),
            Version = HttpVersion.Version20
        };
    }

    public static HttpResponseMessage CreateEmptyErrorResponse(HttpStatusCode statusCode)
    {
        return new HttpResponseMessage(statusCode)
        {
            Content = new StringContent(string.Empty, Encoding.UTF8, "application/json"),
            RequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://some-url.com"),
            Version = HttpVersion.Version20
        };
    }

    public static HttpResponseMessage CreateErrorResponse(HttpStatusCode statusCode)
    {
        APIError apiError = new()
        {
            HttpStatusCode = (int)statusCode
        };
        return CreateErrorResponse(statusCode, apiError);
    }

    public static HttpResponseMessage CreateErrorResponse(HttpStatusCode statusCode, APIError apiError)
    {
        return CreateErrorResponse(statusCode, new List<APIError> { apiError });
    }

    public static HttpResponseMessage CreateErrorResponse(HttpStatusCode statusCode, List<APIError> apiErrors)
    {
        ErrorResponse errorResponse = new()
        {
            Errors = apiErrors
        };

        string jsonString = JsonConvert.SerializeObject(errorResponse);
        return new HttpResponseMessage(statusCode)
        {
            Content = new StringContent(jsonString, Encoding.UTF8, "application/json"),
            RequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://some-url.com"),
            Version = HttpVersion.Version20
        };
    }
}

