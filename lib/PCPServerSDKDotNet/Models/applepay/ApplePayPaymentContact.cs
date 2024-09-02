namespace PCPServerSDKDotNet.Models.ApplePay;

using Newtonsoft.Json;

/// <summary>
/// The result of authorizing a payment request that contains payment information.
/// Data in PaymentToken is encrypted. Billing and shipping contact data are not encrypted.
/// </summary>
public class ApplePayPaymentContact : IEquatable<ApplePayPaymentContact>
{
    public ApplePayPaymentContact()
    {
    }

    public ApplePayPaymentContact(
        string phoneNumber,
        string emailAddress,
        string givenName,
        string familyName,
        string phoneticGivenName,
        string phoneticFamilyName,
        List<string> addressLines,
        string locality,
        string postalCode,
        string administrativeArea,
        string subAdministrativeArea,
        string country,
        string countryCode)
    {
        this.PhoneNumber = phoneNumber;
        this.EmailAddress = emailAddress;
        this.GivenName = givenName;
        this.FamilyName = familyName;
        this.PhoneticGivenName = phoneticGivenName;
        this.PhoneticFamilyName = phoneticFamilyName;
        this.AddressLines = addressLines;
        this.Locality = locality;
        this.PostalCode = postalCode;
        this.AdministrativeArea = administrativeArea;
        this.SubAdministrativeArea = subAdministrativeArea;
        this.Country = country;
        this.CountryCode = countryCode;
    }

    [JsonProperty("phoneNumber")]
    public string? PhoneNumber { get; set; }

    [JsonProperty("emailAddress")]
    public string? EmailAddress { get; set; }

    [JsonProperty("givenName")]
    public string? GivenName { get; set; }

    [JsonProperty("familyName")]
    public string? FamilyName { get; set; }

    [JsonProperty("phoneticGivenName")]
    public string? PhoneticGivenName { get; set; }

    [JsonProperty("phoneticFamilyName")]
    public string? PhoneticFamilyName { get; set; }

    [JsonProperty("addressLines")]
    public List<string>? AddressLines { get; set; }

    [JsonProperty("locality")]
    public string? Locality { get; set; }

    [JsonProperty("postalCode")]
    public string? PostalCode { get; set; }

    [JsonProperty("administrativeArea")]
    public string? AdministrativeArea { get; set; }

    [JsonProperty("subAdministrativeArea")]
    public string? SubAdministrativeArea { get; set; }

    [JsonProperty("country")]
    public string? Country { get; set; }

    [JsonProperty("countryCode")]
    public string? CountryCode { get; set; }

    public ApplePayPaymentContact WithPhoneNumber(string phoneNumber)
    {
        this.PhoneNumber = phoneNumber;
        return this;
    }

    public ApplePayPaymentContact WithEmailAddress(string emailAddress)
    {
        this.EmailAddress = emailAddress;
        return this;
    }

    public ApplePayPaymentContact WithGivenName(string givenName)
    {
        this.GivenName = givenName;
        return this;
    }

    public ApplePayPaymentContact WithFamilyName(string familyName)
    {
        this.FamilyName = familyName;
        return this;
    }

    public ApplePayPaymentContact WithPhoneticGivenName(string phoneticGivenName)
    {
        this.PhoneticGivenName = phoneticGivenName;
        return this;
    }

    public ApplePayPaymentContact WithPhoneticFamilyName(string phoneticFamilyName)
    {
        this.PhoneticFamilyName = phoneticFamilyName;
        return this;
    }

    public ApplePayPaymentContact WithAddressLines(List<string> addressLines)
    {
        this.AddressLines = addressLines;
        return this;
    }

    public ApplePayPaymentContact WithLocality(string locality)
    {
        this.Locality = locality;
        return this;
    }

    public ApplePayPaymentContact WithPostalCode(string postalCode)
    {
        this.PostalCode = postalCode;
        return this;
    }

    public ApplePayPaymentContact WithAdministrativeArea(string administrativeArea)
    {
        this.AdministrativeArea = administrativeArea;
        return this;
    }

    public ApplePayPaymentContact WithSubAdministrativeArea(string subAdministrativeArea)
    {
        this.SubAdministrativeArea = subAdministrativeArea;
        return this;
    }

    public ApplePayPaymentContact WithCountry(string country)
    {
        this.Country = country;
        return this;
    }

    public ApplePayPaymentContact WithCountryCode(string countryCode)
    {
        this.CountryCode = countryCode;
        return this;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        return this.Equals(obj as ApplePayPaymentContact);
    }

    public bool Equals(ApplePayPaymentContact? other)
    {
        return other != null &&
               this.PhoneNumber == other.PhoneNumber &&
               this.EmailAddress == other.EmailAddress &&
               this.GivenName == other.GivenName &&
               this.FamilyName == other.FamilyName &&
               this.PhoneticGivenName == other.PhoneticGivenName &&
               this.PhoneticFamilyName == other.PhoneticFamilyName &&
               EqualityComparer<List<string>>.Default.Equals(this.AddressLines, other.AddressLines) &&
               this.Locality == other.Locality &&
               this.PostalCode == other.PostalCode &&
               this.AdministrativeArea == other.AdministrativeArea &&
               this.SubAdministrativeArea == other.SubAdministrativeArea &&
               this.Country == other.Country &&
               this.CountryCode == other.CountryCode;
    }

    public override int GetHashCode()
    {
        int hash = HashCode.Combine(this.PhoneNumber, this.EmailAddress, this.GivenName, this.FamilyName, this.PhoneticGivenName, this.PhoneticFamilyName, this.AddressLines, this.Locality);
        hash = HashCode.Combine(hash, this.PostalCode, this.AdministrativeArea, this.SubAdministrativeArea, this.Country, this.CountryCode);
        return hash;
    }

    public override string ToString()
    {
        return $"class ApplePayPaymentContact {{\n" +
               $"    phoneNumber: {this.ToIndentedString(this.PhoneNumber)},\n" +
               $"    emailAddress: {this.ToIndentedString(this.EmailAddress)},\n" +
               $"    givenName: {this.ToIndentedString(this.GivenName)},\n" +
               $"    familyName: {this.ToIndentedString(this.FamilyName)},\n" +
               $"    phoneticGivenName: {this.ToIndentedString(this.PhoneticGivenName)},\n" +
               $"    phoneticFamilyName: {this.ToIndentedString(this.PhoneticFamilyName)},\n" +
               $"    addressLines: {this.ToIndentedString(this.AddressLines)},\n" +
               $"    locality: {this.ToIndentedString(this.Locality)},\n" +
               $"    postalCode: {this.ToIndentedString(this.PostalCode)},\n" +
               $"    administrativeArea: {this.ToIndentedString(this.AdministrativeArea)},\n" +
               $"    subAdministrativeArea: {this.ToIndentedString(this.SubAdministrativeArea)},\n" +
               $"    country: {this.ToIndentedString(this.Country)},\n" +
               $"    countryCode: {this.ToIndentedString(this.CountryCode)}\n" +
               $"}}";
    }

    private string ToIndentedString(object? o)
    {
        if (o == null)
        {
            return "null";
        }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        return o.ToString().Replace("\n", "\n    ");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}
