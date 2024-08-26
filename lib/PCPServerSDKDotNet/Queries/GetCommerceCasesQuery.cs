using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Utils;

namespace PCPServerSDKDotNet.Queries;

public class GetCommerceCasesQuery : IQueryConfig
{
    public int? Offset { get; private set; }
    public int? Size { get; private set; }
    public string? FromDate { get; private set; }
    public string? ToDate { get; private set; }
    public string? CommerceCaseId { get; private set; }
    public string? MerchantReference { get; private set; }
    public string? MerchantCustomerId { get; private set; }
    public List<StatusCheckout>? IncludeCheckoutStatus { get; private set; }
    public List<PaymentChannel>? IncludePaymentChannel { get; private set; }



    public GetCommerceCasesQuery SetOffset(int? offset)
    {
        Offset = offset;
        return this;
    }

    public GetCommerceCasesQuery SetSize(int? size)
    {
        Size = size;
        return this;
    }

    public GetCommerceCasesQuery SetFromDate(string fromDate)
    {
        FromDate = fromDate;
        return this;
    }

    public GetCommerceCasesQuery SetToDate(string toDate)
    {
        ToDate = toDate;
        return this;
    }

    public GetCommerceCasesQuery SetCommerceCaseId(string commerceCaseId)
    {
        CommerceCaseId = commerceCaseId;
        return this;
    }

    public GetCommerceCasesQuery SetMerchantReference(string merchantReference)
    {
        MerchantReference = merchantReference;
        return this;
    }

    public GetCommerceCasesQuery SetMerchantCustomerId(string merchantCustomerId)
    {
        MerchantCustomerId = merchantCustomerId;
        return this;
    }

    public GetCommerceCasesQuery SetIncludeCheckoutStatus(List<StatusCheckout> includeCheckoutStatus)
    {
        IncludeCheckoutStatus = includeCheckoutStatus;
        return this;
    }

    public GetCommerceCasesQuery SetIncludePaymentChannel(List<PaymentChannel> includePaymentChannel)
    {
        IncludePaymentChannel = includePaymentChannel;
        return this;
    }

    public Dictionary<string, string> ToQueryMap()
    {
        var query = new Dictionary<string, string>();

        if (Offset.HasValue)
        {
            query["offset"] = Offset.Value.ToString();
        }
        if (Size.HasValue)
        {
            query["size"] = Size.Value.ToString();
        }
        if (!string.IsNullOrEmpty(FromDate))
        {
            query["fromDate"] = FromDate;
        }
        if (!string.IsNullOrEmpty(ToDate))
        {
            query["toDate"] = ToDate;
        }
        if (!string.IsNullOrEmpty(CommerceCaseId))
        {
            query["commerceCaseId"] = CommerceCaseId;
        }
        if (!string.IsNullOrEmpty(MerchantReference))
        {
            query["merchantReference"] = MerchantReference;
        }
        if (!string.IsNullOrEmpty(MerchantCustomerId))
        {
            query["merchantCustomerId"] = MerchantCustomerId;
        }
        if (IncludeCheckoutStatus != null && IncludeCheckoutStatus.Count > 0)
        {
            var statusList = new List<StatusCheckout>();
            foreach (StatusCheckout status in IncludeCheckoutStatus)
            {
                statusList.Add(status);
            }
            query["includeCheckoutStatus"] = string.Join(",", statusList);
        }
        if (IncludePaymentChannel != null && IncludePaymentChannel.Count > 0)
        {
            var channelList = new List<PaymentChannel>();
            foreach (PaymentChannel channel in IncludePaymentChannel)
            {
                channelList.Add(channel);
            }
            query["includePaymentChannel"] = string.Join(",", channelList);
        }

        return query;
    }
}

