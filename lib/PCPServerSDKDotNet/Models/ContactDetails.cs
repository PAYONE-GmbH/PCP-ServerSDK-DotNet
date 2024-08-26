namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing contact details like email address and phone number.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ContactDetails
    {
        /// <summary>
        /// Gets or sets email address of the customer.
        /// </summary>
        /// <value>Email address of the customer.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "emailAddress")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets phone number of the customer.
        /// </summary>
        /// <value>Phone number of the customer.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phoneNumber")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactDetails {\n");
            sb.Append("  EmailAddress: ").Append(this.EmailAddress).Append('\n');
            sb.Append("  PhoneNumber: ").Append(this.PhoneNumber).Append('\n');
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
