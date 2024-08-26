using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object that holds the number of found Checkouts and the requested page of Checkouts
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class CheckoutsResponse
  {
    /// <summary>
    /// Number of found Checkouts
    /// </summary>
    /// <value>Number of found Checkouts</value>
    [DataMember(Name = "numberOfCheckouts", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "numberOfCheckouts")]
    public long? NumberOfCheckouts { get; set; }

    /// <summary>
    /// List of Checkouts
    /// </summary>
    /// <value>List of Checkouts</value>
    [DataMember(Name = "checkouts", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "checkouts")]
    public List<CheckoutResponse>? Checkouts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CheckoutsResponse {\n");
      sb.Append("  NumberOfCheckouts: ").Append(NumberOfCheckouts).Append("\n");
      sb.Append("  Checkouts: ").Append(Checkouts).Append("\n");
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
