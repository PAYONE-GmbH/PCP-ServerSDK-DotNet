namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing specific input required for PayPal payments (Payment product ID 840).
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RedirectPaymentProduct840SpecificInput : RedirectPaymentProduct840SpecificInputData
    {
        /// <summary>
        /// Gets or sets a unique ID determined by the merchant, to link a Paypal transaction to a FraudNet PayPal risk session.
        /// Only applicable to customer-initiated transactions, when the FraudNet SDK is used, and to be passed in the API
        /// request with the same tracking ID value (FraudNet Session Identifier).
        /// </summary>
        [DataMember(Name = "fraudNetId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fraudNetId")]
        public string? FraudNetId { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedirectPaymentProduct840SpecificInput {\n");
            sb.Append("  AddressSelectionAtPayPal: ").Append(this.AddressSelectionAtPayPal).Append('\n');
            sb.Append("  FraudNetId: ").Append(this.FraudNetId).Append('\n');
            sb.Append("  JavaScriptSdkFlow: ").Append(this.JavaScriptSdkFlow).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
