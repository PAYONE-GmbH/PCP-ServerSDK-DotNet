namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Request to mark items as of the respective Checkout as cancelled and to automatically reverse the associated payment.  A Cancel can be created for a full or the partial ShoppingCart of the Checkout.  The platform will automatically calculate the respective amount to trigger the Cancel. For a partial Cancel a list of items must be provided.  The cancellationReason is mandatory for BNPL payment methods (paymentProductId 3390, 3391 and 3392). For other payment methods the cancellationReason is not mandatory but can be used for reporting and reconciliation purposes.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CancelRequest
    {
        /// <summary>
        /// Gets or Sets CancelType.
        /// </summary>
        [DataMember(Name = "cancelType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cancelType")]
        public CancelType? CancelType { get; set; }

        /// <summary>
        /// Gets or Sets CancellationReason.
        /// </summary>
        [DataMember(Name = "cancellationReason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cancellationReason")]
        public CancellationReason? CancellationReason { get; set; }

        /// <summary>
        /// Gets or Sets CancelItems.
        /// </summary>
        [DataMember(Name = "cancelItems", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cancelItems")]
        public List<CancelItem>? CancelItems { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelRequest {\n");
            sb.Append("  CancelType: ").Append(this.CancelType).Append('\n');
            sb.Append("  CancellationReason: ").Append(this.CancellationReason).Append('\n');
            sb.Append("  CancelItems: ").Append(this.CancelItems).Append('\n');
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
