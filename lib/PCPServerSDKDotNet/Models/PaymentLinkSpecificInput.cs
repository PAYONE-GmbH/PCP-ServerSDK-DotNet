namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentLinkSpecificInput
    {
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expirationDate")]
        public DateTimeOffset? ExpirationDate { get; set; }

        [DataMember(Name = "authorizationMode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "authorizationMode", Required = Required.Always)]
        required public AuthorizationMode AuthorizationMode { get; set; }

        [DataMember(Name = "paymentMethods", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentMethods", Required = Required.Always)]
        required public List<string> PaymentMethods { get; set; }

        [DataMember(Name = "bnplId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bnplId")]
        public string? BnplId { get; set; }

        [DataMember(Name = "returnUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "returnUrl")]
        public string? ReturnUrl { get; set; }

        [DataMember(Name = "logoUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "logoUrl")]
        public string? LogoUrl { get; set; }

        [DataMember(Name = "autoRedirection", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "autoRedirection")]
        public bool? AutoRedirection { get; set; }

        [DataMember(Name = "termsUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "termsUrl")]
        public string? TermsUrl { get; set; }

        [DataMember(Name = "retryNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "retryNumber")]
        public long? RetryNumber { get; set; }

        [DataMember(Name = "merchantName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantName")]
        public string? MerchantName { get; set; }

        [DataMember(Name = "merchantOrigin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantOrigin")]
        public string? MerchantOrigin { get; set; }
    }
}
