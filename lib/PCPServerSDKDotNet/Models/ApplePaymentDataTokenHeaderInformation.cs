namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Additional information about the Apple payment data token header.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ApplePaymentDataTokenHeaderInformation
    {
        /// <summary>
        /// Gets or sets a hexadecimal Transaction identifier identifier as a string.
        /// </summary>
        /// <value>A hexadecimal Transaction identifier identifier as a string.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionId")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Gets or sets sHA–256 hash, hex encoded as a string. Hash of the applicationData property of the original PKPaymentRequest object.
        /// </summary>
        /// <value>SHA–256 hash, hex encoded as a string. Hash of the applicationData property of the original PKPaymentRequest object.</value>
        [DataMember(Name = "applicationData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "applicationData")]
        public string? ApplicationData { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplePaymentDataTokenHeaderInformation {\n");
            sb.Append("  TransactionId: ").Append(this.TransactionId).Append('\n');
            sb.Append("  ApplicationData: ").Append(this.ApplicationData).Append('\n');
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
