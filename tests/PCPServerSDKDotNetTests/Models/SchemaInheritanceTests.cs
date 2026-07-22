using PCPServerSDKDotNet.Models;

namespace PCPServerSDKDotNetTests.Models;

public class SchemaInheritanceTests
{
    [Theory]
    [InlineData(typeof(CartItemInput), typeof(CartItemData))]
    [InlineData(typeof(CreatePaymentIntentRequest), typeof(CreatePaymentIntent))]
    [InlineData(typeof(OrderLineDetailsPatch), typeof(OrderLineDetailsInput))]
    [InlineData(typeof(OrderLineDetailsResult), typeof(OrderLineDetailsInput))]
    [InlineData(typeof(PaymentIntentOutput), typeof(PaymentIntentResponseData))]
    [InlineData(typeof(PaymentIntentResponse), typeof(PaymentIntentResponseData))]
    [InlineData(typeof(PaymentProduct840SpecificOutput), typeof(PaymentProduct840SpecificOutputData))]
    [InlineData(typeof(PaymentProduct840SpecificOutputForIntent), typeof(PaymentProduct840SpecificOutputData))]
    [InlineData(typeof(PaymentReferencesForRefund), typeof(PaymentReferences))]
    [InlineData(typeof(RedirectPaymentProduct840SpecificInput), typeof(RedirectPaymentProduct840SpecificInputData))]
    [InlineData(typeof(ShippingAddress), typeof(AddressPersonal))]
    public void AllOfSchemas_UseTheDeclaredBaseModel(Type derivedType, Type baseType)
    {
        Assert.True(baseType.IsAssignableFrom(derivedType));
    }

    [Fact]
    public void InheritedProperties_AreSerializedWithDerivedProperties()
    {
        CreatePaymentIntentRequest request = new()
        {
            AmountOfMoney = new AmountOfMoney { Amount = 1000, CurrencyCode = "EUR" },
            PaymentMethodSpecificInput = new PaymentMethodSpecificInputForIntent(),
        };

        string json = request.ToJson();

        Assert.Contains("\"amountOfMoney\"", json);
        Assert.Contains("\"paymentMethodSpecificInput\"", json);
    }
}
