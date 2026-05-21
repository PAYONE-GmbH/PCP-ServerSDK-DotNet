namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing specific input required for Wero payments (Payment product ID 900).
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RedirectPaymentProduct900SpecificInput
    {
        /// <summary>
        /// Gets or sets the event upon which the payment should be captured.
        /// </summary>
        [DataMember(Name = "captureTrigger", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "captureTrigger")]
        public CaptureTrigger? CaptureTrigger { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedirectPaymentProduct900SpecificInput {\n");
            sb.Append("  CaptureTrigger: ").Append(this.CaptureTrigger).Append('\n');
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
