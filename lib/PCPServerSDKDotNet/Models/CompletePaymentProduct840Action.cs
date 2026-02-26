namespace PCPServerSDKDotNet.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompletePaymentProduct840Action
    {
        [JsonProperty("CONFIRM_ORDER_STATUS")]
        ConfirmOrderStatus,
    }
}
