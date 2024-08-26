using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing the specific input details for financing payment methods (Buy Now Pay Later)
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class FinancingPaymentMethodSpecificInput
  {
    /// <summary>
    /// Payment product identifier - please check product documentation for a full overview of possible values. Currently supported payment methods * 3390 - PAYONE Secured Invoice * 3391 - PAYONE Secured Installment * 3392 - PAYONE Secured Direct Debit
    /// </summary>
    /// <value>Payment product identifier - please check product documentation for a full overview of possible values. Currently supported payment methods * 3390 - PAYONE Secured Invoice * 3391 - PAYONE Secured Installment * 3392 - PAYONE Secured Direct Debit</value>
    [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProductId")]
    public int? PaymentProductId { get; set; }

    /// <summary>
    /// * true = the payment requires approval before the funds will be captured using the Approve payment or Capture payment API * false = the payment does not require approval, and the funds will be captured automatically  If the parameter is not provided in the request, the default value will be true
    /// </summary>
    /// <value>* true = the payment requires approval before the funds will be captured using the Approve payment or Capture payment API * false = the payment does not require approval, and the funds will be captured automatically  If the parameter is not provided in the request, the default value will be true</value>
    [DataMember(Name = "requiresApproval", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "requiresApproval")]
    public bool? RequiresApproval { get; set; }

    /// <summary>
    /// Gets or Sets PaymentProduct3392SpecificInput
    /// </summary>
    [DataMember(Name = "paymentProduct3392SpecificInput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProduct3392SpecificInput")]
    public PaymentProduct3392SpecificInput? PaymentProduct3392SpecificInput { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class FinancingPaymentMethodSpecificInput {\n");
      sb.Append("  PaymentProductId: ").Append(PaymentProductId).Append('\n');
      sb.Append("  RequiresApproval: ").Append(RequiresApproval).Append('\n');
      sb.Append("  PaymentProduct3392SpecificInput: ").Append(PaymentProduct3392SpecificInput).Append('\n');
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
