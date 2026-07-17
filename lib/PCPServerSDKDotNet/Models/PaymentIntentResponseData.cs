namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentIntentResponseData
    {
        [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amountOfMoney")]
        public AmountOfMoney? AmountOfMoney { get; set; }

        [DataMember(Name = "references", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "references")]
        public PaymentReferences? References { get; set; }

        [DataMember(Name = "paymentIntentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentIntentId")]
        public string? PaymentIntentId { get; set; }

        [DataMember(Name = "paymentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentId")]
        public string? PaymentId { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
