namespace PCPServerSDKDotNet.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IntegrationTypeEnum
    {
        [JsonProperty("MERCHANT_CERTIFICATE")]
        MERCHANT_CERTIFICATE,

        [JsonProperty("MASS_ENABLEMENT")]
        MASS_ENABLEMENT,
    }
}
