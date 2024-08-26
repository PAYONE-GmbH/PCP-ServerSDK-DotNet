using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing specific information for PAYONE Secured Direct. Debit.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class PaymentProduct3392SpecificInput
  {
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
      sb.Append("class PaymentProduct3392SpecificInput {\n");
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
