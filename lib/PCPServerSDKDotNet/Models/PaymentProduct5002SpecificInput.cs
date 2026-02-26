namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing specific input for Click to Pay (payment product 5002).
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentProduct5002SpecificInput
    {
        /// <summary>
        /// Gets or Sets Network.
        /// </summary>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "network")]
        public MobilePaymentNetwork? Network { get; set; }

        /// <summary>
        /// Gets or sets the payment checkout data provided by the Click to Pay SDK.
        /// </summary>
        [DataMember(Name = "paymentCheckoutData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentCheckoutData")]
        public string? PaymentCheckoutData { get; set; }

        /// <summary>
        /// Gets or sets the SRC DPA identifier.
        /// </summary>
        [DataMember(Name = "srcDpaId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "srcDpaId")]
        public string? SrcDpaId { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProduct5002SpecificInput {\n");
            sb.Append("  Network: ").Append(this.Network).Append('\n');
            sb.Append("  PaymentCheckoutData: ").Append(this.PaymentCheckoutData).Append('\n');
            sb.Append("  SrcDpaId: ").Append(this.SrcDpaId).Append('\n');
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
