using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing the specific input details for mobile payments.
  /// </summary>
  [DataContract]
  public class MobilePaymentMethodSpecificInput
  {
    /// <summary>
    /// Payment product identifier - please check product documentation for a full overview of possible values.
    /// </summary>
    /// <value>Payment product identifier - please check product documentation for a full overview of possible values.</value>
    [DataMember(Name = "paymentProductId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProductId")]
    public int? PaymentProductId { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationMode
    /// </summary>
    [DataMember(Name = "authorizationMode", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "authorizationMode")]
    public AuthorizationMode? AuthorizationMode { get; set; }

    /// <summary>
    /// The payment data if we will do the decryption of the encrypted payment data. Typically you'd use encryptedCustomerInput in the root of the create payment request to provide the encrypted payment data instead.
    /// </summary>
    /// <value>The payment data if we will do the decryption of the encrypted payment data. Typically you'd use encryptedCustomerInput in the root of the create payment request to provide the encrypted payment data instead.</value>
    [DataMember(Name = "encryptedPaymentData", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "encryptedPaymentData")]
    public string? EncryptedPaymentData { get; set; }

    /// <summary>
    /// Public Key Hash A unique identifier to retrieve key used by Apple to encrypt information.
    /// </summary>
    /// <value>Public Key Hash A unique identifier to retrieve key used by Apple to encrypt information.</value>
    [DataMember(Name = "publicKeyHash", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "publicKeyHash")]
    public string? PublicKeyHash { get; set; }

    /// <summary>
    /// Ephemeral Key A unique generated key used by Apple to encrypt data.
    /// </summary>
    /// <value>Ephemeral Key A unique generated key used by Apple to encrypt data.</value>
    [DataMember(Name = "ephemeralKey", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "ephemeralKey")]
    public string? EphemeralKey { get; set; }

    /// <summary>
    /// Gets or Sets PaymentProduct302SpecificInput
    /// </summary>
    [DataMember(Name = "paymentProduct302SpecificInput", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentProduct302SpecificInput")]
    public PaymentProduct320SpecificInput? PaymentProduct302SpecificInput { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class MobilePaymentMethodSpecificInput {\n");
      sb.Append("  PaymentProductId: ").Append(PaymentProductId).Append("\n");
      sb.Append("  AuthorizationMode: ").Append(AuthorizationMode).Append("\n");
      sb.Append("  EncryptedPaymentData: ").Append(EncryptedPaymentData).Append("\n");
      sb.Append("  PublicKeyHash: ").Append(PublicKeyHash).Append("\n");
      sb.Append("  EphemeralKey: ").Append(EphemeralKey).Append("\n");
      sb.Append("  PaymentProduct302SpecificInput: ").Append(PaymentProduct302SpecificInput).Append("\n");
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
