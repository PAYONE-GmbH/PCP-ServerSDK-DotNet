
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Indicates which payment endpoints can be used for the respective Checkout.
  /// The system offers two alternatives to trigger a payment and consecutive events: 
  /// OrderManagementCheckoutActions or the Payment Execution resource. Both alternatives 
  /// can be used simultaneously but once one of the Payment Execution endpoints is used 
  /// the Order Management endpoints can no longer be used for that Checkout since it is 
  /// no longer possible to match payment events to items of the Checkout. There are two 
  /// exceptions to this rule: The Complete and Pause request do not limit the use of 
  /// the OrderManagementCheckoutActions.
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum AllowedPaymentActions
  {
    [JsonProperty("ORDER_MANAGEMENT")]
    [EnumMember(Value = "ORDER_MANAGEMENT")]
    OrderManagement,

    [JsonProperty("PAYMENT_EXECUTION")]
    [EnumMember(Value = "PAYMENT_EXECUTION")]
    PaymentExecution
  }
}
