namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Return object contains additional information about the return/shipment, which is the basis for the Refund. The amountOfMoney in the cartItem will not be used in the request.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ReturnInformation
    {
        /// <summary>
        /// Gets or sets reason of the Refund (e.g. communicated by or to the consumer).
        /// </summary>
        /// <value>Reason of the Refund (e.g. communicated by or to the consumer).</value>
        [DataMember(Name = "returnReason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "returnReason")]
        public string? ReturnReason { get; set; }

        /// <summary>
        /// Gets or sets items returned.
        /// </summary>
        /// <value>Items returned.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "items")]
        public List<CartItemInput>? Items { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReturnInformation {\n");
            sb.Append("  ReturnReason: ").Append(this.ReturnReason).Append('\n');
            sb.Append("  Items: ").Append(this.Items).Append('\n');
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
