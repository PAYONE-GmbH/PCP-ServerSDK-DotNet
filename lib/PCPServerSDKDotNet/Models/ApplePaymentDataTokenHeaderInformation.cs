using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Additional information about the Apple payment data token header.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class ApplePaymentDataTokenHeaderInformation
  {
    /// <summary>
    /// A hexadecimal Transaction identifier identifier as a string.
    /// </summary>
    /// <value>A hexadecimal Transaction identifier identifier as a string.</value>
    [DataMember(Name = "transactionId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "transactionId")]
    public string? TransactionId { get; set; }

    /// <summary>
    /// SHA–256 hash, hex encoded as a string. Hash of the applicationData property of the original PKPaymentRequest object.
    /// </summary>
    /// <value>SHA–256 hash, hex encoded as a string. Hash of the applicationData property of the original PKPaymentRequest object.</value>
    [DataMember(Name = "applicationData", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "applicationData")]
    public string? ApplicationData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class ApplePaymentDataTokenHeaderInformation {\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append('\n');
      sb.Append("  ApplicationData: ").Append(ApplicationData).Append('\n');
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
