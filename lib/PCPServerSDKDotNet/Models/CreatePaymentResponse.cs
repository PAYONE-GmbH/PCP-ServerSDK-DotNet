namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing details on the created payment it has directly be executed.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreatePaymentResponse
    {
        /// <summary>
        /// Gets or Sets CreationOutput.
        /// </summary>
        [DataMember(Name = "creationOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationOutput")]
        public PaymentCreationOutput? CreationOutput { get; set; }

        /// <summary>
        /// Gets or Sets MerchantAction.
        /// </summary>
        [DataMember(Name = "merchantAction", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAction")]
        public MerchantAction? MerchantAction { get; set; }

        /// <summary>
        /// Gets or Sets Payment.
        /// </summary>
        [DataMember(Name = "payment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payment")]
        public PaymentResponse? Payment { get; set; }

        /// <summary>
        /// Gets or sets reference to the paymentExecution.
        /// </summary>
        /// <value>reference to the paymentExecution.</value>
        [DataMember(Name = "paymentExecutionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentExecutionId")]
        public string? PaymentExecutionId { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePaymentResponse {\n");
            sb.Append("  CreationOutput: ").Append(this.CreationOutput).Append('\n');
            sb.Append("  MerchantAction: ").Append(this.MerchantAction).Append('\n');
            sb.Append("  Payment: ").Append(this.Payment).Append('\n');
            sb.Append("  PaymentExecutionId: ").Append(this.PaymentExecutionId).Append('\n');
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
