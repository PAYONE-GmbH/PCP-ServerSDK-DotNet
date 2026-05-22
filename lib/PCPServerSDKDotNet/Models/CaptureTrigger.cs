namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Indicates the event upon which the payment should be captured.
    /// This value is shown to customers in the Wero portal to clarify
    /// when the capture will occur.
    /// Has the following possible values:
    /// - shipping: Upon shipping the order.
    /// - delivery: Upon delivering the order.
    /// - availability: As soon as the order is available.
    /// - serviceFulfillment: Upon fulfilling the service.
    /// - other: For any other use case.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CaptureTrigger
    {
        [JsonProperty("shipping")]
        [EnumMember(Value = "shipping")]
        Shipping,

        [JsonProperty("delivery")]
        [EnumMember(Value = "delivery")]
        Delivery,

        [JsonProperty("availability")]
        [EnumMember(Value = "availability")]
        Availability,

        [JsonProperty("serviceFulfillment")]
        [EnumMember(Value = "serviceFulfillment")]
        ServiceFulfillment,

        [JsonProperty("other")]
        [EnumMember(Value = "other")]
        Other,
    }
}
