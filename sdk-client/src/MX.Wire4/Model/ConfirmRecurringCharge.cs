/* 
 * Wire4RestAPI
 *
 * Referencia de la API de Wire4
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = MX.Wire4.Client.SwaggerDateConverter;
namespace MX.Wire4.Model
{
    /// <summary>
    /// ConfirmRecurringCharge
    /// </summary>
    [DataContract]
        public partial class ConfirmRecurringCharge :  IEquatable<ConfirmRecurringCharge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmRecurringCharge" /> class.
        /// </summary>
        /// <param name="orderId">Identificador de la orden enviada por parte del cliente.</param>
        /// <param name="url">Url del portal en donde se debe capturar los datos de la tarjeta para aplicar el cargo.</param>
        public ConfirmRecurringCharge(string orderId = default(string), string url = default(string))
        {
            this.OrderId = orderId;
            this.Url = url;
        }
        
        /// <summary>
        /// Identificador de la orden enviada por parte del cliente
        /// </summary>
        /// <value>Identificador de la orden enviada por parte del cliente</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Url del portal en donde se debe capturar los datos de la tarjeta para aplicar el cargo
        /// </summary>
        /// <value>Url del portal en donde se debe capturar los datos de la tarjeta para aplicar el cargo</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmRecurringCharge {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfirmRecurringCharge);
        }

        /// <summary>
        /// Returns true if ConfirmRecurringCharge instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfirmRecurringCharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmRecurringCharge input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
