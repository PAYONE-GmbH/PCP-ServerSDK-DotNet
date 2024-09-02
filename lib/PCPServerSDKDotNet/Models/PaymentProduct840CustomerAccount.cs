namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing the details of the PayPal account.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentProduct840CustomerAccount
    {
        /// <summary>
        /// Gets or sets name of the company in case the PayPal account is owned by a business.
        /// </summary>
        /// <value>Name of the company in case the PayPal account is owned by a business.</value>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Gets or sets first name of the PayPal account holder.
        /// </summary>
        /// <value>First name of the PayPal account holder.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of a PayPal account and will never change in the life cycle of a PayPal account.
        /// </summary>
        /// <value>The unique identifier of a PayPal account and will never change in the life cycle of a PayPal account.</value>
        [DataMember(Name = "payerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payerId")]
        public string? PayerId { get; set; }

        /// <summary>
        /// Gets or sets surname of the PayPal account holder.
        /// </summary>
        /// <value>Surname of the PayPal account holder.</value>
        [DataMember(Name = "surname", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "surname")]
        public string? Surname { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProduct840CustomerAccount {\n");
            sb.Append("  CompanyName: ").Append(this.CompanyName).Append('\n');
            sb.Append("  FirstName: ").Append(this.FirstName).Append('\n');
            sb.Append("  PayerId: ").Append(this.PayerId).Append('\n');
            sb.Append("  Surname: ").Append(this.Surname).Append('\n');
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
