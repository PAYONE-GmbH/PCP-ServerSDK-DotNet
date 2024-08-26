using System.Text.Json.Serialization;

namespace PCPServerSDKDotNet.Models.ApplePay
{
    /// <summary>
    /// An object that contains the user's payment credentials.
    /// You access the payment token of an authorized payment request using the token property of the Payment object.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public class ApplePayPaymentToken
    {

        [JsonPropertyName("paymentData")]
        [JsonInclude]
        public ApplePayPaymentData? PaymentData { get; set; }

        [JsonPropertyName("paymentMethod")]
        [JsonInclude]
        public ApplePayPaymentMethod? PaymentMethod { get; set; }

        [JsonPropertyName("transactionIdentifier")]
        [JsonInclude]
        public string? TransactionIdentifier { get; set; }

        public ApplePayPaymentToken() { }

        public ApplePayPaymentToken(ApplePayPaymentData paymentData, ApplePayPaymentMethod paymentMethod, string transactionIdentifier)
        {
            PaymentData = paymentData;
            PaymentMethod = paymentMethod;
            TransactionIdentifier = transactionIdentifier;
        }

        public ApplePayPaymentToken WithPaymentData(ApplePayPaymentData paymentData)
        {
            PaymentData = paymentData;
            return this;
        }

        public ApplePayPaymentToken WithPaymentMethod(ApplePayPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
            return this;
        }

        public ApplePayPaymentToken WithTransactionIdentifier(string transactionIdentifier)
        {
            TransactionIdentifier = transactionIdentifier;
            return this;
        }

        public override bool Equals(object obj)
        {
            return obj is ApplePayPaymentToken token &&
                   EqualityComparer<ApplePayPaymentData>.Default.Equals(PaymentData, token.PaymentData) &&
                   EqualityComparer<ApplePayPaymentMethod>.Default.Equals(PaymentMethod, token.PaymentMethod) &&
                   TransactionIdentifier == token.TransactionIdentifier;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(PaymentData, PaymentMethod, TransactionIdentifier);
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class PaymentToken {\n");
            sb.Append("    paymentData: ").Append(ToIndentedString(PaymentData)).Append("\n");
            sb.Append("    paymentMethod: ").Append(ToIndentedString(PaymentMethod)).Append("\n");
            sb.Append("    transactionIdentifier: ").Append(ToIndentedString(TransactionIdentifier)).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }

        private string ToIndentedString(object obj)
        {
            if (obj == null)
            {
                return "null";
            }
            return obj.ToString().Replace("\n", "\n    ");
        }
    }
}
