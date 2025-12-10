namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing information about the device of the end customer.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CustomerDevice
    {
        /// <summary>
        /// Gets or sets the accept-header of the customer client from the HTTP headers.
        /// </summary>
        /// <value>The accept-header of the customer client from the HTTP headers.</value>
        [DataMember(Name = "acceptHeader", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "acceptHeader")]
        public string? AcceptHeader { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the customer client from the HTTP Headers.
        /// </summary>
        /// <value>The IP address of the customer client from the HTTP Headers.</value>
        [DataMember(Name = "ipAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ipAddress")]
        public string? IpAddress { get; set; }

        /// <summary>
        /// Gets or sets tokenized representation of the end customers device. For example used for PAYONE Buy Now, Pay Later (BNPL).
        /// </summary>
        /// <value>Tokenized representation of the end customers device. For example used for PAYONE Buy Now, Pay Later (BNPL).</value>
        [DataMember(Name = "deviceToken", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deviceToken")]
        public string? DeviceToken { get; set; }

        /// <summary>
        /// Gets or sets the User-Agent of the client device/browser from the HTTP headers.
        /// </summary>
        /// <value>User-Agent of the client device/browser from the HTTP headers.</value>
        [DataMember(Name = "userAgent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userAgent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerDevice {\n");
            sb.Append("  AcceptHeader: ").Append(this.AcceptHeader).Append('\n');
            sb.Append("  IpAddress: ").Append(this.IpAddress).Append('\n');
            sb.Append("  DeviceToken: ").Append(this.DeviceToken).Append('\n');
            sb.Append("  UserAgent: ").Append(this.UserAgent).Append('\n');
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
