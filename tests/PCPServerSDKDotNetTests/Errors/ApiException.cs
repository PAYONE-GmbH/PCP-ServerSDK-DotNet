namespace PCPServerSDKDotNetTests.Errors;

using PCPServerSDKDotNet.Errors;

public class ApiExceptionTests
{
    [Fact]
    public void Constructor_ShouldInitializePropertiesCorrectly()
    {
        // Arrange
        int expectedStatusCode = 404;
        string expectedResponseBody = "Not Found";
        string expectedMessage = $"Status code: {expectedStatusCode}, Response body: {expectedResponseBody}";

        // Act
        var exception = new ApiException(expectedStatusCode, expectedResponseBody);

        // Assert
        Assert.Equal(expectedStatusCode, exception.StatusCode);
        Assert.Equal(expectedResponseBody, exception.ResponseBody);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Constructor_ShouldInitializeWithEmptyResponseBody()
    {
        // Arrange
        int expectedStatusCode = 200;
        string expectedResponseBody = string.Empty;
        string expectedMessage = $"Status code: {expectedStatusCode}, Response body: {expectedResponseBody}";

        // Act
        var exception = new ApiException(expectedStatusCode, expectedResponseBody);

        // Assert
        Assert.Equal(expectedStatusCode, exception.StatusCode);
        Assert.Equal(expectedResponseBody, exception.ResponseBody);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Constructor_ShouldHandleNullResponseBody()
    {
        // Arrange
        int expectedStatusCode = 500;
        string expectedResponseBody = "";
        string expectedMessage = $"Status code: {expectedStatusCode}, Response body: ";

        // Act
        var exception = new ApiException(expectedStatusCode, expectedResponseBody);

        // Assert
        Assert.Equal(expectedStatusCode, exception.StatusCode);
        Assert.Equal(expectedResponseBody, exception.ResponseBody);
        Assert.Equal(expectedMessage, exception.Message);
    }
}

