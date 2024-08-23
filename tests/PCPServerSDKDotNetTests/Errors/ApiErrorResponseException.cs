
namespace PCPServerSDKDotNetTests.Errors;

using PCPServerSDKDotNet.Errors;
using PCPServerSDKDotNet.Models;


public class ApiErrorResponseExceptionTests
{
    [Fact]
    public void ApiErrorResponseException_ShouldInitializePropertiesCorrectly()
    {
        // Arrange
        int statusCode = 404;
        string responseBody = "Not Found";
        var errors = new List<APIError>
            {
                new APIError { Id = "error_id", ErrorCode = "error_message" }
            };

        // Act
        var exception = new ApiErrorResponseException(statusCode, responseBody, errors);

        // Assert
        Assert.Equal(statusCode, exception.StatusCode);
        Assert.Equal(responseBody, exception.ResponseBody);
        Assert.Equal(errors, exception.Errors);
    }

    [Fact]
    public void ApiErrorResponseException_ShouldInitializePropertiesWithDefaults()
    {
        // Arrange
        int statusCode = 404;
        string responseBody = "Not Found";

        // Act
        var exception = new ApiErrorResponseException(statusCode, responseBody);

        // Assert
        Assert.Equal(statusCode, exception.StatusCode);
        Assert.Equal(responseBody, exception.ResponseBody);
        Assert.Empty(exception.Errors);
    }

    [Fact]
    public void GetErrors_ShouldReturnErrors()
    {
        // Arrange
        var errors = new List<APIError>
            {
                new APIError { Id = "error_id", ErrorCode = "error_message" }
            };
        var exception = new ApiErrorResponseException(404, "Not Found", errors);

        // Act
        var result = exception.Errors;

        // Assert
        Assert.Equal(errors, result);
    }
}

