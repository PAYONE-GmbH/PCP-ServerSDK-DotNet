namespace PCPServerSDKDotNet.Queries;

using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Utils;

public class GetCheckoutsQuery : IQueryConfig
{
    public GetCheckoutsQuery()
    {
        // Empty constructor
        // GetCheckoutsQuery should be populated using the setter methods
    }

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

    public GetCheckoutsQuery SetOffset(int? offset)
    {
        this.Offset = offset;
        return this;
    }

    public GetCheckoutsQuery SetSize(int? size)
    {
        this.Size = size;
        return this;
    }

    public GetCheckoutsQuery SetFromDate(string fromDate)
    {
        this.FromDate = fromDate;
        return this;
    }

    public GetCheckoutsQuery SetToDate(string toDate)
    {
        this.ToDate = toDate;
        return this;
    }

    public GetCheckoutsQuery SetFromCheckoutAmount(int? fromCheckoutAmount)
    {
        this.FromCheckoutAmount = fromCheckoutAmount;
        return this;
    }

    public GetCheckoutsQuery SetToCheckoutAmount(int? toCheckoutAmount)
    {
        this.ToCheckoutAmount = toCheckoutAmount;
        return this;
    }

    public GetCheckoutsQuery SetFromOpenAmount(int? fromOpenAmount)
    {
        this.FromOpenAmount = fromOpenAmount;
        return this;
    }

    public GetCheckoutsQuery SetToOpenAmount(int? toOpenAmount)
    {
        this.ToOpenAmount = toOpenAmount;
        return this;
    }

    public GetCheckoutsQuery SetFromCollectedAmount(int? fromCollectedAmount)
    {
        this.FromCollectedAmount = fromCollectedAmount;
        return this;
    }

    public GetCheckoutsQuery SetToCollectedAmount(int? toCollectedAmount)
    {
        this.ToCollectedAmount = toCollectedAmount;
        return this;
    }

    public GetCheckoutsQuery SetFromCancelledAmount(int? fromCancelledAmount)
    {
        this.FromCancelledAmount = fromCancelledAmount;
        return this;
    }

    public GetCheckoutsQuery SetToCancelledAmount(int? toCancelledAmount)
    {
        this.ToCancelledAmount = toCancelledAmount;
        return this;
    }

    public GetCheckoutsQuery SetFromRefundAmount(int? fromRefundAmount)
    {
        this.FromRefundAmount = fromRefundAmount;
        return this;
    }

    public GetCheckoutsQuery SetToRefundAmount(int? toRefundAmount)
    {
        this.ToRefundAmount = toRefundAmount;
        return this;
    }

    public GetCheckoutsQuery SetFromChargebackAmount(int? fromChargebackAmount)
    {
        this.FromChargebackAmount = fromChargebackAmount;
        return this;
    }

    public GetCheckoutsQuery SetToChargebackAmount(int? toChargebackAmount)
    {
        this.ToChargebackAmount = toChargebackAmount;
        return this;
    }

    public GetCheckoutsQuery SetCheckoutId(string checkoutId)
    {
        this.CheckoutId = checkoutId;
        return this;
    }

    public GetCheckoutsQuery SetMerchantReference(string merchantReference)
    {
        this.MerchantReference = merchantReference;
        return this;
    }

    public GetCheckoutsQuery SetMerchantCustomerId(string merchantCustomerId)
    {
        this.MerchantCustomerId = merchantCustomerId;
        return this;
    }

    public GetCheckoutsQuery SetIncludePaymentProductId(List<int> includePaymentProductId)
    {
        this.IncludePaymentProductId = includePaymentProductId;
        return this;
    }

    public GetCheckoutsQuery SetIncludeCheckoutStatus(List<StatusCheckout> includeCheckoutStatus)
    {
        this.IncludeCheckoutStatus = includeCheckoutStatus;
        return this;
    }

    public GetCheckoutsQuery SetIncludeExtendedCheckoutStatus(List<ExtendedCheckoutStatus> includeExtendedCheckoutStatus)
    {
        this.IncludeExtendedCheckoutStatus = includeExtendedCheckoutStatus;
        return this;
    }

    public GetCheckoutsQuery SetIncludePaymentChannel(List<PaymentChannel> includePaymentChannel)
    {
        this.IncludePaymentChannel = includePaymentChannel;
        return this;
    }

    public GetCheckoutsQuery SetPaymentReference(string paymentReference)
    {
        this.PaymentReference = paymentReference;
        return this;
    }

    public GetCheckoutsQuery SetPaymentId(string paymentId)
    {
        this.PaymentId = paymentId;
        return this;
    }

    public GetCheckoutsQuery SetFirstName(string firstName)
    {
        this.FirstName = firstName;
        return this;
    }

    public GetCheckoutsQuery SetSurname(string surname)
    {
        this.Surname = surname;
        return this;
    }

    public GetCheckoutsQuery SetEmail(string email)
    {
        this.Email = email;
        return this;
    }

    public GetCheckoutsQuery SetPhoneNumber(string phoneNumber)
    {
        this.PhoneNumber = phoneNumber;
        return this;
    }

    public GetCheckoutsQuery SetDateOfBirth(string dateOfBirth)
    {
        this.DateOfBirth = dateOfBirth;
        return this;
    }

