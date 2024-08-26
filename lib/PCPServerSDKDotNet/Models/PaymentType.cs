using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCPServerSDKDotNet.Models
{
  /// <summary>
  /// Defines the respective payment type.
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum PaymentType
  {
    [JsonProperty("SALE")]
    [EnumMember(Value = "SALE")]
    Sale,

    [JsonProperty("RESERVATION")]
    [EnumMember(Value = "RESERVATION")]
    Reservation,

    [JsonProperty("CAPTURE")]
    [EnumMember(Value = "CAPTURE")]
    Capture,

    [JsonProperty("REFUND")]
    [EnumMember(Value = "REFUND")]
    Refund,

    [JsonProperty("REVERSAL")]
    [EnumMember(Value = "REVERSAL")]
    Reversal,

    [JsonProperty("CHARGEBACK_REVERSAL")]
    [EnumMember(Value = "CHARGEBACK_REVERSAL")]
    ChargebackReversal,

    [JsonProperty("CREDIT_NOTE")]
    [EnumMember(Value = "CREDIT_NOTE")]
    CreditNote,

    [JsonProperty("DEBIT_NOTE")]
    [EnumMember(Value = "DEBIT_NOTE")]
    DebitNote
  }
}
