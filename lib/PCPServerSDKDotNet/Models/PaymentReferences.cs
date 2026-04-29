namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object that holds all reference properties that are linked to this transaction.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentReferences
    {
        /// <summary>
        /// Gets or sets unique reference of payment transactions, also returned for reporting and reconciliation purposes.
        /// For capture requests, providing this value is recommended to support an end-to-end refund flow.
        /// If provided for captures or refunds, it must be unique per Checkout.
        /// </summary>
        /// <value>
        /// Unique reference of payment transactions, also returned for reporting and reconciliation purposes.
        /// For capture requests, providing this value is recommended to support an end-to-end refund flow.
        /// If provided for captures or refunds, it must be unique per Checkout.
        /// </value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string? MerchantReference { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentReferences {\n");
            sb.Append("  MerchantReference: ").Append(this.MerchantReference).Append('\n');
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
