namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Indicates the channel via which the payment is created. Allowed values:
    /// * ECOMMERCE - The transaction is a regular E-Commerce transaction.
    /// * MOTO - The transaction is a Mail Order/Telephone Order.
    /// Defaults to ECOMMERCE.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionChannel
    {
        [JsonProperty("ECOMMERCE")]
        [EnumMember(Value = "ECOMMERCE")]
        Ecommerce,

        [JsonProperty("MOTO")]
        [EnumMember(Value = "MOTO")]
        Moto,
    }
}
