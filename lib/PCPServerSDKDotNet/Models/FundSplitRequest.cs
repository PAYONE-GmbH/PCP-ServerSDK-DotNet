namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Request object for creating a fund split instruction for a chargeback event in a marketplace transaction.
    /// Contains the fund split details specifying how the chargeback amount should be distributed among the
    /// different sellers and/or the platform involved in the original marketplace order.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class FundSplitRequest
    {
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
            sb.Append("class FundSplitRequest {\n");
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
