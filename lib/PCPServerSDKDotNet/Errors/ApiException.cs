namespace PCPServerSDKDotNet.Errors;

public class ApiException : Exception
{
    public int StatusCode { get; }
    public string ResponseBody { get; }

    public ApiException(int statusCode, string responseBody)
        : base($"Status code: {statusCode}, Response body: {responseBody}")
    {
        StatusCode = statusCode;
        ResponseBody = responseBody;
    }
}

