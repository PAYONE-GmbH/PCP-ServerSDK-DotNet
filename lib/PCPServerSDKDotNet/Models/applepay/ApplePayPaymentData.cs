namespace PCPServerSDKDotNet.Models.ApplePay;

using System.Text.Json.Serialization;

/// <summary>
/// An object that contains the user's payment credentials.
/// You access the payment token of an authorized payment request using the token property of the Payment object.
/// </summary>
public class ApplePayPaymentData
{
    public ApplePayPaymentData()
    {
    }

    public ApplePayPaymentData(string data, ApplePayPaymentDataHeader header, string signature, string version)
    {
        this.Data = data;
        this.Header = header;
        this.Signature = signature;
        this.Version = version;
    }

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

    public ApplePayPaymentData WithData(string data)
    {
        this.Data = data;
        return this;
    }

    public ApplePayPaymentData WithHeader(ApplePayPaymentDataHeader header)
    {
        this.Header = header;
        return this;
    }

    public ApplePayPaymentData WithSignature(string signature)
    {
        this.Signature = signature;
        return this;
    }

    public ApplePayPaymentData WithVersion(string version)
    {
        this.Version = version;
        return this;
    }

    public override bool Equals(object? obj)
    {
        return obj is ApplePayPaymentData data &&
               this.Data == data.Data &&
               EqualityComparer<ApplePayPaymentDataHeader>.Default.Equals(this.Header, data.Header) &&
               this.Signature == data.Signature &&
               this.Version == data.Version;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.Data, this.Header, this.Signature, this.Version);
    }

    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();
        sb.Append("class PaymentData {\n");
        sb.Append("    data: ").Append(this.ToIndentedString(this.Data)).Append('\n');
        sb.Append("    header: ").Append(this.ToIndentedString(this.Header)).Append('\n');
        sb.Append("    signature: ").Append(this.ToIndentedString(this.Signature)).Append('\n');
        sb.Append("    version: ").Append(this.ToIndentedString(this.Version)).Append('\n');
        sb.Append("}");
        return sb.ToString();
    }

    private string ToIndentedString(object? obj)
    {
        if (obj == null)
        {
            return "null";
        }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        return obj.ToString().Replace("\n", "\n    ");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}
