namespace PCPServerSDKDotNet.Models.ApplePay;

using Newtonsoft.Json;

/// <summary>
/// Information about the card used in the transaction.
/// </summary>
[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public class ApplePayPaymentMethod
{
    public ApplePayPaymentMethod()
    {
    }

    public ApplePayPaymentMethod(string displayName, string network, ApplePayPaymentMethodType type, string paymentPass, ApplePayPaymentContact billingContact)
    {
        this.DisplayName = displayName;
        this.Network = network;
        this.Type = type;
        this.PaymentPass = paymentPass;
        this.BillingContact = billingContact;
    }

    [JsonProperty("displayName")]
    public string? DisplayName { get; set; }

    [JsonProperty("network")]
    public string? Network { get; set; }

    [JsonProperty("type")]
    public ApplePayPaymentMethodType? Type { get; set; }

    [JsonProperty("paymentPass")]
    public string? PaymentPass { get; set; }

    [JsonProperty("billingContact")]
    public ApplePayPaymentContact? BillingContact { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is ApplePayPaymentMethod method &&
               this.DisplayName == method.DisplayName &&
               this.Network == method.Network &&
               this.Type == method.Type &&
               this.PaymentPass == method.PaymentPass &&
               EqualityComparer<ApplePayPaymentContact>.Default.Equals(this.BillingContact, method.BillingContact);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.DisplayName, this.Network, this.Type, this.PaymentPass, this.BillingContact);
    }

    public override string ToString()
    {
        return $"class PaymentMethod {{\n" +
               $"    displayName: {this.ToIndentedString(this.DisplayName)}\n" +
               $"    network: {this.ToIndentedString(this.Network)}\n" +
               $"    type: {this.ToIndentedString(this.Type)}\n" +
               $"    paymentPass: {this.ToIndentedString(this.PaymentPass)}\n" +
               $"    billingContact: {this.ToIndentedString(this.BillingContact)}\n" +
               $"}}";
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
