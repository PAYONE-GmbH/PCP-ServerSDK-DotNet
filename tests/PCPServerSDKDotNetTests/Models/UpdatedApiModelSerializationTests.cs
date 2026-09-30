using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PCPServerSDKDotNet.Models;

namespace PCPServerSDKDotNetTests.Models;

public class UpdatedApiModelSerializationTests
{
    [Fact]
    public void CardOnFileRequestorSerializesAsSchemaEnum()
    {
        CardPaymentMethodSpecificInput model = new()
        {
            UnscheduledCardOnFileRequestor = UnscheduledCardOnFileRequestor.MerchantInitiated,
        };

        Assert.Equal("{\"unscheduledCardOnFileRequestor\":\"merchantInitiated\"}", JsonConvert.SerializeObject(model));
    }

    [Fact]
    public void PaymentInformationResponseDeserializesPosIdentifiers()
    {
        PaymentInformationResponse? model = JsonConvert.DeserializeObject<PaymentInformationResponse>("{\"traceNumber\":\"012345\",\"receiptNumber\":\"0321\"}");

        Assert.Equal("012345", model?.TraceNumber);
        Assert.Equal("0321", model?.ReceiptNumber);
    }

    [Fact]
    public void PaymentIntentPaypalAccountDeserializesEmailAddress()
    {
        PaymentProduct840SpecificOutputForIntent? model = JsonConvert.DeserializeObject<PaymentProduct840SpecificOutputForIntent>("{\"customerAccount\":{\"emailAddress\":\"customer@example.com\"}}");

        Assert.Equal("customer@example.com", model?.CustomerAccount?.EmailAddress);
    }

    [Fact]
    public void PaypalOutputSerializesAllSchemaProperties()
    {
        PaymentProduct840SpecificOutput model = new()
        {
            BillingAddress = new Address { City = "Berlin" },
            CustomerAccount = new PaymentProduct840CustomerAccount { PayerId = "payer-1" },
            PayPalTransactionId = "transaction-1",
            ShippingAddress = new Address { City = "Hamburg" },
        };

        string json = JsonConvert.SerializeObject(model);

        Assert.Contains("\"billingAddress\"", json);
        Assert.Contains("\"customerAccount\"", json);
        Assert.Contains("\"payPalTransactionId\":\"transaction-1\"", json);
        Assert.Contains("\"shippingAddress\"", json);
    }

    [Fact]
    public void PayByLinkModelsUseSchemaPropertyNames()
    {
        CreatePayByLinkRequest model = new()
        {
            PaymentLinkSpecificInput = new()
            {
                AuthorizationMode = AuthorizationMode.Sale,
                PaymentMethods = ["840"],
            },
            OrderType = OrderType.Full,
            OrderReferences = new() { MerchantReference = "order-1" },
        };

        string json = JsonConvert.SerializeObject(model);

        Assert.Contains("\"paymentLinkSpecificInput\"", json);
        Assert.Contains("\"authorizationMode\":\"SALE\"", json);
        Assert.Contains("\"paymentMethods\":[\"840\"]", json);
        Assert.Contains("\"orderType\":\"FULL\"", json);
    }

    [Fact]
    public void PaymentIntentReferencesRequireMerchantReference()
    {
        PaymentReferencesForPaymentIntent references = new() { MerchantReference = "order-1" };

        Assert.Equal("{\"merchantReference\":\"order-1\"}", JsonConvert.SerializeObject(references));
    }

    [Fact]
    public void PatchPaymentIntentRequest_UsesOnlySchemaFields()
    {
        PatchPaymentIntentRequest request = new()
        {
            AmountOfMoney = new AmountOfMoney { Amount = 100, CurrencyCode = "EUR" },
            ShoppingCart = new ShoppingCartData { Items = [] },
        };

        Assert.Equal("{\"amountOfMoney\":{\"amount\":100,\"currencyCode\":\"EUR\"},\"shoppingCart\":{\"items\":[]}}", JsonConvert.SerializeObject(request));
    }

    [Fact]
    public void PatchPaymentIntentResponse_InheritsCreateResponseStructure()
    {
        const string json = "{\"shoppingCart\":{\"items\":[]},\"paymentIntentOutput\":{\"paymentIntentId\":\"intent\",\"redirectPaymentMethodSpecificOutput\":{\"redirectData\":{\"redirectURL\":\"https://example.com\"}}}}";

        PatchPaymentIntentResponse? response = JsonConvert.DeserializeObject<PatchPaymentIntentResponse>(json);

        Assert.NotNull(response?.ShoppingCart?.Items);
        Assert.Equal("intent", response.PaymentIntentOutput?.PaymentIntentId);
        Assert.Equal("https://example.com", response.PaymentIntentOutput?.RedirectPaymentMethodSpecificOutput?.RedirectData?.RedirectURL);
        Assert.True(JToken.DeepEquals(JToken.Parse(json), JToken.Parse(JsonConvert.SerializeObject(response))));
    }

    [Fact]
    public void CreatePaymentIntentResponse_UsesRedirectDataInsteadOfRedirectionData()
    {
        CreatePaymentIntentResponse response = new()
        {
            PaymentIntentOutput = new PaymentIntentOutput
            {
                RedirectPaymentMethodSpecificOutput = new RedirectPaymentMethodSpecificOutputForCreateIntent
                {
                    RedirectData = new RedirectData { RedirectURL = "https://example.com" },
                },
            },
        };

        string json = JsonConvert.SerializeObject(response);

        Assert.Contains("\"redirectData\":{\"redirectURL\":\"https://example.com\"}", json);
        Assert.DoesNotContain("redirectionData", json);
    }
}
