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
    public class DeliverItem
    {
        /// <summary>
        /// Gets or sets id of the item to deliver.
        /// </summary>
        /// <value>Id of the item to deliver.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets quantity of the units being delivered, should be greater than zero Note: Must not be all spaces or all zeros.
        /// </summary>
        /// <value>Quantity of the units being delivered, should be greater than zero Note: Must not be all spaces or all zeros.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliverItem {\n");
            sb.Append("  Id: ").Append(this.Id).Append('\n');
            sb.Append("  Quantity: ").Append(this.Quantity).Append('\n');
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
