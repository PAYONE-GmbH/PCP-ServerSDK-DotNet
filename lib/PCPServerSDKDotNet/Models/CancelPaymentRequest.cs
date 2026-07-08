namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// CancelPaymentRequest.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CancelPaymentRequest
    {
        /// <summary>
        /// Gets or Sets CancellationReason.
        /// </summary>
        [DataMember(Name = "cancellationReason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cancellationReason")]
        public CancellationReason? CancellationReason { get; set; }

        /// <summary>
        /// Gets or sets the amount that you want to cancel (specified in cents, where single digit currencies
        /// are presumed to have 2 digits). The amount can be lower than the amount that was authorized, but not higher.
        /// If left empty, the remaining open amount will be cancelled.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public long? Amount { get; set; }

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
            sb.Append("class CancelPaymentRequest {\n");
            sb.Append("  CancellationReason: ").Append(this.CancellationReason).Append('\n');
            sb.Append("  Amount: ").Append(this.Amount).Append('\n');
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
