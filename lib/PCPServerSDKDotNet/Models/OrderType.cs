using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// The orderType refers to the ShoppingCart of the Checkout.         orderType &#x3D; FULL should be provided if a payment for the entire ShoppingCart should be created.         orderType &#x3D; PARTIAL should be provided if the payment should be created only for certain items of the ShoppingCart. For this type the list of items has to be provided. Following conditions apply to the Order request:   * amount of the Checkout can not be zero   * the ShoppingCart cannot be empty   * for orderType &#x3D; FULL the Checkout status is OPEN, there is no other order and/or Payment Execution and no items should be provided in the body   * if no paymentMethodSpecificInput has been provided in the creation of the Commerce Case or Checkout it has to be provided in this request 
  /// </summary>
  [DataContract]
  public class OrderType
  {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class OrderType {\n");
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
