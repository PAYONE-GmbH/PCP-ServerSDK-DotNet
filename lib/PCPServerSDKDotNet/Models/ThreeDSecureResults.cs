using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// 3D Secure results object
  /// </summary>
  [DataContract]
  public class ThreeDSecureResults
  {
    /// <summary>
    /// 3D Secure Protocol version used during this transaction.
    /// </summary>
    /// <value>3D Secure Protocol version used during this transaction.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "version")]
    public string? Version { get; set; }

    /// <summary>
    /// 3D Secure ECI (Electronic Commerce Indicator) depending on the Scheme. Returned by DS.
    /// </summary>
    /// <value>3D Secure ECI (Electronic Commerce Indicator) depending on the Scheme. Returned by DS.</value>
    [DataMember(Name = "schemeEci", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "schemeEci")]
    public string? SchemeEci { get; set; }

    /// <summary>
    /// Exemption requested and applied in the authorization. 
    /// </summary>
    /// <value>Exemption requested and applied in the authorization. </value>
    [DataMember(Name = "appliedExemption", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "appliedExemption")]
    public string? AppliedExemption { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class ThreeDSecureResults {\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  SchemeEci: ").Append(SchemeEci).Append("\n");
      sb.Append("  AppliedExemption: ").Append(AppliedExemption).Append("\n");
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
