using PCPServerSDKDotNet.Utils;

namespace PCPServerSDKDotNet;


public class CommunicatorConfiguration
{
    public string ApiKey { get; set; }
    public string ApiSecret { get; set; }
    public string Host { get; set; }
    public ServerMetaInfo ServerMetaInfo { get; set; }

    public CommunicatorConfiguration(string apiKey, string apiSecret, string host, string? integrator)
    {
        ApiKey = apiKey;
        ApiSecret = apiSecret;
        Host = host;
        ServerMetaInfo = ServerMetaInfo.WithDefaults(integrator);
    }


}
