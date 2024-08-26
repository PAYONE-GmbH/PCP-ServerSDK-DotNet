namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the mobile payment method details.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class MobilePaymentMethodSpecificOutput
    {
        /// <summary>
        /// Gets or sets payment product identifier - please check product documentation for a full overview of possible values.
        /// </summary>
        /// <value>Payment product identifier - please check product documentation for a full overview of possible values.</value>
        [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProductId")]
        public int? PaymentProductId { get; set; }

        /// <summary>
        /// Gets or sets card Authorization code as returned by the acquirer.
        /// </summary>
        /// <value>Card Authorization code as returned by the acquirer.</value>
        [DataMember(Name = "authorisationCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "authorisationCode")]
        public string? AuthorisationCode { get; set; }

        /// <summary>
        /// Gets or Sets FraudResults.
        /// </summary>
        [DataMember(Name = "fraudResults", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fraudResults")]
        public CardFraudResults? FraudResults { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDSecureResults.
        /// </summary>
        [DataMember(Name = "threeDSecureResults", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "threeDSecureResults")]
        public ThreeDSecureResults? ThreeDSecureResults { get; set; }

        /// <summary>
        /// Gets or sets the card network that was used for a mobile payment method operation.
        /// </summary>
        /// <value>The card network that was used for a mobile payment method operation.</value>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobilePaymentMethodSpecificOutput {\n");
            sb.Append("  PaymentProductId: ").Append(this.PaymentProductId).Append('\n');
            sb.Append("  AuthorisationCode: ").Append(this.AuthorisationCode).Append('\n');
            sb.Append("  FraudResults: ").Append(this.FraudResults).Append('\n');
            sb.Append("  ThreeDSecureResults: ").Append(this.ThreeDSecureResults).Append('\n');
            sb.Append("  Network: ").Append(this.Network).Append('\n');
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
