using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// The deliverType refers to the ShoppingCart items of the Checkout.      deliverType &#x3D; FULL should be provided if all items should be marked as delivered and the payment for the entire ShoppingCart should be captured.         deliverType &#x3D; PARTIAL should be provided if only certain items should be marked as delivered and the Capture should not be made for the entire ShoppingCart. For this type the list of items has to be provided.         Following conditions apply to the Deliver request:   * items must be in status ORDERED   * there was no Capture, Refund or Cancel triggered over the Payment Execution resource   * for the deliverType FULL no items are provided in the request Note: If a DISCOUNT productType is among the ShoppingCart items, only deliverType FULL is possible. 
  /// </summary>
  [DataContract]
  public class DeliverType
  {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class DeliverType {\n");
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
