namespace PCPServerSDKDotNet.Errors;

public class ApiResponseRetrievalException : ApiException
{
    public ApiResponseRetrievalException(int statusCode, string responseBody)
        : base(statusCode, responseBody)
    {
    }
}
