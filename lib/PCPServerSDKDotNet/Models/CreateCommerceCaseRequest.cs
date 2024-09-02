namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateCommerceCaseRequest
    {
        /// <summary>
        /// Gets or sets unique reference of the Commerce Case that is also returned for reporting and reconciliation purposes.
        /// </summary>
        /// <value>Unique reference of the Commerce Case that is also returned for reporting and reconciliation purposes.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string? MerchantReference { get; set; }

        /// <summary>
        /// Gets or Sets Customer.
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customer")]
        public Customer? Customer { get; set; }

        /// <summary>
        /// Gets or Sets CreationDateTime.
        /// </summary>
        [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDateTime")]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Checkout.
        /// </summary>
        [DataMember(Name = "checkout", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "checkout")]
        public CreateCheckoutRequest? Checkout { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCommerceCaseRequest {\n");
            sb.Append("  MerchantReference: ").Append(this.MerchantReference).Append('\n');
            sb.Append("  Customer: ").Append(this.Customer).Append('\n');
            sb.Append("  CreationDateTime: ").Append(this.CreationDateTime).Append('\n');
            sb.Append("  Checkout: ").Append(this.Checkout).Append('\n');
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
