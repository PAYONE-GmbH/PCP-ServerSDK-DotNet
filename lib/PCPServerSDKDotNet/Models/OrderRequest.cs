namespace PCPServerSDKDotNet.Models
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Request to execute an Order for the corresponding Checkout for a specific payment method. The provided data from the Commerce Case and the Checkout regarding customer, shipping, and ShoppingCart will be automatically loaded and used for the Payment Execution.  In case the paymentMethodSpecificInput has already been provided when creating the Commerce Case or Checkout, this input will automatically be used.  An Order can be created for a full or the partial ShoppingCart of the Checkout. For a partial Order a list of items must be provided. The platform will automatically calculate the respective amount to trigger the payment execution.
    /// </summary>
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class OrderRequest
    {
        /// <summary>
        /// Gets or Sets OrderType.
        /// </summary>
        [DataMember(Name = "orderType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderType")]
        public OrderType? OrderType { get; set; }

        /// <summary>
        /// Gets or Sets OrderReferences.
        /// </summary>
        [DataMember(Name = "orderReferences", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderReferences")]
        public References? OrderReferences { get; set; }

        /// <summary>
        /// Gets or Sets Items.
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "items")]
        public List<OrderItem>? Items { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethodSpecificInput.
        /// </summary>
        [DataMember(Name = "paymentMethodSpecificInput", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentMethodSpecificInput")]
        public PaymentMethodSpecificInput? PaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderRequest {\n");
            sb.Append("  OrderType: ").Append(this.OrderType).Append('\n');
            sb.Append("  OrderReferences: ").Append(this.OrderReferences).Append('\n');
            sb.Append("  Items: ").Append(this.Items).Append('\n');
            sb.Append("  PaymentMethodSpecificInput: ").Append(this.PaymentMethodSpecificInput).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
