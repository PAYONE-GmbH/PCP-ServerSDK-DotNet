namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing information on payment instructions details (e.g. on the invoice payments).
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentInstructions
    {
        /// <summary>
        /// Gets or sets Payee details.
        /// </summary>
        [DataMember(Name = "payee", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payee")]
        public Payee? Payee { get; set; }

        /// <summary>
        /// Gets or sets the due date of the payment. Format: YYYYMMDD.
        /// </summary>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dueDate")]
        public string? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the external payment reference number as part of payment instructions for the consumer.
        /// </summary>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "referenceNumber")]
        public string? ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the status, usually describing the status of the invoice (e.g., paid, overdue, open).
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>A string representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInstructions {\n");
            sb.Append("  Payee: ").Append(this.Payee).Append('\n');
            sb.Append("  DueDate: ").Append(this.DueDate).Append('\n');
            sb.Append("  ReferenceNumber: ").Append(this.ReferenceNumber).Append('\n');
            sb.Append("  Status: ").Append(this.Status).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string representation of the object.
        /// </summary>
        /// <returns>A JSON string representation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
