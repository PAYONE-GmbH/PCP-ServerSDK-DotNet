using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing the SEPA direct debit details.
  /// </summary>
  [DataContract]
  public class SepaDirectDebitPaymentMethodSpecificOutput
  {
    /// <summary>
    /// Payment product identifier - please check product documentation for a full overview of possible values.
    /// </summary>
    /// <value>Payment product identifier - please check product documentation for a full overview of possible values.</value>
    [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProductId")]
    public int? PaymentProductId { get; set; }

    /// <summary>
    /// Gets or Sets PaymentProduct771SpecificOutput
    /// </summary>
    [DataMember(Name = "paymentProduct771SpecificOutput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProduct771SpecificOutput")]
    public PaymentProduct771SpecificOutput? PaymentProduct771SpecificOutput { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class SepaDirectDebitPaymentMethodSpecificOutput {\n");
      sb.Append("  PaymentProductId: ").Append(PaymentProductId).Append("\n");
      sb.Append("  PaymentProduct771SpecificOutput: ").Append(PaymentProduct771SpecificOutput).Append("\n");
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
