namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing Capture details.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CaptureOutput
    {
        /// <summary>
        /// Gets or Sets AmountOfMoney.
        /// </summary>
        [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amountOfMoney")]
        public AmountOfMoney? AmountOfMoney { get; set; }

        /// <summary>
        /// Gets or sets merchant parameters. It allows you to store additional parameters for the transaction in JSON format.
        /// This field must not contain any personal data.
        /// </summary>
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
        /// Gets or sets payment method identifier used by our payment engine.
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentMethod")]
        public string? PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInstructions.
        /// </summary>
        [DataMember(Name = "paymentInstructions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentInstructions")]
        public PaymentInstructions? PaymentInstructions { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaptureOutput {\n");
            sb.Append("  AmountOfMoney: ").Append(this.AmountOfMoney).Append('\n');
            sb.Append("  MerchantParameters: ").Append(this.MerchantParameters).Append('\n');
            sb.Append("  References: ").Append(this.References).Append('\n');
            sb.Append("  PaymentMethod: ").Append(this.PaymentMethod).Append('\n');
            sb.Append("  PaymentInstructions: ").Append(this.PaymentInstructions).Append('\n');
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
