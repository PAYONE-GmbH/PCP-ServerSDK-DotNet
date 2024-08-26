namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Models;

public class PaymentInformationApiClient : BaseApiClient
{
    public PaymentInformationApiClient(CommunicatorConfiguration config)
        : base(config)
    {
    }

    public async Task<PaymentInformationResponse> CreatePaymentInformationAsync(string merchantId, string commerceCaseId, string checkoutId, PaymentInformationRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANTIDREQUIREDERROR);
        }

        if (string.IsNullOrEmpty(commerceCaseId))
        {
            throw new ArgumentException(COMMERCECASEIDREQUIREDERROR);
        }

        if (string.IsNullOrEmpty(checkoutId))
        {
            throw new ArgumentException(CHECKOUTIDREQUIREDERROR);
        }

        if (payload == null)
        {
            throw new ArgumentException(PAYLOADREQUIREDERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPSSCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}/{PCPPATHSEGMENTCHECKOUTS}/{checkoutId}/payment-informations",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSONCONTENTTYPE),
        };
        request.Content.Headers.ContentType = JSONMEDIATYPE;

        return await this.MakeApiCallAsync<PaymentInformationResponse>(request);
    }

    public async Task<PaymentInformationResponse> GetPaymentInformationAsync(string merchantId, string commerceCaseId, string checkoutId, string paymentInformationId)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANTIDREQUIREDERROR);
        }

        if (string.IsNullOrEmpty(commerceCaseId))
        {
            throw new ArgumentException(COMMERCECASEIDREQUIREDERROR);
        }

        if (string.IsNullOrEmpty(checkoutId))
        {
            throw new ArgumentException(CHECKOUTIDREQUIREDERROR);
        }

        if (string.IsNullOrEmpty(paymentInformationId))
        {
            throw new ArgumentException("Payment Information ID is required");
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPSSCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}/{PCPPATHSEGMENTCHECKOUTS}/{checkoutId}/payment-informations/{paymentInformationId}",
        }.Uri;

        HttpRequestMessage request = new(HttpMethod.Get, url);

        return await this.MakeApiCallAsync<PaymentInformationResponse>(request);
    }
}
