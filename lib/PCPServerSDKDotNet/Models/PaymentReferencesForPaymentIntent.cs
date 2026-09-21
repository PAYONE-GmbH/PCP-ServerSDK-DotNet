namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    public class PaymentReferencesForPaymentIntent : PaymentReferences
    {
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference", Required = Required.Always)]
        required public new string MerchantReference { get; set; }
    }
}
