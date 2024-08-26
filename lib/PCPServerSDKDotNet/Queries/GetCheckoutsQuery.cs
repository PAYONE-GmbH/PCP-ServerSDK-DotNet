using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Utils;

namespace PCPServerSDKDotNet.Queries;

public class GetCheckoutsQuery : IQueryConfig
{
    public int? Offset { get; set; }
    public int? Size { get; set; }
    public string? FromDate { get; set; }
    public string? ToDate { get; set; }
    public int? FromCheckoutAmount { get; set; }
    public int? ToCheckoutAmount { get; set; }
    public int? FromOpenAmount { get; set; }
    public int? ToOpenAmount { get; set; }
    public int? FromCollectedAmount { get; set; }
    public int? ToCollectedAmount { get; set; }
    public int? FromCancelledAmount { get; set; }
    public int? ToCancelledAmount { get; set; }
    public int? FromRefundAmount { get; set; }
    public int? ToRefundAmount { get; set; }
    public int? FromChargebackAmount { get; set; }
    public int? ToChargebackAmount { get; set; }
    public string? CheckoutId { get; set; }
    public string? MerchantReference { get; set; }
    public string? MerchantCustomerId { get; set; }
    public List<int>? IncludePaymentProductId { get; set; }
    public List<StatusCheckout>? IncludeCheckoutStatus { get; set; }
    public List<ExtendedCheckoutStatus>? IncludeExtendedCheckoutStatus { get; set; }
    public List<PaymentChannel>? IncludePaymentChannel { get; set; }
    public string? PaymentReference { get; set; }
    public string? PaymentId { get; set; }
    public string? FirstName { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? DateOfBirth { get; set; }
    public string? CompanyInformation { get; set; }

    public GetCheckoutsQuery()
    {
        // Empty constructor
        // GetCheckoutsQuery should be populated using the setter methods
    }

    public GetCheckoutsQuery SetOffset(int? offset)
    {
        Offset = offset;
        return this;
    }

    public GetCheckoutsQuery SetSize(int? size)
    {
        Size = size;
        return this;
    }

    public GetCheckoutsQuery SetFromDate(string fromDate)
    {
        FromDate = fromDate;
        return this;
    }

    public GetCheckoutsQuery SetToDate(string toDate)
    {
        ToDate = toDate;
        return this;
    }

    public GetCheckoutsQuery SetFromCheckoutAmount(int? fromCheckoutAmount)
    {
        FromCheckoutAmount = fromCheckoutAmount;
        return this;
    }

    public GetCheckoutsQuery SetToCheckoutAmount(int? toCheckoutAmount)
    {
        ToCheckoutAmount = toCheckoutAmount;
        return this;
    }

    public GetCheckoutsQuery SetFromOpenAmount(int? fromOpenAmount)
    {
        FromOpenAmount = fromOpenAmount;
        return this;
    }

    public GetCheckoutsQuery SetToOpenAmount(int? toOpenAmount)
    {
        ToOpenAmount = toOpenAmount;
        return this;
    }

    public GetCheckoutsQuery SetFromCollectedAmount(int? fromCollectedAmount)
    {
        FromCollectedAmount = fromCollectedAmount;
        return this;
    }

    public GetCheckoutsQuery SetToCollectedAmount(int? toCollectedAmount)
    {
        ToCollectedAmount = toCollectedAmount;
        return this;
    }

    public GetCheckoutsQuery SetFromCancelledAmount(int? fromCancelledAmount)
    {
        FromCancelledAmount = fromCancelledAmount;
        return this;
    }

    public GetCheckoutsQuery SetToCancelledAmount(int? toCancelledAmount)
    {
        ToCancelledAmount = toCancelledAmount;
        return this;
    }

    public GetCheckoutsQuery SetFromRefundAmount(int? fromRefundAmount)
    {
        FromRefundAmount = fromRefundAmount;
        return this;
    }

    public GetCheckoutsQuery SetToRefundAmount(int? toRefundAmount)
    {
        ToRefundAmount = toRefundAmount;
        return this;
    }

    public GetCheckoutsQuery SetFromChargebackAmount(int? fromChargebackAmount)
    {
        FromChargebackAmount = fromChargebackAmount;
        return this;
    }

    public GetCheckoutsQuery SetToChargebackAmount(int? toChargebackAmount)
    {
        ToChargebackAmount = toChargebackAmount;
        return this;
    }

    public GetCheckoutsQuery SetCheckoutId(string checkoutId)
    {
        CheckoutId = checkoutId;
        return this;
    }

    public GetCheckoutsQuery SetMerchantReference(string merchantReference)
    {
        MerchantReference = merchantReference;
        return this;
    }

    public GetCheckoutsQuery SetMerchantCustomerId(string merchantCustomerId)
    {
        MerchantCustomerId = merchantCustomerId;
        return this;
    }

    public GetCheckoutsQuery SetIncludePaymentProductId(List<int> includePaymentProductId)
    {
        IncludePaymentProductId = includePaymentProductId;
        return this;
    }

    public GetCheckoutsQuery SetIncludeCheckoutStatus(List<StatusCheckout> includeCheckoutStatus)
    {
        IncludeCheckoutStatus = includeCheckoutStatus;
        return this;
    }

    public GetCheckoutsQuery SetIncludeExtendedCheckoutStatus(List<ExtendedCheckoutStatus> includeExtendedCheckoutStatus)
    {
        IncludeExtendedCheckoutStatus = includeExtendedCheckoutStatus;
        return this;
    }

    public GetCheckoutsQuery SetIncludePaymentChannel(List<PaymentChannel> includePaymentChannel)
    {
        IncludePaymentChannel = includePaymentChannel;
        return this;
    }

    public GetCheckoutsQuery SetPaymentReference(string paymentReference)
    {
        PaymentReference = paymentReference;
        return this;
    }

    public GetCheckoutsQuery SetPaymentId(string paymentId)
    {
        PaymentId = paymentId;
        return this;
    }

    public GetCheckoutsQuery SetFirstName(string firstName)
    {
        FirstName = firstName;
        return this;
    }

    public GetCheckoutsQuery SetSurname(string surname)
    {
        Surname = surname;
        return this;
    }

    public GetCheckoutsQuery SetEmail(string email)
    {
        Email = email;
        return this;
    }

    public GetCheckoutsQuery SetPhoneNumber(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
        return this;
    }

    public GetCheckoutsQuery SetDateOfBirth(string dateOfBirth)
    {
        DateOfBirth = dateOfBirth;
        return this;
    }

    public GetCheckoutsQuery SetCompanyInformation(string companyInformation)
    {
        CompanyInformation = companyInformation;
        return this;
    }

    public Dictionary<string, string> ToQueryMap()
    {
        Dictionary<string, string> query = [];

        if (Offset.HasValue)
        {
            query.Add("offset", Offset.Value.ToString());
        }

        if (Size.HasValue)
        {
            query.Add("size", Size.Value.ToString());
        }

        if (!string.IsNullOrEmpty(FromDate))
        {
            query.Add("fromDate", FromDate);
        }

        if (!string.IsNullOrEmpty(ToDate))
        {
            query.Add("toDate", ToDate);
        }

        if (FromCheckoutAmount.HasValue)
        {
            query.Add("fromCheckoutAmount", FromCheckoutAmount.Value.ToString());
        }

        if (ToCheckoutAmount.HasValue)
        {
            query.Add("toCheckoutAmount", ToCheckoutAmount.Value.ToString());
        }

        if (FromOpenAmount.HasValue)
        {
            query.Add("fromOpenAmount", FromOpenAmount.Value.ToString());
        }

        if (ToOpenAmount.HasValue)
        {
            query.Add("toOpenAmount", ToOpenAmount.Value.ToString());
        }

        if (FromCollectedAmount.HasValue)
        {
            query.Add("fromCollectedAmount", FromCollectedAmount.Value.ToString());
        }

        if (ToCollectedAmount.HasValue)
        {
            query.Add("toCollectedAmount", ToCollectedAmount.Value.ToString());
        }

        if (FromCancelledAmount.HasValue)
        {
            query.Add("fromCancelledAmount", FromCancelledAmount.Value.ToString());
        }

        if (ToCancelledAmount.HasValue)
        {
            query.Add("toCancelledAmount", ToCancelledAmount.Value.ToString());
        }

        if (FromRefundAmount.HasValue)
        {
            query.Add("fromRefundAmount", FromRefundAmount.Value.ToString());
        }

        if (ToRefundAmount.HasValue)
        {
            query.Add("toRefundAmount", ToRefundAmount.Value.ToString());
        }

        if (FromChargebackAmount.HasValue)
        {
            query.Add("fromChargebackAmount", FromChargebackAmount.Value.ToString());
        }

        if (ToChargebackAmount.HasValue)
        {
            query.Add("toChargebackAmount", ToChargebackAmount.Value.ToString());
        }

        if (!string.IsNullOrEmpty(CheckoutId))
        {
            query.Add("checkoutId", CheckoutId);
        }

        if (!string.IsNullOrEmpty(MerchantReference))
        {
            query.Add("merchantReference", MerchantReference);
        }

        if (!string.IsNullOrEmpty(MerchantCustomerId))
        {
            query.Add("merchantCustomerId", MerchantCustomerId);
        }

        if (IncludePaymentProductId != null && IncludePaymentProductId.Count > 0)
        {
            List<string> productIdList = [];
            foreach (int productId in IncludePaymentProductId)
            {
                productIdList.Add(productId.ToString());
            }
            query.Add("includePaymentProductId", string.Join(",", productIdList));
        }

        if (IncludeCheckoutStatus != null && IncludeCheckoutStatus.Count > 0)
        {
            List<StatusCheckout> statusList = [.. IncludeCheckoutStatus];
            query.Add("includeCheckoutStatus", string.Join(",", statusList));
        }

        if (IncludeExtendedCheckoutStatus != null && IncludeExtendedCheckoutStatus.Count > 0)
        {
            List<ExtendedCheckoutStatus> statusList = [.. IncludeExtendedCheckoutStatus];
            query.Add("includeExtendedCheckoutStatus", string.Join(",", statusList));
        }

        if (IncludePaymentChannel != null && IncludePaymentChannel.Count > 0)
        {
            List<PaymentChannel> channelList = [.. IncludePaymentChannel];
            query.Add("includePaymentChannel", string.Join(",", channelList));
        }

        if (!string.IsNullOrEmpty(PaymentReference))
        {
            query.Add("paymentReference", PaymentReference);
        }

        if (!string.IsNullOrEmpty(PaymentId))
        {
            query.Add("paymentId", PaymentId);
        }

        if (!string.IsNullOrEmpty(FirstName))
        {
            query.Add("firstName", FirstName);
        }

        if (!string.IsNullOrEmpty(Surname))
        {
            query.Add("surname", Surname);
        }

        if (!string.IsNullOrEmpty(Email))
        {
            query.Add("email", Email);
        }

        if (!string.IsNullOrEmpty(PhoneNumber))
        {
            query.Add("phoneNumber", PhoneNumber);
        }

        if (!string.IsNullOrEmpty(DateOfBirth))
        {
            query.Add("dateOfBirth", DateOfBirth);
        }

        if (!string.IsNullOrEmpty(CompanyInformation))
        {
            query.Add("companyInformation", CompanyInformation);
        }

        return query;
    }
}

