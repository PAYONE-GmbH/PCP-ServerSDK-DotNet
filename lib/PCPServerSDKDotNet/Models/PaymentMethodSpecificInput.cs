namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Input for the payment for a respective payment method. In case the paymentMethodSpecificInput has already been provided when creating the Commerce Case or Checkout, it will automatically be used for the Payment Execution. If a new input will be provided, the existing input will be updated.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentMethodSpecificInput
    {
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
        /// Gets or Sets CustomerDevice.
        /// </summary>
        [DataMember(Name = "customerDevice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customerDevice")]
        public CustomerDevice? CustomerDevice { get; set; }

        /// <summary>
        /// Gets or Sets PaymentChannel.
        /// </summary>
        [DataMember(Name = "paymentChannel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentChannel")]
        public PaymentChannel? PaymentChannel { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodSpecificInput {\n");
            sb.Append("  CardPaymentMethodSpecificInput: ").Append(this.CardPaymentMethodSpecificInput).Append('\n');
            sb.Append("  MobilePaymentMethodSpecificInput: ").Append(this.MobilePaymentMethodSpecificInput).Append('\n');
            sb.Append("  RedirectPaymentMethodSpecificInput: ").Append(this.RedirectPaymentMethodSpecificInput).Append('\n');
            sb.Append("  SepaDirectDebitPaymentMethodSpecificInput: ").Append(this.SepaDirectDebitPaymentMethodSpecificInput).Append('\n');
            sb.Append("  FinancingPaymentMethodSpecificInput: ").Append(this.FinancingPaymentMethodSpecificInput).Append('\n');
            sb.Append("  CustomerDevice: ").Append(this.CustomerDevice).Append('\n');
            sb.Append("  PaymentChannel: ").Append(this.PaymentChannel).Append('\n');
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