    public GetCheckoutsQuery SetCompanyInformation(string companyInformation)
    {
        this.CompanyInformation = companyInformation;
        return this;
    }

    public Dictionary<string, string> ToQueryMap()
    {
        Dictionary<string, string> query = new();

        if (this.Offset.HasValue)
        {
            query.Add("offset", this.Offset.Value.ToString());
        }

        if (this.Size.HasValue)
        {
            query.Add("size", this.Size.Value.ToString());
        }

        if (!string.IsNullOrEmpty(this.FromDate))
        {
            query.Add("fromDate", this.FromDate);
        }

        if (!string.IsNullOrEmpty(this.ToDate))
        {
            query.Add("toDate", this.ToDate);
        }

        if (this.FromCheckoutAmount.HasValue)
        {
            query.Add("fromCheckoutAmount", this.FromCheckoutAmount.Value.ToString());
        }

        if (this.ToCheckoutAmount.HasValue)
        {
            query.Add("toCheckoutAmount", this.ToCheckoutAmount.Value.ToString());
        }

        if (this.FromOpenAmount.HasValue)
        {
            query.Add("fromOpenAmount", this.FromOpenAmount.Value.ToString());
        }

        if (this.ToOpenAmount.HasValue)
        {
            query.Add("toOpenAmount", this.ToOpenAmount.Value.ToString());
        }

        if (this.FromCollectedAmount.HasValue)
        {
            query.Add("fromCollectedAmount", this.FromCollectedAmount.Value.ToString());
        }

        if (this.ToCollectedAmount.HasValue)
        {
            query.Add("toCollectedAmount", this.ToCollectedAmount.Value.ToString());
        }

        if (this.FromCancelledAmount.HasValue)
        {
            query.Add("fromCancelledAmount", this.FromCancelledAmount.Value.ToString());
        }

        if (this.ToCancelledAmount.HasValue)
        {
            query.Add("toCancelledAmount", this.ToCancelledAmount.Value.ToString());
        }

        if (this.FromRefundAmount.HasValue)
        {
            query.Add("fromRefundAmount", this.FromRefundAmount.Value.ToString());
        }

        if (this.ToRefundAmount.HasValue)
        {
            query.Add("toRefundAmount", this.ToRefundAmount.Value.ToString());
        }

        if (this.FromChargebackAmount.HasValue)
        {
            query.Add("fromChargebackAmount", this.FromChargebackAmount.Value.ToString());
        }

        if (this.ToChargebackAmount.HasValue)
        {
            query.Add("toChargebackAmount", this.ToChargebackAmount.Value.ToString());
        }

        if (!string.IsNullOrEmpty(this.CheckoutId))
        {
            query.Add("checkoutId", this.CheckoutId);
        }

        if (!string.IsNullOrEmpty(this.MerchantReference))
        {
            query.Add("merchantReference", this.MerchantReference);
        }

        if (!string.IsNullOrEmpty(this.MerchantCustomerId))
        {
            query.Add("merchantCustomerId", this.MerchantCustomerId);
        }

        if (this.IncludePaymentProductId != null && this.IncludePaymentProductId.Count > 0)
        {
            List<string> productIdList = new();
            foreach (int productId in this.IncludePaymentProductId)
            {
                productIdList.Add(productId.ToString());
            }

            query.Add("includePaymentProductId", string.Join(",", productIdList));
        }

        if (this.IncludeCheckoutStatus != null && this.IncludeCheckoutStatus.Count > 0)
        {
            List<StatusCheckout> statusList = new(this.IncludeCheckoutStatus);
            query.Add("includeCheckoutStatus", string.Join(",", statusList));
        }

        if (this.IncludeExtendedCheckoutStatus != null && this.IncludeExtendedCheckoutStatus.Count > 0)
        {
            List<ExtendedCheckoutStatus> statusList = new(this.IncludeExtendedCheckoutStatus);
            query.Add("includeExtendedCheckoutStatus", string.Join(",", statusList));
        }

        if (this.IncludePaymentChannel != null && this.IncludePaymentChannel.Count > 0)
        {
            List<PaymentChannel> channelList = new(this.IncludePaymentChannel);
            query.Add("includePaymentChannel", string.Join(",", channelList));
        }

        if (!string.IsNullOrEmpty(this.PaymentReference))
        {
            query.Add("paymentReference", this.PaymentReference);
        }

        if (!string.IsNullOrEmpty(this.PaymentId))
        {
            query.Add("paymentId", this.PaymentId);
        }

        if (!string.IsNullOrEmpty(this.FirstName))
        {
            query.Add("firstName", this.FirstName);
        }

        if (!string.IsNullOrEmpty(this.Surname))
        {
            query.Add("surname", this.Surname);
        }

        if (!string.IsNullOrEmpty(this.Email))
        {
            query.Add("email", this.Email);
        }

        if (!string.IsNullOrEmpty(this.PhoneNumber))
        {
            query.Add("phoneNumber", this.PhoneNumber);
        }

        if (!string.IsNullOrEmpty(this.DateOfBirth))
        {
            query.Add("dateOfBirth", this.DateOfBirth);
        }

        if (!string.IsNullOrEmpty(this.CompanyInformation))
        {
            query.Add("companyInformation", this.CompanyInformation);
        }

        return query;
    }
}
