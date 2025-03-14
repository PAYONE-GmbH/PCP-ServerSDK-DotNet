namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the specific input details for mobile payments.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class MobilePaymentMethodSpecificInput
    {
        /// <summary>
        /// Gets or sets payment product identifier - please check product documentation for a full overview of possible values.
        /// </summary>
        [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProductId")]
        public int? PaymentProductId { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationMode.
        /// </summary>
        [DataMember(Name = "authorizationMode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "authorizationMode")]
        public AuthorizationMode? AuthorizationMode { get; set; }

        /// <summary>
        /// Gets or sets the payment data if we will do the decryption of the encrypted payment data.
        /// Typically you'd use encryptedCustomerInput in the root of the create payment request to provide the encrypted payment data instead.
        /// </summary>
        [DataMember(Name = "encryptedPaymentData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "encryptedPaymentData")]
        public string? EncryptedPaymentData { get; set; }

        /// <summary>
        /// Gets or sets public Key Hash - a unique identifier to retrieve key used by Apple to encrypt information.
        /// </summary>
        [DataMember(Name = "publicKeyHash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "publicKeyHash")]
        public string? PublicKeyHash { get; set; }

        /// <summary>
        /// Gets or sets ephemeral Key - a unique generated key used by Apple to encrypt data.
        /// </summary>
        [DataMember(Name = "ephemeralKey", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ephemeralKey")]
        public string? EphemeralKey { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDSecure.
        /// </summary>
        [DataMember(Name = "threeDSecure", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "threeDSecure")]
        public MobilePaymentThreeDSecure? ThreeDSecure { get; set; }

        /// <summary>
        /// Gets or Sets PaymentProduct302SpecificInput.
        /// </summary>
        [DataMember(Name = "paymentProduct302SpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProduct302SpecificInput")]
        public PaymentProduct302SpecificInput? PaymentProduct302SpecificInput { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobilePaymentMethodSpecificInput {\n");
            sb.Append("  PaymentProductId: ").Append(this.PaymentProductId).Append('\n');
            sb.Append("  AuthorizationMode: ").Append(this.AuthorizationMode).Append('\n');
            sb.Append("  EncryptedPaymentData: ").Append(this.EncryptedPaymentData).Append('\n');
            sb.Append("  PublicKeyHash: ").Append(this.PublicKeyHash).Append('\n');
            sb.Append("  EphemeralKey: ").Append(this.EphemeralKey).Append('\n');
            sb.Append("  ThreeDSecure: ").Append(this.ThreeDSecure).Append('\n');
            sb.Append("  PaymentProduct302SpecificInput: ").Append(this.PaymentProduct302SpecificInput).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
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
