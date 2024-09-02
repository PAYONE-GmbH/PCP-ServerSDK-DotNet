namespace PCPServerSDKDotNet.Errors;

using System.Collections.Generic;
using PCPServerSDKDotNet.Models;

public class ApiErrorResponseException : ApiException
{
    public ApiErrorResponseException(int statusCode, string responseBody, List<APIError>? errors = null)
        : base(statusCode, responseBody)
    {
        this.Errors = errors ?? new List<APIError>();
    }

    public List<APIError> Errors { get; }

    public List<APIError> GetErrors()
    {
        return this.Errors;
    }
}
