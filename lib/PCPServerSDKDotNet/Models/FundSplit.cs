namespace PCPServerSDKDotNet.Models
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Instructions for distributing funds to multiple suppliers or partners in a marketplace context.
    /// Only allowed for marketplace merchants or if feature to ignore Marketplace fields is enabled in configuration.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class FundSplit
    {
        /// <summary>
        /// Gets or sets unique identifier of the fund split.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the payment event associated with this fund split.
        /// </summary>
        [DataMember(Name = "paymentEventId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentEventId")]
        public string? PaymentEventId { get; set; }

        /// <summary>
        /// Gets or Sets FundDistributions.
        /// </summary>
        [DataMember(Name = "fundDistributions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fundDistributions")]
        public List<FundDistribution>? FundDistributions { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundSplit {\n");
            sb.Append("  Id: ").Append(this.Id).Append('\n');
            sb.Append("  PaymentEventId: ").Append(this.PaymentEventId).Append('\n');
            sb.Append("  FundDistributions: ").Append(this.FundDistributions).Append('\n');
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
