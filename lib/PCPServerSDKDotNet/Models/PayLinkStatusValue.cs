namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayLinkStatusValue
    {
        [JsonProperty("ACTIVE")]
        [EnumMember(Value = "ACTIVE")]
        Active,

        [JsonProperty("PAID")]
        [EnumMember(Value = "PAID")]
        Paid,

        [JsonProperty("EXPIRED")]
        [EnumMember(Value = "EXPIRED")]
        Expired,

        [JsonProperty("REDIRECTED")]
        [EnumMember(Value = "REDIRECTED")]
        Redirected,
    }
}
