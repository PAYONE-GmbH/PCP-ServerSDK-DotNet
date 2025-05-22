namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing data related to recurring.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CardRecurrenceDetails
    {
        /// <summary>
        /// Gets or sets the recurring payment sequence indicator.
        /// </summary>
        /// <value>Indicates whether this is the first or a subsequent recurring transaction.</value>
        [DataMember(Name = "recurringPaymentSequenceIndicator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recurringPaymentSequenceIndicator")]
        public RecurringPaymentSequenceIndicator? RecurringPaymentSequenceIndicator { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardRecurrenceDetails {\n");
            sb.Append("  RecurringPaymentSequenceIndicator: ").Append(this.RecurringPaymentSequenceIndicator).Append('\n');
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
