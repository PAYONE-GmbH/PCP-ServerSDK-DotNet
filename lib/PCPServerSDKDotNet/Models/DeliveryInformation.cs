using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// Delivery object contains additional information about the delivery/shipment, which is the basis for the Capture. The amountOfMoney in the cartItem will not be used in the request.
  /// </summary>
  [DataContract]
  public class DeliveryInformation
  {
    /// <summary>
    /// Items delivered.
    /// </summary>
    /// <value>Items delivered.</value>
    [DataMember(Name = "items", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "items")]
    public List<CartItemInput>? Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class DeliveryInformation {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
