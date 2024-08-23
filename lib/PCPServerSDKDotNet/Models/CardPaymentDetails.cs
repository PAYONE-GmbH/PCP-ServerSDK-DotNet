using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Information for card payments realized at a POS.
  /// </summary>
  [DataContract]
  public class CardPaymentDetails
  {
    /// <summary>
    /// Reference to the card of the transaction.
    /// </summary>
    /// <value>Reference to the card of the transaction.</value>
    [DataMember(Name = "maskedCardNumber", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "maskedCardNumber")]
    public string? MaskedCardNumber { get; set; }

    /// <summary>
    /// ID of the token. This property is populated when the payment was done with a token.
    /// </summary>
    /// <value>ID of the token. This property is populated when the payment was done with a token.</value>
    [DataMember(Name = "paymentProcessingToken", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProcessingToken")]
    public string? PaymentProcessingToken { get; set; }

    /// <summary>
    /// Token to identify the card in the reporting.
    /// </summary>
    /// <value>Token to identify the card in the reporting.</value>
    [DataMember(Name = "reportingToken", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "reportingToken")]
    public string? ReportingToken { get; set; }

    /// <summary>
    /// Identifier for a successful authorization, reversal or refund. Usually provided by the issuer system. Only provided for card payments. 
    /// </summary>
    /// <value>Identifier for a successful authorization, reversal or refund. Usually provided by the issuer system. Only provided for card payments. </value>
    [DataMember(Name = "cardAuthorizationId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "cardAuthorizationId")]
    public string? CardAuthorizationId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CardPaymentDetails {\n");
      sb.Append("  MaskedCardNumber: ").Append(MaskedCardNumber).Append("\n");
      sb.Append("  PaymentProcessingToken: ").Append(PaymentProcessingToken).Append("\n");
      sb.Append("  ReportingToken: ").Append(ReportingToken).Append("\n");
      sb.Append("  CardAuthorizationId: ").Append(CardAuthorizationId).Append("\n");
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
