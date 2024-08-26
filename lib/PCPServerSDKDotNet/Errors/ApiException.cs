namespace PCPServerSDKDotNet.Errors;

public class ApiException : Exception
{
    public ApiException(int statusCode, string responseBody)
        : base($"Status code: {statusCode}, Response body: {responseBody}")
    {
        this.StatusCode = statusCode;
        this.ResponseBody = responseBody;
    }

    public int StatusCode { get; }

    public string ResponseBody { get; }
}
