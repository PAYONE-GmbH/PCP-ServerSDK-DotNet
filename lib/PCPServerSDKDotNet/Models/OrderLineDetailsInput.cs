namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing additional information that when supplied can have a beneficial effect on the discountrates.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class OrderLineDetailsInput
    {
        /// <summary>
        /// Gets or sets product or UPC Code.
        /// </summary>
        /// <value>Product or UPC Code.</value>
        [DataMember(Name = "productCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Gets or sets the price of one unit of the product, the value should be zero or greater.
        /// </summary>
        /// <value>The price of one unit of the product, the value should be zero or greater.</value>
        [DataMember(Name = "productPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productPrice")]
        public long? ProductPrice { get; set; }

        /// <summary>
        /// Gets or Sets ProductType.
        /// </summary>
        [DataMember(Name = "productType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productType")]
        public ProductType? ProductType { get; set; }

        /// <summary>
        /// Gets or sets quantity of the units being purchased, should be greater than zero Note: Must not be all spaces or all zeros.
        /// </summary>
        /// <value>Quantity of the units being purchased, should be greater than zero Note: Must not be all spaces or all zeros.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Gets or sets tax on the line item, with the last two digits implied as decimal places.
        /// </summary>
        /// <value>Tax on the line item, with the last two digits implied as decimal places.</value>
        [DataMember(Name = "taxAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxAmount")]
        public long? TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets uRL of the product in shop.   Used for PAYONE Buy Now, Pay Later (BNPL).
        /// </summary>
        /// <value>URL of the product in shop.   Used for PAYONE Buy Now, Pay Later (BNPL).</value>
        [DataMember(Name = "productUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productUrl")]
        public string? ProductUrl { get; set; }

        /// <summary>
        /// Gets or sets uRL of a product image.   Used for PAYONE Buy Now, Pay Later (BNPL).
        /// </summary>
        /// <value>URL of a product image.   Used for PAYONE Buy Now, Pay Later (BNPL).</value>
        [DataMember(Name = "productImageUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productImageUrl")]
        public string? ProductImageUrl { get; set; }

        /// <summary>
        /// Gets or sets category path of the item.   Used for PAYONE Buy Now, Pay Later (BNPL).
        /// </summary>
        /// <value>Category path of the item.   Used for PAYONE Buy Now, Pay Later (BNPL).</value>
        [DataMember(Name = "productCategoryPath", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productCategoryPath")]
        public string? ProductCategoryPath { get; set; }

        /// <summary>
        /// Gets or sets optional parameter to define the delivery shop or touchpoint where an item has been collected (e.g. for Click & Collect or Click & Reserve).
        /// </summary>
        /// <value>Optional parameter to define the delivery shop or touchpoint where an item has been collected (e.g. for Click & Collect or Click & Reserve).</value>
        [DataMember(Name = "merchantShopDeliveryReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantShopDeliveryReference")]
        public string? MerchantShopDeliveryReference { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineDetailsInput {\n");
            sb.Append("  ProductCode: ").Append(this.ProductCode).Append('\n');
            sb.Append("  ProductPrice: ").Append(this.ProductPrice).Append('\n');
            sb.Append("  ProductType: ").Append(this.ProductType).Append('\n');
            sb.Append("  Quantity: ").Append(this.Quantity).Append('\n');
            sb.Append("  TaxAmount: ").Append(this.TaxAmount).Append('\n');
            sb.Append("  ProductUrl: ").Append(this.ProductUrl).Append('\n');
            sb.Append("  ProductImageUrl: ").Append(this.ProductImageUrl).Append('\n');
            sb.Append("  ProductCategoryPath: ").Append(this.ProductCategoryPath).Append('\n');
            sb.Append("  MerchantShopDeliveryReference: ").Append(this.MerchantShopDeliveryReference).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
