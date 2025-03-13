namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The Complete-Order request is the last step to finalize the initial Order.
    /// It requires the CompletePaymentMethodSpecificInput. The previously provided data
    /// from the Commerce Case, Checkout, and Order will automatically be loaded and
    /// used for the completion of the Order.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CompleteOrderRequest
    {
        /// <summary>
        /// Gets or sets the complete payment method-specific input.
        /// </summary>
        [DataMember(Name = "completePaymentMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "completePaymentMethodSpecificInput")]
        public CompletePaymentMethodSpecificInput? CompletePaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            return $"CompleteOrderRequest {{ CompletePaymentMethodSpecificInput = {this.CompletePaymentMethodSpecificInput} }}";
        }

        /// <summary>
        /// Get the JSON string representation of the object.
        /// </summary>
        /// <returns>JSON string representation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
