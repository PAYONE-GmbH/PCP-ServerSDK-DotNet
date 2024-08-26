using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// URL and content type information for an web resource.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class LinkInformation
  {
    /// <summary>
    /// URL of link.
    /// </summary>
    /// <value>URL of link.</value>
    [DataMember(Name = "href", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "href")]
    public string? Href { get; set; }

    /// <summary>
    /// Content type of linked data.
    /// </summary>
    /// <value>Content type of linked data.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "type")]
    public string? Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class LinkInformation {\n");
      sb.Append("  Href: ").Append(Href).Append('\n');
      sb.Append("  Type: ").Append(Type).Append('\n');
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson()
    {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

  }
}
