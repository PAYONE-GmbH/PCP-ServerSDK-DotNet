namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Payee bank account details as part of the payment instructions.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Payee
    {
        /// <summary>
        /// Gets or sets IBAN of the payee's or beneficiary's bank account.
        /// The IBAN is the International Bank Account Number. It is an internationally agreed format for
        /// the BBAN and includes the ISO country code and two check digits.
        /// </summary>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "iban")]
        public string? Iban { get; set; }

        /// <summary>
        /// Gets or sets the Bank Identification Code (BIC).
        /// </summary>
        [DataMember(Name = "bic", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bic")]
        public string? Bic { get; set; }

        /// <summary>
        /// Gets or sets the name of the payee.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payee {\n");
            sb.Append("  Iban: ").Append(this.Iban).Append('\n');
            sb.Append("  Bic: ").Append(this.Bic).Append('\n');
            sb.Append("  Name: ").Append(this.Name).Append('\n');
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
