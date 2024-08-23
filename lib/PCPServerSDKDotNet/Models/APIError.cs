using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// Contains detailed information on one single error.
  /// </summary>
  [DataContract]
  public class APIError
  {
    /// <summary>
    /// Error code
    /// </summary>
    /// <value>Error code</value>
    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary>
    /// Category the error belongs to. The category should give an indication of the type of error you are dealing with. Possible values: * DIRECT_PLATFORM_ERROR - indicating that a functional error has occurred in the platform. * PAYMENT_PLATFORM_ERROR - indicating that a functional error has occurred in the payment platform. * IO_ERROR - indicating that a technical error has occurred within the payment platform or between the payment platform and third party systems. * COMMERCE_PLATFORM_ERROR - indicating an error originating from the Commerce Platform. * COMMERCE_PORTAL_BACKEND_ERROR - indicating an error originating from the Commerce Portal Backend.
    /// </summary>
    /// <value>Category the error belongs to. The category should give an indication of the type of error you are dealing with. Possible values: * DIRECT_PLATFORM_ERROR - indicating that a functional error has occurred in the platform. * PAYMENT_PLATFORM_ERROR - indicating that a functional error has occurred in the payment platform. * IO_ERROR - indicating that a technical error has occurred within the payment platform or between the payment platform and third party systems. * COMMERCE_PLATFORM_ERROR - indicating an error originating from the Commerce Platform. * COMMERCE_PORTAL_BACKEND_ERROR - indicating an error originating from the Commerce Portal Backend.</value>
    [DataMember(Name = "category", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "category")]
    public string? Category { get; set; }

    /// <summary>
    /// HTTP status code for this error that can be used to determine the type of error
    /// </summary>
    /// <value>HTTP status code for this error that can be used to determine the type of error</value>
    [DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "httpStatusCode")]
    public int? HttpStatusCode { get; set; }

    /// <summary>
    /// ID of the error. This is a short human-readable message that briefly describes the error.
    /// </summary>
    /// <value>ID of the error. This is a short human-readable message that briefly describes the error.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "id")]
    public string? Id { get; set; }

    /// <summary>
    /// Human-readable error message that is not meant to be relayed to customer as it might tip off people who are trying to commit fraud
    /// </summary>
    /// <value>Human-readable error message that is not meant to be relayed to customer as it might tip off people who are trying to commit fraud</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "message")]
    public string? Message { get; set; }

    /// <summary>
    /// Returned only if the error relates to a value that was missing or incorrect.  Contains a location path to the value as a JSonata query.  Some common examples: * a.b selects the value of property b of root property a, * a[1] selects the first element of the array in root property a, * a[b='some value'] selects all elements of the array in root property a that have a property b with value 'some value'.
    /// </summary>
    /// <value>Returned only if the error relates to a value that was missing or incorrect.  Contains a location path to the value as a JSonata query.  Some common examples: * a.b selects the value of property b of root property a, * a[1] selects the first element of the array in root property a, * a[b='some value'] selects all elements of the array in root property a that have a property b with value 'some value'.</value>
    [DataMember(Name = "propertyName", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "propertyName")]
    public string? PropertyName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class APIError {\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
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
