namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing additional information needed for Apple Pay payment transactions.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentProduct302SpecificInput
    {
        /// <summary>
        /// Gets or sets the type of Apple Pay integration.
        /// </summary>
        [DataMember(Name = "integrationType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "integrationType")]
        public IntegrationTypeEnum? IntegrationType { get; set; }

        /// <summary>
        /// Gets or sets the network/scheme of the card used for the payment.
        /// </summary>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "network")]
        public NetworkEnum? Network { get; set; }

        /// <summary>
        /// Gets or sets the Apple Pay token data.
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "token")]
        public ApplePaymentDataTokenInformation? Token { get; set; }

        /// <summary>
        /// Gets or sets the domain of the webshop. Needed for Apple Pay session initialization with integrationType = MASS_ENABLEMENT.
        /// </summary>
        [DataMember(Name = "domainName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "domainName")]
        public string? DomainName { get; set; }

        /// <summary>
        /// Gets or sets the display name of the store. Needed for Apple Pay session initialization with integrationType = MASS_ENABLEMENT.
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>A string representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProduct302SpecificInput {\n");
            sb.Append("  IntegrationType: ").Append(this.IntegrationType).Append('\n');
            sb.Append("  Network: ").Append(this.Network).Append('\n');
            sb.Append("  Token: ").Append(this.Token).Append('\n');
            sb.Append("  DomainName: ").Append(this.DomainName).Append('\n');
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append('\n');
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
