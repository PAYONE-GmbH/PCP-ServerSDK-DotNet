namespace PCPServerSDKDotNet;

using System;

public class CommunicatorConfiguration
{
    public string ApiKey { get; set; }
    public string ApiSecret { get; set; }
    public string Host { get; set; }
    public ServerMetaInfo ServerMetaInfo { get; set; }

    public CommunicatorConfiguration(string apiKey, string apiSecret, string host, string? integrator)
    {
        this.ApiKey = apiKey;
        this.ApiSecret = apiSecret;
        this.Host = host;
        this.ServerMetaInfo = ServerMetaInfo.WithDefaults(integrator);
    }


}
