using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCPServerSDKDotNet.Models
{
  /// <summary>
  /// Current high-level status of the payment in a human-readable form.
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum StatusValue
  {
    [JsonProperty("CREATED")]
    [EnumMember(Value = "CREATED")]
    Created,

    [JsonProperty("CANCELLED")]
    [EnumMember(Value = "CANCELLED")]
    Cancelled,

    [JsonProperty("REJECTED")]
    [EnumMember(Value = "REJECTED")]
    Rejected,

    [JsonProperty("REJECTED_CAPTURE")]
    [EnumMember(Value = "REJECTED_CAPTURE")]
    RejectedCapture,

    [JsonProperty("REDIRECTED")]
    [EnumMember(Value = "REDIRECTED")]
    Redirected,

    [JsonProperty("PENDING_PAYMENT")]
    [EnumMember(Value = "PENDING_PAYMENT")]
    PendingPayment,

    [JsonProperty("PENDING_COMPLETION")]
    [EnumMember(Value = "PENDING_COMPLETION")]
    PendingCompletion,

    [JsonProperty("PENDING_CAPTURE")]
    [EnumMember(Value = "PENDING_CAPTURE")]
    PendingCapture,

    [JsonProperty("AUTHORIZATION_REQUESTED")]
    [EnumMember(Value = "AUTHORIZATION_REQUESTED")]
    AuthorizationRequested,

    [JsonProperty("CAPTURE_REQUESTED")]
    [EnumMember(Value = "CAPTURE_REQUESTED")]
    CaptureRequested,

    [JsonProperty("CAPTURED")]
    [EnumMember(Value = "CAPTURED")]
    Captured,

    [JsonProperty("REVERSED")]
    [EnumMember(Value = "REVERSED")]
    Reversed,

    [JsonProperty("REFUND_REQUESTED")]
    [EnumMember(Value = "REFUND_REQUESTED")]
    RefundRequested,

    [JsonProperty("REFUNDED")]
    [EnumMember(Value = "REFUNDED")]
    Refunded,

    [JsonProperty("REJECTED_REFUND")]
    [EnumMember(Value = "REJECTED_REFUND")]
    RejectedRefund,

    [JsonProperty("CANCELLATION_REQUESTED")]
    [EnumMember(Value = "CANCELLATION_REQUESTED")]
    CancellationRequested,

    [JsonProperty("PAUSED")]
    [EnumMember(Value = "PAUSED")]
    Paused,

    [JsonProperty("CHARGEBACKED")]
    [EnumMember(Value = "CHARGEBACKED")]
    Chargebacked,

    [JsonProperty("CHARGEBACK_REVERSED")]
    [EnumMember(Value = "CHARGEBACK_REVERSED")]
    ChargebackReversed,

    [JsonProperty("ACCOUNT_CREDITED")]
    [EnumMember(Value = "ACCOUNT_CREDITED")]
    AccountCredited,

    [JsonProperty("ACCOUNT_DEBITED")]
    [EnumMember(Value = "ACCOUNT_DEBITED")]
    AccountDebited
  }
}
