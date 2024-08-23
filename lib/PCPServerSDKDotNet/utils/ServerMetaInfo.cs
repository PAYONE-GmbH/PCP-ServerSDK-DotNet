namespace PCPServerSDKDotNet;

using System;
using System.Text.Json.Serialization;
using System.Text.Json;

public class ServerMetaInfo
{
    public static ServerMetaInfo WithDefaults(string? integrator = null)
    {
        return new ServerMetaInfo()
            .WithPlatformIdentifier($"{Environment.OSVersion}, .NET version is: {Environment.Version}")
            .WithSdkIdentifier("DotNetServerSDK/v1.0.0")
            .WithSdkCreator("PAYONE GmbH")
            .WithIntegrator(integrator);
    }

    [JsonPropertyName("platformIdentifier")]
    public string? PlatformIdentifier { get; set; }

    [JsonPropertyName("sdkIdentifier")]
    public string? SdkIdentifier { get; set; }

    [JsonPropertyName("sdkCreator")]
    public string? SdkCreator { get; set; }

    [JsonPropertyName("integrator")]
    public string? Integrator { get; set; }



    public ServerMetaInfo WithPlatformIdentifier(string platformIdentifier)
    {
        PlatformIdentifier = platformIdentifier;
        return this;
    }

    public ServerMetaInfo WithSdkIdentifier(string sdkIdentifier)
    {
        SdkIdentifier = sdkIdentifier;
        return this;
    }

    public ServerMetaInfo WithSdkCreator(string sdkCreator)
    {
        SdkCreator = sdkCreator;
        return this;
    }

    public ServerMetaInfo WithIntegrator(string? integrator)
    {
        Integrator = integrator;
        return this;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as ServerMetaInfo);
    }

    public bool Equals(ServerMetaInfo other)
    {
        return other != null &&
               PlatformIdentifier == other.PlatformIdentifier &&
               SdkIdentifier == other.SdkIdentifier &&
               SdkCreator == other.SdkCreator &&
               Integrator == other.Integrator;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(PlatformIdentifier, SdkIdentifier, SdkCreator, Integrator);
    }
}
