namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the details of the created payment.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentCreationOutput
    {
        /// <summary>
        /// Gets or sets the external reference is an identifier for this transaction and can be used for reconciliation purposes.
        /// </summary>
        /// <value>The external reference is an identifier for this transaction and can be used for reconciliation purposes.</value>
        [DataMember(Name = "externalReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "externalReference")]
        public string? ExternalReference { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCreationOutput {\n");
            sb.Append("  ExternalReference: ").Append(this.ExternalReference).Append('\n');
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
