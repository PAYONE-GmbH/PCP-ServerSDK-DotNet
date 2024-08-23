using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// Request to trigger a payment for a respective Checkout providing the input for a specific payment method.  The data from the Commerce case and the Checkout will not be loaded automatically and there is no validation between the data input in place.  Depending on the payment method, information of the customer and / or the shopping cart might be required.  For more details regarding payment method specific input please check the documentation. 
  /// </summary>
  [DataContract]
  public class PaymentExecutionRequest
  {
    /// <summary>
    /// Gets or Sets PaymentMethodSpecificInput
    /// </summary>
    [DataMember(Name = "paymentMethodSpecificInput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentMethodSpecificInput")]
    public PaymentMethodSpecificInput? PaymentMethodSpecificInput { get; set; }

    /// <summary>
    /// Gets or Sets PaymentExecutionSpecificInput
    /// </summary>
    [DataMember(Name = "paymentExecutionSpecificInput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentExecutionSpecificInput")]
    public PaymentExecutionSpecificInput? PaymentExecutionSpecificInput { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class PaymentExecutionRequest {\n");
      sb.Append("  PaymentMethodSpecificInput: ").Append(PaymentMethodSpecificInput).Append("\n");
      sb.Append("  PaymentExecutionSpecificInput: ").Append(PaymentExecutionSpecificInput).Append("\n");
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
