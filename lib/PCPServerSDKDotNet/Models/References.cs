using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object that holds all reference properties that are linked to this transaction.
  /// </summary>
  [DataContract]
  public class References
  {
    /// <summary>
    /// Descriptive text that is used towards to customer, either during an online Checkout at a third party and/or on the statement of the customer. For card transactions this is usually referred to as a Soft Descriptor. The maximum allowed length varies per card acquirer:  * AIB - 22 characters  * American Express - 25 characters  * Atos Origin BNP - 15 characters  * Barclays - 25 characters  * Catella - 22 characters  * CBA - 20 characters  * Elavon - 25 characters  * First Data - 25 characters  * INICIS (INIPAY) - 22-30 characters  * JCB - 25 characters  * Merchant Solutions - 22-25 characters  * Payvision (EU & HK) - 25 characters  * SEB Euroline - 22 characters  * Sub1 Argentina - 15 characters  * Wells Fargo - 25 characters  Note that we advise you to use 22 characters as the max length as beyond this our experience is that issuers will start to truncate. We currently also only allow per API call overrides for AIB and Barclays For alternative payment products the maximum allowed length varies per payment product:  * 402 e-Przelewy - 30 characters  * 404 INICIS - 80 characters  * 802 Nordea ePayment Finland - 234 characters  * 809 iDeal - 32 characters  * 836 SOFORT - 42 characters  * 840 PayPal - 127 characters  * 841 WebMoney - 175 characters  * 849 Yandex - 64 characters  * 861 Alipay - 256 characters  * 863 WeChat Pay - 32 characters  * 880 BOKU - 20 characters  * 8580 Qiwi - 255 characters  * 1504 Konbini - 80 characters  All other payment products don't support a descriptor.
    /// </summary>
    /// <value>Descriptive text that is used towards to customer, either during an online Checkout at a third party and/or on the statement of the customer. For card transactions this is usually referred to as a Soft Descriptor. The maximum allowed length varies per card acquirer:  * AIB - 22 characters  * American Express - 25 characters  * Atos Origin BNP - 15 characters  * Barclays - 25 characters  * Catella - 22 characters  * CBA - 20 characters  * Elavon - 25 characters  * First Data - 25 characters  * INICIS (INIPAY) - 22-30 characters  * JCB - 25 characters  * Merchant Solutions - 22-25 characters  * Payvision (EU & HK) - 25 characters  * SEB Euroline - 22 characters  * Sub1 Argentina - 15 characters  * Wells Fargo - 25 characters  Note that we advise you to use 22 characters as the max length as beyond this our experience is that issuers will start to truncate. We currently also only allow per API call overrides for AIB and Barclays For alternative payment products the maximum allowed length varies per payment product:  * 402 e-Przelewy - 30 characters  * 404 INICIS - 80 characters  * 802 Nordea ePayment Finland - 234 characters  * 809 iDeal - 32 characters  * 836 SOFORT - 42 characters  * 840 PayPal - 127 characters  * 841 WebMoney - 175 characters  * 849 Yandex - 64 characters  * 861 Alipay - 256 characters  * 863 WeChat Pay - 32 characters  * 880 BOKU - 20 characters  * 8580 Qiwi - 255 characters  * 1504 Konbini - 80 characters  All other payment products don't support a descriptor.</value>
    [DataMember(Name = "descriptor", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "descriptor")]
    public string? Descriptor { get; set; }

    /// <summary>
    /// The merchantReference is a unique identifier for a payment and can be used for reporting purposes. The merchantReference is required for the execution of a payment and has to be unique. In case a payment has failed the same merchantReference can be used again. Once a successful payment has been made the same merchantReference can no longer be used and will be rejected. 
    /// </summary>
    /// <value>The merchantReference is a unique identifier for a payment and can be used for reporting purposes. The merchantReference is required for the execution of a payment and has to be unique. In case a payment has failed the same merchantReference can be used again. Once a successful payment has been made the same merchantReference can no longer be used and will be rejected. </value>
    [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "merchantReference")]
    public string? MerchantReference { get; set; }

    /// <summary>
    /// It allows you to store additional parameters for the transaction in JSON format. This field must not contain any personal data.
    /// </summary>
    /// <value>It allows you to store additional parameters for the transaction in JSON format. This field must not contain any personal data.</value>
    [DataMember(Name = "merchantParameters", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "merchantParameters")]
    public string? MerchantParameters { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class References {\n");
      sb.Append("  Descriptor: ").Append(Descriptor).Append("\n");
      sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
      sb.Append("  MerchantParameters: ").Append(MerchantParameters).Append("\n");
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
