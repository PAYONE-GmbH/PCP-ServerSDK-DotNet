namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing additional information that when supplied can have a beneficial effect on the discount rates.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class OrderLineDetailsInput
    {
        /// <summary>
        /// Gets or sets product or UPC Code.
        /// </summary>
        [DataMember(Name = "productCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Gets or sets the price of one unit of the product, should be zero or greater.
        /// </summary>
        [DataMember(Name = "productPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productPrice")]
        public long? ProductPrice { get; set; }

        /// <summary>
        /// Gets or sets product type.
        /// </summary>
        [DataMember(Name = "productType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productType")]
        public ProductType? ProductType { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the units being purchased, should be greater than zero.
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Gets or sets tax on the line item, with the last two digits implied as decimal places.
        /// </summary>
        [DataMember(Name = "taxAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxAmount")]
        public long? TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets whether tax amount is per unit (true) or per line item (false).
        /// </summary>
        [DataMember(Name = "taxAmountPerUnit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxAmountPerUnit")]
        public bool? TaxAmountPerUnit { get; set; }

        /// <summary>
        /// Gets or sets the URL of the product in the shop (used for PAYONE BNPL).
        /// </summary>
        [DataMember(Name = "productUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productUrl")]
        public string? ProductUrl { get; set; }

        /// <summary>
        /// Gets or sets the URL of a product image (used for PAYONE BNPL).
        /// </summary>
        [DataMember(Name = "productImageUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productImageUrl")]
        public string? ProductImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the category path of the item (used for PAYONE BNPL).
        /// </summary>
        [DataMember(Name = "productCategoryPath", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productCategoryPath")]
        public string? ProductCategoryPath { get; set; }

        /// <summary>
        /// Gets or sets the optional parameter to define the delivery shop or touchpoint (e.g. Click & Collect).
        /// </summary>
        [DataMember(Name = "merchantShopDeliveryReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantShopDeliveryReference")]
        public string? MerchantShopDeliveryReference { get; set; }

        /// <summary>
        /// Get the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineDetailsInput {\n");
            sb.Append("  ProductCode: ").Append(this.ProductCode).Append('\n');
            sb.Append("  ProductPrice: ").Append(this.ProductPrice).Append('\n');
            sb.Append("  ProductType: ").Append(this.ProductType).Append('\n');
            sb.Append("  Quantity: ").Append(this.Quantity).Append('\n');
            sb.Append("  TaxAmount: ").Append(this.TaxAmount).Append('\n');
            sb.Append("  TaxAmountPerUnit: ").Append(this.TaxAmountPerUnit).Append('\n');
            sb.Append("  ProductUrl: ").Append(this.ProductUrl).Append('\n');
            sb.Append("  ProductImageUrl: ").Append(this.ProductImageUrl).Append('\n');
            sb.Append("  ProductCategoryPath: ").Append(this.ProductCategoryPath).Append('\n');
            sb.Append("  MerchantShopDeliveryReference: ").Append(this.MerchantShopDeliveryReference).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string representation of the object.
        /// </summary>
        /// <returns>JSON string representation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
