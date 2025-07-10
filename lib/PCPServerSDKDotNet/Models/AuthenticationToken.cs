namespace PCPServerSDKDotNet.Models
{
    using System;
    using System.Text.Json.Serialization;

    public class AuthenticationToken
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        [JsonPropertyName("creationDate")]
        public DateTime CreationDate { get; set; }

        [JsonPropertyName("expirationDate")]
        public DateTime ExpirationDate { get; set; }
    }
}
