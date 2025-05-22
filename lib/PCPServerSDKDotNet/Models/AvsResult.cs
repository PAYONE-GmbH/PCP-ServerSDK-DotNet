namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Result of the Address Verification Service checks. Possible values are:
    /// * A - Address (Street) matches, Zip does not
    /// * B - Street address match for international transactions—Postal code not verified due to incompatible formats
    /// * C - Street address and postal code not verified for international transaction due to incompatible formats
    /// * D - Street address and postal code match for international transaction, cardholder name is incorrect
    /// * E - AVS error
    /// * F - Address does match and five digit ZIP code does match (UK only)
    /// * G - Address information is unavailable; international transaction; non-AVS participant
    /// * H - Billing address and postal code match, cardholder name is incorrect (Amex)
    /// * I - Address information not verified for international transaction
    /// * K - Cardholder name matches (Amex)
    /// * L - Cardholder name and postal code match (Amex)
    /// * M - Cardholder name, street address, and postal code match for international transaction
    /// * N - No Match on Address (Street) or Zip
    /// * O - Cardholder name and address match (Amex)
    /// * P - Postal codes match for international transaction—Street address not verified due to incompatible formats
    /// * Q - Billing address matches, cardholder is incorrect (Amex)
    /// * R - Retry, System unavailable or Timed out
    /// * S - Service not supported by issuer
    /// * U - Address information is unavailable
    /// * W - 9 digit Zip matches, Address (Street) does not
    /// * X - Exact AVS Match
    /// * Y - Address (Street) and 5 digit Zip match
    /// * Z - 5 digit Zip matches, Address (Street) does not
    /// * 0 - No service available.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AvsResult
    {
        /// <summary>Address (Street) matches, Zip does not</summary>
        [JsonProperty("A")]
        [EnumMember(Value = "A")]
        A,

        /// <summary>Street address match for international transactions—Postal code not verified due to incompatible formats</summary>
        [JsonProperty("B")]
        [EnumMember(Value = "B")]
        B,

        /// <summary>Street address and postal code not verified for international transaction due to incompatible formats</summary>
        [JsonProperty("C")]
        [EnumMember(Value = "C")]
        C,

        /// <summary>Street address and postal code match for international transaction, cardholder name is incorrect</summary>
        [JsonProperty("D")]
        [EnumMember(Value = "D")]
        D,

        /// <summary>AVS error</summary>
        [JsonProperty("E")]
        [EnumMember(Value = "E")]
        E,

        /// <summary>Address does match and five digit ZIP code does match (UK only)</summary>
        [JsonProperty("F")]
        [EnumMember(Value = "F")]
        F,

        /// <summary>Address information is unavailable; international transaction; non-AVS participant</summary>
        [JsonProperty("G")]
        [EnumMember(Value = "G")]
        G,

        /// <summary>Billing address and postal code match, cardholder name is incorrect (Amex)</summary>
        [JsonProperty("H")]
        [EnumMember(Value = "H")]
        H,

        /// <summary>Address information not verified for international transaction</summary>
        [JsonProperty("I")]
        [EnumMember(Value = "I")]
        I,

        /// <summary>Cardholder name matches (Amex)</summary>
        [JsonProperty("K")]
        [EnumMember(Value = "K")]
        K,

        /// <summary>Cardholder name and postal code match (Amex)</summary>
        [JsonProperty("L")]
        [EnumMember(Value = "L")]
        L,

        /// <summary>Cardholder name, street address, and postal code match for international transaction</summary>
        [JsonProperty("M")]
        [EnumMember(Value = "M")]
        M,

        /// <summary>No Match on Address (Street) or Zip</summary>
        [JsonProperty("N")]
        [EnumMember(Value = "N")]
        N,

        /// <summary>Cardholder name and address match (Amex)</summary>
        [JsonProperty("O")]
        [EnumMember(Value = "O")]
        O,

        /// <summary>Postal codes match for international transaction—Street address not verified due to incompatible formats</summary>
        [JsonProperty("P")]
        [EnumMember(Value = "P")]
        P,

        /// <summary>Billing address matches, cardholder is incorrect (Amex)</summary>
        [JsonProperty("Q")]
        [EnumMember(Value = "Q")]
        Q,

        /// <summary>Retry, System unavailable or Timed out</summary>
        [JsonProperty("R")]
        [EnumMember(Value = "R")]
        R,

        /// <summary>Service not supported by issuer</summary>
        [JsonProperty("S")]
        [EnumMember(Value = "S")]
        S,

        /// <summary>Address information is unavailable</summary>
        [JsonProperty("U")]
        [EnumMember(Value = "U")]
        U,

        /// <summary>9 digit Zip matches, Address (Street) does not</summary>
        [JsonProperty("W")]
        [EnumMember(Value = "W")]
        W,

        /// <summary>Exact AVS Match</summary>
        [JsonProperty("X")]
        [EnumMember(Value = "X")]
        X,

        /// <summary>Address (Street) and 5 digit Zip match</summary>
        [JsonProperty("Y")]
        [EnumMember(Value = "Y")]
        Y,

        /// <summary>5 digit Zip matches, Address (Street) does not</summary>
        [JsonProperty("Z")]
        [EnumMember(Value = "Z")]
        Z,

        /// <summary>No service available</summary>
        [JsonProperty("0")]
        [EnumMember(Value = "0")]
        NoService,
    }
}
