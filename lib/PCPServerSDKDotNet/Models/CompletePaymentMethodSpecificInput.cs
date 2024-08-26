using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// To complete the Order the completePaymentMethodSpecificInput has to be provided, containing the selected installmentOptionId as well as the the bankAccountInformation of the customer. 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class CompletePaymentMethodSpecificInput
  {
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
      sb.Append("class CompletePaymentMethodSpecificInput {\n");
      sb.Append("  PaymentProduct3391SpecificInput: ").Append(PaymentProduct3391SpecificInput).Append('\n');
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
