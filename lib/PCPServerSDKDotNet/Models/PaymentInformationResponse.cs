namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the related data of the created Payment Information.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentInformationResponse
    {
        /// <summary>
        /// Gets or sets unique ID of the Commerce Case.
        /// </summary>
        [DataMember(Name = "commerceCaseId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "commerceCaseId")]
        public string? CommerceCaseId { get; set; }

        /// <summary>
        /// Gets or sets unique ID of the Checkout.
        /// </summary>
        [DataMember(Name = "checkoutId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "checkoutId")]
        public string? CheckoutId { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the customer.
        /// </summary>
        [DataMember(Name = "merchantCustomerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantCustomerId")]
        public string? MerchantCustomerId { get; set; }

        /// <summary>
        /// Gets or sets unique ID of the Payment Information.
        /// </summary>
        [DataMember(Name = "paymentInformationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentInformationId")]
        public string? PaymentInformationId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentChannel.
        /// </summary>
        [DataMember(Name = "paymentChannel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentChannel")]
        public PaymentChannel? PaymentChannel { get; set; }

        /// <summary>
        /// Gets or sets the payment product identifier.
        /// </summary>
        [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProductId")]
        public int? PaymentProductId { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the POS terminal of the payment transaction.
        /// </summary>
        [DataMember(Name = "terminalId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "terminalId")]
        public string? TerminalId { get; set; }

        /// <summary>
        /// Gets or sets unique ID that identifies a store location or transaction point.
        /// </summary>
        [DataMember(Name = "cardAcceptorId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cardAcceptorId")]
        public string? CardAcceptorId { get; set; }

        /// <summary>
        /// Gets or sets unique reference of the PaymentInformation.
        /// </summary>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string? MerchantReference { get; set; }

        /// <summary>
        /// Gets or sets the creation date and time of the payment.
        /// </summary>
        [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDateTime")]
        public DateTimeOffset? CreationDateTime { get; set; }

        /// <summary>
        /// Gets or sets the last updated date and time of the payment.
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastUpdated")]
        public DateTimeOffset? LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets CardPaymentDetails.
        /// </summary>
        [DataMember(Name = "cardPaymentDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cardPaymentDetails")]
        public CardPaymentDetails? CardPaymentDetails { get; set; }

        /// <summary>
        /// Gets or Sets Events.
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "events")]
        public List<PaymentEvent>? Events { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInformationResponse {\n");
            sb.Append("  CommerceCaseId: ").Append(this.CommerceCaseId).Append('\n');
            sb.Append("  CheckoutId: ").Append(this.CheckoutId).Append('\n');
            sb.Append("  MerchantCustomerId: ").Append(this.MerchantCustomerId).Append('\n');
            sb.Append("  PaymentInformationId: ").Append(this.PaymentInformationId).Append('\n');
            sb.Append("  PaymentChannel: ").Append(this.PaymentChannel).Append('\n');
            sb.Append("  PaymentProductId: ").Append(this.PaymentProductId).Append('\n');
            sb.Append("  TerminalId: ").Append(this.TerminalId).Append('\n');
            sb.Append("  CardAcceptorId: ").Append(this.CardAcceptorId).Append('\n');
            sb.Append("  MerchantReference: ").Append(this.MerchantReference).Append('\n');
            sb.Append("  CreationDateTime: ").Append(this.CreationDateTime).Append('\n');
            sb.Append("  LastUpdated: ").Append(this.LastUpdated).Append('\n');
            sb.Append("  CardPaymentDetails: ").Append(this.CardPaymentDetails).Append('\n');
            sb.Append("  Events: ").Append(this.Events).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string representation of the object.
        /// </summary>
        /// <returns>JSON string representation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
