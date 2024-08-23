using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing the line items of the invoice or shopping cart.
  /// </summary>
  [DataContract]
  public class CartItemInvoiceData
  {
    /// <summary>
    /// Shopping cart item description. The description will also be displayed in the portal as the product name. 
    /// </summary>
    /// <value>Shopping cart item description. The description will also be displayed in the portal as the product name. </value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string? Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CartItemInvoiceData {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
