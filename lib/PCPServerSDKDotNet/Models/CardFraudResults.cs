namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Fraud results contained in the CardFraudResults object.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CardFraudResults
    {
        /// <summary>
        /// Gets or sets result of the Address Verification Service checks.
        /// </summary>
        /// <value>Result of the Address Verification Service checks.</value>
        [DataMember(Name = "avsResult", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "avsResult")]
        public AvsResult? AvsResult { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardFraudResults {\n");
            sb.Append("  AvsResult: ").Append(this.AvsResult?.ToString()).Append('\n');
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
