using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing data related to recurring.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class CardRecurrenceDetails
  {
    /// <summary>
    /// * first = This transaction is the first of a series of recurring transactions * recurring = This transaction is a subsequent transaction in a series of recurring transactions  Note: For any first of a recurring the system will automatically create a token as you will need to use a token for any subsequent recurring transactions. In case a token already exists this is indicated in the response with a value of False for the isNewToken property in the response.
    /// </summary>
    /// <value>* first = This transaction is the first of a series of recurring transactions * recurring = This transaction is a subsequent transaction in a series of recurring transactions  Note: For any first of a recurring the system will automatically create a token as you will need to use a token for any subsequent recurring transactions. In case a token already exists this is indicated in the response with a value of False for the isNewToken property in the response.</value>
    [DataMember(Name = "recurringPaymentSequenceIndicator", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "recurringPaymentSequenceIndicator")]
    public string? RecurringPaymentSequenceIndicator { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CardRecurrenceDetails {\n");
      sb.Append("  RecurringPaymentSequenceIndicator: ").Append(RecurringPaymentSequenceIndicator).Append('\n');
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
