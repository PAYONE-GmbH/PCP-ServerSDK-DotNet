namespace PCPServerSDKDotNet.Models.ApplePay
{
    using System.Text.Json.Serialization;

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

        public ApplePayPayment()
        {
        }

        public ApplePayPayment(ApplePayPaymentToken token, ApplePayPaymentContact billingContact, ApplePayPaymentContact shippingContact)
        {
            this.Token = token;
            this.BillingContact = billingContact;
            this.ShippingContact = shippingContact;
        }

        public ApplePayPayment WithToken(ApplePayPaymentToken token)
        {
            this.Token = token;
            return this;
        }

        public ApplePayPayment WithBillingContact(ApplePayPaymentContact billingContact)
        {
            this.BillingContact = billingContact;
            return this;
        }

        public ApplePayPayment WithShippingContact(ApplePayPaymentContact shippingContact)
        {
            this.ShippingContact = shippingContact;
            return this;
        }

        public override bool Equals(object obj)
        {
            return obj is ApplePayPayment payment &&
                   EqualityComparer<ApplePayPaymentToken>.Default.Equals(this.Token, payment.Token) &&
                   EqualityComparer<ApplePayPaymentContact>.Default.Equals(this.BillingContact, payment.BillingContact) &&
                   EqualityComparer<ApplePayPaymentContact>.Default.Equals(this.ShippingContact, payment.ShippingContact);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Token, this.BillingContact, this.ShippingContact);
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("    token: ").Append(this.ToIndentedString(this.Token)).Append('\n');
            sb.Append("    billingContact: ").Append(this.ToIndentedString(this.BillingContact)).Append('\n');
            sb.Append("    shippingContact: ").Append(this.ToIndentedString(this.ShippingContact)).Append('\n');
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
