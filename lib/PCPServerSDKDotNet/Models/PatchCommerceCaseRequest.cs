namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Update the customer data of the given Commerce Case.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PatchCommerceCaseRequest
    {
        /// <summary>
        /// Gets or Sets Customer.
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customer")]
        public Customer? Customer { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchCommerceCaseRequest {\n");
            sb.Append("  Customer: ").Append(this.Customer).Append('\n');
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
