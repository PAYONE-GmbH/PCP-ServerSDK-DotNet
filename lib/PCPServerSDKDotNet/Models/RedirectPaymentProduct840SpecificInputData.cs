namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RedirectPaymentProduct840SpecificInputData
    {
        [DataMember(Name = "addressSelectionAtPayPal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "addressSelectionAtPayPal")]
        public bool? AddressSelectionAtPayPal { get; set; }

        [DataMember(Name = "javaScriptSdkFlow", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "javaScriptSdkFlow")]
        public bool? JavaScriptSdkFlow { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
