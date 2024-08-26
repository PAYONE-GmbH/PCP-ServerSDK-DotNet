using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCPServerSDKDotNet.Models
{
  /// <summary>
  /// The extendedCheckoutStatus provides a more granular status of the Checkout
  /// based on the respective amounts. The extendedCheckoutStatus includes the
  /// regular Checkout status OPEN, DELETED, PENDING_COMPLETION, COMPLETED, BILLED,
  /// and CHARGEBACK as well as three additional statuses: 
  /// 1. PARTIALLY_BILLED: Checkout amount has been partially collected. Overall the Checkout status is
  ///    BILLED and one of the following conditions is true: (1) the openAmount is greater than zero or 
  ///    (2) the openAmount is zero, the refundAmount is zero and the checkoutAmount is not equal to 
  ///    collectedAmount plus the cancelledAmount.
  /// 2. PARTIALLY_REFUNDED: The entire Checkout amount has been captured and an amount has been 
  ///    partially refunded to the customer. Overall the Checkout status is BILLED, the openAmount 
  ///    is zero and the refundAmount and collectedAmount are greater than zero.
  /// 3. REFUNDED: The entire Checkout amount has been refunded to the customer. Overall the Checkout 
  ///    status is BILLED, the openAmount and collectedAmount are zero but the refundAmount is greater than zero.
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum ExtendedCheckoutStatus
  {
    [JsonProperty("OPEN")]
    [EnumMember(Value = "OPEN")]
    Open,

    [JsonProperty("DELETED")]
    [EnumMember(Value = "DELETED")]
    Deleted,

    [JsonProperty("PENDING_COMPLETION")]
    [EnumMember(Value = "PENDING_COMPLETION")]
    PendingCompletion,

    [JsonProperty("COMPLETED")]
    [EnumMember(Value = "COMPLETED")]
    Completed,

    [JsonProperty("PARTIALLY_BILLED")]
    [EnumMember(Value = "PARTIALLY_BILLED")]
    PartiallyBilled,

    [JsonProperty("BILLED")]
    [EnumMember(Value = "BILLED")]
    Billed,

    [JsonProperty("CHARGEBACKED")]
    [EnumMember(Value = "CHARGEBACKED")]
    Chargebacked,

    [JsonProperty("PARTIALLY_REFUNDED")]
    [EnumMember(Value = "PARTIALLY_REFUNDED")]
    PartiallyRefunded,

    [JsonProperty("REFUNDED")]
    [EnumMember(Value = "REFUNDED")]
    Refunded
  }
}
