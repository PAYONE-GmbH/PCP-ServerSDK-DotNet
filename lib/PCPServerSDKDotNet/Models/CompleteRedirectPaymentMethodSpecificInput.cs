namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the redirect payment product details to complete a payment execution.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CompleteRedirectPaymentMethodSpecificInput
    {
        /// <summary>
        /// Gets or sets the payment product identifier.
        /// </summary>
        [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProductId")]
        public int? PaymentProductId { get; set; }

        /// <summary>
        /// Gets or sets the PayPal specific completion input.
        /// </summary>
        [DataMember(Name = "paymentProduct840SpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProduct840SpecificInput")]
        public CompletePaymentProduct840SpecificInput? PaymentProduct840SpecificInput { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompleteRedirectPaymentMethodSpecificInput {\n");
            sb.Append("  PaymentProductId: ").Append(this.PaymentProductId).Append('\n');
            sb.Append("  PaymentProduct840SpecificInput: ").Append(this.PaymentProduct840SpecificInput).Append('\n');
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
