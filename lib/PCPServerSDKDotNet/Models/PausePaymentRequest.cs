namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Request to pause a payment for a specific payment method.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PausePaymentRequest
    {
        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            return "class PausePaymentRequest {\n}\n";
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
