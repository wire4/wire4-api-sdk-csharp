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
    /// BeneficiariesResponse
    /// </summary>
    [DataContract]
        public partial class BeneficiariesResponse :  IEquatable<BeneficiariesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiariesResponse" /> class.
        /// </summary>
        /// <param name="beneficiaries">Es una lista de beneficiarios obtenidos..</param>
        public BeneficiariesResponse(List<AccountResponse> beneficiaries = default(List<AccountResponse>))
        {
            this.Beneficiaries = beneficiaries;
        }
        
        /// <summary>
        /// Es una lista de beneficiarios obtenidos.
        /// </summary>
        /// <value>Es una lista de beneficiarios obtenidos.</value>
        [DataMember(Name="beneficiaries", EmitDefaultValue=false)]
        public List<AccountResponse> Beneficiaries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeneficiariesResponse {\n");
            sb.Append("  Beneficiaries: ").Append(Beneficiaries).Append("\n");
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
            return this.Equals(input as BeneficiariesResponse);
        }

        /// <summary>
        /// Returns true if BeneficiariesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BeneficiariesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeneficiariesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Beneficiaries == input.Beneficiaries ||
                    this.Beneficiaries != null &&
                    input.Beneficiaries != null &&
                    this.Beneficiaries.SequenceEqual(input.Beneficiaries)
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
                if (this.Beneficiaries != null)
                    hashCode = hashCode * 59 + this.Beneficiaries.GetHashCode();
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
