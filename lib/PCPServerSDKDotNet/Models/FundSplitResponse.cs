namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Response object returned after successfully creating a fund split instruction. Contains the unique
    /// identifier of the created fund split and the processing status.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class FundSplitResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier assigned to the created fund split instruction. This ID can be used for tracking
        /// and referencing the fund split in subsequent operations or inquiries.
        /// </summary>
        [DataMember(Name = "fundSplitId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fundSplitId")]
        public string? FundSplitId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the Payment Execution that this fund split is associated with.
        /// </summary>
        [DataMember(Name = "paymentExecutionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentExecutionId")]
        public string? PaymentExecutionId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the chargeback event that this fund split instruction was created for.
        /// </summary>
        [DataMember(Name = "eventId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventId")]
        public string? EventId { get; set; }

        /// <summary>
        /// Gets or Sets FundSplit.
        /// </summary>
        [DataMember(Name = "fundSplit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fundSplit")]
        public FundSplit? FundSplit { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundSplitResponse {\n");
            sb.Append("  FundSplitId: ").Append(this.FundSplitId).Append('\n');
            sb.Append("  PaymentExecutionId: ").Append(this.PaymentExecutionId).Append('\n');
            sb.Append("  EventId: ").Append(this.EventId).Append('\n');
            sb.Append("  FundSplit: ").Append(this.FundSplit).Append('\n');
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
