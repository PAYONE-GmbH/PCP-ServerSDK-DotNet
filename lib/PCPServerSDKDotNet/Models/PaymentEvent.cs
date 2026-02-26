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
    public class PaymentEvent
    {
        /// <summary>
        /// Gets or Sets Type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public PaymentType? Type { get; set; }

        /// <summary>
        /// Gets or Sets AmountOfMoney.
        /// </summary>
        [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amountOfMoney")]
        public AmountOfMoney? AmountOfMoney { get; set; }

        /// <summary>
        /// Gets or Sets PaymentStatus.
        /// </summary>
        [DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentStatus")]
        public StatusValue? PaymentStatus { get; set; }

        /// <summary>
        /// Gets or Sets CancellationReason.
        /// </summary>
        [DataMember(Name = "cancellationReason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cancellationReason")]
        public CancellationReason? CancellationReason { get; set; }

        /// <summary>
        /// Gets or sets reason of the Refund (e.g. communicated by or to the customer).
        /// </summary>
        [DataMember(Name = "returnReason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "returnReason")]
        public string? ReturnReason { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInstructions.
        /// </summary>
        [DataMember(Name = "paymentInstructions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentInstructions")]
        public PaymentInstructions? PaymentInstructions { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the payment event.
        /// </summary>
        [DataMember(Name = "paymentEventId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentEventId")]
        public string? PaymentEventId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the payment event was created.
        /// </summary>
        [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDateTime")]
        public DateTimeOffset? CreationDateTime { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentEvent {\n");
            sb.Append("  Type: ").Append(this.Type).Append('\n');
            sb.Append("  AmountOfMoney: ").Append(this.AmountOfMoney).Append('\n');
            sb.Append("  PaymentStatus: ").Append(this.PaymentStatus).Append('\n');
            sb.Append("  CancellationReason: ").Append(this.CancellationReason).Append('\n');
            sb.Append("  ReturnReason: ").Append(this.ReturnReason).Append('\n');
            sb.Append("  PaymentInstructions: ").Append(this.PaymentInstructions).Append('\n');
            sb.Append("  PaymentEventId: ").Append(this.PaymentEventId).Append('\n');
            sb.Append("  CreationDateTime: ").Append(this.CreationDateTime).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string representation of the object.
        /// </summary>
        /// <returns>JSON string representation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
