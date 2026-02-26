namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Object containing details on how funds should be distributed to the different sub-merchants.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class FundDistribution
    {
        /// <summary>
        /// Gets or sets unique identifier of the fund distribution.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the account identifier to which the funds should be distributed.
        /// </summary>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountId")]
        public string? AccountId { get; set; }

        /// <summary>
        /// Gets or sets a description of the fund distribution.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the amount to be distributed in the smallest currency unit (e.g., cents).
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public FundDistributionType? Type { get; set; }

        /// <summary>
        /// Gets or sets merchant-defined reference for the fund distribution.
        /// </summary>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string? MerchantReference { get; set; }

        /// <summary>
        /// Gets or sets merchant-defined parameters for the fund distribution.
        /// </summary>
        [DataMember(Name = "merchantParameters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantParameters")]
        public string? MerchantParameters { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundDistribution {\n");
            sb.Append("  Id: ").Append(this.Id).Append('\n');
            sb.Append("  AccountId: ").Append(this.AccountId).Append('\n');
            sb.Append("  Description: ").Append(this.Description).Append('\n');
            sb.Append("  Amount: ").Append(this.Amount).Append('\n');
            sb.Append("  Type: ").Append(this.Type).Append('\n');
            sb.Append("  MerchantReference: ").Append(this.MerchantReference).Append('\n');
            sb.Append("  MerchantParameters: ").Append(this.MerchantParameters).Append('\n');
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
