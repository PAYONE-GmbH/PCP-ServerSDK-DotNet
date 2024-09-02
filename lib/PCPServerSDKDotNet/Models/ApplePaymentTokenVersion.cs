namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApplePaymentTokenVersion
    {
        [JsonProperty("EC_V1")]
        [EnumMember(Value = "EC_V1")]
        EcV1,
    }
}
