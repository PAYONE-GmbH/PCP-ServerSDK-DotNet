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
    public class ReturnResponse
    {
        /// <summary>
        /// Gets or Sets ReturnPaymentResponse.
        /// </summary>
        [DataMember(Name = "returnPaymentResponse", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "returnPaymentResponse")]
        public RefundPaymentResponse? ReturnPaymentResponse { get; set; }

        /// <summary>
        /// Gets or Sets ShoppingCart.
        /// </summary>
        [DataMember(Name = "shoppingCart", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shoppingCart")]
        public ShoppingCartResult? ShoppingCart { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReturnResponse {\n");
            sb.Append("  ReturnPaymentResponse: ").Append(this.ReturnPaymentResponse).Append('\n');
            sb.Append("  ShoppingCart: ").Append(this.ShoppingCart).Append('\n');
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
