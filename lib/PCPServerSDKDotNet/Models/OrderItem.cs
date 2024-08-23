using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// Items should only be provided for orderType &#x3D; PARTIAL
  /// </summary>
  [DataContract]
  public class OrderItem
  {
    /// <summary>
    /// Id of the item from the ShoppingCart. The id will be returned in the response from create Checkout request.
    /// </summary>
    /// <value>Id of the item from the ShoppingCart. The id will be returned in the response from create Checkout request.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "id")]
    public string? Id { get; set; }

    /// <summary>
    /// Quantity of the specific item. Must be greater than zero.  Note: Must not be all spaces or all zeros 
    /// </summary>
    /// <value>Quantity of the specific item. Must be greater than zero.  Note: Must not be all spaces or all zeros </value>
    [DataMember(Name = "quantity", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "quantity")]
    public long? Quantity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class OrderItem {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
