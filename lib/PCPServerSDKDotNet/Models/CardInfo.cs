namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing additional non PCI DSS relevant card information. used instead of card (missing fields: cardNumber, expiryDate, cvv).
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CardInfo
    {
        /// <summary>
        /// Gets or sets the card holder's name on the card.
        /// </summary>
        /// <value>The card holder's name on the card.</value>
        [DataMember(Name = "cardholderName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cardholderName")]
        public string? CardholderName { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardInfo {\n");
            sb.Append("  CardholderName: ").Append(this.CardholderName).Append('\n');
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
