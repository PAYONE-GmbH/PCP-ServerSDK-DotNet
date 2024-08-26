namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object that holds the payment related properties for the refund of a Payment Information.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PayoutResponse
    {
        /// <summary>
        /// Gets or Sets PayoutOutput.
        /// </summary>
        [DataMember(Name = "payoutOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payoutOutput")]
        public PayoutOutput? PayoutOutput { get; set; }

        /// <summary>
        /// Gets or Sets Status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public StatusValue? Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusCategory.
        /// </summary>
        [DataMember(Name = "statusCategory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusCategory")]
        public StatusCategoryValue? StatusCategory { get; set; }

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
            sb.Append("class PayoutResponse {\n");
            sb.Append("  PayoutOutput: ").Append(this.PayoutOutput).Append('\n');
            sb.Append("  Status: ").Append(this.Status).Append('\n');
            sb.Append("  StatusCategory: ").Append(this.StatusCategory).Append('\n');
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
