namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ErrorResponse
    {
        /// <summary>
        /// Gets or sets unique reference of this error response for debugging purposes.
        /// </summary>
        /// <value>Unique reference of this error response for debugging purposes.</value>
        [DataMember(Name = "errorId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorId")]
        public string? ErrorId { get; set; }

        /// <summary>
        /// Gets or Sets Errors.
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errors")]
        public List<APIError>? Errors { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorResponse {\n");
            sb.Append("  ErrorId: ").Append(this.ErrorId).Append('\n');
            sb.Append("  Errors: ").Append(this.Errors).Append('\n');
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
