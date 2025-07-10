namespace PCPServerSDKDotNet.Models
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Model for authentication JWT token response.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class AuthenticationToken
    {
        /// <summary>
        /// Gets or sets the token id.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the JWT token string.
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDate")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expirationDate")]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            return $"AuthenticationToken {{ Id = {this.Id}, Token = {this.Token}, CreationDate = {this.CreationDate}, ExpirationDate = {this.ExpirationDate} }}";
        }
    }
}
