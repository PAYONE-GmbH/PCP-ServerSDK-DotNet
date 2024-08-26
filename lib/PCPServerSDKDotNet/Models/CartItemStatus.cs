using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCPServerSDKDotNet.Models
{
  /// <summary>
  /// Indicates in which status the line item is.
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum CartItemStatus
  {
    [JsonProperty("ORDERED")]
    [EnumMember(Value = "ORDERED")]
    Ordered,

    [JsonProperty("DELIVERED")]
    [EnumMember(Value = "DELIVERED")]
    Delivered,

    [JsonProperty("CANCELLED")]
    [EnumMember(Value = "CANCELLED")]
    Cancelled,

    [JsonProperty("RETURNED")]
    [EnumMember(Value = "RETURNED")]
    Returned,

    [JsonProperty("WAITING_FOR_PAYMENT")]
    [EnumMember(Value = "WAITING_FOR_PAYMENT")]
    WaitingForPayment
  }
}
