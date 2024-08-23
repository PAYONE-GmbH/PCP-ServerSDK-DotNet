using Newtonsoft.Json;

namespace PCPServerSDKDotNet.Models.ApplePay
{
    /// <summary>
    /// The result of authorizing a payment request that contains payment information.
    /// Data in PaymentToken is encrypted. Billing and shipping contact data are not encrypted.
    /// </summary>
    public class ApplePayPaymentContact : IEquatable<ApplePayPaymentContact>
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("phoneticGivenName")]
        public string PhoneticGivenName { get; set; }

        [JsonProperty("phoneticFamilyName")]
        public string PhoneticFamilyName { get; set; }

        [JsonProperty("addressLines")]
        public List<string> AddressLines { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("administrativeArea")]
        public string AdministrativeArea { get; set; }

        [JsonProperty("subAdministrativeArea")]
        public string SubAdministrativeArea { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        public ApplePayPaymentContact() { }

        public ApplePayPaymentContact(string phoneNumber, string emailAddress, string givenName, string familyName,
                                      string phoneticGivenName, string phoneticFamilyName, List<string> addressLines,
                                      string locality, string postalCode, string administrativeArea,
                                      string subAdministrativeArea, string country, string countryCode)
        {
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            GivenName = givenName;
            FamilyName = familyName;
            PhoneticGivenName = phoneticGivenName;
            PhoneticFamilyName = phoneticFamilyName;
            AddressLines = addressLines;
            Locality = locality;
            PostalCode = postalCode;
            AdministrativeArea = administrativeArea;
            SubAdministrativeArea = subAdministrativeArea;
            Country = country;
            CountryCode = countryCode;
        }

        public ApplePayPaymentContact WithPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
            return this;
        }

        public ApplePayPaymentContact WithEmailAddress(string emailAddress)
        {
            EmailAddress = emailAddress;
            return this;
        }

        public ApplePayPaymentContact WithGivenName(string givenName)
        {
            GivenName = givenName;
            return this;
        }

        public ApplePayPaymentContact WithFamilyName(string familyName)
        {
            FamilyName = familyName;
            return this;
        }

        public ApplePayPaymentContact WithPhoneticGivenName(string phoneticGivenName)
        {
            PhoneticGivenName = phoneticGivenName;
            return this;
        }

        public ApplePayPaymentContact WithPhoneticFamilyName(string phoneticFamilyName)
        {
            PhoneticFamilyName = phoneticFamilyName;
            return this;
        }

        public ApplePayPaymentContact WithAddressLines(List<string> addressLines)
        {
            AddressLines = addressLines;
            return this;
        }

        public ApplePayPaymentContact WithLocality(string locality)
        {
            Locality = locality;
            return this;
        }

        public ApplePayPaymentContact WithPostalCode(string postalCode)
        {
            PostalCode = postalCode;
            return this;
        }

        public ApplePayPaymentContact WithAdministrativeArea(string administrativeArea)
        {
            AdministrativeArea = administrativeArea;
            return this;
        }

        public ApplePayPaymentContact WithSubAdministrativeArea(string subAdministrativeArea)
        {
            SubAdministrativeArea = subAdministrativeArea;
            return this;
        }

        public ApplePayPaymentContact WithCountry(string country)
        {
            Country = country;
            return this;
        }

        public ApplePayPaymentContact WithCountryCode(string countryCode)
        {
            CountryCode = countryCode;
            return this;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ApplePayPaymentContact);
        }

        public bool Equals(ApplePayPaymentContact other)
        {
            return other != null &&
                   PhoneNumber == other.PhoneNumber &&
                   EmailAddress == other.EmailAddress &&
                   GivenName == other.GivenName &&
                   FamilyName == other.FamilyName &&
                   PhoneticGivenName == other.PhoneticGivenName &&
                   PhoneticFamilyName == other.PhoneticFamilyName &&
                   EqualityComparer<List<string>>.Default.Equals(AddressLines, other.AddressLines) &&
                   Locality == other.Locality &&
                   PostalCode == other.PostalCode &&
                   AdministrativeArea == other.AdministrativeArea &&
                   SubAdministrativeArea == other.SubAdministrativeArea &&
                   Country == other.Country &&
                   CountryCode == other.CountryCode;
        }

        public override int GetHashCode()
        {
            int hash = HashCode.Combine(PhoneNumber, EmailAddress, GivenName, FamilyName, PhoneticGivenName, PhoneticFamilyName, AddressLines, Locality);
            hash = HashCode.Combine(hash, PostalCode, AdministrativeArea, SubAdministrativeArea, Country, CountryCode);
            return hash;
        }

        public override string ToString()
        {
            return $"class ApplePayPaymentContact {{\n" +
                   $"    phoneNumber: {ToIndentedString(PhoneNumber)},\n" +
                   $"    emailAddress: {ToIndentedString(EmailAddress)},\n" +
                   $"    givenName: {ToIndentedString(GivenName)},\n" +
                   $"    familyName: {ToIndentedString(FamilyName)},\n" +
                   $"    phoneticGivenName: {ToIndentedString(PhoneticGivenName)},\n" +
                   $"    phoneticFamilyName: {ToIndentedString(PhoneticFamilyName)},\n" +
                   $"    addressLines: {ToIndentedString(AddressLines)},\n" +
                   $"    locality: {ToIndentedString(Locality)},\n" +
                   $"    postalCode: {ToIndentedString(PostalCode)},\n" +
                   $"    administrativeArea: {ToIndentedString(AdministrativeArea)},\n" +
                   $"    subAdministrativeArea: {ToIndentedString(SubAdministrativeArea)},\n" +
                   $"    country: {ToIndentedString(Country)},\n" +
                   $"    countryCode: {ToIndentedString(CountryCode)}\n" +
                   $"}}";
        }

        private string ToIndentedString(object o)
        {
            if (o == null)
            {
                return "null";
            }
            return o.ToString().Replace("\n", "\n    ");
        }
    }
}
