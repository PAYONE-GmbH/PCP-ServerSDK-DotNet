using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCPServerSDKDotNet.Models
{
  /// <summary>
  /// Specifies whether the mandate is for one-off or recurring payments. Possible
  /// values are: 
  /// * UNIQUE 
  /// * RECURRING
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum MandateRecurrenceType
  {
    [JsonProperty("UNIQUE")]
    [EnumMember(Value = "UNIQUE")]
    Unique,

    [JsonProperty("RECURRING")]
    [EnumMember(Value = "RECURRING")]
    Recurring
  }
}
