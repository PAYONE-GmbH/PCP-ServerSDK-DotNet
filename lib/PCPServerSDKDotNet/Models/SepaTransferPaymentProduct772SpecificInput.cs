namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the specific input details for SEPA credit transfers
    /// excluding cross-border ones.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class SepaTransferPaymentProduct772SpecificInput
    {
        /// <summary>
        /// Gets or Sets BankAccountInformation.
        /// </summary>
        [DataMember(Name = "bankAccountInformation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankAccountInformation")]
        public BankAccountInformation? BankAccountInformation { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class SepaTransferPaymentProduct772SpecificInput {\n");
            sb.Append("  BankAccountInformation: ").Append(this.BankAccountInformation).Append('\n');
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
