using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing personal information like name, date of birth and gender.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class PersonalInformation
  {
    /// <summary>
    /// The date of birth of the customer of the recipient of the loan. Format YYYYMMDD
    /// </summary>
    /// <value>The date of birth of the customer of the recipient of the loan. Format YYYYMMDD</value>
    [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "dateOfBirth")]
    public string? DateOfBirth { get; set; }

    /// <summary>
    /// The gender of the customer, possible values are:  * MALE  * FEMALE  * UNKNOWN
    /// </summary>
    /// <value>The gender of the customer, possible values are:  * MALE  * FEMALE  * UNKNOWN</value>
    [DataMember(Name = "gender", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "gender")]
    public string? Gender { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public PersonalName? Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class PersonalInformation {\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
