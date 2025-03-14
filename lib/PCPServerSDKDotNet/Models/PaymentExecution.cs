namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object contains information of the payment with a specific payment method.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentExecution
    {
        /// <summary>
        /// Gets or sets the unique ID of paymentExecution.
        /// </summary>
        [DataMember(Name = "paymentExecutionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentExecutionId")]
        public string? PaymentExecutionId { get; set; }

        /// <summary>
        /// Gets or sets the unique payment transaction identifier of the payment gateway.
        /// </summary>
        [DataMember(Name = "paymentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentId")]
        public string? PaymentId { get; set; }

        /// <summary>
        /// Gets or Sets CardPaymentMethodSpecificInput.
        /// </summary>
        [DataMember(Name = "cardPaymentMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cardPaymentMethodSpecificInput")]
        public CardPaymentMethodSpecificInput? CardPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Gets or Sets MobilePaymentMethodSpecificInput.
        /// </summary>
        [DataMember(Name = "mobilePaymentMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mobilePaymentMethodSpecificInput")]
        public MobilePaymentMethodSpecificInput? MobilePaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Gets or Sets RedirectPaymentMethodSpecificInput.
        /// </summary>
        [DataMember(Name = "redirectPaymentMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redirectPaymentMethodSpecificInput")]
        public RedirectPaymentMethodSpecificInput? RedirectPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Gets or Sets SepaDirectDebitPaymentMethodSpecificInput.
        /// </summary>
        [DataMember(Name = "sepaDirectDebitPaymentMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sepaDirectDebitPaymentMethodSpecificInput")]
        public SepaDirectDebitPaymentMethodSpecificInput? SepaDirectDebitPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Gets or Sets FinancingPaymentMethodSpecificInput.
        /// </summary>
        [DataMember(Name = "financingPaymentMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "financingPaymentMethodSpecificInput")]
        public FinancingPaymentMethodSpecificInput? FinancingPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Gets or Sets BankPayoutMethodSpecificInput.
        /// </summary>
        [DataMember(Name = "bankPayoutMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankPayoutMethodSpecificInput")]
        public BankPayoutMethodSpecificInput? BankPayoutMethodSpecificInput { get; set; }

        /// <summary>
        /// Gets or Sets PaymentChannel.
        /// </summary>
        [DataMember(Name = "paymentChannel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentChannel")]
        public PaymentChannel? PaymentChannel { get; set; }

        /// <summary>
        /// Gets or Sets References.
        /// </summary>
        [DataMember(Name = "references", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "references")]
        public References? References { get; set; }

        /// <summary>
        /// Gets or Sets PreviousPayment.
        /// </summary>
        [DataMember(Name = "previousPayment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previousPayment")]
        public string? PreviousPayment { get; set; }

        /// <summary>
        /// Gets or Sets CreationDateTime.
        /// </summary>
        [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDateTime")]
        public DateTimeOffset? CreationDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated.
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastUpdated")]
        public DateTimeOffset? LastUpdated { get; set; }

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
            sb.Append("class PaymentExecution {\n");
            sb.Append("  PaymentExecutionId: ").Append(this.PaymentExecutionId).Append('\n');
            sb.Append("  PaymentId: ").Append(this.PaymentId).Append('\n');
            sb.Append("  CardPaymentMethodSpecificInput: ").Append(this.CardPaymentMethodSpecificInput).Append('\n');
            sb.Append("  MobilePaymentMethodSpecificInput: ").Append(this.MobilePaymentMethodSpecificInput).Append('\n');
            sb.Append("  RedirectPaymentMethodSpecificInput: ").Append(this.RedirectPaymentMethodSpecificInput).Append('\n');
            sb.Append("  SepaDirectDebitPaymentMethodSpecificInput: ").Append(this.SepaDirectDebitPaymentMethodSpecificInput).Append('\n');
            sb.Append("  FinancingPaymentMethodSpecificInput: ").Append(this.FinancingPaymentMethodSpecificInput).Append('\n');
            sb.Append("  BankPayoutMethodSpecificInput: ").Append(this.BankPayoutMethodSpecificInput).Append('\n');
            sb.Append("  PaymentChannel: ").Append(this.PaymentChannel).Append('\n');
            sb.Append("  References: ").Append(this.References).Append('\n');
            sb.Append("  PreviousPayment: ").Append(this.PreviousPayment).Append('\n');
            sb.Append("  CreationDateTime: ").Append(this.CreationDateTime).Append('\n');
            sb.Append("  LastUpdated: ").Append(this.LastUpdated).Append('\n');
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
