namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Enum representing the payment status.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentStatus
    {
        [JsonProperty("WAITING_FOR_PAYMENT")]
        [EnumMember(Value = "WAITING_FOR_PAYMENT")]
        WaitingForPayment,

        [JsonProperty("PAYMENT_NOT_COMPLETED")]
        [EnumMember(Value = "PAYMENT_NOT_COMPLETED")]
        PaymentNotCompleted,

        [JsonProperty("PAYMENT_COMPLETED")]
        [EnumMember(Value = "PAYMENT_COMPLETED")]
        PaymentCompleted,

        [JsonProperty("NO_PAYMENT")]
        [EnumMember(Value = "NO_PAYMENT")]
        NoPayment,
    }
}
