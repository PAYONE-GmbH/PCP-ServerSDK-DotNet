namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing specific data regarding 3-D Secure for card digital wallets.
    /// Necessary to perform 3D Secure when there is no liability shift from the wallet and corresponding card network.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class MobilePaymentThreeDSecure
    {
        /// <summary>
        /// Gets or Sets RedirectionData.
        /// </summary>
        [DataMember(Name = "redirectionData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redirectionData")]
        public RedirectionData? RedirectionData { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobilePaymentThreeDSecure {\n");
            sb.Append("  RedirectionData: ").Append(this.RedirectionData).Append('\n');
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
