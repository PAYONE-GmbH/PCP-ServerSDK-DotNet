using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Output that is SEPA Direct Debit specific (i.e. the used mandate).
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class PaymentProduct771SpecificOutput
  {
    /// <summary>
    /// Unique reference fo a SEPA Mandate
    /// </summary>
    /// <value>Unique reference fo a SEPA Mandate</value>
    [DataMember(Name = "mandateReference", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "mandateReference")]
    public string? MandateReference { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class PaymentProduct771SpecificOutput {\n");
      sb.Append("  MandateReference: ").Append(MandateReference).Append('\n');
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
