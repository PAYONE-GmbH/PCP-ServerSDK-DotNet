namespace PCPServerSDKDotNet.Transformer;

using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Models.ApplePay;

public class ApplePayTransformer
{
    private const int APPLEPAYPAYMENTPRODUCTID = 302;

    // Private constructor to prevent instantiation
    private ApplePayTransformer()
    {
    }

    public static MobilePaymentMethodSpecificInput TransformApplePayPaymentToMobilePaymentMethodSpecificInput(
        ApplePayPayment payment)
    {
        if (payment == null)
        {
            throw new ArgumentNullException(nameof(payment));
        }

        string? publicKeyHash = null;
        string? ephemeralKey = null;
        string? network = null;
        string? version = null;
        string? signature = null;
        string? transactionId = null;
        string? applicationData = null;

        if (payment?.Token?.PaymentData != null)
        {
            version = payment.Token.PaymentData.Version;
            signature = payment.Token.PaymentData.Signature;
        }

        if (payment?.Token?.PaymentData?.Header != null)
        {
            publicKeyHash = payment.Token.PaymentData.Header.PublicKeyHash;
            ephemeralKey = payment.Token.PaymentData.Header.EphemeralPublicKey;
            applicationData = payment.Token.PaymentData.Header.ApplicationData;
            transactionId = payment.Token.PaymentData.Header.TransactionId;
        }

        if (payment?.Token?.PaymentMethod != null)
        {
            network = payment.Token.PaymentMethod.Network;
        }

        MobilePaymentMethodSpecificInput input = new();
        PaymentProduct320SpecificInput paymentProduct320SpecificInput = new();
        ApplePaymentDataTokenInformation applePaymentDataTokenInformation = new();

        if (network != null)
        {
            paymentProduct320SpecificInput.Network = Enum.Parse<NetworkEnum>(network);
        }

        if (version != null)
        {
            applePaymentDataTokenInformation.Version = Enum.Parse<ApplePaymentTokenVersion>(version);
        }

        applePaymentDataTokenInformation.Signature = signature;
        applePaymentDataTokenInformation.Header = new ApplePaymentDataTokenHeaderInformation
        {
            TransactionId = transactionId,
            ApplicationData = applicationData,
        };

        paymentProduct320SpecificInput.Token = applePaymentDataTokenInformation;

        input.PaymentProductId = APPLEPAYPAYMENTPRODUCTID;
        input.PublicKeyHash = publicKeyHash;
        input.EphemeralKey = ephemeralKey;
        input.PaymentProduct302SpecificInput = paymentProduct320SpecificInput;

        return input;
    }
}
