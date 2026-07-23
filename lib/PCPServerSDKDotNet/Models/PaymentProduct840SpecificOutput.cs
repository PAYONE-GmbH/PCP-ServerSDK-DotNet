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
    public class PaymentProduct840SpecificOutput : PaymentProduct840SpecificOutputData
    {
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
            sb.Append("  PayPalTransactionId: ").Append(this.PayPalTransactionId).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
