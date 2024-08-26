
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
        List<APIError> errors = new List<APIError>
            {
                new() { Id = "error_id", ErrorCode = "error_message" }
            };

        // Act
        ApiErrorResponseException exception = new(statusCode, responseBody, errors);

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
        ApiErrorResponseException exception = new(statusCode, responseBody);

        // Assert
        Assert.Equal(statusCode, exception.StatusCode);
        Assert.Equal(responseBody, exception.ResponseBody);
        Assert.Empty(exception.Errors);
    }

    [Fact]
    public void GetErrors_ShouldReturnErrors()
    {
        // Arrange
        List<APIError> errors =
        [
                new APIError { Id = "error_id", ErrorCode = "error_message" }
            ];
        ApiErrorResponseException exception = new(404, "Not Found", errors);

        // Act
        List<APIError> result = exception.Errors;

        // Assert
        Assert.Equal(errors, result);
    }
}

