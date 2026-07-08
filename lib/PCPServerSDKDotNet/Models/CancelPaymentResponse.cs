namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// CancelPaymentResponse.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CancelPaymentResponse
    {
        /// <summary>
        /// Gets or Sets Payment.
        /// </summary>
        [DataMember(Name = "payment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payment")]
        public PaymentResponse? Payment { get; set; }

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
            sb.Append("class CancelPaymentResponse {\n");
            sb.Append("  Payment: ").Append(this.Payment).Append('\n');
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
