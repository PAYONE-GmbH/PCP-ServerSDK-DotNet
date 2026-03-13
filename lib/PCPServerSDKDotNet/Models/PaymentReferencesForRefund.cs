namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object that holds all reference properties that are linked to this transaction.
    /// Extends PaymentReferences with an additional captureReference field for refunds.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentReferencesForRefund : PaymentReferences
    {
        /// <summary>
        /// Gets or sets the reference of the capture that should be used for the refund.
        /// </summary>
        [DataMember(Name = "captureReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "captureReference")]
        public string? CaptureReference { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentReferencesForRefund {\n");
            sb.Append("  MerchantReference: ").Append(this.MerchantReference).Append('\n');
            sb.Append("  CaptureReference: ").Append(this.CaptureReference).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
