namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the name details of the customer.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PersonalName
    {
        /// <summary>
        /// Gets or sets given name(s) or first name(s) of the customer.
        /// </summary>
        /// <value>Given name(s) or first name(s) of the customer.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets surname(s) or last name(s) of the customer.
        /// </summary>
        /// <value>Surname(s) or last name(s) of the customer.</value>
        [DataMember(Name = "surname", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "surname")]
        public string? Surname { get; set; }

        /// <summary>
        /// Gets or sets title of customer.
        /// </summary>
        /// <value>Title of customer.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "title")]
        public string? Title { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalName {\n");
            sb.Append("  FirstName: ").Append(this.FirstName).Append('\n');
            sb.Append("  Surname: ").Append(this.Surname).Append('\n');
            sb.Append("  Title: ").Append(this.Title).Append('\n');
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
