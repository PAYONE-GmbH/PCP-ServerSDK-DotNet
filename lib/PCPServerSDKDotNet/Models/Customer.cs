using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// Object containing the details of a customer. 
  /// </summary>
  [DataContract]
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class Customer
  {
    /// <summary>
    /// Gets or Sets CompanyInformation
    /// </summary>
    [DataMember(Name = "companyInformation", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "companyInformation")]
    public CompanyInformation? CompanyInformation { get; set; }

    /// <summary>
    /// Unique identifier for the customer.
    /// </summary>
    /// <value>Unique identifier for the customer.</value>
    [DataMember(Name = "merchantCustomerId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "merchantCustomerId")]
    public string? MerchantCustomerId { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "billingAddress")]
    public Address? BillingAddress { get; set; }

    /// <summary>
    /// Gets or Sets ContactDetails
    /// </summary>
    [DataMember(Name = "contactDetails", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "contactDetails")]
    public ContactDetails? ContactDetails { get; set; }

    /// <summary>
    /// Fiscal registration number of the customer or the tax registration number of the company for a business customer. Please find below specifics per country:  * Brazil - Consumer (CPF) with a length of 11 digits  * Brazil - Company (CNPJ) with a length of 14 digits  * Denmark - Consumer (CPR-nummer or personnummer) with a length of 10 digits  * Finland - Consumer (Finnish: henkilötunnus (abbreviated as HETU), Swedish: personbeteckning) with a length of 11 characters  * Norway - Consumer (fødselsnummer) with a length of 11 digits  * Sweden - Consumer (personnummer) with a length of 10 or 12 digits
    /// </summary>
    /// <value>Fiscal registration number of the customer or the tax registration number of the company for a business customer. Please find below specifics per country:  * Brazil - Consumer (CPF) with a length of 11 digits  * Brazil - Company (CNPJ) with a length of 14 digits  * Denmark - Consumer (CPR-nummer or personnummer) with a length of 10 digits  * Finland - Consumer (Finnish: henkilötunnus (abbreviated as HETU), Swedish: personbeteckning) with a length of 11 characters  * Norway - Consumer (fødselsnummer) with a length of 11 digits  * Sweden - Consumer (personnummer) with a length of 10 or 12 digits</value>
    [DataMember(Name = "fiscalNumber", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "fiscalNumber")]
    public string? FiscalNumber { get; set; }

    /// <summary>
    /// Business relation to the customer. Possible values:         * B2C - Indicates business to consumer * B2B - Indicates business to business  Mandatory for the the following payment methods: * 3390 - PAYONE Secured Invoice * 3391 - PAYONE Secured Installment * 3392 - PAYONE Secured Direct Debit
    /// </summary>
    /// <value>Business relation to the customer. Possible values:         * B2C - Indicates business to consumer * B2B - Indicates business to business  Mandatory for the the following payment methods: * 3390 - PAYONE Secured Invoice * 3391 - PAYONE Secured Installment * 3392 - PAYONE Secured Direct Debit</value>
    [DataMember(Name = "businessRelation", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "businessRelation")]
    public string? BusinessRelation { get; set; }

    /// <summary>
    /// The locale that the customer should be addressed in (for 3rd parties).   Note: Only the language code is supported.
    /// </summary>
    /// <value>The locale that the customer should be addressed in (for 3rd parties).   Note: Only the language code is supported.</value>
    [DataMember(Name = "locale", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// Gets or Sets PersonalInformation
    /// </summary>
    [DataMember(Name = "personalInformation", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "personalInformation")]
    public PersonalInformation? PersonalInformation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class Customer {\n");
      sb.Append("  CompanyInformation: ").Append(CompanyInformation).Append("\n");
      sb.Append("  MerchantCustomerId: ").Append(MerchantCustomerId).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
      sb.Append("  FiscalNumber: ").Append(FiscalNumber).Append("\n");
      sb.Append("  BusinessRelation: ").Append(BusinessRelation).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  PersonalInformation: ").Append(PersonalInformation).Append("\n");
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
