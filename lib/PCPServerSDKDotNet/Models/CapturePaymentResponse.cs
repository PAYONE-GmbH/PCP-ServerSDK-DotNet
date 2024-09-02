namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CapturePaymentResponse
    {
        /// <summary>
        /// Gets or Sets CaptureOutput.
        /// </summary>
        [DataMember(Name = "captureOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "captureOutput")]
        public CaptureOutput? CaptureOutput { get; set; }

        /// <summary>
        /// Gets or Sets Status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public StatusValue? Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusOutput.
        /// </summary>
        [DataMember(Name = "statusOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusOutput")]
        public PaymentStatusOutput? StatusOutput { get; set; }

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
            sb.Append("class CapturePaymentResponse {\n");
            sb.Append("  CaptureOutput: ").Append(this.CaptureOutput).Append('\n');
            sb.Append("  Status: ").Append(this.Status).Append('\n');
            sb.Append("  StatusOutput: ").Append(this.StatusOutput).Append('\n');
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
