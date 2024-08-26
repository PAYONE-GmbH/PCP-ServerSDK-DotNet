using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing all data needed to redirect the customer.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class RedirectData
  {
    /// <summary>
    /// The URL that the customer should be redirected to. Be sure to redirect using the GET method
    /// </summary>
    /// <value>The URL that the customer should be redirected to. Be sure to redirect using the GET method</value>
    [DataMember(Name = "redirectURL", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "redirectURL")]
    public string? RedirectURL { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class RedirectData {\n");
      sb.Append("  RedirectURL: ").Append(RedirectURL).Append('\n');
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
