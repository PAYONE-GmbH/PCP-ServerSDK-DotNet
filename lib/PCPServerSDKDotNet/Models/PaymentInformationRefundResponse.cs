namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// PaymentInformationRefundResponse.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentInformationRefundResponse
    {
        /// <summary>
        /// Gets or Sets Payment.
        /// </summary>
        [DataMember(Name = "payment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payment")]
        public PayoutResponse? Payment { get; set; }

        /// <summary>
        /// Gets or sets reference to the paymentExecution.
        /// </summary>
        [DataMember(Name = "paymentExecutionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentExecutionId")]
        public string? PaymentExecutionId { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInformationRefundResponse {\n");
            sb.Append("  Payment: ").Append(this.Payment).Append('\n');
            sb.Append("  PaymentExecutionId: ").Append(this.PaymentExecutionId).Append('\n');
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
