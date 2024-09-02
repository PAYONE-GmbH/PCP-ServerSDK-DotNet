namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the relevant information of a SEPA Direct Debit mandate for processing (mandatory fields in pain.008). Renamed from CreateMandateWithReturnUrl to ProcessingMandateInformation.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ProcessingMandateInformation
    {
        /// <summary>
        /// Gets or Sets BankAccountIban.
        /// </summary>
        [DataMember(Name = "bankAccountIban", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankAccountIban")]
        public BankAccountInformation? BankAccountIban { get; set; }

        /// <summary>
        /// Gets or Sets RecurrenceType.
        /// </summary>
        [DataMember(Name = "recurrenceType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recurrenceType")]
        public MandateRecurrenceType? RecurrenceType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the mandate.
        /// </summary>
        /// <value>The unique identifier of the mandate.</value>
        [DataMember(Name = "uniqueMandateReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uniqueMandateReference")]
        public string? UniqueMandateReference { get; set; }

        /// <summary>
        /// Gets or sets the date of signature of the mandate. Format YYYYMMDD.
        /// </summary>
        /// <value>The date of signature of the mandate. Format YYYYMMDD.</value>
        [DataMember(Name = "dateOfSignature", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateOfSignature")]
        public string? DateOfSignature { get; set; }

        /// <summary>
        /// Gets or sets your unique creditor identifier.
        /// </summary>
        /// <value>Your unique creditor identifier.</value>
        [DataMember(Name = "creditorId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creditorId")]
        public string? CreditorId { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessingMandateInformation {\n");
            sb.Append("  BankAccountIban: ").Append(this.BankAccountIban).Append('\n');
            sb.Append("  RecurrenceType: ").Append(this.RecurrenceType).Append('\n');
            sb.Append("  UniqueMandateReference: ").Append(this.UniqueMandateReference).Append('\n');
            sb.Append("  DateOfSignature: ").Append(this.DateOfSignature).Append('\n');
            sb.Append("  CreditorId: ").Append(this.CreditorId).Append('\n');
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
