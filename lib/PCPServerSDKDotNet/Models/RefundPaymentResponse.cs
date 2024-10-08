namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// This object has the numeric representation of the current Refund status, timestamp of last status change and performable action on the current Refund resource. In case of a rejected Refund, detailed error information is listed.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RefundPaymentResponse
    {
        /// <summary>
        /// Gets or Sets RefundOutput.
        /// </summary>
        [DataMember(Name = "refundOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "refundOutput")]
        public RefundOutput? RefundOutput { get; set; }

        /// <summary>
        /// Gets or Sets Status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public StatusValue? Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusOutput.
        /// </summary>
        [DataMember(Name = "statusOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusOutput")]
        public PaymentStatusOutput? StatusOutput { get; set; }

        /// <summary>
        /// Gets or sets unique payment transaction identifier of the payment gateway.
        /// </summary>
        /// <value>Unique payment transaction identifier of the payment gateway.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundPaymentResponse {\n");
            sb.Append("  RefundOutput: ").Append(this.RefundOutput).Append('\n');
            sb.Append("  Status: ").Append(this.Status).Append('\n');
            sb.Append("  StatusOutput: ").Append(this.StatusOutput).Append('\n');
            sb.Append("  Id: ").Append(this.Id).Append('\n');
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
