using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing the redirect payment product details. 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class RedirectPaymentMethodSpecificOutput
  {
    /// <summary>
    /// <- Payment product identifier - please check product documentation for a full overview of possible values.
    /// </summary>
    /// <value><- Payment product identifier - please check product documentation for a full overview of possible values.</value>
    [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProductId")]
    public int? PaymentProductId { get; set; }

    /// <summary>
    /// Gets or Sets PaymentProduct840SpecificOutput
    /// </summary>
    [DataMember(Name = "paymentProduct840SpecificOutput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProduct840SpecificOutput")]
    public PaymentProduct840SpecificOutput? PaymentProduct840SpecificOutput { get; set; }

    /// <summary>
    /// ID of the token. This property is populated when the payment was done with a token.
    /// </summary>
    /// <value>ID of the token. This property is populated when the payment was done with a token.</value>
    [DataMember(Name = "paymentProcessingToken", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProcessingToken")]
    public string? PaymentProcessingToken { get; set; }

    /// <summary>
    /// Token to identify the card in the reporting.
    /// </summary>
    /// <value>Token to identify the card in the reporting.</value>
    [DataMember(Name = "reportingToken", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "reportingToken")]
    public string? ReportingToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class RedirectPaymentMethodSpecificOutput {\n");
      sb.Append("  PaymentProductId: ").Append(PaymentProductId).Append("\n");
      sb.Append("  PaymentProduct840SpecificOutput: ").Append(PaymentProduct840SpecificOutput).Append("\n");
      sb.Append("  PaymentProcessingToken: ").Append(PaymentProcessingToken).Append("\n");
      sb.Append("  ReportingToken: ").Append(ReportingToken).Append("\n");
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
