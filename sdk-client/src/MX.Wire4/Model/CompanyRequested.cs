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
    /// Contiene la información de la empresa que se quiere registrar.
    /// </summary>
    [DataContract]
        public partial class CompanyRequested :  IEquatable<CompanyRequested>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRequested" /> class.
        /// </summary>
        /// <param name="businessName">Es el nombre de la empresa que se va a registrar..</param>
        /// <param name="certificate">certificate.</param>
        /// <param name="comercialName">Es el nombre comercial de la empresa que se va a registrar..</param>
        /// <param name="rfc">Es el Registro Federal de Contribuyentes (RFC) de la empresa que se va a registrar..</param>
        public CompanyRequested(string businessName = default(string), CertificateRequest certificate = default(CertificateRequest), string comercialName = default(string), string rfc = default(string))
        {
            this.BusinessName = businessName;
            this.Certificate = certificate;
            this.ComercialName = comercialName;
            this.Rfc = rfc;
        }
        
        /// <summary>
        /// Es el nombre de la empresa que se va a registrar.
        /// </summary>
        /// <value>Es el nombre de la empresa que se va a registrar.</value>
        [DataMember(Name="business_name", EmitDefaultValue=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public CertificateRequest Certificate { get; set; }

        /// <summary>
        /// Es el nombre comercial de la empresa que se va a registrar.
        /// </summary>
        /// <value>Es el nombre comercial de la empresa que se va a registrar.</value>
        [DataMember(Name="comercial_name", EmitDefaultValue=false)]
        public string ComercialName { get; set; }

        /// <summary>
        /// Es el Registro Federal de Contribuyentes (RFC) de la empresa que se va a registrar.
        /// </summary>
        /// <value>Es el Registro Federal de Contribuyentes (RFC) de la empresa que se va a registrar.</value>
        [DataMember(Name="rfc", EmitDefaultValue=false)]
        public string Rfc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyRequested {\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  ComercialName: ").Append(ComercialName).Append("\n");
            sb.Append("  Rfc: ").Append(Rfc).Append("\n");
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
            return this.Equals(input as CompanyRequested);
        }

        /// <summary>
        /// Returns true if CompanyRequested instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyRequested to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyRequested input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusinessName == input.BusinessName ||
                    (this.BusinessName != null &&
                    this.BusinessName.Equals(input.BusinessName))
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.ComercialName == input.ComercialName ||
                    (this.ComercialName != null &&
                    this.ComercialName.Equals(input.ComercialName))
                ) && 
                (
                    this.Rfc == input.Rfc ||
                    (this.Rfc != null &&
                    this.Rfc.Equals(input.Rfc))
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
                if (this.BusinessName != null)
                    hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.ComercialName != null)
                    hashCode = hashCode * 59 + this.ComercialName.GetHashCode();
                if (this.Rfc != null)
                    hashCode = hashCode * 59 + this.Rfc.GetHashCode();
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
