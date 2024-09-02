namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class InstallmentOption
    {
        /// <summary>
        /// Gets or sets installment option Identifier. Use this in the Complete Payment for the selected installment option.
        /// </summary>
        /// <value>Installment option Identifier. Use this in the Complete Payment for the selected installment option.</value>
        [DataMember(Name = "installmentOptionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "installmentOptionId")]
        public string? InstallmentOptionId { get; set; }

        /// <summary>
        /// Gets or sets the number of monthly payments for this installment.
        /// </summary>
        /// <value>The number of monthly payments for this installment.</value>
        [DataMember(Name = "numberOfPayments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numberOfPayments")]
        public int? NumberOfPayments { get; set; }

        /// <summary>
        /// Gets or sets monthly rate amount.
        /// </summary>
        /// <value>Monthly rate amount.</value>
        [DataMember(Name = "monthlyAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "monthlyAmount")]
        public AmountOfMoney? MonthlyAmount { get; set; }

        /// <summary>
        /// Gets or sets last rate amount.
        /// </summary>
        /// <value>Last rate amount.</value>
        [DataMember(Name = "lastRateAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastRateAmount")]
        public AmountOfMoney? LastRateAmount { get; set; }

        /// <summary>
        /// Gets or sets effective interest amount in percent with two decimals.
        /// </summary>
        /// <value>Effective interest amount in percent with two decimals.</value>
        [DataMember(Name = "effectiveInterestRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "effectiveInterestRate")]
        public int? EffectiveInterestRate { get; set; }

        /// <summary>
        /// Gets or sets nominal interest amount in percent with two decimals.
        /// </summary>
        /// <value>Nominal interest amount in percent with two decimals.</value>
        [DataMember(Name = "nominalInterestRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nominalInterestRate")]
        public int? NominalInterestRate { get; set; }

        /// <summary>
        /// Gets or sets total rate amount.
        /// </summary>
        /// <value>Total rate amount.</value>
        [DataMember(Name = "totalAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalAmount")]
        public AmountOfMoney? TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets due date of first rate. Format: YYYYMMDD.
        /// </summary>
        /// <value>Due date of first rate. Format: YYYYMMDD.</value>
        [DataMember(Name = "firstRateDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstRateDate")]
        public string? FirstRateDate { get; set; }

        /// <summary>
        /// Gets or sets link with credit information.
        /// </summary>
        /// <value>Link with credit information.</value>
        [DataMember(Name = "creditInformation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creditInformation")]
        public LinkInformation? CreditInformation { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstallmentOption {\n");
            sb.Append("  InstallmentOptionId: ").Append(this.InstallmentOptionId).Append('\n');
            sb.Append("  NumberOfPayments: ").Append(this.NumberOfPayments).Append('\n');
            sb.Append("  MonthlyAmount: ").Append(this.MonthlyAmount).Append('\n');
            sb.Append("  LastRateAmount: ").Append(this.LastRateAmount).Append('\n');
            sb.Append("  EffectiveInterestRate: ").Append(this.EffectiveInterestRate).Append('\n');
            sb.Append("  NominalInterestRate: ").Append(this.NominalInterestRate).Append('\n');
            sb.Append("  TotalAmount: ").Append(this.TotalAmount).Append('\n');
            sb.Append("  FirstRateDate: ").Append(this.FirstRateDate).Append('\n');
            sb.Append("  CreditInformation: ").Append(this.CreditInformation).Append('\n');
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
