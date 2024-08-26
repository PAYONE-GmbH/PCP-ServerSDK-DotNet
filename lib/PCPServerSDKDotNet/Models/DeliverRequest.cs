using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Request to mark items of the respective Checkout as delivered and to automatically execute a Capture.  A Deliver can be created for a full or the partial ShoppingCart of the Checkout.  The platform will automatically calculate the respective amount to trigger the Capture. For a partial Deliver a list of items must be provided. The item details for the Capture will be automatically loaded from the Checkout.     The cancellationReason must be provided if deliverType is set to PARTIAL and isFinal is set to true for BNPL payment methods (paymentProductId 3390, 3391 and 3392). For other payment methods the cancellationReason is not mandatory in this case but can be used for reporting and reconciliation purposes. 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class DeliverRequest
  {
    /// <summary>
    /// Gets or Sets DeliverType
    /// </summary>
    [DataMember(Name = "deliverType", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "deliverType")]
    public DeliverType? DeliverType { get; set; }

    /// <summary>
    /// This property indicates whether this will be the final operation. For deliverType FULL, it is always the final operation. If deliverType PARTIAL is provided and the property is set to true, the remaining amount of the items will be cancelled and the items are marked as CANCELLED. 
    /// </summary>
    /// <value>This property indicates whether this will be the final operation. For deliverType FULL, it is always the final operation. If deliverType PARTIAL is provided and the property is set to true, the remaining amount of the items will be cancelled and the items are marked as CANCELLED. </value>
    [DataMember(Name = "isFinal", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "isFinal")]
    public bool? IsFinal { get; set; }

    /// <summary>
    /// Gets or Sets CancellationReason
    /// </summary>
    [DataMember(Name = "cancellationReason", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "cancellationReason")]
    public CancellationReason? CancellationReason { get; set; }

    /// <summary>
    /// Gets or Sets DeliverItems
    /// </summary>
    [DataMember(Name = "deliverItems", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "deliverItems")]
    public List<DeliverItem>? DeliverItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class DeliverRequest {\n");
      sb.Append("  DeliverType: ").Append(DeliverType).Append("\n");
      sb.Append("  IsFinal: ").Append(IsFinal).Append("\n");
      sb.Append("  CancellationReason: ").Append(CancellationReason).Append("\n");
      sb.Append("  DeliverItems: ").Append(DeliverItems).Append("\n");
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
