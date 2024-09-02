namespace PCPServerSDKDotNet.Utils;

using System;
using System.Text.Json.Serialization;

public class ServerMetaInfo
{
    [JsonPropertyName("platformIdentifier")]
    public string? PlatformIdentifier { get; set; }

    [JsonPropertyName("sdkIdentifier")]
    public string? SdkIdentifier { get; set; }

    [JsonPropertyName("sdkCreator")]
    public string? SdkCreator { get; set; }

    [JsonPropertyName("integrator")]
    public string? Integrator { get; set; }

    public static ServerMetaInfo WithDefaults(string? integrator = null)
    {
        return new ServerMetaInfo()
            .WithPlatformIdentifier($"{Environment.OSVersion}, .NET version is: {Environment.Version}")
            .WithSdkIdentifier("DotNetServerSDK/v0.0.2")
            .WithSdkCreator("PAYONE GmbH")
            .WithIntegrator(integrator);
    }

    public ServerMetaInfo WithPlatformIdentifier(string platformIdentifier)
    {
        this.PlatformIdentifier = platformIdentifier;
        return this;
    }

    public ServerMetaInfo WithSdkIdentifier(string sdkIdentifier)
    {
        this.SdkIdentifier = sdkIdentifier;
        return this;
    }

    public ServerMetaInfo WithSdkCreator(string sdkCreator)
    {
        this.SdkCreator = sdkCreator;
        return this;
    }

    public ServerMetaInfo WithIntegrator(string? integrator)
    {
        this.Integrator = integrator;
        return this;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (obj is ServerMetaInfo)
        {
            return this.Equals(obj as ServerMetaInfo);
        }

        return false;
    }

    public bool Equals(ServerMetaInfo? other)
    {
        if (other == null)
        {
            return false;
        }

        return this.PlatformIdentifier == other.PlatformIdentifier &&
               this.SdkIdentifier == other.SdkIdentifier &&
               this.SdkCreator == other.SdkCreator &&
               this.Integrator == other.Integrator;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.PlatformIdentifier, this.SdkIdentifier, this.SdkCreator, this.Integrator);
    }
}
