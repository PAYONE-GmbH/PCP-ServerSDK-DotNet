using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models.ApplePay
{
    /// <summary>
    /// Information about the card used in the transaction.
    /// </summary>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ApplePayPaymentMethod
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("type")]
        public ApplePayPaymentMethodType Type { get; set; }

        [JsonProperty("paymentPass")]
        public string PaymentPass { get; set; }

        [JsonProperty("billingContact")]
        public ApplePayPaymentContact BillingContact { get; set; }

        public ApplePayPaymentMethod() { }

        public ApplePayPaymentMethod(string displayName, string network, ApplePayPaymentMethodType type, string paymentPass, ApplePayPaymentContact billingContact)
        {
            DisplayName = displayName;
            Network = network;
            Type = type;
            PaymentPass = paymentPass;
            BillingContact = billingContact;
        }

        public override bool Equals(object obj)
        {
            return obj is ApplePayPaymentMethod method &&
                   DisplayName == method.DisplayName &&
                   Network == method.Network &&
                   Type == method.Type &&
                   PaymentPass == method.PaymentPass &&
                   EqualityComparer<ApplePayPaymentContact>.Default.Equals(BillingContact, method.BillingContact);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DisplayName, Network, Type, PaymentPass, BillingContact);
        }

        public override string ToString()
        {
            return $"class PaymentMethod {{\n" +
                   $"    displayName: {ToIndentedString(DisplayName)}\n" +
                   $"    network: {ToIndentedString(Network)}\n" +
                   $"    type: {ToIndentedString(Type)}\n" +
                   $"    paymentPass: {ToIndentedString(PaymentPass)}\n" +
                   $"    billingContact: {ToIndentedString(BillingContact)}\n" +
                   $"}}";
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
