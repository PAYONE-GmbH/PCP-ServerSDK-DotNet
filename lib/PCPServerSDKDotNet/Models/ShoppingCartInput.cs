using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Shopping cart data, including items and specific amounts. 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class ShoppingCartInput
  {
    /// <summary>
    /// Gets or Sets Items
    /// </summary>
    [DataMember(Name = "items", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "items")]
    public List<CartItemInput>? Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class ShoppingCartInput {\n");
      sb.Append("  Items: ").Append(Items).Append('\n');
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
