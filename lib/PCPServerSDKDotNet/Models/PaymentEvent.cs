using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Detailed information regarding an occurred payment event.
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class PaymentEvent
  {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "type")]
    public PaymentType? Type { get; set; }

    /// <summary>
    /// Gets or Sets AmountOfMoney
    /// </summary>
    [DataMember(Name = "amountOfMoney", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "amountOfMoney")]
    public AmountOfMoney? AmountOfMoney { get; set; }

    /// <summary>
    /// Gets or Sets PaymentStatus
    /// </summary>
    [DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentStatus")]
    public StatusValue? PaymentStatus { get; set; }

    /// <summary>
    /// Gets or Sets CancellationReason
    /// </summary>
    [DataMember(Name = "cancellationReason", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "cancellationReason")]
    public CancellationReason? CancellationReason { get; set; }

    /// <summary>
    /// Reason of the Refund (e.g. communicated by or to the costumer).
    /// </summary>
    /// <value>Reason of the Refund (e.g. communicated by or to the costumer).</value>
    [DataMember(Name = "returnReason", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "returnReason")]
    public string? ReturnReason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class PaymentEvent {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  AmountOfMoney: ").Append(AmountOfMoney).Append("\n");
      sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
      sb.Append("  CancellationReason: ").Append(CancellationReason).Append("\n");
      sb.Append("  ReturnReason: ").Append(ReturnReason).Append("\n");
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
