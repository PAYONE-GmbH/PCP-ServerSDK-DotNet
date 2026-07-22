namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ShippingAddress : AddressPersonal
    {
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "companyName")]
        public string? CompanyName { get; set; }
    }
}
