using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing amount and ISO currency code attributes
  /// </summary>
  [DataContract]
  public class AmountOfMoney
  {
    /// <summary>
    /// Amount in cents and always having 2 decimals
    /// </summary>
    /// <value>Amount in cents and always having 2 decimals</value>
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "amount")]
    public long? Amount { get; set; }

    /// <summary>
    /// Three-letter ISO currency code representing the currency for the amount
    /// </summary>
    /// <value>Three-letter ISO currency code representing the currency for the amount</value>
    [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "currencyCode")]
    public string? CurrencyCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class AmountOfMoney {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
