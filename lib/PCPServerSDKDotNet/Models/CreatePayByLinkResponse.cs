namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreatePayByLinkResponse
    {
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expirationDate")]
        public DateTimeOffset? ExpirationDate { get; set; }

        [DataMember(Name = "paymentLinkOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentLinkOrder")]
        public PaymentLinkOrder? PaymentLinkOrder { get; set; }

        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public PayLinkStatusValue? Status { get; set; }

        [DataMember(Name = "redirectionUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redirectionUrl")]
        public string? RedirectionUrl { get; set; }

        [DataMember(Name = "paymentLinkId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentLinkId")]
        public string? PaymentLinkId { get; set; }
    }
}
