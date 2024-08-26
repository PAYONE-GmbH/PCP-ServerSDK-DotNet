using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Queries;

namespace PCPServerSDKDotNetTests.Queries;

public class GetCheckoutsQueryTest
{
    [Fact]
    public void ToQueryMapTest()
    {
        GetCheckoutsQuery query = new();
        query.SetOffset(1)
             .SetSize(10)
             .SetFromDate("2021-01-01")
             .SetToDate("2021-01-31")
             .SetFromCheckoutAmount(100)
             .SetToCheckoutAmount(200)
             .SetFromOpenAmount(50)
             .SetToOpenAmount(150)
             .SetFromCollectedAmount(10)
             .SetToCollectedAmount(20)
             .SetFromCancelledAmount(5)
             .SetToCancelledAmount(15)
             .SetFromRefundAmount(1)
             .SetToRefundAmount(2)
             .SetFromChargebackAmount(100)
             .SetToChargebackAmount(200)
             .SetCheckoutId("123456")
             .SetMerchantReference("7890")
             .SetMerchantCustomerId("1234")
             .SetIncludePaymentProductId([12, 456])
             .SetIncludeCheckoutStatus([StatusCheckout.Billed, StatusCheckout.Chargebacked])
             .SetIncludeExtendedCheckoutStatus([ExtendedCheckoutStatus.Open, ExtendedCheckoutStatus.Deleted])
             .SetIncludePaymentChannel([PaymentChannel.Ecommerce, PaymentChannel.Pos])
             .SetPaymentReference("1234")
             .SetPaymentId("5678")
             .SetFirstName("John")
             .SetSurname("Doe")
             .SetEmail("john.doe@example.com")
             .SetPhoneNumber("1234567890")
             .SetDateOfBirth("1980-01-01")
             .SetCompanyInformation("Company Inc.");

        Dictionary<string, string> queryMap = query.ToQueryMap();

        Assert.Equal("1", queryMap["offset"]);
        Assert.Equal("10", queryMap["size"]);
        Assert.Equal("2021-01-01", queryMap["fromDate"]);
        Assert.Equal("2021-01-31", queryMap["toDate"]);
        Assert.Equal("100", queryMap["fromCheckoutAmount"]);
        Assert.Equal("200", queryMap["toCheckoutAmount"]);
        Assert.Equal("50", queryMap["fromOpenAmount"]);
        Assert.Equal("150", queryMap["toOpenAmount"]);
        Assert.Equal("10", queryMap["fromCollectedAmount"]);
        Assert.Equal("20", queryMap["toCollectedAmount"]);
        Assert.Equal("5", queryMap["fromCancelledAmount"]);
        Assert.Equal("15", queryMap["toCancelledAmount"]);
        Assert.Equal("1", queryMap["fromRefundAmount"]);
        Assert.Equal("2", queryMap["toRefundAmount"]);
        Assert.Equal("100", queryMap["fromChargebackAmount"]);
        Assert.Equal("200", queryMap["toChargebackAmount"]);
        Assert.Equal("123456", queryMap["checkoutId"]);
        Assert.Equal("7890", queryMap["merchantReference"]);
        Assert.Equal("1234", queryMap["merchantCustomerId"]);
        Assert.Equal("12,456", queryMap["includePaymentProductId"]);
        Assert.Equal("Billed,Chargebacked", queryMap["includeCheckoutStatus"]);
        Assert.Equal("Open,Deleted", queryMap["includeExtendedCheckoutStatus"]);
        Assert.Equal("Ecommerce,Pos", queryMap["includePaymentChannel"]);
        Assert.Equal("1234", queryMap["paymentReference"]);
        Assert.Equal("5678", queryMap["paymentId"]);
        Assert.Equal("John", queryMap["firstName"]);
        Assert.Equal("Doe", queryMap["surname"]);
        Assert.Equal("john.doe@example.com", queryMap["email"]);
        Assert.Equal("1234567890", queryMap["phoneNumber"]);
        Assert.Equal("1980-01-01", queryMap["dateOfBirth"]);
        Assert.Equal("Company Inc.", queryMap["companyInformation"]);
    }

