using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCPServerSDKDotNet.Models
{
  /// <summary>
  /// * first = This transaction is the first of a series of unscheduled recurring transactions
  /// * subsequent = This transaction is a subsequent transaction in a series of unscheduled recurring transactions
  /// Note: This property is not allowed if isRecurring is true.
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum UnscheduledCardOnFileSequenceIndicator
  {
    [JsonProperty("first")]
    [EnumMember(Value = "first")]
    First,

    [JsonProperty("subsequent")]
    [EnumMember(Value = "subsequent")]
    Subsequent
  }
}
