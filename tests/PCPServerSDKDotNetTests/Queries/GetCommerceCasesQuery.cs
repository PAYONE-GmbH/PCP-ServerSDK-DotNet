
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Queries;

namespace PCPServerSDKDotNetTests.Queries;

public class GetCommerceCasesQueryTest
{
    [Fact]
    public void ToQueryMapTest()
    {
        GetCommerceCasesQuery query = new GetCommerceCasesQuery();
        query.SetOffset(1)
             .SetSize(10)
             .SetFromDate("2021-01-01")
             .SetToDate("2021-01-31")
             .SetCommerceCaseId("123456")
             .SetMerchantReference("7890")
             .SetMerchantCustomerId("1234")
             .SetIncludeCheckoutStatus([StatusCheckout.Billed, StatusCheckout.Chargebacked])
             .SetIncludePaymentChannel([PaymentChannel.Ecommerce, PaymentChannel.Pos]);

        Dictionary<string, string> queryMap = query.ToQueryMap();

        Assert.Equal("1", queryMap["offset"]);
        Assert.Equal("10", queryMap["size"]);
        Assert.Equal("2021-01-01", queryMap["fromDate"]);
        Assert.Equal("2021-01-31", queryMap["toDate"]);
        Assert.Equal("123456", queryMap["commerceCaseId"]);
        Assert.Equal("7890", queryMap["merchantReference"]);
        Assert.Equal("1234", queryMap["merchantCustomerId"]);
        Assert.Equal("Billed,Chargebacked", queryMap["includeCheckoutStatus"]);
        Assert.Equal("Ecommerce,Pos", queryMap["includePaymentChannel"]);
    }

    [Fact]
    public void GettersTest()
    {
        GetCommerceCasesQuery query = new GetCommerceCasesQuery();
        query.SetOffset(1)
             .SetSize(10)
             .SetFromDate("2021-01-01")
             .SetToDate("2021-01-31")
             .SetCommerceCaseId("123456")
             .SetMerchantReference("7890")
             .SetMerchantCustomerId("1234")
             .SetIncludeCheckoutStatus([StatusCheckout.Billed, StatusCheckout.Chargebacked])
             .SetIncludePaymentChannel([PaymentChannel.Ecommerce, PaymentChannel.Pos]);

        Assert.Equal(1, query.Offset);
        Assert.Equal(10, query.Size);
        Assert.Equal("2021-01-01", query.FromDate);
        Assert.Equal("2021-01-31", query.ToDate);
        Assert.Equal("123456", query.CommerceCaseId);
        Assert.Equal("7890", query.MerchantReference);
        Assert.Equal("1234", query.MerchantCustomerId);
        Assert.Equal([StatusCheckout.Billed, StatusCheckout.Chargebacked], query.IncludeCheckoutStatus);
        Assert.Equal([PaymentChannel.Ecommerce, PaymentChannel.Pos], query.IncludePaymentChannel);
    }

    [Fact]
    public void NullsTest()
    {
        GetCommerceCasesQuery query = new GetCommerceCasesQuery();
        Dictionary<string, string> queryMap = query.ToQueryMap();

        Assert.Empty(queryMap);
    }
}
