namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// This object contains information of all items in the cart. If a cart item is provided, the productPrice and quantity is required.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CartItemResult
    {
        /// <summary>
        /// Gets or Sets InvoiceData.
        /// </summary>
        [DataMember(Name = "invoiceData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invoiceData")]
        public CartItemInvoiceData? InvoiceData { get; set; }

        /// <summary>
        /// Gets or Sets OrderLineDetails.
        /// </summary>
        [DataMember(Name = "orderLineDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderLineDetails")]
        public OrderLineDetailsResult? OrderLineDetails { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartItemResult {\n");
            sb.Append("  InvoiceData: ").Append(this.InvoiceData).Append('\n');
            sb.Append("  OrderLineDetails: ").Append(this.OrderLineDetails).Append('\n');
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
