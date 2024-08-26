namespace PCPServerSDKDotNetTests.Transformer;

using Newtonsoft.Json;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Models.ApplePay;
using PCPServerSDKDotNet.Transformer;

public class ApplePayTransformerTest
{
    [Fact]
    public void TestApplePayPaymentToMobilePaymentMethodSpecificInput()
    {
        ApplePayPayment payment = new()
        {
            Token = new ApplePayPaymentToken
            {
                PaymentData = new ApplePayPaymentData
                {
                    Data = "data",
                    Header = new ApplePayPaymentDataHeader
                    {
                        ApplicationData = null,
                        PublicKeyHash = "hashhashhash",
                        TransactionId = "transaction-101"
                    },
                    Signature = null,
                    Version = null
                },
                PaymentMethod = new ApplePayPaymentMethod
                {
                    DisplayName = "The name is...",
                    Network = "Mastercard",
                    Type = ApplePayPaymentMethodType.Credit,
                    PaymentPass = null,
                    BillingContact = null
                },
                TransactionIdentifier = "transaction-101-cc"
            },
            BillingContact = new ApplePayPaymentContact
            {
                PhoneNumber = "+1239452324",
                EmailAddress = "mail@imail.com",
                GivenName = "John",
                FamilyName = "Michell",
                PhoneticGivenName = "",
                PhoneticFamilyName = "",
                AddressLines = new List<string> { "Alarichtstraße 12" },
                Locality = "Berlin",
                PostalCode = "12105",
                SubAdministrativeArea = ""
            },
            ShippingContact = null
        };

        MobilePaymentMethodSpecificInput expected = new()
        {
            PaymentProductId = 302,
            PublicKeyHash = "hashhashhash",
            EphemeralKey = null,
            PaymentProduct302SpecificInput = new PaymentProduct320SpecificInput
            {
                Network = NetworkEnum.Mastercard,
                Token = new ApplePaymentDataTokenInformation
                {
                    Signature = null,
                    Header = new ApplePaymentDataTokenHeaderInformation
                    {
                        TransactionId = "transaction-101",
                        ApplicationData = null
                    }
                }
            }
        };

        MobilePaymentMethodSpecificInput result = ApplePayTransformer.TransformApplePayPaymentToMobilePaymentMethodSpecificInput(payment);

        Assert.Equal(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(result));
    }
}
