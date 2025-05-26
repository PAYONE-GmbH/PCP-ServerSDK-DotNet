namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Action merchants needs to take in the online payment process.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionType
    {
        /// <summary>
        /// The customer needs to be redirected using the details found in redirectData
        /// </summary>
        [JsonProperty("REDIRECT")]
        [EnumMember(Value = "REDIRECT")]
        Redirect,

        /// <summary>
        /// The customer needs to be shown a form with the fields found in formFields.
        /// You can submit the data entered by the user in a Complete payment request.
        /// </summary>
        [JsonProperty("SHOW_FORM")]
        [EnumMember(Value = "SHOW_FORM")]
        ShowForm,

        /// <summary>
        /// The customer needs to be shown payment instruction using the details found in showData.
        /// Alternatively the instructions can be rendered by us using the instructionsRenderingData
        /// </summary>
        [JsonProperty("SHOW_INSTRUCTIONS")]
        [EnumMember(Value = "SHOW_INSTRUCTIONS")]
        ShowInstructions,

        /// <summary>
        /// The customer needs to be shown the transaction results using the details found in showData.
        /// Alternatively the instructions can be rendered by us using the instructionsRenderingData
        /// </summary>
        [JsonProperty("SHOW_TRANSACTION_RESULTS")]
        [EnumMember(Value = "SHOW_TRANSACTION_RESULTS")]
        ShowTransactionResults,

        /// <summary>
        /// The customer needs to complete a challenge as part of the 3D Secure authentication inside your mobile app.
        /// The details contained in mobileThreeDSecureChallengeParameters need to be provided to the EMVco certified
        /// Mobile SDK as a challengeParameters object.
        /// </summary>
        [JsonProperty("MOBILE_THREEDS_CHALLENGE")]
        [EnumMember(Value = "MOBILE_THREEDS_CHALLENGE")]
        MobileThreedsChallenge,

        /// <summary>
        /// The merchant needs to call a third party using the data found in thirdPartyData
        /// </summary>
        [JsonProperty("CALL_THIRD_PARTY")]
        [EnumMember(Value = "CALL_THIRD_PARTY")]
        CallThirdParty,
    }
}
