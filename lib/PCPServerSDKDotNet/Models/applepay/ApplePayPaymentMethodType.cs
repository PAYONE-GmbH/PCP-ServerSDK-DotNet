namespace PCPServerSDKDotNet.Models.ApplePay
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A string that represents the type of the payment method.
    ///
    /// The type of card the customer uses to complete the transaction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApplePayPaymentMethodType
    {
        [JsonProperty("debit")]
        Debit,

        [JsonProperty("credit")]
        Credit,

        [JsonProperty("prepaid")]
        Prepaid,

        [JsonProperty("store")]
        Store,
    }

    public static class ApplePayPaymentMethodTypeExtensions
    {
        public static string GetValue(this ApplePayPaymentMethodType type)
        {
            return type.ToString().ToLower();
        }

        public static ApplePayPaymentMethodType FromValue(string value)
        {
            foreach (ApplePayPaymentMethodType type in Enum.GetValues(typeof(ApplePayPaymentMethodType)))
            {
                if (type.GetValue() == value)
                {
                    return type;
                }
            }

            throw new ArgumentException($"Unexpected value '{value}'");
        }
    }
}
