namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RedirectPaymentMethodSpecificOutputForIntent
    {
        [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProductId")]
        public int? PaymentProductId { get; set; }

        [DataMember(Name = "paymentProduct840SpecificOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProduct840SpecificOutput")]
        public PaymentProduct840SpecificOutputForIntent? PaymentProduct840SpecificOutput { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
