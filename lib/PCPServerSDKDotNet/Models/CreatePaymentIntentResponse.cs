namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreatePaymentIntentResponse
    {
        [DataMember(Name = "shoppingCart", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shoppingCart")]
        public ShoppingCartData? ShoppingCart { get; set; }

        [DataMember(Name = "paymentIntentOutput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentIntentOutput")]
        public PaymentIntentOutput? PaymentIntentOutput { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
