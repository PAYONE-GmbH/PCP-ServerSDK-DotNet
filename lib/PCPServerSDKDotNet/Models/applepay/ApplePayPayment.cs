using System.Text.Json.Serialization;

namespace PCPServerSDKDotNet.Models.ApplePay
{
    /// <summary>
    /// The result of authorizing a payment request that contains payment information.
    /// Data in PaymentToken is encrypted. Billing and shipping contact data are not encrypted.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public class ApplePayPayment
    {
        [JsonPropertyName("token")]
        [JsonInclude]
        public ApplePayPaymentToken? Token { get; set; }

        [JsonPropertyName("billingContact")]
        [JsonInclude]
        public ApplePayPaymentContact? BillingContact { get; set; }

        [JsonPropertyName("shippingContact")]
        [JsonInclude]
        public ApplePayPaymentContact? ShippingContact { get; set; }

        public ApplePayPayment() { }

        public ApplePayPayment(ApplePayPaymentToken token, ApplePayPaymentContact billingContact, ApplePayPaymentContact shippingContact)
        {
            Token = token;
            BillingContact = billingContact;
            ShippingContact = shippingContact;
        }

        public ApplePayPayment WithToken(ApplePayPaymentToken token)
        {
            Token = token;
            return this;
        }

        public ApplePayPayment WithBillingContact(ApplePayPaymentContact billingContact)
        {
            BillingContact = billingContact;
            return this;
        }

        public ApplePayPayment WithShippingContact(ApplePayPaymentContact shippingContact)
        {
            ShippingContact = shippingContact;
            return this;
        }

        public override bool Equals(object obj)
        {
            return obj is ApplePayPayment payment &&
                   EqualityComparer<ApplePayPaymentToken>.Default.Equals(Token, payment.Token) &&
                   EqualityComparer<ApplePayPaymentContact>.Default.Equals(BillingContact, payment.BillingContact) &&
                   EqualityComparer<ApplePayPaymentContact>.Default.Equals(ShippingContact, payment.ShippingContact);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Token, BillingContact, ShippingContact);
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("    token: ").Append(ToIndentedString(Token)).Append('\n');
            sb.Append("    billingContact: ").Append(ToIndentedString(BillingContact)).Append('\n');
            sb.Append("    shippingContact: ").Append(ToIndentedString(ShippingContact)).Append('\n');
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
