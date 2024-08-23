using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// An existing shopping cart of a Checkout will not be overwritten with the Patch request. New items can be added to the shoppingCart by providing them in the request. To change existing items (delete, modify or add), the respective itemId must be provided. An item can be completely removed if quantity &#x3D; 0 is provided.  The price of an item can be changed as long as no payment has happened for this item (i.e. as long as an item has no specific status). Items with a status can no longer be removed entirely, however the quantity can be increased or decreased (for items without payment) by using the itemId.  If no amountOfMoney for the Checkout is provided, the platform will calculate the respective amount based on the cartItem productPrice and productQuantity. 
  /// </summary>
  [DataContract]
  public class PatchCheckoutRequest
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
    public ShoppingCartPatch? ShoppingCart { get; set; }

    /// <summary>
    /// Gets or Sets PaymentMethodSpecificInput
    /// </summary>
    [DataMember(Name = "paymentMethodSpecificInput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentMethodSpecificInput")]
    public PaymentMethodSpecificInput? PaymentMethodSpecificInput { get; set; }

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
      sb.Append("class PatchCheckoutRequest {\n");
      sb.Append("  AmountOfMoney: ").Append(AmountOfMoney).Append("\n");
      sb.Append("  References: ").Append(References).Append("\n");
      sb.Append("  Shipping: ").Append(Shipping).Append("\n");
      sb.Append("  ShoppingCart: ").Append(ShoppingCart).Append("\n");
      sb.Append("  PaymentMethodSpecificInput: ").Append(PaymentMethodSpecificInput).Append("\n");
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
