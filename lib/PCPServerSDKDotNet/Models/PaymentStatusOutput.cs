namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// This object has the numeric representation of the current payment status, timestamp of last status change and performable action on the current payment resource. In case of failed payments and negative scenarios, detailed error information is listed.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentStatusOutput
    {
        /// <summary>
        /// Gets or sets flag indicating if the payment can be cancelled.
        /// </summary>
        /// <value>Flag indicating if the payment can be cancelled.</value>
        [DataMember(Name = "isCancellable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isCancellable")]
        public bool? IsCancellable { get; set; }

        /// <summary>
        /// Gets or Sets StatusCategory.
        /// </summary>
        [DataMember(Name = "statusCategory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusCategory")]
        public StatusCategoryValue? StatusCategory { get; set; }

        /// <summary>
        /// Gets or sets indicates if the transaction has been authorized.
        /// </summary>
        /// <value>Indicates if the transaction has been authorized.</value>
        [DataMember(Name = "isAuthorized", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isAuthorized")]
        public bool? IsAuthorized { get; set; }

        /// <summary>
        /// Gets or sets flag indicating if the payment can be refunded.
        /// </summary>
        /// <value>Flag indicating if the payment can be refunded.</value>
        [DataMember(Name = "isRefundable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isRefundable")]
        public bool? IsRefundable { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentStatusOutput {\n");
            sb.Append("  IsCancellable: ").Append(this.IsCancellable).Append('\n');
            sb.Append("  StatusCategory: ").Append(this.StatusCategory).Append('\n');
            sb.Append("  IsAuthorized: ").Append(this.IsAuthorized).Append('\n');
            sb.Append("  IsRefundable: ").Append(this.IsRefundable).Append('\n');
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
