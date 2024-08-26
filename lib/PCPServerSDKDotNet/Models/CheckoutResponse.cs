using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// The Checkout corresponds to the order of the WL API. We do not take additionalInput from the WL API. We have no  shipping and use deliveryAddress instead of address. 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class CheckoutResponse
  {
    /// <summary>
    /// reference to the Commerce Case.
    /// </summary>
    /// <value>reference to the Commerce Case.</value>
    [DataMember(Name = "commerceCaseId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "commerceCaseId")]
    public string? CommerceCaseId { get; set; }

    /// <summary>
    /// reference to the Checkout.
    /// </summary>
    /// <value>reference to the Checkout.</value>
    [DataMember(Name = "checkoutId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "checkoutId")]
    public string? CheckoutId { get; set; }

    /// <summary>
    /// Unique identifier for the customer.
    /// </summary>
    /// <value>Unique identifier for the customer.</value>
    [DataMember(Name = "merchantCustomerId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "merchantCustomerId")]
    public string? MerchantCustomerId { get; set; }

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
    public ShoppingCartResult? ShoppingCart { get; set; }

    /// <summary>
    /// Gets or Sets PaymentExecutions
    /// </summary>
    [DataMember(Name = "paymentExecutions", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentExecutions")]
    public List<PaymentExecution>? PaymentExecutions { get; set; }

    /// <summary>
    /// Gets or Sets CheckoutStatus
    /// </summary>
    [DataMember(Name = "checkoutStatus", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "checkoutStatus")]
    public StatusCheckout? CheckoutStatus { get; set; }

    /// <summary>
    /// Gets or Sets StatusOutput
    /// </summary>
    [DataMember(Name = "statusOutput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "statusOutput")]
    public StatusOutput? StatusOutput { get; set; }

    /// <summary>
    /// Gets or Sets PaymentInformation
    /// </summary>
    [DataMember(Name = "paymentInformation", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentInformation")]
    public List<PaymentInformationResponse>? PaymentInformation { get; set; }

    /// <summary>
    /// Gets or Sets CreationDateTime
    /// </summary>
    [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "creationDateTime")]
    public DateTime? CreationDateTime { get; set; }

    /// <summary>
    /// Gets or Sets AllowedPaymentActions
    /// </summary>
    [DataMember(Name = "allowedPaymentActions", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "allowedPaymentActions")]
    public List<AllowedPaymentActions>? AllowedPaymentActions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CheckoutResponse {\n");
      sb.Append("  CommerceCaseId: ").Append(CommerceCaseId).Append("\n");
      sb.Append("  CheckoutId: ").Append(CheckoutId).Append("\n");
      sb.Append("  MerchantCustomerId: ").Append(MerchantCustomerId).Append("\n");
      sb.Append("  AmountOfMoney: ").Append(AmountOfMoney).Append("\n");
      sb.Append("  References: ").Append(References).Append("\n");
      sb.Append("  Shipping: ").Append(Shipping).Append("\n");
      sb.Append("  ShoppingCart: ").Append(ShoppingCart).Append("\n");
      sb.Append("  PaymentExecutions: ").Append(PaymentExecutions).Append("\n");
      sb.Append("  CheckoutStatus: ").Append(CheckoutStatus).Append("\n");
      sb.Append("  StatusOutput: ").Append(StatusOutput).Append("\n");
      sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
      sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
      sb.Append("  AllowedPaymentActions: ").Append(AllowedPaymentActions).Append("\n");
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
