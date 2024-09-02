namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// High-level status of the payment, payout, or refund.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusCategoryValue
    {
        [JsonProperty("CREATED")]
        [EnumMember(Value = "CREATED")]
        Created,

        [JsonProperty("UNSUCCESSFUL")]
        [EnumMember(Value = "UNSUCCESSFUL")]
        Unsuccessful,

        [JsonProperty("PENDING_PAYMENT")]
        [EnumMember(Value = "PENDING_PAYMENT")]
        PendingPayment,

        [JsonProperty("PENDING_MERCHANT")]
        [EnumMember(Value = "PENDING_MERCHANT")]
        PendingMerchant,

        [JsonProperty("PENDING_CONNECT_OR_3RD_PARTY")]
        [EnumMember(Value = "PENDING_CONNECT_OR_3RD_PARTY")]
        PendingConnectOr3rdParty,

        [JsonProperty("COMPLETED")]
        [EnumMember(Value = "COMPLETED")]
        Completed,

        [JsonProperty("REVERSED")]
        [EnumMember(Value = "REVERSED")]
        Reversed,

        [JsonProperty("REFUNDED")]
        [EnumMember(Value = "REFUNDED")]
        Refunded,
    }
}
