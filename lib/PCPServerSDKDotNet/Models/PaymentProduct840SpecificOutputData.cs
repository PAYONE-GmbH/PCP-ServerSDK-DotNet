namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentProduct840SpecificOutputData
    {
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingAddress")]
        public Address? BillingAddress { get; set; }

        [DataMember(Name = "customerAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customerAccount")]
        public PaymentProduct840CustomerAccount? CustomerAccount { get; set; }

        [DataMember(Name = "payPalTransactionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payPalTransactionId")]
        public string? PayPalTransactionId { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
