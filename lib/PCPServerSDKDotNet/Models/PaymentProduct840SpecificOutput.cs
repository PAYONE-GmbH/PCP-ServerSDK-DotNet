namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// PayPal (payment product 840) specific details.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentProduct840SpecificOutput
    {
        /// <summary>
        /// Gets or Sets BillingAddress.
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingAddress")]
        public Address? BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets CustomerAccount.
        /// </summary>
        [DataMember(Name = "customerAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customerAccount")]
        public PaymentProduct840CustomerAccount? CustomerAccount { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress.
        /// </summary>
        [DataMember(Name = "shippingAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shippingAddress")]
        public Address? ShippingAddress { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProduct840SpecificOutput {\n");
            sb.Append("  BillingAddress: ").Append(this.BillingAddress).Append('\n');
            sb.Append("  CustomerAccount: ").Append(this.CustomerAccount).Append('\n');
            sb.Append("  ShippingAddress: ").Append(this.ShippingAddress).Append('\n');
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
