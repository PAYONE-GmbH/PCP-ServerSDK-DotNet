namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing details from the created payout.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PayoutOutput
    {
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
        public PaymentReferences? References { get; set; }

        /// <summary>
        /// Gets or sets payment method identifier based on the paymentProductId.
        /// </summary>
        /// <value>Payment method identifier based on the paymentProductId.</value>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentMethod")]
        public string? PaymentMethod { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutOutput {\n");
            sb.Append("  AmountOfMoney: ").Append(this.AmountOfMoney).Append('\n');
            sb.Append("  References: ").Append(this.References).Append('\n');
            sb.Append("  PaymentMethod: ").Append(this.PaymentMethod).Append('\n');
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
