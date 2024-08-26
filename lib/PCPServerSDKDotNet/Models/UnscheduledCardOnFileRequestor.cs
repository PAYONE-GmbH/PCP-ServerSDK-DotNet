using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Indicates which party initiated the unscheduled recurring transaction. Allowed values:   * merchantInitiated - Merchant Initiated Transaction.   * cardholderInitiated - Cardholder Initiated Transaction. Note:   * When a customer has chosen to use a token on a hosted Checkout this property is set to \&quot;cardholderInitiated\&quot;.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class UnscheduledCardOnFileRequestor
  {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class UnscheduledCardOnFileRequestor {\n");
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
