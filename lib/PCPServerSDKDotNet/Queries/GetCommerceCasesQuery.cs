namespace PCPServerSDKDotNet.Queries;

using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Utils;

public class GetCommerceCasesQuery : IQueryConfig
{
    public GetCommerceCasesQuery()
    {
        // Empty constructor
        // GetCheckoutsQuery should be populated using the setter methods
    }

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
        this.Offset = offset;
        return this;
    }

    public GetCommerceCasesQuery SetSize(int? size)
    {
        this.Size = size;
        return this;
    }

    public GetCommerceCasesQuery SetFromDate(string fromDate)
    {
        this.FromDate = fromDate;
        return this;
    }

    public GetCommerceCasesQuery SetToDate(string toDate)
    {
        this.ToDate = toDate;
        return this;
    }

    public GetCommerceCasesQuery SetCommerceCaseId(string commerceCaseId)
    {
        this.CommerceCaseId = commerceCaseId;
        return this;
    }

    public GetCommerceCasesQuery SetMerchantReference(string merchantReference)
    {
        this.MerchantReference = merchantReference;
        return this;
    }

    public GetCommerceCasesQuery SetMerchantCustomerId(string merchantCustomerId)
    {
        this.MerchantCustomerId = merchantCustomerId;
        return this;
    }

    public GetCommerceCasesQuery SetIncludeCheckoutStatus(List<StatusCheckout> includeCheckoutStatus)
    {
        this.IncludeCheckoutStatus = includeCheckoutStatus;
        return this;
    }

    public GetCommerceCasesQuery SetIncludePaymentChannel(List<PaymentChannel> includePaymentChannel)
    {
        this.IncludePaymentChannel = includePaymentChannel;
        return this;
    }

    public Dictionary<string, string> ToQueryMap()
    {
        Dictionary<string, string> query = [];

        if (this.Offset.HasValue)
        {
            query["offset"] = this.Offset.Value.ToString();
        }

        if (this.Size.HasValue)
        {
            query["size"] = this.Size.Value.ToString();
        }

        if (!string.IsNullOrEmpty(this.FromDate))
        {
            query["fromDate"] = this.FromDate;
        }

        if (!string.IsNullOrEmpty(this.ToDate))
        {
            query["toDate"] = this.ToDate;
        }

        if (!string.IsNullOrEmpty(this.CommerceCaseId))
        {
            query["commerceCaseId"] = this.CommerceCaseId;
        }

        if (!string.IsNullOrEmpty(this.MerchantReference))
        {
            query["merchantReference"] = this.MerchantReference;
        }

        if (!string.IsNullOrEmpty(this.MerchantCustomerId))
        {
            query["merchantCustomerId"] = this.MerchantCustomerId;
        }

        if (this.IncludeCheckoutStatus != null && this.IncludeCheckoutStatus.Count > 0)
        {
            List<StatusCheckout> statusList = [.. this.IncludeCheckoutStatus];
            query["includeCheckoutStatus"] = string.Join(",", statusList);
        }

        if (this.IncludePaymentChannel != null && this.IncludePaymentChannel.Count > 0)
        {
            List<PaymentChannel> channelList = [.. this.IncludePaymentChannel];
            query["includePaymentChannel"] = string.Join(",", channelList);
        }

        return query;
    }
}
