using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RefundErrorResponse
  {
    /// <summary>
    /// Unique reference, for debugging purposes, of this error response
    /// </summary>
    /// <value>Unique reference, for debugging purposes, of this error response</value>
    [DataMember(Name = "errorId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "errorId")]
    public string? ErrorId { get; set; }

    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [DataMember(Name = "errors", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "errors")]
    public List<APIError>? Errors { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class RefundErrorResponse {\n");
      sb.Append("  ErrorId: ").Append(ErrorId).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
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
