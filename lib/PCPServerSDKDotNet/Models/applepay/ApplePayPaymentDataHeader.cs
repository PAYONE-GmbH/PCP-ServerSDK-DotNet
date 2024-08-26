namespace PCPServerSDKDotNet.Models.ApplePay
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// PaymentDataHeader contains the payment data header information.
    /// This includes various keys and identifiers used in the Apple Pay payment process.
    /// </summary>
    public class ApplePayPaymentDataHeader
    {
        public ApplePayPaymentDataHeader()
        {
        }

        public ApplePayPaymentDataHeader(string applicationData, string ephemeralPublicKey, string wrappedKey, string publicKeyHash, string transactionId)
        {
            this.ApplicationData = applicationData;
            this.EphemeralPublicKey = ephemeralPublicKey;
            this.WrappedKey = wrappedKey;
            this.PublicKeyHash = publicKeyHash;
            this.TransactionId = transactionId;
        }

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

        public ApplePayPaymentDataHeader WithApplicationData(string applicationData)
        {
            this.ApplicationData = applicationData;
            return this;
        }

        public ApplePayPaymentDataHeader WithEphemeralPublicKey(string ephemeralPublicKey)
        {
            this.EphemeralPublicKey = ephemeralPublicKey;
            return this;
        }

        public ApplePayPaymentDataHeader WithWrappedKey(string wrappedKey)
        {
            this.WrappedKey = wrappedKey;
            return this;
        }

        public ApplePayPaymentDataHeader WithPublicKeyHash(string publicKeyHash)
        {
            this.PublicKeyHash = publicKeyHash;
            return this;
        }

        public ApplePayPaymentDataHeader WithTransactionId(string transactionId)
        {
            this.TransactionId = transactionId;
            return this;
        }

        public override bool Equals(object obj)
        {
            return obj is ApplePayPaymentDataHeader header &&
                   this.ApplicationData == header.ApplicationData &&
                   this.EphemeralPublicKey == header.EphemeralPublicKey &&
                   this.WrappedKey == header.WrappedKey &&
                   this.PublicKeyHash == header.PublicKeyHash &&
                   this.TransactionId == header.TransactionId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.ApplicationData, this.EphemeralPublicKey, this.WrappedKey, this.PublicKeyHash, this.TransactionId);
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class PaymentDataHeader {\n");
            sb.Append("    applicationData: ").Append(this.ToIndentedString(this.ApplicationData)).Append('\n');
            sb.Append("    ephemeralPublicKey: ").Append(this.ToIndentedString(this.EphemeralPublicKey)).Append('\n');
            sb.Append("    wrappedKey: ").Append(this.ToIndentedString(this.WrappedKey)).Append('\n');
            sb.Append("    publicKeyHash: ").Append(this.ToIndentedString(this.PublicKeyHash)).Append('\n');
            sb.Append("    transactionId: ").Append(this.ToIndentedString(this.TransactionId)).Append('\n');
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
