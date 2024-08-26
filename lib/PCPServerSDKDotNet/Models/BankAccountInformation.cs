namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing information about the end customer&#x27;s bank account.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class BankAccountInformation
    {
        /// <summary>
        /// Gets or sets iBAN of the end customer's bank account. The IBAN is the International Bank Account Number. It is an internationally agreed format for the BBAN and includes the ISO country code and two check digits.
        /// </summary>
        /// <value>IBAN of the end customer's bank account. The IBAN is the International Bank Account Number. It is an internationally agreed format for the BBAN and includes the ISO country code and two check digits.</value>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "iban")]
        public string? Iban { get; set; }

        /// <summary>
        /// Gets or sets account holder of the bank account with the given IBAN. Does not necessarily have to be the end customer (e.g. joint accounts).
        /// </summary>
        /// <value>Account holder of the bank account with the given IBAN. Does not necessarily have to be the end customer (e.g. joint accounts).</value>
        [DataMember(Name = "accountHolder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountHolder")]
        public string? AccountHolder { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccountInformation {\n");
            sb.Append("  Iban: ").Append(this.Iban).Append('\n');
            sb.Append("  AccountHolder: ").Append(this.AccountHolder).Append('\n');
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
