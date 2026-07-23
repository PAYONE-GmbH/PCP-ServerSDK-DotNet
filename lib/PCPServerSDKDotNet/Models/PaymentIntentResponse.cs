namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentIntentResponse : PaymentIntentResponseData
    {
        [DataMember(Name = "redirectPaymentMethodSpecificOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redirectPaymentMethodSpecificOutput")]
        public RedirectPaymentMethodSpecificOutputForIntent? RedirectPaymentMethodSpecificOutput { get; set; }
    }
}
