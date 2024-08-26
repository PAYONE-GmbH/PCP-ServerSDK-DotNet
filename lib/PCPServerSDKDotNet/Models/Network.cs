namespace PCPServerSDKDotNet.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NetworkEnum
    {
        [JsonProperty("MASTERCARD")]
        Mastercard,

        [JsonProperty("VISA")]
        Visa,

        [JsonProperty("AMEX")]
        Amex,

        [JsonProperty("GIROCARD")]
        Girocard,

        [JsonProperty("DISCOVER")]
        Discover,

        [JsonProperty("JCB")]
        Jcb,
    }
}
