namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Request to initiate refund for a Payment Information of Checkout.
    /// It is possible to initiate multiple partial refunds by providing an amount that is
    /// lower than the total captured amount of the Payment Information.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentInformationRefundRequest
    {
        /// <summary>
        /// Gets or Sets AmountOfMoney.
        /// </summary>
        [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amountOfMoney")]
        public PositiveAmountOfMoney? AmountOfMoney { get; set; }

        /// <summary>
        /// Gets or Sets References.
        /// </summary>
        [DataMember(Name = "references", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "references")]
        public PaymentReferences? References { get; set; }

        /// <summary>
        /// Gets or sets account holder of the bank account.
        /// Does not necessarily have to be the customer (e.g. joint accounts).
        /// The name of the account holder is required for payment methods that will use a credit transfer for the refund (e.g. girocard, SEPA Direct Debit).
        /// </summary>
        [DataMember(Name = "accountHolder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountHolder")]
        public string? AccountHolder { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInformationRefundRequest {\n");
            sb.Append("  AmountOfMoney: ").Append(this.AmountOfMoney).Append('\n');
            sb.Append("  References: ").Append(this.References).Append('\n');
            sb.Append("  AccountHolder: ").Append(this.AccountHolder).Append('\n');
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
