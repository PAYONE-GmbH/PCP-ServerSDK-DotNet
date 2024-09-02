namespace PCPServerSDKDotNet.Utils;

public interface IQueryConfig
{
    // Method to convert the query configuration into a dictionary of query parameters
    Dictionary<string, string> ToQueryMap();
}
