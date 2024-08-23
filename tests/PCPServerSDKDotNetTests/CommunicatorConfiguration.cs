namespace PCPServerSDKDotNetTests;

using PCPServerSDKDotNet.Utils;
using PCPServerSDKDotNet;


public class CommunicatorConfigurationTest
{
    [Fact]
    public void Constructor_ShouldInitializePropertiesCorrectly()
    {
        // Arrange
        string expectedApiKey = "test-api-key";
        string expectedApiSecret = "test-api-secret";
        string expectedHost = "test-host.com";
        string expectedIntegrator = "test-integrator";

        // Act
        CommunicatorConfiguration config = new(expectedApiKey, expectedApiSecret, expectedHost, expectedIntegrator);

        // Assert
        Assert.Equal(expectedApiKey, config.ApiKey);
        Assert.Equal(expectedApiSecret, config.ApiSecret);
        Assert.Equal(expectedHost, config.Host);
        Assert.NotNull(config.ServerMetaInfo);
        Assert.Equal(expectedIntegrator, config.ServerMetaInfo.Integrator);
    }

    [Fact]
    public void Constructor_ShouldHandleNullIntegrator()
    {
        // Arrange
        string expectedApiKey = "test-api-key";
        string expectedApiSecret = "test-api-secret";
        string expectedHost = "test-host.com";

        // Act
        CommunicatorConfiguration config = new(expectedApiKey, expectedApiSecret, expectedHost, null);

        // Assert
        Assert.Equal(expectedApiKey, config.ApiKey);
        Assert.Equal(expectedApiSecret, config.ApiSecret);
        Assert.Equal(expectedHost, config.Host);
        Assert.NotNull(config.ServerMetaInfo);
        Assert.Null(config.ServerMetaInfo.Integrator);
    }

    [Fact]
    public void ApiKey_ShouldBeSetCorrectly()
    {
        // Arrange
        CommunicatorConfiguration config = new("initial-key", "test-api-secret", "test-host.com", "test-integrator")
        {
            // Act
            ApiKey = "new-api-key"
        };

        // Assert
        Assert.Equal("new-api-key", config.ApiKey);
    }

    [Fact]
    public void ApiSecret_ShouldBeSetCorrectly()
    {
        // Arrange
        CommunicatorConfiguration config = new("test-api-key", "initial-secret", "test-host.com", "test-integrator")
        {
            // Act
            ApiSecret = "new-api-secret"
        };

        // Assert
        Assert.Equal("new-api-secret", config.ApiSecret);
    }

    [Fact]
    public void Host_ShouldBeSetCorrectly()
    {
        // Arrange
        CommunicatorConfiguration config = new("test-api-key", "test-api-secret", "initial-host.com", "test-integrator")
        {
            // Act
            Host = "new-host.com"
        };

        // Assert
        Assert.Equal("new-host.com", config.Host);
    }

    [Fact]
    public void ServerMetaInfo_ShouldBeSetCorrectly()
    {
        // Arrange
        CommunicatorConfiguration config = new("test-api-key", "test-api-secret", "test-host.com", "test-integrator");
        ServerMetaInfo newServerMetaInfo = new ServerMetaInfo()
            .WithPlatformIdentifier("Custom Platform")
            .WithSdkIdentifier("Custom SDK Identifier")
            .WithSdkCreator("Custom SDK Creator")
            .WithIntegrator("Custom Integrator");

        // Act
        config.ServerMetaInfo = newServerMetaInfo;

        // Assert
        Assert.Equal(newServerMetaInfo, config.ServerMetaInfo);
    }
}

