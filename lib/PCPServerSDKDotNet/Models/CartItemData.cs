namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CartItemData
    {
        [DataMember(Name = "invoiceData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invoiceData")]
        public CartItemInvoiceData? InvoiceData { get; set; }

        [DataMember(Name = "orderLineDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderLineDetails")]
        public OrderLineDetailsInput? OrderLineDetails { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
