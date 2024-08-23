using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Request to create a Checkout for a Commerce Case. The payment for the Checkout can be directly executed if autoExecuteOrder &#x3D; true. In this case, the paymentMethodSpecificInput must be provided and only a full order is possible.  If no amountOfMoney is provided, the platform will calculate the respective Checkout amount based on the cartItem productPrice and quantity.  In case of a payment error, the payment can be retried by providing the respective commerceCaseId and checkoutId to the the Order or Payment Execution endpoint. 
  /// </summary>
  [DataContract]
  public class CreateCheckoutRequest
  {
    /// <summary>
    /// Gets or Sets AmountOfMoney
    /// </summary>
    [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "amountOfMoney")]
    public AmountOfMoney? AmountOfMoney { get; set; }

    /// <summary>
    /// Gets or Sets References
    /// </summary>
    [DataMember(Name = "references", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "references")]
    public CheckoutReferences? References { get; set; }

    /// <summary>
    /// Gets or Sets Shipping
    /// </summary>
    [DataMember(Name = "shipping", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "shipping")]
    public Shipping? Shipping { get; set; }

    /// <summary>
    /// Gets or Sets ShoppingCart
    /// </summary>
    [DataMember(Name = "shoppingCart", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "shoppingCart")]
    public ShoppingCartInput? ShoppingCart { get; set; }

    /// <summary>
    /// Gets or Sets OrderRequest
    /// </summary>
    [DataMember(Name = "orderRequest", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "orderRequest")]
    public OrderRequest? OrderRequest { get; set; }

    /// <summary>
    /// Gets or Sets CreationDateTime
    /// </summary>
    [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "creationDateTime")]
    public DateTime? CreationDateTime { get; set; }

    /// <summary>
    /// Set this flag to directly execute a payment when creating a Commerce Case or Checkout. If the value for autoExecuteOrder is set to true, the paymentMethodSpecificInput for the order is mandatory and has to be provided. The autoExecuteOrder can only be used for orderType = full. If no shoppingCart information has been provided, a Payment Execution will be created instead of an Order. As a consequence, only Payment Execution endpoints can be used. 
    /// </summary>
    /// <value>Set this flag to directly execute a payment when creating a Commerce Case or Checkout. If the value for autoExecuteOrder is set to true, the paymentMethodSpecificInput for the order is mandatory and has to be provided. The autoExecuteOrder can only be used for orderType = full. If no shoppingCart information has been provided, a Payment Execution will be created instead of an Order. As a consequence, only Payment Execution endpoints can be used. </value>
    [DataMember(Name = "autoExecuteOrder", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "autoExecuteOrder")]
    public bool? AutoExecuteOrder { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CreateCheckoutRequest {\n");
      sb.Append("  AmountOfMoney: ").Append(AmountOfMoney).Append("\n");
      sb.Append("  References: ").Append(References).Append("\n");
      sb.Append("  Shipping: ").Append(Shipping).Append("\n");
      sb.Append("  ShoppingCart: ").Append(ShoppingCart).Append("\n");
      sb.Append("  OrderRequest: ").Append(OrderRequest).Append("\n");
      sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
      sb.Append("  AutoExecuteOrder: ").Append(AutoExecuteOrder).Append("\n");
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
