using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Request to refund a payment for a Checkout. It is possible to perform multiple partial refunds by providing an amount that is lower than the total captured amount. The returnReason can be provided for reporting and reconciliation purposes but is not mandatory. 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class RefundRequest
  {
    /// <summary>
    /// Gets or Sets AmountOfMoney
    /// </summary>
    [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "amountOfMoney")]
    public PositiveAmountOfMoney? AmountOfMoney { get; set; }

    /// <summary>
    /// Gets or Sets References
    /// </summary>
    [DataMember(Name = "references", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "references")]
    public PaymentReferences? References { get; set; }

    /// <summary>
    /// Gets or Sets _Return
    /// </summary>
    [DataMember(Name = "return", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "return")]
    public ReturnInformation? _Return { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class RefundRequest {\n");
      sb.Append("  AmountOfMoney: ").Append(AmountOfMoney).Append("\n");
      sb.Append("  References: ").Append(References).Append("\n");
      sb.Append("  _Return: ").Append(_Return).Append("\n");
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
