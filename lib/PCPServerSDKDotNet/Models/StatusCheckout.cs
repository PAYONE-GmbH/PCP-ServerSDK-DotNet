namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Current high-level status of the Checkout.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusCheckout
    {
        [JsonProperty("OPEN")]
        [EnumMember(Value = "OPEN")]
        Open,

        [JsonProperty("PENDING_COMPLETION")]
        [EnumMember(Value = "PENDING_COMPLETION")]
        PendingCompletion,

        [JsonProperty("COMPLETED")]
        [EnumMember(Value = "COMPLETED")]
        Completed,

        [JsonProperty("BILLED")]
        [EnumMember(Value = "BILLED")]
        Billed,

        [JsonProperty("CHARGEBACKED")]
        [EnumMember(Value = "CHARGEBACKED")]
        Chargebacked,

        [JsonProperty("DELETED")]
        [EnumMember(Value = "DELETED")]
        Deleted,
    }
}
