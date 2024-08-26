namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Models;

public class PaymentExecutionApiClient : BaseApiClient
{
    private const string PAYMENTEXECUTIONIDREQUIREDERROR = "Payment Execution ID is required";
    private const string PCPPATHSEGMENTPAYMENTEXECUTIONS = "payment-executions";

    public PaymentExecutionApiClient(CommunicatorConfiguration config)
        : base(config)
    {
    }

    public async Task<CreatePaymentResponse> CreatePaymentAsync(string merchantId, string commerceCaseId, string checkoutId, PaymentExecutionRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(commerceCaseId))
        {
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(checkoutId))
        {
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        }

        if (payload == null)
        {
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/{PCPPATHSEGMENTPAYMENTEXECUTIONS}",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSON_CONTENT_TYPE),
        };
        request.Content.Headers.ContentType = JSON_MEDIA_TYPE;

        return await this.MakeApiCallAsync<CreatePaymentResponse>(request);
    }

    public async Task<CapturePaymentResponse> CapturePaymentAsync(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId, CapturePaymentRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(commerceCaseId))
        {
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(checkoutId))
        {
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(paymentExecutionId))
        {
            throw new ArgumentException(PAYMENTEXECUTIONIDREQUIREDERROR);
        }

        if (payload == null)
        {
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/{PCPPATHSEGMENTPAYMENTEXECUTIONS}/{paymentExecutionId}/capture",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSON_CONTENT_TYPE),
        };
        request.Content.Headers.ContentType = JSON_MEDIA_TYPE;

        return await this.MakeApiCallAsync<CapturePaymentResponse>(request);
    }

    public async Task<CancelPaymentResponse> CancelPaymentAsync(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId, CancelPaymentRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(commerceCaseId))
        {
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(checkoutId))
        {
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(paymentExecutionId))
        {
            throw new ArgumentException(PAYMENTEXECUTIONIDREQUIREDERROR);
        }

        if (payload == null)
        {
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/{PCPPATHSEGMENTPAYMENTEXECUTIONS}/{paymentExecutionId}/cancel",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSON_CONTENT_TYPE),
        };
        request.Content.Headers.ContentType = JSON_MEDIA_TYPE;

        return await this.MakeApiCallAsync<CancelPaymentResponse>(request);
    }

    public async Task<RefundPaymentResponse> RefundPaymentAsync(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId, RefundRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(commerceCaseId))
        {
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(checkoutId))
        {
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(paymentExecutionId))
        {
            throw new ArgumentException(PAYMENTEXECUTIONIDREQUIREDERROR);
        }

        if (payload == null)
        {
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/{PCPPATHSEGMENTPAYMENTEXECUTIONS}/{paymentExecutionId}/refund",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSON_CONTENT_TYPE),
        };
        request.Content.Headers.ContentType = JSON_MEDIA_TYPE;

        return await this.MakeApiCallAsync<RefundPaymentResponse>(request);
    }

    public async Task<CompletePaymentResponse> CompletePaymentAsync(string merchantId, string commerceCaseId, string checkoutId, string paymentExecutionId, CompletePaymentRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANT_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(commerceCaseId))
        {
            throw new ArgumentException(COMMERCE_CASE_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(checkoutId))
        {
            throw new ArgumentException(CHECKOUT_ID_REQUIRED_ERROR);
        }

        if (string.IsNullOrEmpty(paymentExecutionId))
        {
            throw new ArgumentException(PAYMENTEXECUTIONIDREQUIREDERROR);
        }

        if (payload == null)
        {
            throw new ArgumentException(PAYLOAD_REQUIRED_ERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPS_SCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCP_PATH_SEGMENT_VERSION}/{merchantId}/{PCP_PATH_SEGMENT_COMMERCE_CASES}/{commerceCaseId}/{PCP_PATH_SEGMENT_CHECKOUTS}/{checkoutId}/{PCPPATHSEGMENTPAYMENTEXECUTIONS}/{paymentExecutionId}/complete",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSON_CONTENT_TYPE),
        };
        request.Content.Headers.ContentType = JSON_MEDIA_TYPE;

        return await this.MakeApiCallAsync<CompletePaymentResponse>(request);
    }
}
