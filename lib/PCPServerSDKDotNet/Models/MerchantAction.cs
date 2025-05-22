namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object that contains the action, including the needed data, that you should perform next, like showing instructions, showing the transaction results or redirect to a third party to complete the payment.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class MerchantAction
    {
        /// <summary>
        /// Gets or sets action merchants needs to take in the online payment process.
        /// </summary>
        [DataMember(Name = "actionType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "actionType")]
        public ActionType? ActionType { get; set; }

        /// <summary>
        /// Gets or Sets RedirectData.
        /// </summary>
        [DataMember(Name = "redirectData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redirectData")]
        public RedirectData? RedirectData { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantAction {\n");
            sb.Append("  ActionType: ").Append(this.ActionType).Append('\n');
            sb.Append("  RedirectData: ").Append(this.RedirectData).Append('\n');
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
