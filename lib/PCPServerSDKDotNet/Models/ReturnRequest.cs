using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Request to mark items of the respective Checkout as returned and to automatically refund a payment for those items.  A Return can be created for a full or the partial ShoppingCart of the Checkout.  The platform will automatically calculate the respective amount to trigger the Refund. For a partial Return a list of items must be provided. The item details for the Refund will be automatically loaded from the Checkout.        The returnReason can be provided for reporting and reconciliation purposes but is not mandatory. 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class ReturnRequest
  {
    /// <summary>
    /// Gets or Sets ReturnType
    /// </summary>
    [DataMember(Name = "returnType", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "returnType")]
    public ReturnType? ReturnType { get; set; }

    /// <summary>
    /// Reason of the Refund (e.g. communicated by or to the consumer).
    /// </summary>
    /// <value>Reason of the Refund (e.g. communicated by or to the consumer).</value>
    [DataMember(Name = "returnReason", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "returnReason")]
    public string? ReturnReason { get; set; }

    /// <summary>
    /// Gets or Sets ReturnItems
    /// </summary>
    [DataMember(Name = "returnItems", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "returnItems")]
    public List<ReturnItem>? ReturnItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class ReturnRequest {\n");
      sb.Append("  ReturnType: ").Append(ReturnType).Append("\n");
      sb.Append("  ReturnReason: ").Append(ReturnReason).Append("\n");
      sb.Append("  ReturnItems: ").Append(ReturnItems).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson()
    {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

  }
}
