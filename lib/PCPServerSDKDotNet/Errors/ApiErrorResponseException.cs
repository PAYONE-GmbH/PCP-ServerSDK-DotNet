namespace PCPServerSDKDotNet.Errors;

using System.Collections.Generic;
using PCPServerSDKDotNet.Models;


public class ApiErrorResponseException : ApiException
{
    public List<APIError> Errors { get; }

    public ApiErrorResponseException(int statusCode, string responseBody, List<APIError>? errors = null)
        : base(statusCode, responseBody)
    {
        Errors = errors ?? [];
    }

    public List<APIError> GetErrors()
    {
        return Errors;
    }
}

