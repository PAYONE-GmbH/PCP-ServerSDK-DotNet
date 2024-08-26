using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing additional Information needed for Apple Pay payment transactions.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class PaymentProduct320SpecificInput
  {
    /// <summary>
    /// Gets or Sets Network
    /// </summary>
    [DataMember(Name = "network", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "network")]
    public NetworkEnum? Network { get; set; }

    /// <summary>
    /// Gets or Sets Token
    /// </summary>
    [DataMember(Name = "token", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "token")]
    public ApplePaymentDataTokenInformation? Token { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class PaymentProduct320SpecificInput {\n");
      sb.Append("  Network: ").Append(Network).Append('\n');
      sb.Append("  Token: ").Append(Token).Append('\n');
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
