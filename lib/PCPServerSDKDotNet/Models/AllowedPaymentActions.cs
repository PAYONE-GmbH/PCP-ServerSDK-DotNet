using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Indicates which payment endpoints can be used for the respective Checkout. The systems offers two alternatives to trigger a payment and consecutive events: OrderManagementCheckoutActions or the Payment Execution resource. Both alternatives can be used simultaneously but once one of the Payment Execution endpoints is used the Order Management endpoints can no longer be used for that Checkout since it is no longer possible to match payment events to items of the Checkout. 
  /// </summary>
  [DataContract]
  public class AllowedPaymentActions
  {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class AllowedPaymentActions {\n");
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
