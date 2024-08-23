using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// The returnType refers to the ShoppingCart items of the Checkout.        returnType &#x3D; FULL should be provided if all items should be marked as returned and the payment for the entire ShoppingCart should be refunded.         returnType &#x3D; PARTIAL should be provided if only certain items should be marked as returned and the Refund should not be made for the entire ShoppingCart. For this type the list of items has to be provided.        Following conditions apply to the Return request:   * items must be in status DELIVERED   * there was no Capture, Refund or Cancel triggered over the Payment Execution resource   * for the deliverType FULL no items are provided in the request Note: If a DISCOUNT productType is among the ShoppingCart items, only returnType FULL is possible. 
  /// </summary>
  [DataContract]
  public class ReturnType
  {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class ReturnType {\n");
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
