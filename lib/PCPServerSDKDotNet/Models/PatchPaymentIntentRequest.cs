namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Details for updating a payment intent.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PatchPaymentIntentRequest
    {
        [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amountOfMoney")]
        public AmountOfMoney? AmountOfMoney { get; set; }

        [DataMember(Name = "shoppingCart", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shoppingCart")]
        public ShoppingCartData? ShoppingCart { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
