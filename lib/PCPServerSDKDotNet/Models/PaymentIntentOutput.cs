namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentIntentOutput : PaymentIntentResponseData
    {
        [DataMember(Name = "redirectPaymentMethodSpecificOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redirectPaymentMethodSpecificOutput")]
        public RedirectPaymentMethodSpecificOutputForCreateIntent? RedirectPaymentMethodSpecificOutput { get; set; }
    }
}
