namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Request to refresh the payment status of a specific payment.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RefreshPaymentRequest
    {
        /// <summary>
        /// Gets or sets the refresh type.
        /// </summary>
        [DataMember(Name = "refreshType", EmitDefaultValue = true)]
        [JsonProperty(PropertyName = "refreshType")]
        public RefreshType? RefreshType { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>A string representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefreshPaymentRequest {\n");
            sb.Append("  RefreshType: ").Append(this.RefreshType).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string representation of the object.
        /// </summary>
        /// <returns>A JSON string representation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
