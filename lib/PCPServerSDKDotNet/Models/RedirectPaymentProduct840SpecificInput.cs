using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing specific input required for PayPal payments (Payment product ID 840)
  /// </summary>
  [DataContract]
  public class RedirectPaymentProduct840SpecificInput
  {
    /// <summary>
    /// Indicates whether to use PayPal Express Checkout Shortcut.  * true = When shortcut is enabled, the consumer can select a shipping address during PayPal checkout.  * false = When shortcut is disabled, the consumer cannot change the shipping address. Default value is false. Please note that this field is ignored when order.additionalInput.typeInformation.purchaseType is set to \"digital\"
    /// </summary>
    /// <value>Indicates whether to use PayPal Express Checkout Shortcut.  * true = When shortcut is enabled, the consumer can select a shipping address during PayPal checkout.  * false = When shortcut is disabled, the consumer cannot change the shipping address. Default value is false. Please note that this field is ignored when order.additionalInput.typeInformation.purchaseType is set to \"digital\"</value>
    [DataMember(Name = "addressSelectionAtPayPal", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "addressSelectionAtPayPal")]
    public bool? AddressSelectionAtPayPal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class RedirectPaymentProduct840SpecificInput {\n");
      sb.Append("  AddressSelectionAtPayPal: ").Append(AddressSelectionAtPayPal).Append("\n");
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
