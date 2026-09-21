namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreatePayByLinkRequest
    {
        [DataMember(Name = "paymentLinkSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentLinkSpecificInput", Required = Required.Always)]
        required public PaymentLinkSpecificInput PaymentLinkSpecificInput { get; set; }

        [DataMember(Name = "orderType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderType", Required = Required.Always)]
        required public OrderType OrderType { get; set; }

        [DataMember(Name = "items", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "items")]
        public List<OrderItem>? Items { get; set; }

        [DataMember(Name = "orderReferences", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderReferences", Required = Required.Always)]
        required public References OrderReferences { get; set; }
    }
}
