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
    /// InstitutionsList
    /// </summary>
    [DataContract]
        public partial class InstitutionsList :  IEquatable<InstitutionsList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionsList" /> class.
        /// </summary>
        /// <param name="institutions">Es la lista de instituciones bancarias..</param>
        public InstitutionsList(List<Institution> institutions = default(List<Institution>))
        {
            this.Institutions = institutions;
        }
        
        /// <summary>
        /// Es la lista de instituciones bancarias.
        /// </summary>
        /// <value>Es la lista de instituciones bancarias.</value>
        [DataMember(Name="institutions", EmitDefaultValue=false)]
        public List<Institution> Institutions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstitutionsList {\n");
            sb.Append("  Institutions: ").Append(Institutions).Append("\n");
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
            return this.Equals(input as InstitutionsList);
        }

        /// <summary>
        /// Returns true if InstitutionsList instances are equal
        /// </summary>
        /// <param name="input">Instance of InstitutionsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstitutionsList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Institutions == input.Institutions ||
                    this.Institutions != null &&
                    input.Institutions != null &&
                    this.Institutions.SequenceEqual(input.Institutions)
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
                if (this.Institutions != null)
                    hashCode = hashCode * 59 + this.Institutions.GetHashCode();
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
