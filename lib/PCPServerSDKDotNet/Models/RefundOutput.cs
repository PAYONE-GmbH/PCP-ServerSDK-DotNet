using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// Object containing Refund details 
  /// </summary>
  [DataContract]
  public class RefundOutput
  {
    /// <summary>
    /// Gets or Sets AmountOfMoney
    /// </summary>
    [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "amountOfMoney")]
    public AmountOfMoney? AmountOfMoney { get; set; }

    /// <summary>
    /// It allows you to store additional parameters for the transaction in JSON format. This field must not contain any personal data. 
    /// </summary>
    /// <value>It allows you to store additional parameters for the transaction in JSON format. This field must not contain any personal data. </value>
    [DataMember(Name = "merchantParameters", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "merchantParameters")]
    public string? MerchantParameters { get; set; }

    /// <summary>
    /// Gets or Sets References
    /// </summary>
    [DataMember(Name = "references", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "references")]
    public PaymentReferences? References { get; set; }

    /// <summary>
    /// Payment method identifier used by the our payment engine.
    /// </summary>
    /// <value>Payment method identifier used by the our payment engine.</value>
    [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentMethod")]
    public string? PaymentMethod { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class RefundOutput {\n");
      sb.Append("  AmountOfMoney: ").Append(AmountOfMoney).Append("\n");
      sb.Append("  MerchantParameters: ").Append(MerchantParameters).Append("\n");
      sb.Append("  References: ").Append(References).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
