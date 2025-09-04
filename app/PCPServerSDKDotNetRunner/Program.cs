namespace PCPServerSDKDotNetRunner;

using System.Linq;
using PCPServerSDKDotNet;
using PCPServerSDKDotNet.Endpoints;
using PCPServerSDKDotNet.Models;

public class Program
{
    public static async Task Main(string[] args)
    {
        // get env
        string? apiKey = Environment.GetEnvironmentVariable("API_KEY");
        string? apiSecret = Environment.GetEnvironmentVariable("API_SECRET");
        string? merchantId = Environment.GetEnvironmentVariable("MERCHANT_ID");
        string? commerceCaseId = Environment.GetEnvironmentVariable("COMMERCE_CASE_ID");
        string? checkoutId = Environment.GetEnvironmentVariable("CHECKOUT_ID");

        if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(apiSecret) || string.IsNullOrEmpty(merchantId) || string.IsNullOrEmpty(commerceCaseId) || string.IsNullOrEmpty(checkoutId))
        {
            Console.WriteLine("Please set the following environment variables: API_KEY, API_SECRET, MERCHANT_ID, COMMERCE_CASE_ID, CHECKOUT_ID");
            throw new ArgumentException("Missing environment variables");
        }

        Console.WriteLine("API_KEY: " + apiKey);
        Console.WriteLine("API_SECRET: " + apiSecret);
        Console.WriteLine("MERCHANT_ID: " + merchantId);
        Console.WriteLine("COMMERCE_CASE_ID: " + commerceCaseId);
        Console.WriteLine("CHECKOUT_ID: " + checkoutId);

        CommunicatorConfiguration config = new(apiKey, apiSecret, "api.preprod.commerce.payone.com", null);
        CheckoutApiClient client = new(config);

        CheckoutsResponse res = await client.GetCheckoutsRequestAsync(merchantId);
        Console.WriteLine(res);
        CreateCheckoutResponse res2 = await client.CreateCheckoutRequestAsync(merchantId, commerceCaseId, new CreateCheckoutRequest());
        Console.WriteLine(res2);

        // Demonstrate HTTP client customization
        await DemonstrateHttpClientCustomization(apiKey, apiSecret, merchantId, commerceCaseId);
    }

    /// <summary>
    /// Demonstrates various ways to customize the HttpClient used by the SDK
    /// </summary>
    private static async Task DemonstrateHttpClientCustomization(string apiKey, string apiSecret, string merchantId, string commerceCaseId)
    {
        Console.WriteLine("\n=== HTTP Client Customization Demo ===");

        // 1. Global HttpClient configuration
        Console.WriteLine("\n1. Global HttpClient Configuration:");
        HttpClient globalHttpClient = new HttpClient();
        globalHttpClient.Timeout = TimeSpan.FromSeconds(30);
        globalHttpClient.DefaultRequestHeaders.Add("User-Agent", "PCP-DotNet-Demo/1.0");

        CommunicatorConfiguration globalConfig = new(apiKey, apiSecret, "api.preprod.commerce.payone.com", null)
        {
            HttpClient = globalHttpClient,
        };

        CheckoutApiClient globalClient = new(globalConfig);
        Console.WriteLine("Created client with global HttpClient (30s timeout, custom User-Agent)");

        // 2. Client-specific HttpClient configuration
        Console.WriteLine("\n2. Client-Specific HttpClient Configuration:");
        HttpClient specificHttpClient = new HttpClient();
        specificHttpClient.Timeout = TimeSpan.FromSeconds(60);
        specificHttpClient.DefaultRequestHeaders.Add("X-Custom-Header", "ClientSpecific");

        CommunicatorConfiguration baseConfig = new(apiKey, apiSecret, "api.preprod.commerce.payone.com", null);
        CheckoutApiClient specificClient = new(baseConfig, specificHttpClient);
        Console.WriteLine("Created client with client-specific HttpClient (60s timeout, custom header)");

        // 3. Runtime HttpClient changes
        Console.WriteLine("\n3. Runtime HttpClient Changes:");
        CheckoutApiClient runtimeClient = new(baseConfig);
        Console.WriteLine("Created client with default HttpClient");

        HttpClient runtimeHttpClient = new HttpClient();
        runtimeHttpClient.Timeout = TimeSpan.FromSeconds(45);
        runtimeClient.SetHttpClient(runtimeHttpClient);
        Console.WriteLine("Changed to custom HttpClient at runtime (45s timeout)");

        runtimeClient.SetHttpClient(null);
        Console.WriteLine("Reset to default HttpClient configuration");

        // 4. Priority demonstration
        Console.WriteLine("\n4. Priority Demonstration:");
        HttpClient priorityGlobalClient = new HttpClient();
        priorityGlobalClient.DefaultRequestHeaders.Add("X-Source", "Global");

        HttpClient prioritySpecificClient = new HttpClient();
        prioritySpecificClient.DefaultRequestHeaders.Add("X-Source", "ClientSpecific");

        CommunicatorConfiguration priorityConfig = new(apiKey, apiSecret, "api.preprod.commerce.payone.com", null)
        {
            HttpClient = priorityGlobalClient,
        };

        CheckoutApiClient priorityClient = new(priorityConfig, prioritySpecificClient);
        Console.WriteLine("Created client with both global and client-specific HttpClients");

        // Demonstrate the priority by showing the X-Source header values
        string globalXSource = priorityGlobalClient.DefaultRequestHeaders.GetValues("X-Source").FirstOrDefault() ?? "Not set";
        string clientSpecificXSource = prioritySpecificClient.DefaultRequestHeaders.GetValues("X-Source").FirstOrDefault() ?? "Not set";

        Console.WriteLine($"Global HttpClient X-Source header: {globalXSource}");
        Console.WriteLine($"Client-specific HttpClient X-Source header: {clientSpecificXSource}");
        Console.WriteLine("Client-specific HttpClient takes priority over global configuration");

        Console.WriteLine("\n=== End of HTTP Client Customization Demo ===\n");
    }
}
