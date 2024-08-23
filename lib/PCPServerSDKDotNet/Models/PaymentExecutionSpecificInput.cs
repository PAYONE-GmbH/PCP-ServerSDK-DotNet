using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// The amount of the paymentSpecificInput might differ from the Checkout amount in case of partial payments but cannot be higher. Additionally, the total amount of the provided shopping cart cannot exceed the Checkout amount.  If a different currency is provided than in the Checkout, the payment execution will be declined. Provided details of the customer and shipping from the Checkout will be automatically loaded and used in the Payment Execution request. The ShoppingCart might differ from the one provided in the Checkout (e.g., for partial payments) and might be required by the payment provider (e.g., BNPL). If the ShoppingCart elements differ from the data provided in the Checkout, the existing data will not be overwritten. 
  /// </summary>
  [DataContract]
  public class PaymentExecutionSpecificInput
  {
    /// <summary>
    /// Gets or Sets AmountOfMoney
    /// </summary>
    [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "amountOfMoney")]
    public AmountOfMoney? AmountOfMoney { get; set; }

    /// <summary>
    /// Gets or Sets ShoppingCart
    /// </summary>
    [DataMember(Name = "shoppingCart", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "shoppingCart")]
    public ShoppingCartInput? ShoppingCart { get; set; }

    /// <summary>
    /// Gets or Sets PaymentReferences
    /// </summary>
    [DataMember(Name = "paymentReferences", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentReferences")]
    public References? PaymentReferences { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class PaymentExecutionSpecificInput {\n");
      sb.Append("  AmountOfMoney: ").Append(AmountOfMoney).Append("\n");
      sb.Append("  ShoppingCart: ").Append(ShoppingCart).Append("\n");
      sb.Append("  PaymentReferences: ").Append(PaymentReferences).Append("\n");
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
