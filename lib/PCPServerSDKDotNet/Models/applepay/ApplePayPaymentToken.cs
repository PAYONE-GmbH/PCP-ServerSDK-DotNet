namespace PCPServerSDKDotNet.Models.ApplePay;

using System.Text.Json.Serialization;

/// <summary>
/// An object that contains the user's payment credentials.
/// You access the payment token of an authorized payment request using the token property of the Payment object.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public class ApplePayPaymentToken
{
    public ApplePayPaymentToken()
    {
    }

    public ApplePayPaymentToken(ApplePayPaymentData paymentData, ApplePayPaymentMethod paymentMethod, string transactionIdentifier)
    {
        this.PaymentData = paymentData;
        this.PaymentMethod = paymentMethod;
        this.TransactionIdentifier = transactionIdentifier;
    }

    [JsonPropertyName("paymentData")]
    [JsonInclude]
    public ApplePayPaymentData? PaymentData { get; set; }

    [JsonPropertyName("paymentMethod")]
    [JsonInclude]
    public ApplePayPaymentMethod? PaymentMethod { get; set; }

    [JsonPropertyName("transactionIdentifier")]
    [JsonInclude]
    public string? TransactionIdentifier { get; set; }

    public ApplePayPaymentToken WithPaymentData(ApplePayPaymentData paymentData)
    {
        this.PaymentData = paymentData;
        return this;
    }

    public ApplePayPaymentToken WithPaymentMethod(ApplePayPaymentMethod paymentMethod)
    {
        this.PaymentMethod = paymentMethod;
        return this;
    }

    public ApplePayPaymentToken WithTransactionIdentifier(string transactionIdentifier)
    {
        this.TransactionIdentifier = transactionIdentifier;
        return this;
    }

    public override bool Equals(object? obj)
    {
        return obj is ApplePayPaymentToken token &&
               EqualityComparer<ApplePayPaymentData>.Default.Equals(this.PaymentData, token.PaymentData) &&
               EqualityComparer<ApplePayPaymentMethod>.Default.Equals(this.PaymentMethod, token.PaymentMethod) &&
               this.TransactionIdentifier == token.TransactionIdentifier;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.PaymentData, this.PaymentMethod, this.TransactionIdentifier);
    }

    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();
        sb.Append("class PaymentToken {\n");
        sb.Append("    paymentData: ").Append(this.ToIndentedString(this.PaymentData)).Append('\n');
        sb.Append("    paymentMethod: ").Append(this.ToIndentedString(this.PaymentMethod)).Append('\n');
        sb.Append("    transactionIdentifier: ").Append(this.ToIndentedString(this.TransactionIdentifier)).Append('\n');
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
