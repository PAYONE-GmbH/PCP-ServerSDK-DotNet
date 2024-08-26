using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing the relevant information of a SEPA Direct Debit mandate for processing (mandatory fields in pain.008). Renamed from CreateMandateWithReturnUrl to ProcessingMandateInformation. 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class ProcessingMandateInformation
  {
    /// <summary>
    /// Gets or Sets BankAccountIban
    /// </summary>
    [DataMember(Name = "bankAccountIban", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "bankAccountIban")]
    public BankAccountInformation? BankAccountIban { get; set; }

    /// <summary>
    /// Gets or Sets RecurrenceType
    /// </summary>
    [DataMember(Name = "recurrenceType", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "recurrenceType")]
    public MandateRecurrenceType? RecurrenceType { get; set; }

    /// <summary>
    /// The unique identifier of the mandate
    /// </summary>
    /// <value>The unique identifier of the mandate</value>
    [DataMember(Name = "uniqueMandateReference", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "uniqueMandateReference")]
    public string? UniqueMandateReference { get; set; }

    /// <summary>
    /// The date of signature of the mandate. Format YYYYMMDD
    /// </summary>
    /// <value>The date of signature of the mandate. Format YYYYMMDD</value>
    [DataMember(Name = "dateOfSignature", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "dateOfSignature")]
    public string? DateOfSignature { get; set; }

    /// <summary>
    /// Your unique creditor identifier.
    /// </summary>
    /// <value>Your unique creditor identifier.</value>
    [DataMember(Name = "creditorId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "creditorId")]
    public string? CreditorId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class ProcessingMandateInformation {\n");
      sb.Append("  BankAccountIban: ").Append(BankAccountIban).Append('\n');
      sb.Append("  RecurrenceType: ").Append(RecurrenceType).Append('\n');
      sb.Append("  UniqueMandateReference: ").Append(UniqueMandateReference).Append('\n');
      sb.Append("  DateOfSignature: ").Append(DateOfSignature).Append('\n');
      sb.Append("  CreditorId: ").Append(CreditorId).Append('\n');
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
