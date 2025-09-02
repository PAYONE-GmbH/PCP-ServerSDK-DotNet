using PCPServerSDKDotNet;
using PCPServerSDKDotNet.Endpoints;

namespace PCPServerSDKDotNetTests.Endpoints;

// Test-specific derived class to access protected members
public class TestableBaseApiClient : BaseApiClient
{
    public TestableBaseApiClient(CommunicatorConfiguration config) : base(config)
    {
    }

    public TestableBaseApiClient(CommunicatorConfiguration config, HttpClient? httpClient) : base(config, httpClient)
    {
    }

    public new HttpClient GetClient()
    {
        return base.GetClient();
    }
}

public class BaseApiClientTest
{
    private readonly CommunicatorConfiguration COMMUNICATOR_CONFIGURATION = new("KEY",
        "Super duper Ethan Hunt level secret",
        "awesome-api.com", null);

    [Fact]
    public void TestDefaultHttpClient()
    {
        // Arrange & Act
        TestableBaseApiClient client = new(COMMUNICATOR_CONFIGURATION);
        HttpClient httpClient = client.GetClient();

        // Assert
        Assert.NotNull(httpClient);
        Assert.IsType<HttpClient>(httpClient);
    }

    [Fact]
    public void TestClientSpecificHttpClient()
    {
        // Arrange
        HttpClient customHttpClient = new();

        // Act
        TestableBaseApiClient client = new(COMMUNICATOR_CONFIGURATION, customHttpClient);
        HttpClient resultClient = client.GetClient();

        // Assert
        Assert.Equal(customHttpClient, resultClient);
    }

    [Fact]
    public void TestGlobalHttpClient()
    {
        // Arrange
        HttpClient globalHttpClient = new();
        CommunicatorConfiguration config = new("KEY", "SECRET", "host", null)
        {
            HttpClient = globalHttpClient
        };

        // Act
        TestableBaseApiClient client = new(config);
        HttpClient resultClient = client.GetClient();

        // Assert
        Assert.Equal(globalHttpClient, resultClient);
    }

    [Fact]
    public void TestClientSpecificOverridesGlobal()
    {
        // Arrange
        HttpClient globalHttpClient = new();
        HttpClient clientSpecificHttpClient = new();

        CommunicatorConfiguration config = new("KEY", "SECRET", "host", null)
        {
            HttpClient = globalHttpClient
        };

        // Act
        TestableBaseApiClient client = new(config, clientSpecificHttpClient);
        HttpClient resultClient = client.GetClient();

        // Assert
        Assert.Equal(clientSpecificHttpClient, resultClient);
        Assert.NotEqual(globalHttpClient, resultClient);
    }

    [Fact]
    public void TestSetHttpClient()
    {
        // Arrange
        TestableBaseApiClient client = new(COMMUNICATOR_CONFIGURATION);
        HttpClient customHttpClient = new();

        // Act
        client.SetHttpClient(customHttpClient);
        HttpClient resultClient = client.GetClient();

        // Assert
        Assert.Equal(customHttpClient, resultClient);
    }

    [Fact]
    public void TestSetHttpClientToNull()
    {
        // Arrange
        HttpClient customHttpClient = new();
        TestableBaseApiClient client = new(COMMUNICATOR_CONFIGURATION, customHttpClient);

        // Verify initial state
        Assert.Equal(customHttpClient, client.GetClient());

        // Act
        client.SetHttpClient(null);
        HttpClient resultClient = client.GetClient();

        // Assert - Should fall back to default
        Assert.NotEqual(customHttpClient, resultClient);
        Assert.IsType<HttpClient>(resultClient);
    }

    [Fact]
    public void TestSetHttpClientOverridesGlobal()
    {
        // Arrange
        HttpClient globalHttpClient = new();
        HttpClient newClientSpecificHttpClient = new();

        CommunicatorConfiguration config = new("KEY", "SECRET", "host", null)
        {
            HttpClient = globalHttpClient
        };

        TestableBaseApiClient client = new(config);

        // Verify initial state uses global
        Assert.Equal(globalHttpClient, client.GetClient());

        // Act
        client.SetHttpClient(newClientSpecificHttpClient);
        HttpClient resultClient = client.GetClient();

        // Assert
        Assert.Equal(newClientSpecificHttpClient, resultClient);
        Assert.NotEqual(globalHttpClient, resultClient);
    }
}
