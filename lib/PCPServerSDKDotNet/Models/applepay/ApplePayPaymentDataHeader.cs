using System.Text.Json.Serialization;

namespace PCPServerSDKDotNet.Models.ApplePay
{
    /// <summary>
    /// PaymentDataHeader contains the payment data header information.
    /// This includes various keys and identifiers used in the Apple Pay payment process.
    /// </summary>
    public class ApplePayPaymentDataHeader
    {

        [JsonPropertyName("applicationData")]
        [JsonInclude]
        public string? ApplicationData { get; set; }

        [JsonPropertyName("ephemeralPublicKey")]
        [JsonInclude]
        public string? EphemeralPublicKey { get; set; }

        [JsonPropertyName("wrappedKey")]
        [JsonInclude]
        public string? WrappedKey { get; set; }

        [JsonPropertyName("publicKeyHash")]
        [JsonInclude]
        public string? PublicKeyHash { get; set; }

        [JsonPropertyName("transactionId")]
        [JsonInclude]
        public string? TransactionId { get; set; }

        public ApplePayPaymentDataHeader() { }

        public ApplePayPaymentDataHeader(string applicationData, string ephemeralPublicKey, string wrappedKey, string publicKeyHash, string transactionId)
        {
            ApplicationData = applicationData;
            EphemeralPublicKey = ephemeralPublicKey;
            WrappedKey = wrappedKey;
            PublicKeyHash = publicKeyHash;
            TransactionId = transactionId;
        }

        public ApplePayPaymentDataHeader WithApplicationData(string applicationData)
        {
            ApplicationData = applicationData;
            return this;
        }

        public ApplePayPaymentDataHeader WithEphemeralPublicKey(string ephemeralPublicKey)
        {
            EphemeralPublicKey = ephemeralPublicKey;
            return this;
        }

        public ApplePayPaymentDataHeader WithWrappedKey(string wrappedKey)
        {
            WrappedKey = wrappedKey;
            return this;
        }

        public ApplePayPaymentDataHeader WithPublicKeyHash(string publicKeyHash)
        {
            PublicKeyHash = publicKeyHash;
            return this;
        }

        public ApplePayPaymentDataHeader WithTransactionId(string transactionId)
        {
            TransactionId = transactionId;
            return this;
        }

        public override bool Equals(object obj)
        {
            return obj is ApplePayPaymentDataHeader header &&
                   ApplicationData == header.ApplicationData &&
                   EphemeralPublicKey == header.EphemeralPublicKey &&
                   WrappedKey == header.WrappedKey &&
                   PublicKeyHash == header.PublicKeyHash &&
                   TransactionId == header.TransactionId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ApplicationData, EphemeralPublicKey, WrappedKey, PublicKeyHash, TransactionId);
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class PaymentDataHeader {\n");
            sb.Append("    applicationData: ").Append(ToIndentedString(ApplicationData)).Append('\n');
            sb.Append("    ephemeralPublicKey: ").Append(ToIndentedString(EphemeralPublicKey)).Append('\n');
            sb.Append("    wrappedKey: ").Append(ToIndentedString(WrappedKey)).Append('\n');
            sb.Append("    publicKeyHash: ").Append(ToIndentedString(PublicKeyHash)).Append('\n');
            sb.Append("    transactionId: ").Append(ToIndentedString(TransactionId)).Append('\n');
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
