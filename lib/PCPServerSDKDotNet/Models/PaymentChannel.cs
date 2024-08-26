using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCPServerSDKDotNet.Models
{
  /// <summary>
  /// Gets or Sets PaymentChannel
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum PaymentChannel
  {
    [JsonProperty("ECOMMERCE")]
    [EnumMember(Value = "ECOMMERCE")]
    Ecommerce,

    [JsonProperty("POS")]
    [EnumMember(Value = "POS")]
    Pos
  }
}
