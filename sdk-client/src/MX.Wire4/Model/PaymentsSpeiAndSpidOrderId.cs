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
    /// Contiene el conjunto de transacciones SPEI y SPID registradas bajo una misma petición
    /// </summary>
    [DataContract]
        public partial class PaymentsSpeiAndSpidOrderId :  IEquatable<PaymentsSpeiAndSpidOrderId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsSpeiAndSpidOrderId" /> class.
        /// </summary>
        /// <param name="spei">Lista de las transacciones spei registradas.</param>
        /// <param name="spid">Lista de las transacciones spid registradas.</param>
        public PaymentsSpeiAndSpidOrderId(List<Payment> spei = default(List<Payment>), List<Payment> spid = default(List<Payment>))
        {
            this.Spei = spei;
            this.Spid = spid;
        }
        
        /// <summary>
        /// Lista de las transacciones spei registradas
        /// </summary>
        /// <value>Lista de las transacciones spei registradas</value>
        [DataMember(Name="spei", EmitDefaultValue=false)]
        public List<Payment> Spei { get; set; }

        /// <summary>
        /// Lista de las transacciones spid registradas
        /// </summary>
        /// <value>Lista de las transacciones spid registradas</value>
        [DataMember(Name="spid", EmitDefaultValue=false)]
        public List<Payment> Spid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsSpeiAndSpidOrderId {\n");
            sb.Append("  Spei: ").Append(Spei).Append("\n");
            sb.Append("  Spid: ").Append(Spid).Append("\n");
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
            return this.Equals(input as PaymentsSpeiAndSpidOrderId);
        }

        /// <summary>
        /// Returns true if PaymentsSpeiAndSpidOrderId instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsSpeiAndSpidOrderId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsSpeiAndSpidOrderId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Spei == input.Spei ||
                    this.Spei != null &&
                    input.Spei != null &&
                    this.Spei.SequenceEqual(input.Spei)
                ) && 
                (
                    this.Spid == input.Spid ||
                    this.Spid != null &&
                    input.Spid != null &&
                    this.Spid.SequenceEqual(input.Spid)
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
                if (this.Spei != null)
                    hashCode = hashCode * 59 + this.Spei.GetHashCode();
                if (this.Spid != null)
                    hashCode = hashCode * 59 + this.Spid.GetHashCode();
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