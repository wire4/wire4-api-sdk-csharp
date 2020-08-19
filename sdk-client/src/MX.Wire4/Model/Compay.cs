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
    /// Objeto que contiene la información de la empresa
    /// </summary>
    [DataContract]
        public partial class Compay :  IEquatable<Compay>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Compay" /> class.
        /// </summary>
        /// <param name="commercialName">Nombre comercial de la empresa.</param>
        /// <param name="companyId">Identificador de la empresa.</param>
        /// <param name="name">Nombre de la empresa.</param>
        /// <param name="rfc">RFC de la empresa.</param>
        public Compay(string commercialName = default(string), string companyId = default(string), string name = default(string), string rfc = default(string))
        {
            this.CommercialName = commercialName;
            this.CompanyId = companyId;
            this.Name = name;
            this.Rfc = rfc;
        }
        
        /// <summary>
        /// Nombre comercial de la empresa
        /// </summary>
        /// <value>Nombre comercial de la empresa</value>
        [DataMember(Name="commercial_name", EmitDefaultValue=false)]
        public string CommercialName { get; set; }

        /// <summary>
        /// Identificador de la empresa
        /// </summary>
        /// <value>Identificador de la empresa</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Nombre de la empresa
        /// </summary>
        /// <value>Nombre de la empresa</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// RFC de la empresa
        /// </summary>
        /// <value>RFC de la empresa</value>
        [DataMember(Name="rfc", EmitDefaultValue=false)]
        public string Rfc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Compay {\n");
            sb.Append("  CommercialName: ").Append(CommercialName).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Compay);
        }

        /// <summary>
        /// Returns true if Compay instances are equal
        /// </summary>
        /// <param name="input">Instance of Compay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Compay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommercialName == input.CommercialName ||
                    (this.CommercialName != null &&
                    this.CommercialName.Equals(input.CommercialName))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.CommercialName != null)
                    hashCode = hashCode * 59 + this.CommercialName.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
