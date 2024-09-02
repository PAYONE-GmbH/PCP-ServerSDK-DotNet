namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing additional information that when supplied can have a beneficial effect on the discountrates.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class OrderLineDetailsResult : OrderLineDetailsInput
    {
        /// <summary>
        /// Gets or sets unique identifier of a cart item.
        /// </summary>
        /// <value>Unique identifier of a cart item.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or Sets Status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public List<CartItemOrderStatus>? Status { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineDetailsResult {\n");
            sb.Append("  Id: ").Append(this.Id).Append('\n');
            sb.Append("  Status: ").Append(this.Status).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
