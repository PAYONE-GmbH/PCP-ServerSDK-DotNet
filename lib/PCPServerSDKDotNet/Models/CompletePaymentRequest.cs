namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The Complete request is the last step to finalize the initially created Payment. It requires the completeFinancingPaymentMethodSpecificInput. The data for the order object should not differ from the previously provided information in Commerce Case, Checkout and Payment, but will not be validated nor automatically loaded from the Commerce Platform.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CompletePaymentRequest
    {
        /// <summary>
        /// Gets or Sets FinancingPaymentMethodSpecificInput.
        /// </summary>
        [DataMember(Name = "financingPaymentMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "financingPaymentMethodSpecificInput")]
        public CompleteFinancingPaymentMethodSpecificInput? FinancingPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Gets or Sets Order.
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "order")]
        public Order? Order { get; set; }

        /// <summary>
        /// Gets or Sets Device.
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "device")]
        public CustomerDevice? Device { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompletePaymentRequest {\n");
            sb.Append("  FinancingPaymentMethodSpecificInput: ").Append(this.FinancingPaymentMethodSpecificInput).Append('\n');
            sb.Append("  Order: ").Append(this.Order).Append('\n');
            sb.Append("  Device: ").Append(this.Device).Append('\n');
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
