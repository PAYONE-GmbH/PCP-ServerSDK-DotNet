namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Indicates which party initiated the unscheduled recurring transaction. Allowed values:   * merchantInitiated - Merchant Initiated Transaction.   * cardholderInitiated - Cardholder Initiated Transaction. Note:   * When a customer has chosen to use a token on a hosted Checkout this property is set to \&quot;cardholderInitiated\&quot;.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnscheduledCardOnFileRequestor
    {
        [JsonProperty("merchantInitiated")]
        [EnumMember(Value = "merchantInitiated")]
        MerchantInitiated,

        [JsonProperty("cardholderInitiated")]
        [EnumMember(Value = "cardholderInitiated")]
        CardholderInitiated,
    }
}
