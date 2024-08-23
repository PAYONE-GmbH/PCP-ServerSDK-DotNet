namespace PCPServerSDKDotNettests.Errors;

using Xunit;
using PCPServerSDKDotNet.Errors;


public class ApiResponseRetrievalExceptionTests
{
    [Fact]
    public void ApiResponseRetrievalException_ShouldInitializePropertiesCorrectly()
    {
        // Arrange
        int statusCode = 500;
        string responseBody = "Internal Server Error";

        // Act
        var exception = new ApiResponseRetrievalException(statusCode, responseBody);

        // Assert
        Assert.Equal(statusCode, exception.StatusCode);
        Assert.Equal(responseBody, exception.ResponseBody);
    }

    [Fact]
    public void ApiResponseRetrievalException_ShouldInheritFromApiException()
    {
        // Arrange
        int statusCode = 500;
        string responseBody = "Internal Server Error";

        // Act
        var exception = new ApiResponseRetrievalException(statusCode, responseBody);

        // Assert
        Assert.IsType<ApiResponseRetrievalException>(exception);
        Assert.IsAssignableFrom<ApiException>(exception);
        Assert.Equal(statusCode, exception.StatusCode);
        Assert.Equal(responseBody, exception.ResponseBody);
    }
}

