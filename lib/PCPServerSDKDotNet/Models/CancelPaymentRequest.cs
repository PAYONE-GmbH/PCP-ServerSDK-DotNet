using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class CancelPaymentRequest
  {
    /// <summary>
    /// Gets or Sets CancellationReason
    /// </summary>
    [DataMember(Name = "cancellationReason", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "cancellationReason")]
    public CancellationReason? CancellationReason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CancelPaymentRequest {\n");
      sb.Append("  CancellationReason: ").Append(CancellationReason).Append("\n");
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
