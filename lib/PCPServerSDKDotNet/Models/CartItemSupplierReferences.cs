namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing supplier references for a cart item.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CartItemSupplierReferences
    {
        /// <summary>
        /// Gets or sets the supplier identifier.
        /// </summary>
        [DataMember(Name = "supplierId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supplierId")]
        public string? SupplierId { get; set; }

        /// <summary>
        /// Gets or sets the order reference at the supplier.
        /// </summary>
        [DataMember(Name = "orderReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderReference")]
        public string? OrderReference { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartItemSupplierReferences {\n");
            sb.Append("  SupplierId: ").Append(this.SupplierId).Append('\n');
            sb.Append("  OrderReference: ").Append(this.OrderReference).Append('\n');
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
