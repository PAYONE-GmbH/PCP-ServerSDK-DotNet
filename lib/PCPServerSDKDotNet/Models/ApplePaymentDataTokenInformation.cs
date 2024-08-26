using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Additional information about the Apple payment data token. This information are needed for checking the validity of the payment data token before decryption.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class ApplePaymentDataTokenInformation
  {
    /// <summary>
    /// Version information about the payment token. Currently only EC_v1 for ECC-encrypted data is supported.
    /// </summary>
    /// <value>Version information about the payment token. Currently only EC_v1 for ECC-encrypted data is supported.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "version")]
    public ApplePaymentTokenVersion? Version { get; set; }

    /// <summary>
    /// Detached PKCS #7 signature, Base64 encoded as string. Signature of the payment and header data. The signature includes the signing certificate, its intermediate CA certificate, and information about the signing algorithm.
    /// </summary>
    /// <value>Detached PKCS #7 signature, Base64 encoded as string. Signature of the payment and header data. The signature includes the signing certificate, its intermediate CA certificate, and information about the signing algorithm.</value>
    [DataMember(Name = "signature", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "signature")]
    public string? Signature { get; set; }

    /// <summary>
    /// Gets or Sets Header
    /// </summary>
    [DataMember(Name = "header", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "header")]
    public ApplePaymentDataTokenHeaderInformation? Header { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class ApplePaymentDataTokenInformation {\n");
      sb.Append("  Version: ").Append(Version).Append('\n');
      sb.Append("  Signature: ").Append(Signature).Append('\n');
      sb.Append("  Header: ").Append(Header).Append('\n');
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
