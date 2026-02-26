namespace PCPServerSDKDotNet.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FundDistributionType
    {
        [JsonProperty("SELLER_REVENUE")]
        SellerRevenue,

        [JsonProperty("COMMISSION_FEE")]
        CommissionFee,

        [JsonProperty("SHIPPING_COSTS")]
        ShippingCosts,

        [JsonProperty("TAX")]
        Tax,

        [JsonProperty("PLATFORM_FEE")]
        PlatformFee,

        [JsonProperty("OTHER")]
        Other,
    }
}
