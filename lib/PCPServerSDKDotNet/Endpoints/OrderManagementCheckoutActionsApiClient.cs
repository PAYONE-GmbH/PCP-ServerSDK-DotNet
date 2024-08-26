namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Models;

public class OrderManagementCheckoutActionsApiClient : BaseApiClient
{
    public OrderManagementCheckoutActionsApiClient(CommunicatorConfiguration config)
        : base(config)
    {
    }

    public async Task<OrderResponse> CreateOrderAsync(string merchantId, string commerceCaseId, string checkoutId, OrderRequest payload)
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
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}/{PCPPATHSEGMENTCHECKOUTS}/{checkoutId}/order",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSONCONTENTTYPE),
        };
        request.Content.Headers.ContentType = JSONMEDIATYPE;

        return await this.MakeApiCallAsync<OrderResponse>(request);
    }

    public async Task<DeliverResponse> DeliverOrderAsync(string merchantId, string commerceCaseId, string checkoutId, DeliverRequest payload)
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
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}/{PCPPATHSEGMENTCHECKOUTS}/{checkoutId}/deliver",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSONCONTENTTYPE),
        };
        request.Content.Headers.ContentType = JSONMEDIATYPE;

        return await this.MakeApiCallAsync<DeliverResponse>(request);
    }

    public async Task<ReturnResponse> ReturnOrderAsync(string merchantId, string commerceCaseId, string checkoutId, ReturnRequest payload)
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
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}/{PCPPATHSEGMENTCHECKOUTS}/{checkoutId}/return",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSONCONTENTTYPE),
        };
        request.Content.Headers.ContentType = JSONMEDIATYPE;

        return await this.MakeApiCallAsync<ReturnResponse>(request);
    }

    public async Task<CancelResponse> CancelOrderAsync(string merchantId, string commerceCaseId, string checkoutId, CancelRequest payload)
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
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}/{PCPPATHSEGMENTCHECKOUTS}/{checkoutId}/cancel",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSONCONTENTTYPE),
        };
        request.Content.Headers.ContentType = JSONMEDIATYPE;

        return await this.MakeApiCallAsync<CancelResponse>(request);
    }
}