    [Fact]
    public void GettersTest()
    {
        GetCheckoutsQuery query = new();
        query.SetOffset(1)
             .SetSize(10)
             .SetFromDate("2021-01-01")
             .SetToDate("2021-01-31")
             .SetFromCheckoutAmount(100)
             .SetToCheckoutAmount(200)
             .SetFromOpenAmount(50)
             .SetToOpenAmount(150)
             .SetFromCollectedAmount(10)
             .SetToCollectedAmount(20)
             .SetFromCancelledAmount(5)
             .SetToCancelledAmount(15)
             .SetFromRefundAmount(1)
             .SetToRefundAmount(2)
             .SetFromChargebackAmount(100)
             .SetToChargebackAmount(200)
             .SetCheckoutId("123456")
             .SetMerchantReference("7890")
             .SetMerchantCustomerId("1234")
             .SetIncludePaymentProductId([12, 456])
             .SetIncludeCheckoutStatus([StatusCheckout.Billed, StatusCheckout.Chargebacked])
             .SetIncludeExtendedCheckoutStatus([ExtendedCheckoutStatus.Open, ExtendedCheckoutStatus.Deleted])
             .SetIncludePaymentChannel([PaymentChannel.Ecommerce, PaymentChannel.Pos])
             .SetPaymentReference("1234")
             .SetPaymentId("5678")
             .SetFirstName("John")
             .SetSurname("Doe")
             .SetEmail("john.doe@example.com")
             .SetPhoneNumber("1234567890")
             .SetDateOfBirth("1980-01-01")
             .SetCompanyInformation("Company Inc.");

        Assert.Equal(1, query.Offset);
        Assert.Equal(10, query.Size);
        Assert.Equal("2021-01-01", query.FromDate);
        Assert.Equal("2021-01-31", query.ToDate);
        Assert.Equal(100, query.FromCheckoutAmount);
        Assert.Equal(200, query.ToCheckoutAmount);
        Assert.Equal(50, query.FromOpenAmount);
        Assert.Equal(150, query.ToOpenAmount);
        Assert.Equal(10, query.FromCollectedAmount);
        Assert.Equal(20, query.ToCollectedAmount);
        Assert.Equal(5, query.FromCancelledAmount);
        Assert.Equal(15, query.ToCancelledAmount);
        Assert.Equal(1, query.FromRefundAmount);
        Assert.Equal(2, query.ToRefundAmount);
        Assert.Equal(100, query.FromChargebackAmount);
        Assert.Equal(200, query.ToChargebackAmount);
        Assert.Equal("123456", query.CheckoutId);
        Assert.Equal("7890", query.MerchantReference);
        Assert.Equal("1234", query.MerchantCustomerId);
        Assert.Equal([12, 456], query.IncludePaymentProductId);
        Assert.Equal([StatusCheckout.Billed, StatusCheckout.Chargebacked], query.IncludeCheckoutStatus);
        Assert.Equal([ExtendedCheckoutStatus.Open, ExtendedCheckoutStatus.Deleted], query.IncludeExtendedCheckoutStatus);
        Assert.Equal([PaymentChannel.Ecommerce, PaymentChannel.Pos], query.IncludePaymentChannel);
        Assert.Equal("1234", query.PaymentReference);
        Assert.Equal("5678", query.PaymentId);
        Assert.Equal("John", query.FirstName);
        Assert.Equal("Doe", query.Surname);
        Assert.Equal("john.doe@example.com", query.Email);
        Assert.Equal("1234567890", query.PhoneNumber);
        Assert.Equal("1980-01-01", query.DateOfBirth);
        Assert.Equal("Company Inc.", query.CompanyInformation);
    }

    [Fact]
    public void NullsTest()
    {
        GetCheckoutsQuery query = new();
        Dictionary<string, string> queryMap = query.ToQueryMap();

        Assert.Empty(queryMap);
    }
}
