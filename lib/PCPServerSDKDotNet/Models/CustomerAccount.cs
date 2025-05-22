namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing data related to the account the customer has with you.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CustomerAccount
    {
        /// <summary>
        /// Gets or sets creation date and time of the customer account in ISO 8601 format (UTC).
        /// Accepted formats are:
        /// * YYYY-MM-DD'T'HH:mm:ss'Z'
        /// * YYYY-MM-DD'T'HH:mm:ss+XX:XX
        /// * YYYY-MM-DD'T'HH:mm:ss-XX:XX
        /// * YYYY-MM-DD'T'HH:mm'Z'
        /// * YYYY-MM-DD'T'HH:mm+XX:XX
        /// * YYYY-MM-DD'T'HH:mm-XX:XX
        /// </summary>
        [DataMember(Name = "createDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "createDate")]
        public string? CreateDate { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerAccount {\n");
            sb.Append("  CreateDate: ").Append(this.CreateDate).Append('\n');
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
