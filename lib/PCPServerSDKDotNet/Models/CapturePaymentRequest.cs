namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// If the shopping cart is specified, a Capture is made with the amount of the shopping cart for the items that are specified.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CapturePaymentRequest
    {
        /// <summary>
        /// Gets or sets here you can specify the amount that you want to capture (specified in cents, where single digit currencies are presumed to have 2 digits). The amount can be lower than the amount that was authorized, but not higher.   If left empty, the full amount will be captured and the request will be final.   If the full amount is captured, the request will also be final.
        /// </summary>
        /// <value>Here you can specify the amount that you want to capture (specified in cents, where single digit currencies are presumed to have 2 digits). The amount can be lower than the amount that was authorized, but not higher.   If left empty, the full amount will be captured and the request will be final.   If the full amount is captured, the request will also be final.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Gets or sets this property indicates whether this will be the final operation.  If the full amount should not captured but the property is set to true, the remaining amount will automatically be cancelled.
        /// </summary>
        /// <value>This property indicates whether this will be the final operation.  If the full amount should not captured but the property is set to true, the remaining amount will automatically be cancelled. </value>
        [DataMember(Name = "isFinal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isFinal")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Gets or Sets CancellationReason.
        /// </summary>
        [DataMember(Name = "cancellationReason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cancellationReason")]
        public CancellationReason? CancellationReason { get; set; }

        /// <summary>
        /// Gets or Sets References.
        /// </summary>
        [DataMember(Name = "references", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "references")]
        public PaymentReferences? References { get; set; }

        /// <summary>
        /// Gets or Sets Delivery.
        /// </summary>
        [DataMember(Name = "delivery", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "delivery")]
        public DeliveryInformation? Delivery { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapturePaymentRequest {\n");
            sb.Append("  Amount: ").Append(this.Amount).Append('\n');
            sb.Append("  IsFinal: ").Append(this.IsFinal).Append('\n');
            sb.Append("  CancellationReason: ").Append(this.CancellationReason).Append('\n');
            sb.Append("  References: ").Append(this.References).Append('\n');
            sb.Append("  Delivery: ").Append(this.Delivery).Append('\n');
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
