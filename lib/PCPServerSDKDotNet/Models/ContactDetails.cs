using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// Object containing contact details like email address and phone number.
  /// </summary>
  [DataContract]
  public class ContactDetails
  {
    /// <summary>
    /// Email address of the customer
    /// </summary>
    /// <value>Email address of the customer</value>
    [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>
    /// Phone number of the customer
    /// </summary>
    /// <value>Phone number of the customer</value>
    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "phoneNumber")]
    public string? PhoneNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class ContactDetails {\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
