namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the specific input details for PayPal payments completed by the merchant.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CompletePaymentProduct840SpecificInput
    {
        /// <summary>
        /// Gets or sets a value indicating whether the PayPal JavaScript SDK flow is used.
        /// </summary>
        [DataMember(Name = "javaScriptSdkFlow", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "javaScriptSdkFlow")]
        public bool? JavaScriptSdkFlow { get; set; }

        /// <summary>
        /// Gets or sets the confirmation of the order status in case of PayPal SDK integration.
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "action")]
        required public string Action { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompletePaymentProduct840SpecificInput {\n");
            sb.Append("  JavaScriptSdkFlow: ").Append(this.JavaScriptSdkFlow).Append('\n');
            sb.Append("  Action: ").Append(this.Action).Append('\n');
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
