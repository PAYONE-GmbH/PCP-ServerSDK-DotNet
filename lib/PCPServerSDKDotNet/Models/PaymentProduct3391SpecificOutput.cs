namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing specific information for PAYONE Secured Installment.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentProduct3391SpecificOutput
    {
        /// <summary>
        /// Gets or sets list of installment options.
        /// </summary>
        /// <value>List of installment options.</value>
        [DataMember(Name = "installmentOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "installmentOptions")]
        public List<InstallmentOption>? InstallmentOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProduct3391SpecificOutput {\n");
            sb.Append("  InstallmentOptions: ").Append(this.InstallmentOptions).Append('\n');
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
