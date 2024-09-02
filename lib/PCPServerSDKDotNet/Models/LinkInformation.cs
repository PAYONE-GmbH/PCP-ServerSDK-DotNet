namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// URL and content type information for an web resource.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class LinkInformation
    {
        /// <summary>
        /// Gets or sets uRL of link.
        /// </summary>
        /// <value>URL of link.</value>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "href")]
        public string? Href { get; set; }

        /// <summary>
        /// Gets or sets content type of linked data.
        /// </summary>
        /// <value>Content type of linked data.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkInformation {\n");
            sb.Append("  Href: ").Append(this.Href).Append('\n');
            sb.Append("  Type: ").Append(this.Type).Append('\n');
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
