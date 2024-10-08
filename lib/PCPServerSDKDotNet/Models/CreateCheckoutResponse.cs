namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the reference of the Checkout for following requests.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateCheckoutResponse
    {
        /// <summary>
        /// Gets or sets reference to the Checkout. Can be used for following requests to get and update the Checkout and execute the payment.
        /// </summary>
        /// <value>Reference to the Checkout. Can be used for following requests to get and update the Checkout and execute the payment.</value>
        [DataMember(Name = "checkoutId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "checkoutId")]
        public string? CheckoutId { get; set; }

        /// <summary>
        /// Gets or Sets ShoppingCart.
        /// </summary>
        [DataMember(Name = "shoppingCart", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shoppingCart")]
        public ShoppingCartResult? ShoppingCart { get; set; }

        /// <summary>
        /// Gets or Sets PaymentResponse.
        /// </summary>
        [DataMember(Name = "paymentResponse", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentResponse")]
        public CreatePaymentResponse? PaymentResponse { get; set; }

        /// <summary>
        /// Gets or Sets ErrorResponse.
        /// </summary>
        [DataMember(Name = "errorResponse", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorResponse")]
        public ErrorResponse? ErrorResponse { get; set; }

        /// <summary>
        /// Gets or Sets AmountOfMoney.
        /// </summary>
        [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amountOfMoney")]
        public AmountOfMoney? AmountOfMoney { get; set; }

        /// <summary>
        /// Gets or Sets References.
        /// </summary>
        [DataMember(Name = "references", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "references")]
        public CheckoutReferences? References { get; set; }

        /// <summary>
        /// Gets or Sets Shipping.
        /// </summary>
        [DataMember(Name = "shipping", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shipping")]
        public Shipping? Shipping { get; set; }

        /// <summary>
        /// Gets or Sets PaymentExecution.
        /// </summary>
        [DataMember(Name = "paymentExecution", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentExecution")]
        public PaymentExecution? PaymentExecution { get; set; }

        /// <summary>
        /// Gets or Sets CheckoutStatus.
        /// </summary>
        [DataMember(Name = "checkoutStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "checkoutStatus")]
        public StatusCheckout? CheckoutStatus { get; set; }

        /// <summary>
        /// Gets or Sets StatusOutput.
        /// </summary>
        [DataMember(Name = "statusOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusOutput")]
        public StatusOutput? StatusOutput { get; set; }

        /// <summary>
        /// Gets or Sets CreationDateTime.
        /// </summary>
        [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDateTime")]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Gets or Sets AllowedPaymentActions.
        /// </summary>
        [DataMember(Name = "allowedPaymentActions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "allowedPaymentActions")]
        public List<AllowedPaymentActions>? AllowedPaymentActions { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCheckoutResponse {\n");
            sb.Append("  CheckoutId: ").Append(this.CheckoutId).Append('\n');
            sb.Append("  ShoppingCart: ").Append(this.ShoppingCart).Append('\n');
            sb.Append("  PaymentResponse: ").Append(this.PaymentResponse).Append('\n');
            sb.Append("  ErrorResponse: ").Append(this.ErrorResponse).Append('\n');
            sb.Append("  AmountOfMoney: ").Append(this.AmountOfMoney).Append('\n');
            sb.Append("  References: ").Append(this.References).Append('\n');
            sb.Append("  Shipping: ").Append(this.Shipping).Append('\n');
            sb.Append("  PaymentExecution: ").Append(this.PaymentExecution).Append('\n');
            sb.Append("  CheckoutStatus: ").Append(this.CheckoutStatus).Append('\n');
            sb.Append("  StatusOutput: ").Append(this.StatusOutput).Append('\n');
            sb.Append("  CreationDateTime: ").Append(this.CreationDateTime).Append('\n');
            sb.Append("  AllowedPaymentActions: ").Append(this.AllowedPaymentActions).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
