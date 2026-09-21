namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PaymentProduct840CustomerAccountForIntent
    {
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "companyName")]
        public string? CompanyName { get; set; }

        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstName")]
        public string? FirstName { get; set; }

        [DataMember(Name = "surname", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "surname")]
        public string? Surname { get; set; }

        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "emailAddress")]
        public string? EmailAddress { get; set; }
    }
}
