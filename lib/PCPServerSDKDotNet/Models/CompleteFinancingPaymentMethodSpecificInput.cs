using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// To complete the Payment the completeFinancingMethodSpecificInput has to be provided. At the moment it is only available for PAYONE Secured Installment (paymentProductId 3391). 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class CompleteFinancingPaymentMethodSpecificInput
  {
    /// <summary>
    /// Payment product identifier. Currently supported payment methods: * 3391 - PAYONE Secured Installment
    /// </summary>
    /// <value>Payment product identifier. Currently supported payment methods: * 3391 - PAYONE Secured Installment</value>
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
    /// Gets or Sets PaymentProduct3391SpecificInput
    /// </summary>
    [DataMember(Name = "paymentProduct3391SpecificInput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProduct3391SpecificInput")]
    public PaymentProduct3391SpecificInput? PaymentProduct3391SpecificInput { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CompleteFinancingPaymentMethodSpecificInput {\n");
      sb.Append("  PaymentProductId: ").Append(PaymentProductId).Append("\n");
      sb.Append("  RequiresApproval: ").Append(RequiresApproval).Append("\n");
      sb.Append("  PaymentProduct3391SpecificInput: ").Append(PaymentProduct3391SpecificInput).Append("\n");
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
