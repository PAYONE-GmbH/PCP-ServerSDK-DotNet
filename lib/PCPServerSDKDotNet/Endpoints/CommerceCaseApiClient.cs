namespace PCPServerSDKDotNet.Endpoints;

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCPServerSDKDotNet.Models;
using PCPServerSDKDotNet.Queries;

public class CommerceCaseApiClient : BaseApiClient
{
    public CommerceCaseApiClient(CommunicatorConfiguration config)
        : base(config)
    {
    }

    public async Task<CreateCommerceCaseResponse> CreateCommerceCaseRequestAsync(string merchantId, CreateCommerceCaseRequest payload)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANTIDREQUIREDERROR);
        }

        if (payload == null)
        {
            throw new ArgumentException(PAYLOADREQUIREDERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPSSCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Post, url)
        {
            Content = new StringContent(jsonString, System.Text.Encoding.UTF8, JSONCONTENTTYPE),
        };
        request.Content.Headers.ContentType = JSONMEDIATYPE;

        return await this.MakeApiCallAsync<CreateCommerceCaseResponse>(request);
    }

    public async Task<CommerceCaseResponse> GetCommerceCaseRequestAsync(string merchantId, string commerceCaseId)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANTIDREQUIREDERROR);
        }

        if (string.IsNullOrEmpty(commerceCaseId))
        {
            throw new ArgumentException(COMMERCECASEIDREQUIREDERROR);
        }

        Uri url = new UriBuilder
        {
            Scheme = HTTPSSCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}",
        }.Uri;

        HttpRequestMessage request = new(HttpMethod.Get, url);

        return await this.MakeApiCallAsync<CommerceCaseResponse>(request);
    }

    public async Task<List<CommerceCaseResponse>> GetCommerceCasesRequestAsync(string merchantId, GetCommerceCasesQuery? queryParams = null)
    {
        if (string.IsNullOrEmpty(merchantId))
        {
            throw new ArgumentException(MERCHANTIDREQUIREDERROR);
        }

        UriBuilder uriBuilder = new()
        {
            Scheme = HTTPSSCHEME,
            Host = this.GetConfig().Host,
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}",
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

        return await this.MakeApiCallAsync<List<CommerceCaseResponse>>(request);
    }

    public async Task UpdateCommerceCaseRequestAsync(string merchantId, string commerceCaseId, Customer payload)
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
            Path = $"{PCPPATHSEGMENTVERSION}/{merchantId}/{PCPPATHSEGMENTCOMMERCECASES}/{commerceCaseId}",
        }.Uri;

        string jsonString = JsonConvert.SerializeObject(payload);

        HttpRequestMessage request = new(HttpMethod.Patch, url)
        {
            Content = new StringContent("{\"customer\":" + jsonString + "}", System.Text.Encoding.UTF8, JSONCONTENTTYPE),
        };
        request.Content.Headers.ContentType = JSONMEDIATYPE;

        await this.MakeApiCallAsync(request);
    }
}
