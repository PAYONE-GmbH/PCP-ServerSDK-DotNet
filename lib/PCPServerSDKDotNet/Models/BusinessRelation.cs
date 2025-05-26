namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Business relation to the customer. This identifies if the customer is a private consumer or a business.
    /// Mandatory for the following payment methods:
    /// * 3390 - PAYONE Secured Invoice
    /// * 3391 - PAYONE Secured Installment
    /// * 3392 - PAYONE Secured Direct Debit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BusinessRelation
    {
        /// <summary>
        /// Indicates business to consumer
        /// </summary>
        [JsonProperty("B2C")]
        [EnumMember(Value = "B2C")]
        B2C,

        /// <summary>
        /// Indicates business to business
        /// </summary>
        [JsonProperty("B2B")]
        [EnumMember(Value = "B2B")]
        B2B,
    }
}
