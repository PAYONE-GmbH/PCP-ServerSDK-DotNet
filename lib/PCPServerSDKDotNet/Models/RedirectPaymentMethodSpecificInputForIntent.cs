namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RedirectPaymentMethodSpecificInputForIntent
    {
        [DataMember(Name = "requiresApproval", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requiresApproval")]
        public bool? RequiresApproval { get; set; }

        [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProductId")]
        public int? PaymentProductId { get; set; }

        [DataMember(Name = "paymentProduct840SpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentProduct840SpecificInput")]
        public RedirectPaymentProduct840SpecificInputData? PaymentProduct840SpecificInput { get; set; }

        [DataMember(Name = "redirectionData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redirectionData")]
        public RedirectionData? RedirectionData { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
