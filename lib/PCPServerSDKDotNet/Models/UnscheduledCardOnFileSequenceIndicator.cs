using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// * first &#x3D; This transaction is the first of a series of unscheduled recurring transactions * subsequent &#x3D; This transaction is a subsequent transaction in a series of unscheduled recurring transactions Note: this property is not allowed if isRecurring is true.
  /// </summary>
  [DataContract]
  public class UnscheduledCardOnFileSequenceIndicator
  {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class UnscheduledCardOnFileSequenceIndicator {\n");
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
