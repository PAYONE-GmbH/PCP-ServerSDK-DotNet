namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// * first = This transaction is the first of a series of recurring transactions
    /// * recurring = This transaction is a subsequent transaction in a series of recurring transactions
    ///
    /// Note: For any first of a recurring the system will automatically create a token as you will need to use a token
    /// for any subsequent recurring transactions. In case a token already exists this is indicated in the response
    /// with a value of False for the isNewToken property in the response.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecurringPaymentSequenceIndicator
    {
        /// <summary>
        /// This transaction is the first of a series of recurring transactions
        /// </summary>
        [JsonProperty("first")]
        [EnumMember(Value = "first")]
        First,

        /// <summary>
        /// This transaction is a subsequent transaction in a series of recurring transactions
        /// </summary>
        [JsonProperty("recurring")]
        [EnumMember(Value = "recurring")]
        Recurring,
    }
}
