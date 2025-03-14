namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the specific input details for SEPA transfers.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class BankPayoutMethodSpecificInput
    {
        /// <summary>
        /// Gets or sets the payment product identifier - please check product documentation for a full overview of possible values.
        /// Minimum: 0, Maximum: 99999.
        /// </summary>
        [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProductId")]
        public int? PaymentProductId { get; set; }

        /// <summary>
        /// Gets or sets the SEPA transfer-specific input.
        /// </summary>
        [DataMember(Name = "paymentProduct772SpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProduct772SpecificInput")]
        public SepaTransferPaymentProduct772SpecificInput? PaymentProduct772SpecificInput { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankPayoutMethodSpecificInput {\n");
            sb.Append("  PaymentProductId: ").Append(this.PaymentProductId).Append('\n');
            sb.Append("  PaymentProduct772SpecificInput: ").Append(this.PaymentProduct772SpecificInput).Append('\n');
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
