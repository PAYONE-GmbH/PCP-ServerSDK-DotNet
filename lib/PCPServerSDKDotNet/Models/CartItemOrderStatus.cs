namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Detailed information regarding an occurred payment event.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CartItemOrderStatus
    {
        /// <summary>
        /// Gets or Sets CartItemStatus.
        /// </summary>
        [DataMember(Name = "cartItemStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cartItemStatus")]
        public CartItemStatus? CartItemStatus { get; set; }

        /// <summary>
        /// Gets or sets amount of units for which this status is applicable, should be greater than zero.
        /// </summary>
        /// <value>Amount of units for which this status is applicable, should be greater than zero.</value>
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
            sb.Append("class CartItemOrderStatus {\n");
            sb.Append("  CartItemStatus: ").Append(this.CartItemStatus).Append('\n');
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
