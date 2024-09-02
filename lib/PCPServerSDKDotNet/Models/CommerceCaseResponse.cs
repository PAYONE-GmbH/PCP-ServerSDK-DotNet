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
    public class CommerceCaseResponse
    {
        /// <summary>
        /// Gets or sets unique reference of the Commerce Case that is also returned for reporting and reconciliation purposes.
        /// </summary>
        /// <value>Unique reference of the Commerce Case that is also returned for reporting and reconciliation purposes.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string? MerchantReference { get; set; }

        /// <summary>
        /// Gets or sets unique ID reference of the Commerce Case. It can be used to add additional Checkouts to the Commerce Case.
        /// </summary>
        /// <value>Unique ID reference of the Commerce Case. It can be used to add additional Checkouts to the Commerce Case.</value>
        [DataMember(Name = "commerceCaseId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "commerceCaseId")]
        public string? CommerceCaseId { get; set; }

        /// <summary>
        /// Gets or Sets Customer.
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customer")]
        public Customer? Customer { get; set; }

        /// <summary>
        /// Gets or Sets Checkouts.
        /// </summary>
        [DataMember(Name = "checkouts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "checkouts")]
        public List<CheckoutResponse>? Checkouts { get; set; }

        /// <summary>
        /// Gets or Sets CreationDateTime.
        /// </summary>
        [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDateTime")]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommerceCaseResponse {\n");
            sb.Append("  MerchantReference: ").Append(this.MerchantReference).Append('\n');
            sb.Append("  CommerceCaseId: ").Append(this.CommerceCaseId).Append('\n');
            sb.Append("  Customer: ").Append(this.Customer).Append('\n');
            sb.Append("  Checkouts: ").Append(this.Checkouts).Append('\n');
            sb.Append("  CreationDateTime: ").Append(this.CreationDateTime).Append('\n');
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
