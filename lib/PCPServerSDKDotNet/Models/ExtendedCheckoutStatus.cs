using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// The extendedCheckoutStatus provides a more granular status of the Checkout based on the respective amounts. The extendedCheckoutStatus include the regular Checkout status OPEN, DELETED, PENDING_COMPLETION, COMPLETED, BILLED, and CHARGEBACKED as well as three additional status:  1. PARTIALLY_BILLED: Checkout amount has been partially collected. Overall the Checkout status is BILLED and one of the following conditions is true:   (1) the openAmount is greater than zero or   (2) the openAmount is zero, the refundAmount is zero and the checkoutAmount is not equal to collectedAmount plus the cancelledAmount. 2. PARTIALLY_REFUNDED: The entire Checkout amount has been captured and an amount has been partially refunded to customer. Overall the Checkout status is BILLED, the openAmount is zero and the refundAmount and collectedAmount are greater than zero. 3. REFUNDED: The entire Checkout amount has been refunded to the customer. Overall the Checkout status is BILLED, the openAmount and collectedAmount are zero but the refundAmount is greater than zero. 
  /// </summary>
  [DataContract]
  public class ExtendedCheckoutStatus
  {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class ExtendedCheckoutStatus {\n");
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
