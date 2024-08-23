using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing the specific input details for SEPA direct debit payments
  /// </summary>
  [DataContract]
  public class SepaDirectDebitPaymentMethodSpecificInput
  {
    /// <summary>
    /// Gets or Sets PaymentProduct771SpecificInput
    /// </summary>
    [DataMember(Name = "paymentProduct771SpecificInput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProduct771SpecificInput")]
    public SepaDirectDebitPaymentProduct771SpecificInput? PaymentProduct771SpecificInput { get; set; }

    /// <summary>
    /// Payment product identifier - please check product documentation for a full overview of possible values.
    /// </summary>
    /// <value>Payment product identifier - please check product documentation for a full overview of possible values.</value>
    [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProductId")]
    public int? PaymentProductId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class SepaDirectDebitPaymentMethodSpecificInput {\n");
      sb.Append("  PaymentProduct771SpecificInput: ").Append(PaymentProduct771SpecificInput).Append("\n");
      sb.Append("  PaymentProductId: ").Append(PaymentProductId).Append("\n");
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
