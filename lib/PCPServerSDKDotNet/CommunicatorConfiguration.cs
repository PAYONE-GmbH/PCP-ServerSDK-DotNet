namespace PCPServerSDKDotNet;

using PCPServerSDKDotNet.Utils;

public class CommunicatorConfiguration
{
    public CommunicatorConfiguration(string apiKey, string apiSecret, string host, string? integrator)
    {
        this.ApiKey = apiKey;
        this.ApiSecret = apiSecret;
        this.Host = host;
        this.ServerMetaInfo = ServerMetaInfo.WithDefaults(integrator);
    }

    public string ApiKey { get; set; }

    public string ApiSecret { get; set; }

    public string Host { get; set; }

    public ServerMetaInfo ServerMetaInfo { get; set; }
}
