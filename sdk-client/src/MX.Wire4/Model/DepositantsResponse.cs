/* 
 * Wire4RestAPI
 *
 * Referencia de API. La API de Wire4 está organizada en torno a REST
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
    /// DepositantsResponse
    /// </summary>
    [DataContract]
        public partial class DepositantsResponse :  IEquatable<DepositantsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositantsResponse" /> class.
        /// </summary>
        /// <param name="clabe">Cuenta CLABE (es de 18 dígitos) del depositante..</param>
        public DepositantsResponse(string clabe = default(string))
        {
            this.Clabe = clabe;
        }
        
        /// <summary>
        /// Cuenta CLABE (es de 18 dígitos) del depositante.
        /// </summary>
        /// <value>Cuenta CLABE (es de 18 dígitos) del depositante.</value>
        [DataMember(Name="clabe", EmitDefaultValue=false)]
        public string Clabe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepositantsResponse {\n");
            sb.Append("  Clabe: ").Append(Clabe).Append("\n");
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
            return this.Equals(input as DepositantsResponse);
        }

        /// <summary>
        /// Returns true if DepositantsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositantsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositantsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Clabe == input.Clabe ||
                    (this.Clabe != null &&
                    this.Clabe.Equals(input.Clabe))
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
                if (this.Clabe != null)
                    hashCode = hashCode * 59 + this.Clabe.GetHashCode();
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
