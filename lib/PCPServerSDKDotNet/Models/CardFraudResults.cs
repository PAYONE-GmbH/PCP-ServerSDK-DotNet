using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet
{

  /// <summary>
  /// Fraud results contained in the CardFraudResults object. 
  /// </summary>
  [DataContract]
  public class CardFraudResults
  {
    /// <summary>
    ///  Result of the Address Verification Service checks. Possible values are:   * A - Address (Street) matches, Zip does not   * B - Street address match for international transactions—Postal code not verified due to incompatible  formats   * C - Street address and postal code not verified for international transaction due to incompatible formats   * D - Street address and postal code match for international transaction, cardholder name is incorrect   * E - AVS error   * F - Address does match and five digit ZIP code does match (UK only)   * G - Address information is unavailable; international transaction; non-AVS participant   * H - Billing address and postal code match, cardholder name is incorrect (Amex)   * I - Address information not verified for international transaction   * K - Cardholder name matches (Amex)   * L - Cardholder name and postal code match (Amex)   * M - Cardholder name, street address, and postal code match for international transaction   * N - No Match on Address (Street) or Zip   * O - Cardholder name and address match (Amex)   * P - Postal codes match for international transaction—Street address not verified due to incompatible formats   * Q - Billing address matches, cardholder is incorrect (Amex)   * R - Retry, System unavailable or Timed out   * S - Service not supported by issuer   * U - Address information is unavailable   * W - 9 digit Zip matches, Address (Street) does not   * X - Exact AVS Match   * Y - Address (Street) and 5 digit Zip match   * Z - 5 digit Zip matches, Address (Street) does not   * 0 - No service available
    /// </summary>
    /// <value> Result of the Address Verification Service checks. Possible values are:   * A - Address (Street) matches, Zip does not   * B - Street address match for international transactions—Postal code not verified due to incompatible  formats   * C - Street address and postal code not verified for international transaction due to incompatible formats   * D - Street address and postal code match for international transaction, cardholder name is incorrect   * E - AVS error   * F - Address does match and five digit ZIP code does match (UK only)   * G - Address information is unavailable; international transaction; non-AVS participant   * H - Billing address and postal code match, cardholder name is incorrect (Amex)   * I - Address information not verified for international transaction   * K - Cardholder name matches (Amex)   * L - Cardholder name and postal code match (Amex)   * M - Cardholder name, street address, and postal code match for international transaction   * N - No Match on Address (Street) or Zip   * O - Cardholder name and address match (Amex)   * P - Postal codes match for international transaction—Street address not verified due to incompatible formats   * Q - Billing address matches, cardholder is incorrect (Amex)   * R - Retry, System unavailable or Timed out   * S - Service not supported by issuer   * U - Address information is unavailable   * W - 9 digit Zip matches, Address (Street) does not   * X - Exact AVS Match   * Y - Address (Street) and 5 digit Zip match   * Z - 5 digit Zip matches, Address (Street) does not   * 0 - No service available</value>
    [DataMember(Name = "avsResult", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "avsResult")]
    public string? AvsResult { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CardFraudResults {\n");
      sb.Append("  AvsResult: ").Append(AvsResult).Append("\n");
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
