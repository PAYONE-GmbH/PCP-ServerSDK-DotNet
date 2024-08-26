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
        /// <value>Unique ID of the Commerce Case.</value>
        [DataMember(Name = "commerceCaseId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "commerceCaseId")]
        public string? CommerceCaseId { get; set; }

        /// <summary>
        /// Gets or sets unique ID of the Commerce Case.
        /// </summary>
        /// <value>Unique ID of the Commerce Case.</value>
        [DataMember(Name = "checkoutId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "checkoutId")]
        public string? CheckoutId { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the customer.
        /// </summary>
        /// <value>Unique identifier of the customer.</value>
        [DataMember(Name = "merchantCustomerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantCustomerId")]
        public string? MerchantCustomerId { get; set; }

        /// <summary>
        /// Gets or sets unique ID of the Payment Information.
        /// </summary>
        /// <value>Unique ID of the Payment Information.</value>
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
        /// Gets or sets payment product identifier - please check see product documentation for a full overview of possible values.
        /// </summary>
        /// <value>Payment product identifier - please check see product documentation for a full overview of possible values.</value>
        [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProductId")]
        public int? PaymentProductId { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the POS terminal of the payment transaction.
        /// </summary>
        /// <value>Unique identifier of the POS terminal of the payment transaction.</value>
        [DataMember(Name = "terminalId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "terminalId")]
        public string? TerminalId { get; set; }

        /// <summary>
        /// Gets or sets unique ID that identifies a store location or transaction point and which refers to the contract number of the merchant accepting the card.
        /// </summary>
        /// <value>Unique ID that identifies a store location or transaction point and which refers to the contract number of the merchant accepting the card.</value>
        [DataMember(Name = "cardAcceptorId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cardAcceptorId")]
        public string? CardAcceptorId { get; set; }

        /// <summary>
        /// Gets or sets unique reference of the PaymentInformation. In case of card present transactions, the reference from the ECR or terminal will be used. It is always the reference for external transactions. (e.g. card present payments, cash payments or payments processed by other payment providers).
        /// </summary>
        /// <value>Unique reference of the PaymentInformation. In case of card present transactions, the reference from the ECR or terminal will be used. It is always the reference for external transactions. (e.g. card present payments, cash payments or payments processed by other payment providers). </value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string? MerchantReference { get; set; }

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
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
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
            sb.Append("  CardPaymentDetails: ").Append(this.CardPaymentDetails).Append('\n');
            sb.Append("  Events: ").Append(this.Events).Append('\n');
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
