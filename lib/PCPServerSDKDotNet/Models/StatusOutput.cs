using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// Contains information about whether the payment of the Checkout has already been completed and how much of the total sum has been collected already.
  /// </summary>
  [DataContract]
  public class StatusOutput
  {
    /// <summary>
    /// * WAITING_FOR_PAYMENT - There does not yet exist a PaymentExecution nor a PaymentInformation for this Checkout. * PAYMENT_NOT_COMPLETED - There exists a PaymentExecution or a PaymentInformation for this Checkout, but all or some part of the total amount is still unpaid. * PAYMENT_COMPLETED - There exists a PaymentExecution or a PaymentInformation for this Checkout and the total amount is fully paid. * NO_PAYMENT - Checkout was created and deleted. No Payment Execution and no other actions can be triggered on the Checkout.
    /// </summary>
    /// <value>* WAITING_FOR_PAYMENT - There does not yet exist a PaymentExecution nor a PaymentInformation for this Checkout. * PAYMENT_NOT_COMPLETED - There exists a PaymentExecution or a PaymentInformation for this Checkout, but all or some part of the total amount is still unpaid. * PAYMENT_COMPLETED - There exists a PaymentExecution or a PaymentInformation for this Checkout and the total amount is fully paid. * NO_PAYMENT - Checkout was created and deleted. No Payment Execution and no other actions can be triggered on the Checkout.</value>
    [DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentStatus")]
    public string? PaymentStatus { get; set; }

    /// <summary>
    /// Indicates whether the Checkout can still be modified. False if any payment is already in progress, true otherwise.
    /// </summary>
    /// <value>Indicates whether the Checkout can still be modified. False if any payment is already in progress, true otherwise.</value>
    [DataMember(Name = "isModifiable", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "isModifiable")]
    public bool? IsModifiable { get; set; }

    /// <summary>
    /// Amount in cents always having 2 decimals. The amount yet to be paid.
    /// </summary>
    /// <value>Amount in cents always having 2 decimals. The amount yet to be paid.</value>
    [DataMember(Name = "openAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "openAmount")]
    public long? OpenAmount { get; set; }

    /// <summary>
    /// Amount in cents always having 2 decimals. The amount that has already been collected.
    /// </summary>
    /// <value>Amount in cents always having 2 decimals. The amount that has already been collected.</value>
    [DataMember(Name = "collectedAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "collectedAmount")]
    public long? CollectedAmount { get; set; }

    /// <summary>
    /// Amount in cents always having 2 decimals. The amount that has already been cancelled.
    /// </summary>
    /// <value>Amount in cents always having 2 decimals. The amount that has already been cancelled.</value>
    [DataMember(Name = "cancelledAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "cancelledAmount")]
    public long? CancelledAmount { get; set; }

    /// <summary>
    /// Amount in cents always having 2 decimals. Amount that has been collected but was refunded to the customer.
    /// </summary>
    /// <value>Amount in cents always having 2 decimals. Amount that has been collected but was refunded to the customer.</value>
    [DataMember(Name = "refundedAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "refundedAmount")]
    public long? RefundedAmount { get; set; }

    /// <summary>
    /// Amount in cents always having 2 decimals. Amount that has been collected but was charged back by the customer.
    /// </summary>
    /// <value>Amount in cents always having 2 decimals. Amount that has been collected but was charged back by the customer.</value>
    [DataMember(Name = "chargebackAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "chargebackAmount")]
    public long? ChargebackAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class StatusOutput {\n");
      sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
      sb.Append("  IsModifiable: ").Append(IsModifiable).Append("\n");
      sb.Append("  OpenAmount: ").Append(OpenAmount).Append("\n");
      sb.Append("  CollectedAmount: ").Append(CollectedAmount).Append("\n");
      sb.Append("  CancelledAmount: ").Append(CancelledAmount).Append("\n");
      sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
      sb.Append("  ChargebackAmount: ").Append(ChargebackAmount).Append("\n");
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
