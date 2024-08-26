using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing the specific input details for payments that involve redirects to 3rd parties to complete, like iDeal and PayPal
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class RedirectPaymentMethodSpecificInput
  {
    /// <summary>
    /// * true = the payment requires approval before the funds will be captured using the Approve payment or Capture payment API * false = the payment does not require approval, and the funds will be captured automatically  If the parameter is not provided in the request, the default value will be true
    /// </summary>
    /// <value>* true = the payment requires approval before the funds will be captured using the Approve payment or Capture payment API * false = the payment does not require approval, and the funds will be captured automatically  If the parameter is not provided in the request, the default value will be true</value>
    [DataMember(Name = "requiresApproval", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "requiresApproval")]
    public bool? RequiresApproval { get; set; }

    /// <summary>
    /// ID of the token to use to create the payment.
    /// </summary>
    /// <value>ID of the token to use to create the payment.</value>
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
    /// Indicates if this transaction should be tokenized   * true - Tokenize the transaction.   * false - Do not tokenize the transaction, unless it would be tokenized by other means such as auto- tokenization of recurring payments. example: false
    /// </summary>
    /// <value>Indicates if this transaction should be tokenized   * true - Tokenize the transaction.   * false - Do not tokenize the transaction, unless it would be tokenized by other means such as auto- tokenization of recurring payments. example: false</value>
    [DataMember(Name = "tokenize", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "tokenize")]
    public bool? Tokenize { get; set; }

    /// <summary>
    /// Payment product identifier - please check product documentation for a full overview of possible values.
    /// </summary>
    /// <value>Payment product identifier - please check product documentation for a full overview of possible values.</value>
    [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProductId")]
    public int? PaymentProductId { get; set; }

    /// <summary>
    /// Gets or Sets PaymentProduct840SpecificInput
    /// </summary>
    [DataMember(Name = "paymentProduct840SpecificInput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProduct840SpecificInput")]
    public RedirectPaymentProduct840SpecificInput? PaymentProduct840SpecificInput { get; set; }

    /// <summary>
    /// Gets or Sets RedirectionData
    /// </summary>
    [DataMember(Name = "redirectionData", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "redirectionData")]
    public RedirectionData? RedirectionData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class RedirectPaymentMethodSpecificInput {\n");
      sb.Append("  RequiresApproval: ").Append(RequiresApproval).Append("\n");
      sb.Append("  PaymentProcessingToken: ").Append(PaymentProcessingToken).Append("\n");
      sb.Append("  ReportingToken: ").Append(ReportingToken).Append("\n");
      sb.Append("  Tokenize: ").Append(Tokenize).Append("\n");
      sb.Append("  PaymentProductId: ").Append(PaymentProductId).Append("\n");
      sb.Append("  PaymentProduct840SpecificInput: ").Append(PaymentProduct840SpecificInput).Append("\n");
      sb.Append("  RedirectionData: ").Append(RedirectionData).Append("\n");
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
