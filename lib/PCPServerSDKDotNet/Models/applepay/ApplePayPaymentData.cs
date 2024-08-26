using System.Text.Json.Serialization;

namespace PCPServerSDKDotNet.Models.ApplePay
{
    /// <summary>
    /// An object that contains the user's payment credentials.
    /// You access the payment token of an authorized payment request using the token property of the Payment object.
    /// </summary>
    public class ApplePayPaymentData
    {

        [JsonPropertyName("data")]
        [JsonInclude]
        public string? Data { get; set; }

        [JsonPropertyName("header")]
        [JsonInclude]
        public ApplePayPaymentDataHeader? Header { get; set; }

        [JsonPropertyName("signature")]
        [JsonInclude]
        public string? Signature { get; set; }

        [JsonPropertyName("version")]
        [JsonInclude]
        public string? Version { get; set; }

        public ApplePayPaymentData() { }

        public ApplePayPaymentData(string data, ApplePayPaymentDataHeader header, string signature, string version)
        {
            Data = data;
            Header = header;
            Signature = signature;
            Version = version;
        }

        public ApplePayPaymentData WithData(string data)
        {
            Data = data;
            return this;
        }

        public ApplePayPaymentData WithHeader(ApplePayPaymentDataHeader header)
        {
            Header = header;
            return this;
        }

        public ApplePayPaymentData WithSignature(string signature)
        {
            Signature = signature;
            return this;
        }

        public ApplePayPaymentData WithVersion(string version)
        {
            Version = version;
            return this;
        }

        public override bool Equals(object obj)
        {
            return obj is ApplePayPaymentData data &&
                   Data == data.Data &&
                   EqualityComparer<ApplePayPaymentDataHeader>.Default.Equals(Header, data.Header) &&
                   Signature == data.Signature &&
                   Version == data.Version;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Data, Header, Signature, Version);
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class PaymentData {\n");
            sb.Append("    data: ").Append(ToIndentedString(Data)).Append("\n");
            sb.Append("    header: ").Append(ToIndentedString(Header)).Append("\n");
            sb.Append("    signature: ").Append(ToIndentedString(Signature)).Append("\n");
            sb.Append("    version: ").Append(ToIndentedString(Version)).Append("\n");
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
