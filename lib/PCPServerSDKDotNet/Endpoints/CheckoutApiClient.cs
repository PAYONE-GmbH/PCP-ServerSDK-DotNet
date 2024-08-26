namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Queries;

public class CheckoutApiClient : BaseApiClient
{
    public CheckoutApiClient(CommunicatorConfiguration config)
        : base(config)
    {
    }

    public async Task<CreateCheckoutResponse> CreateCheckoutRequestAsync(string merchantId, string commerceCaseId, CreateCheckoutRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANTIDREQUIREDERROR);
        }

        if (string.IsNullOrEmpty(commerceCaseId))
        {
            throw new ArgumentException(COMMERCECASEIDREQUIREDERROR);
        }

        if (payload == null)
        {
            throw new ArgumentException(PAYLOADREQUIREDERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPSSCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}/{PCPPATHSEGMENTCHECKOUTS}",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSONCONTENTTYPE),
        };
        request.Content.Headers.ContentType = JSONMEDIATYPE;

        return await this.MakeApiCallAsync<CreateCheckoutResponse>(request);
    }

    public async Task<CheckoutResponse> GetCheckoutRequestAsync(string merchantId, string commerceCaseId, string checkoutId)
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

        Uri url = new UriBuilder
        {
            Scheme = HTTPSSCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}/{PCPPATHSEGMENTCHECKOUTS}/{checkoutId}",
        }.Uri;

        HttpRequestMessage request = new(HttpMethod.Get, url);

        return await this.MakeApiCallAsync<CheckoutResponse>(request);
    }

    public async Task<CheckoutsResponse> GetCheckoutsRequestAsync(string merchantId, GetCheckoutsQuery? queryParams = null)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANTIDREQUIREDERROR);
        }

        UriBuilder uriBuilder = new()
        {
            Scheme = HTTPSSCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCHECKOUTS}",
        };

        Dictionary<string, string>? queryParameters = queryParams?.ToQueryMap();
        if (queryParameters != null)
        {
            NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);
            foreach (KeyValuePair<string, string> param in queryParameters)
            {
                query[param.Key] = param.Value;
            }

            uriBuilder.Query = query.ToString();
        }

        HttpRequestMessage request = new(HttpMethod.Get, uriBuilder.Uri);

        return await this.MakeApiCallAsync<CheckoutsResponse>(request);
    }

    public async Task UpdateCheckoutRequestAsync(string merchantId, string commerceCaseId, string checkoutId, PatchCheckoutRequest payload)
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
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}/{PCPPATHSEGMENTCHECKOUTS}/{checkoutId}",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Patch, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSONCONTENTTYPE),
        };
        request.Content.Headers.ContentType = JSONMEDIATYPE;
        await this.MakeApiCallAsync(request);
    }

    public async Task RemoveCheckoutRequestAsync(string merchantId, string commerceCaseId, string checkoutId)
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

        Uri url = new UriBuilder
        {
            Scheme = HTTPSSCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}/{PCPPATHSEGMENTCHECKOUTS}/{checkoutId}",
        }.Uri;

        HttpRequestMessage request = new(HttpMethod.Delete, url);

        await this.MakeApiCallAsync(request);
    }
}
