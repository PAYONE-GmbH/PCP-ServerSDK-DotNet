namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The response contains references to the created Commerce case and the Checkout. It also contains the payment response if the flag &#x27;autoExecuteOrder&#x27; was set to true.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateCommerceCaseResponse
    {
        /// <summary>
        /// Gets or sets unique ID of the Commerce Case. It can used to add additional Checkouts to the Commerce Case.
        /// </summary>
        /// <value>Unique ID of the Commerce Case. It can used to add additional Checkouts to the Commerce Case.</value>
        [DataMember(Name = "commerceCaseId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "commerceCaseId")]
        public string? CommerceCaseId { get; set; }

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
        /// Gets or Sets Checkout.
        /// </summary>
        [DataMember(Name = "checkout", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "checkout")]
        public CreateCheckoutResponse? Checkout { get; set; }

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
            sb.Append("class CreateCommerceCaseResponse {\n");
            sb.Append("  CommerceCaseId: ").Append(this.CommerceCaseId).Append('\n');
            sb.Append("  MerchantReference: ").Append(this.MerchantReference).Append('\n');
            sb.Append("  Customer: ").Append(this.Customer).Append('\n');
            sb.Append("  Checkout: ").Append(this.Checkout).Append('\n');
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
