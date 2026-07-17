namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentProduct840SpecificOutputForIntent : PaymentProduct840SpecificOutputData
    {
        [DataMember(Name = "shippingAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shippingAddress")]
        public ShippingAddress? ShippingAddress { get; set; }
    }
}
