using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// Object containing the specific input details for card payments. 
  /// </summary>
  [DataContract]
  public class CardPaymentMethodSpecificInput
  {
    /// <summary>
    /// Gets or Sets AuthorizationMode
    /// </summary>
    [DataMember(Name = "authorizationMode", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "authorizationMode")]
    public AuthorizationMode? AuthorizationMode { get; set; }

    /// <summary>
    /// Gets or Sets Recurring
    /// </summary>
    [DataMember(Name = "recurring", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "recurring")]
    public CardRecurrenceDetails? Recurring { get; set; }

    /// <summary>
    /// ID of the token to use to create the payment.
    /// </summary>
    /// <value>ID of the token to use to create the payment.</value>
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
    /// Gets or Sets TransactionChannel
    /// </summary>
    [DataMember(Name = "transactionChannel", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "transactionChannel")]
    public TransactionChannel? TransactionChannel { get; set; }

    /// <summary>
    /// Gets or Sets UnscheduledCardOnFileRequestor
    /// </summary>
    [DataMember(Name = "unscheduledCardOnFileRequestor", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "unscheduledCardOnFileRequestor")]
    public UnscheduledCardOnFileRequestor? UnscheduledCardOnFileRequestor { get; set; }

    /// <summary>
    /// Gets or Sets UnscheduledCardOnFileSequenceIndicator
    /// </summary>
    [DataMember(Name = "unscheduledCardOnFileSequenceIndicator", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "unscheduledCardOnFileSequenceIndicator")]
    public UnscheduledCardOnFileSequenceIndicator? UnscheduledCardOnFileSequenceIndicator { get; set; }

    /// <summary>
    /// Payment product identifier - please check product documentation for a full overview of possible values.
    /// </summary>
    /// <value>Payment product identifier - please check product documentation for a full overview of possible values.</value>
    [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProductId")]
    public int? PaymentProductId { get; set; }

    /// <summary>
    /// Gets or Sets Card
    /// </summary>
    [DataMember(Name = "card", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "card")]
    public CardInfo? Card { get; set; }

    /// <summary>
    /// The URL that the customer is redirect to after the payment flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the customer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process. Note: The provided URL should be absolute and contain the protocol to use, e.g. http:// or https://. For use on mobile devices a custom protocol can be used in the form of protocol://. This protocol must be registered on the device first. URLs without a protocol will be rejected.
    /// </summary>
    /// <value>The URL that the customer is redirect to after the payment flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the customer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process. Note: The provided URL should be absolute and contain the protocol to use, e.g. http:// or https://. For use on mobile devices a custom protocol can be used in the form of protocol://. This protocol must be registered on the device first. URLs without a protocol will be rejected.</value>
    [DataMember(Name = "returnUrl", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "returnUrl")]
    public string? ReturnUrl { get; set; }

    /// <summary>
    /// Period of payment occurrence for recurring and installment payments. Allowed values: * Yearly * Quarterly * Monthly  * Weekly * Daily Supported soon
    /// </summary>
    /// <value>Period of payment occurrence for recurring and installment payments. Allowed values: * Yearly * Quarterly * Monthly  * Weekly * Daily Supported soon</value>
    [DataMember(Name = "cardOnFileRecurringFrequency", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "cardOnFileRecurringFrequency")]
    public string? CardOnFileRecurringFrequency { get; set; }

    /// <summary>
    /// The end date of the last scheduled payment in a series of transactions. Format YYYYMMDD Supported soon
    /// </summary>
    /// <value>The end date of the last scheduled payment in a series of transactions. Format YYYYMMDD Supported soon</value>
    [DataMember(Name = "cardOnFileRecurringExpiration", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "cardOnFileRecurringExpiration")]
    public string? CardOnFileRecurringExpiration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CardPaymentMethodSpecificInput {\n");
      sb.Append("  AuthorizationMode: ").Append(AuthorizationMode).Append("\n");
      sb.Append("  Recurring: ").Append(Recurring).Append("\n");
      sb.Append("  PaymentProcessingToken: ").Append(PaymentProcessingToken).Append("\n");
      sb.Append("  ReportingToken: ").Append(ReportingToken).Append("\n");
      sb.Append("  TransactionChannel: ").Append(TransactionChannel).Append("\n");
      sb.Append("  UnscheduledCardOnFileRequestor: ").Append(UnscheduledCardOnFileRequestor).Append("\n");
      sb.Append("  UnscheduledCardOnFileSequenceIndicator: ").Append(UnscheduledCardOnFileSequenceIndicator).Append("\n");
      sb.Append("  PaymentProductId: ").Append(PaymentProductId).Append("\n");
      sb.Append("  Card: ").Append(Card).Append("\n");
      sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
      sb.Append("  CardOnFileRecurringFrequency: ").Append(CardOnFileRecurringFrequency).Append("\n");
      sb.Append("  CardOnFileRecurringExpiration: ").Append(CardOnFileRecurringExpiration).Append("\n");
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
