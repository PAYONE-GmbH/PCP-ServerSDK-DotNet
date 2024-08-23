using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// Determines the type of the authorization that will be used. Allowed values:    * PRE_AUTHORIZATION - The payment creation results in a pre-authorization that is ready for Capture. Pre- authortizations can be reversed and can be captured within 30 days. The capture amount can be lower than the authorized amount.    * SALE - The payment creation results in an authorization that is already captured at the moment of approval.   If the parameter is not provided in the request, the default value will be PRE_AUTHORIZATION
  /// </summary>
  [DataContract]
  public class AuthorizationMode
  {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class AuthorizationMode {\n");
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
