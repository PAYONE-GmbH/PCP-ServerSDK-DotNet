namespace PCPServerSDKDotNetRunner;

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
    }
}
