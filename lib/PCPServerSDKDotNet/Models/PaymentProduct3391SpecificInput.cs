using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing specific information for PAYONE Secured Installment.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class PaymentProduct3391SpecificInput
  {
    /// <summary>
    /// ID of the selected installment option. Will be provided in the response of the Order / Payment Execution request.
    /// </summary>
    /// <value>ID of the selected installment option. Will be provided in the response of the Order / Payment Execution request.</value>
    [DataMember(Name = "installmentOptionId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "installmentOptionId")]
    public string? InstallmentOptionId { get; set; }

    /// <summary>
    /// Gets or Sets BankAccountInformation
    /// </summary>
    [DataMember(Name = "bankAccountInformation", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "bankAccountInformation")]
    public BankAccountInformation? BankAccountInformation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class PaymentProduct3391SpecificInput {\n");
      sb.Append("  InstallmentOptionId: ").Append(InstallmentOptionId).Append('\n');
      sb.Append("  BankAccountInformation: ").Append(BankAccountInformation).Append('\n');
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
