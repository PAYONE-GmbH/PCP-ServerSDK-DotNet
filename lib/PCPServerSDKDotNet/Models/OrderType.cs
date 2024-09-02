namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The orderType refers to the ShoppingCart of the Checkout. orderType = FULL
    /// should be provided if a payment for the entire ShoppingCart should be created.
    /// orderType = PARTIAL should be provided if the payment should be created only
    /// for certain items of the ShoppingCart. For this type the list of items has to be
    /// provided. Following conditions apply to the Order request:
    /// * amount of the Checkout cannot be zero
    /// * the ShoppingCart cannot be empty
    /// * for orderType = FULL the Checkout status is OPEN, there is no other order and/or
    ///   Payment Execution and no items should be provided in the body
    /// * if no paymentMethodSpecificInput has been provided in the creation of the Commerce Case or Checkout
    ///   it has to be provided in this request.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderType
    {
        [JsonProperty("FULL")]
        [EnumMember(Value = "FULL")]
        Full,

        [JsonProperty("PARTIAL")]
        [EnumMember(Value = "PARTIAL")]
        Partial,
    }
}
