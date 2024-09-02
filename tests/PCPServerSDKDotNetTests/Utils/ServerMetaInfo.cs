namespace PCPServerSDKDotNetTests.Utils;

using PCPServerSDKDotNet.Utils;

public class ServerMetaInfoTest
{
    [Fact]
    public void TestWithDefaults_WithIntegrator()
    {
        // Arrange
        string integrator = "TestIntegrator";

        // Act
        ServerMetaInfo result = ServerMetaInfo.WithDefaults(integrator);

        // Assert
        Assert.NotNull(result.PlatformIdentifier);
        Assert.Equal($"{Environment.OSVersion}, .NET version is: {Environment.Version}", result.PlatformIdentifier);
        Assert.Equal("DotNetServerSDK/v0.0.2", result.SdkIdentifier);
        Assert.Equal("PAYONE GmbH", result.SdkCreator);
        Assert.Equal(integrator, result.Integrator);
    }

    [Fact]
    public void TestWithDefaults_WithoutIntegrator()
    {
        // Act
        ServerMetaInfo result = ServerMetaInfo.WithDefaults();

        // Assert
        Assert.NotNull(result.PlatformIdentifier);
        Assert.Equal($"{Environment.OSVersion}, .NET version is: {Environment.Version}", result.PlatformIdentifier);
        Assert.Equal("DotNetServerSDK/v0.0.2", result.SdkIdentifier);
        Assert.Equal("PAYONE GmbH", result.SdkCreator);
        Assert.Null(result.Integrator);
    }

    [Fact]
    public void TestPropertySetters()
    {
        // Arrange
        string platformIdentifier = "Windows 10, .NET version is: 5.0";
        string sdkIdentifier = "DotNetServerSDK/v0.0.2";
        string sdkCreator = "Another Creator";
        string integrator = "AnotherIntegrator";

        // Act
        ServerMetaInfo result = new ServerMetaInfo()
            .WithPlatformIdentifier(platformIdentifier)
            .WithSdkIdentifier(sdkIdentifier)
            .WithSdkCreator(sdkCreator)
            .WithIntegrator(integrator);

        // Assert
        Assert.Equal(platformIdentifier, result.PlatformIdentifier);
        Assert.Equal(sdkIdentifier, result.SdkIdentifier);
        Assert.Equal(sdkCreator, result.SdkCreator);
        Assert.Equal(integrator, result.Integrator);
    }

    [Fact]
    public void TestEquality()
    {
        // Arrange
        ServerMetaInfo info1 = new ServerMetaInfo()
            .WithPlatformIdentifier("Platform1")
            .WithSdkIdentifier("SDK1")
            .WithSdkCreator("Creator1")
            .WithIntegrator("Integrator1");

        ServerMetaInfo info2 = new ServerMetaInfo()
            .WithPlatformIdentifier("Platform1")
            .WithSdkIdentifier("SDK1")
            .WithSdkCreator("Creator1")
            .WithIntegrator("Integrator1");

        // Act & Assert
        Assert.Equal(info1, info2);
        Assert.True(info1.Equals(info2));
        Assert.Equal(info1.GetHashCode(), info2.GetHashCode());
    }

    [Fact]
    public void TestInequality()
    {
        // Arrange
        ServerMetaInfo info1 = new ServerMetaInfo()
            .WithPlatformIdentifier("Platform1")
            .WithSdkIdentifier("SDK1")
            .WithSdkCreator("Creator1")
            .WithIntegrator("Integrator1");

        ServerMetaInfo info2 = new ServerMetaInfo()
            .WithPlatformIdentifier("Platform2")
            .WithSdkIdentifier("SDK2")
            .WithSdkCreator("Creator2")
            .WithIntegrator("Integrator2");

        // Act & Assert
        Assert.NotEqual(info1, info2);
        Assert.False(info1.Equals(info2));
        Assert.NotEqual(info1.GetHashCode(), info2.GetHashCode());
    }
}
