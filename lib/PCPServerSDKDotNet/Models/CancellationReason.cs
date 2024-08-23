using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Reason why an order was cancelled. Possible values:         * CONSUMER_REQUEST - The consumer requested a cancellation of the Order * UNDELIVERABLE - The merchant cannot fulfill the Order * DUPLICATE - The Order was created twice accidentally * FRAUDULENT- Consumer turned out to be a fraudster * ORDER_SHIPPED_IN_FULL - The merchant shipped everything and wants to cancel the remaining authorized amount of the Order * AUTOMATED_SHIPMENT_FAILED - A technical error was thrown during an automated shipment API call rendering the Order impossible to complete  Mandatory for PAYONE Buy Now, Pay Later (BNPL): * 3390 - PAYONE Secured Invoice * 3391 - PAYONE Secured Installment * 3392 - PAYONE Secured Direct Debit
  /// </summary>
  [DataContract]
  public class CancellationReason
  {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CancellationReason {\n");
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
