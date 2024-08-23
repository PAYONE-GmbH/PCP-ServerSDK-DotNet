using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models
{

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InstallmentOption
  {
    /// <summary>
    /// Installment option Identifier. Use this in the Complete Payment for the selected installment option.
    /// </summary>
    /// <value>Installment option Identifier. Use this in the Complete Payment for the selected installment option.</value>
    [DataMember(Name = "installmentOptionId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "installmentOptionId")]
    public string? InstallmentOptionId { get; set; }

    /// <summary>
    /// The number of monthly payments for this installment.
    /// </summary>
    /// <value>The number of monthly payments for this installment.</value>
    [DataMember(Name = "numberOfPayments", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "numberOfPayments")]
    public int? NumberOfPayments { get; set; }

    /// <summary>
    /// Monthly rate amount.
    /// </summary>
    /// <value>Monthly rate amount.</value>
    [DataMember(Name = "monthlyAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "monthlyAmount")]
    public AllOfInstallmentOptionMonthlyAmount? MonthlyAmount { get; set; }

    /// <summary>
    /// Last rate amount.
    /// </summary>
    /// <value>Last rate amount.</value>
    [DataMember(Name = "lastRateAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "lastRateAmount")]
    public AllOfInstallmentOptionLastRateAmount? LastRateAmount { get; set; }

    /// <summary>
    /// Effective interest amount in percent with two decimals.
    /// </summary>
    /// <value>Effective interest amount in percent with two decimals.</value>
    [DataMember(Name = "effectiveInterestRate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "effectiveInterestRate")]
    public int? EffectiveInterestRate { get; set; }

    /// <summary>
    /// Nominal interest amount in percent with two decimals.
    /// </summary>
    /// <value>Nominal interest amount in percent with two decimals.</value>
    [DataMember(Name = "nominalInterestRate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "nominalInterestRate")]
    public int? NominalInterestRate { get; set; }

    /// <summary>
    /// Total rate amount.
    /// </summary>
    /// <value>Total rate amount.</value>
    [DataMember(Name = "totalAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "totalAmount")]
    public AllOfInstallmentOptionTotalAmount? TotalAmount { get; set; }

    /// <summary>
    /// Due date of first rate. Format: YYYYMMDD
    /// </summary>
    /// <value>Due date of first rate. Format: YYYYMMDD</value>
    [DataMember(Name = "firstRateDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "firstRateDate")]
    public string? FirstRateDate { get; set; }

    /// <summary>
    /// Link with credit information.
    /// </summary>
    /// <value>Link with credit information.</value>
    [DataMember(Name = "creditInformation", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "creditInformation")]
    public AllOfInstallmentOptionCreditInformation? CreditInformation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class InstallmentOption {\n");
      sb.Append("  InstallmentOptionId: ").Append(InstallmentOptionId).Append("\n");
      sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
      sb.Append("  MonthlyAmount: ").Append(MonthlyAmount).Append("\n");
      sb.Append("  LastRateAmount: ").Append(LastRateAmount).Append("\n");
      sb.Append("  EffectiveInterestRate: ").Append(EffectiveInterestRate).Append("\n");
      sb.Append("  NominalInterestRate: ").Append(NominalInterestRate).Append("\n");
      sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
      sb.Append("  FirstRateDate: ").Append(FirstRateDate).Append("\n");
      sb.Append("  CreditInformation: ").Append(CreditInformation).Append("\n");
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
