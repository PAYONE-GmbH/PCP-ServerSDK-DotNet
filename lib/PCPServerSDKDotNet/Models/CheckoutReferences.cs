namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing all details that are linked to the Checkout.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CheckoutReferences
    {
        /// <summary>
        /// Gets or sets unique reference of the Checkout that is also returned for reporting and reconciliation purposes.
        /// </summary>
        /// <value>Unique reference of the Checkout that is also returned for reporting and reconciliation purposes.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string? MerchantReference { get; set; }

        /// <summary>
        /// Gets or sets optional parameter to define the shop or touchpoint where a sale has been realized (e.g. different stores).
        /// </summary>
        /// <value>Optional parameter to define the shop or touchpoint where a sale has been realized (e.g. different stores).</value>
        [DataMember(Name = "merchantShopReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantShopReference")]
        public string? MerchantShopReference { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutReferences {\n");
            sb.Append("  MerchantReference: ").Append(this.MerchantReference).Append('\n');
            sb.Append("  MerchantShopReference: ").Append(this.MerchantShopReference).Append('\n');
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
