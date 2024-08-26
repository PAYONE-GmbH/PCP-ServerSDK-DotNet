using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCPServerSDKDotNet.Models
{
  /// <summary>
  /// Enum to classify items that are purchased
  /// * GOODS - Goods
  /// * SHIPMENT - Shipping charges
  /// * HANDLING_FEE - Handling fee
  /// * DISCOUNT - Voucher / discount
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum ProductType
  {
    [JsonProperty("GOODS")]
    [EnumMember(Value = "GOODS")]
    Goods,

    [JsonProperty("SHIPMENT")]
    [EnumMember(Value = "SHIPMENT")]
    Shipment,

    [JsonProperty("HANDLING_FEE")]
    [EnumMember(Value = "HANDLING_FEE")]
    HandlingFee,

    [JsonProperty("DISCOUNT")]
    [EnumMember(Value = "DISCOUNT")]
    Discount
  }
}
