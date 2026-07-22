namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentMethodSpecificInputForIntent
    {
        [DataMember(Name = "redirectPaymentMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redirectPaymentMethodSpecificInput")]
        public RedirectPaymentMethodSpecificInputForIntent? RedirectPaymentMethodSpecificInput { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
