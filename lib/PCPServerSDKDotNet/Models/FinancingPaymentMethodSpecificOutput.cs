namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the specific output details for financing payment methods (Buy Now Pay Later).
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class FinancingPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Gets or sets payment product identifier - please check product documentation for a full overview of possible values. Currently supported payment methods * 3390 - PAYONE Secured Invoice * 3391 - PAYONE Secured Installment * 3392 - PAYONE Secured Direct Debit.
        /// </summary>
        /// <value>Payment product identifier - please check product documentation for a full overview of possible values. Currently supported payment methods * 3390 - PAYONE Secured Invoice * 3391 - PAYONE Secured Installment * 3392 - PAYONE Secured Direct Debit.</value>
        [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProductId")]
        public int? PaymentProductId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentProduct3391SpecificOutput.
        /// </summary>
        [DataMember(Name = "paymentProduct3391SpecificOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProduct3391SpecificOutput")]
        public PaymentProduct3391SpecificOutput? PaymentProduct3391SpecificOutput { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinancingPaymentMethodSpecificOutput {\n");
            sb.Append("  PaymentProductId: ").Append(this.PaymentProductId).Append('\n');
            sb.Append("  PaymentProduct3391SpecificOutput: ").Append(this.PaymentProduct3391SpecificOutput).Append('\n');
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
