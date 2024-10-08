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
    public class PaymentInformationRequest
    {
        /// <summary>
        /// Gets or Sets AmountOfMoney.
        /// </summary>
        [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amountOfMoney")]
        public AmountOfMoney? AmountOfMoney { get; set; }

        /// <summary>
        /// Gets or Sets Type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public PaymentType? Type { get; set; }

        /// <summary>
        /// Gets or Sets PaymentChannel.
        /// </summary>
        [DataMember(Name = "paymentChannel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentChannel")]
        public PaymentChannel? PaymentChannel { get; set; }

        /// <summary>
        /// Gets or sets payment method identifier - please check the product documentation for a full overview of possible values.
        /// </summary>
        /// <value>Payment method identifier - please check the product documentation for a full overview of possible values.</value>
        [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProductId")]
        public int? PaymentProductId { get; set; }

        /// <summary>
        /// Gets or sets unique reference of the PaymentInformation. In case of card present transactions, the reference from the ECR or terminal will be used. It is always the reference for external transactions. (e.g. card present payments, cash payments or payments processed by other payment providers).
        /// </summary>
        /// <value>Unique reference of the PaymentInformation. In case of card present transactions, the reference from the ECR or terminal will be used. It is always the reference for external transactions. (e.g. card present payments, cash payments or payments processed by other payment providers). </value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string? MerchantReference { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInformationRequest {\n");
            sb.Append("  AmountOfMoney: ").Append(this.AmountOfMoney).Append('\n');
            sb.Append("  Type: ").Append(this.Type).Append('\n');
            sb.Append("  PaymentChannel: ").Append(this.PaymentChannel).Append('\n');
            sb.Append("  PaymentProductId: ").Append(this.PaymentProductId).Append('\n');
            sb.Append("  MerchantReference: ").Append(this.MerchantReference).Append('\n');
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
