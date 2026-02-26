namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Reason why an order was cancelled. Possible values:
    /// * CONSUMER_REQUEST - The consumer requested a cancellation of the Order
    /// * UNDELIVERABLE - The merchant cannot fulfill the Order
    /// * DUPLICATE - The Order was created twice accidentally
    /// * FRAUDULENT - Consumer turned out to be a fraudster
    /// * ORDER_SHIPPED_IN_FULL - The merchant shipped everything and wants to cancel the remaining authorized amount of the Order
    /// * AUTOMATED_SHIPMENT_FAILED - A technical error was thrown during an automated shipment API call rendering the Order impossible to complete
    ///
    /// Mandatory for PAYONE Buy Now, Pay Later (BNPL):
    /// * 3390 - PAYONE Secured Invoice
    /// * 3391 - PAYONE Secured Installment
    /// * 3392 - PAYONE Secured Direct Debit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CancellationReason
    {
        [JsonProperty("CONSUMER_REQUEST")]
        [EnumMember(Value = "CONSUMER_REQUEST")]
        ConsumerRequest,

        [JsonProperty("UNDELIVERABLE")]
        [EnumMember(Value = "UNDELIVERABLE")]
        Undeliverable,

        [JsonProperty("DUPLICATE")]
        [EnumMember(Value = "DUPLICATE")]
        Duplicate,

        [JsonProperty("FRAUDULENT")]
        [EnumMember(Value = "FRAUDULENT")]
        Fraudulent,

        [JsonProperty("ORDER_SHIPPED_IN_FULL")]
        [EnumMember(Value = "ORDER_SHIPPED_IN_FULL")]
        OrderShippedInFull,

        [JsonProperty("AUTOMATED_SHIPMENT_FAILED")]
        [EnumMember(Value = "AUTOMATED_SHIPMENT_FAILED")]
        AutomatedShipmentFailed,
    }
}
