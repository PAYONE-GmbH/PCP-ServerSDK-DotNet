namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreatePaymentIntentRequest : CreatePaymentIntent
    {
        [DataMember(Name = "paymentMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentMethodSpecificInput")]
        public PaymentMethodSpecificInputForIntent? PaymentMethodSpecificInput { get; set; }
    }
}
