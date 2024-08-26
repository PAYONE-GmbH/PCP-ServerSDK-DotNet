using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing information specific to SEPA Direct Debit
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class SepaDirectDebitPaymentProduct771SpecificInput
  {
    /// <summary>
    /// The unique reference of the existing mandate to use in this payment.
    /// </summary>
    /// <value>The unique reference of the existing mandate to use in this payment.</value>
    [DataMember(Name = "existingUniqueMandateReference", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "existingUniqueMandateReference")]
    public string? ExistingUniqueMandateReference { get; set; }

    /// <summary>
    /// Gets or Sets Mandate
    /// </summary>
    [DataMember(Name = "mandate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "mandate")]
    public ProcessingMandateInformation? Mandate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class SepaDirectDebitPaymentProduct771SpecificInput {\n");
      sb.Append("  ExistingUniqueMandateReference: ").Append(ExistingUniqueMandateReference).Append("\n");
      sb.Append("  Mandate: ").Append(Mandate).Append("\n");
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
