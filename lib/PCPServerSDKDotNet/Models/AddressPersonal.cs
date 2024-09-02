namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Object containing personal or shipping address information.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class AddressPersonal
    {
        /// <summary>
        /// Gets or sets second line of street or additional address information such as apartments and suits.
        /// </summary>
        /// <value>Second line of street or additional address information such as apartments and suits.</value>
        [DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalInfo")]
        public string? AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or sets city.
        /// </summary>
        /// <value>City.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "city")]
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets iSO 3166-1 alpha-2 country code.
        /// </summary>
        /// <value>ISO 3166-1 alpha-2 country code.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "countryCode")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets house number.
        /// </summary>
        /// <value>House number.</value>
        [DataMember(Name = "houseNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "houseNumber")]
        public string? HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets state (ISO 3166-2 subdivisions), only if country=US, CA, CN, JP, MX, BR, AR, ID, TH, IN.
        /// </summary>
        /// <value>State (ISO 3166-2 subdivisions), only if country=US, CA, CN, JP, MX, BR, AR, ID, TH, IN.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }

        /// <summary>
        /// Gets or sets street name.
        /// </summary>
        /// <value>Street name.</value>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "street")]
        public string? Street { get; set; }

        /// <summary>
        /// Gets or sets zip code.
        /// </summary>
        /// <value>Zip code.</value>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// Gets or Sets Name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public PersonalName? Name { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressPersonal {\n");
            sb.Append("  AdditionalInfo: ").Append(this.AdditionalInfo).Append('\n');
            sb.Append("  City: ").Append(this.City).Append('\n');
            sb.Append("  CountryCode: ").Append(this.CountryCode).Append('\n');
            sb.Append("  HouseNumber: ").Append(this.HouseNumber).Append('\n');
            sb.Append("  State: ").Append(this.State).Append('\n');
            sb.Append("  Street: ").Append(this.Street).Append('\n');
            sb.Append("  Zip: ").Append(this.Zip).Append('\n');
            sb.Append("  Name: ").Append(this.Name).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
