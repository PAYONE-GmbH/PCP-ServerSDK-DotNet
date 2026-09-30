namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Updated payment intent, including its shopping cart and payment intent output.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PatchPaymentIntentResponse : CreatePaymentIntentResponse
    {
    }
}
