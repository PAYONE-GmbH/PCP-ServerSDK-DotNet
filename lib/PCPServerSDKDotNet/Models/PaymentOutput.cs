namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing payment details.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentOutput
    {
        /// <summary>
        /// Gets or Sets AmountOfMoney.
        /// </summary>
        [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amountOfMoney")]
        public AmountOfMoney? AmountOfMoney { get; set; }

        /// <summary>
        /// Gets or sets it allows you to store additional parameters for the transaction in JSON format. This field should not contain any personal data.
        /// </summary>
        /// <value>It allows you to store additional parameters for the transaction in JSON format. This field should not contain any personal data.</value>
        [DataMember(Name = "merchantParameters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantParameters")]
        public string? MerchantParameters { get; set; }

        /// <summary>
        /// Gets or Sets References.
        /// </summary>
        [DataMember(Name = "references", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "references")]
        public PaymentReferences? References { get; set; }

        /// <summary>
        /// Gets or Sets CardPaymentMethodSpecificOutput.
        /// </summary>
        [DataMember(Name = "cardPaymentMethodSpecificOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cardPaymentMethodSpecificOutput")]
        public CardPaymentMethodSpecificOutput? CardPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Gets or Sets MobilePaymentMethodSpecificOutput.
        /// </summary>
        [DataMember(Name = "mobilePaymentMethodSpecificOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mobilePaymentMethodSpecificOutput")]
        public MobilePaymentMethodSpecificOutput? MobilePaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Gets or sets payment method identifier based on the paymentProductId.
        /// </summary>
        /// <value>Payment method identifier based on the paymentProductId.</value>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentMethod")]
        public string? PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets RedirectPaymentMethodSpecificOutput.
        /// </summary>
        [DataMember(Name = "redirectPaymentMethodSpecificOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redirectPaymentMethodSpecificOutput")]
        public RedirectPaymentMethodSpecificOutput? RedirectPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Gets or Sets SepaDirectDebitPaymentMethodSpecificOutput.
        /// </summary>
        [DataMember(Name = "sepaDirectDebitPaymentMethodSpecificOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sepaDirectDebitPaymentMethodSpecificOutput")]
        public SepaDirectDebitPaymentMethodSpecificOutput? SepaDirectDebitPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Gets or Sets FinancingPaymentMethodSpecificOutput.
        /// </summary>
        [DataMember(Name = "financingPaymentMethodSpecificOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "financingPaymentMethodSpecificOutput")]
        public FinancingPaymentMethodSpecificOutput? FinancingPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentOutput {\n");
            sb.Append("  AmountOfMoney: ").Append(this.AmountOfMoney).Append('\n');
            sb.Append("  MerchantParameters: ").Append(this.MerchantParameters).Append('\n');
            sb.Append("  References: ").Append(this.References).Append('\n');
            sb.Append("  CardPaymentMethodSpecificOutput: ").Append(this.CardPaymentMethodSpecificOutput).Append('\n');
            sb.Append("  MobilePaymentMethodSpecificOutput: ").Append(this.MobilePaymentMethodSpecificOutput).Append('\n');
            sb.Append("  PaymentMethod: ").Append(this.PaymentMethod).Append('\n');
            sb.Append("  RedirectPaymentMethodSpecificOutput: ").Append(this.RedirectPaymentMethodSpecificOutput).Append('\n');
            sb.Append("  SepaDirectDebitPaymentMethodSpecificOutput: ").Append(this.SepaDirectDebitPaymentMethodSpecificOutput).Append('\n');
            sb.Append("  FinancingPaymentMethodSpecificOutput: ").Append(this.FinancingPaymentMethodSpecificOutput).Append('\n');
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
