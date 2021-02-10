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
    /// Objeto que contiene la información del banco.
    /// </summary>
    [DataContract]
        public partial class MessageInstitution :  IEquatable<MessageInstitution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageInstitution" /> class.
        /// </summary>
        /// <param name="companyName">Es el nombre de la institución bancaria registrada ante el Servicio de Administración Tributaria (SAT)..</param>
        /// <param name="key">Es la clave de la institución bancaria..</param>
        /// <param name="name">Es el nombre de la institución bancaria..</param>
        /// <param name="rfc">Es el Registro Federal de Contribuyentes (RFC) de la institución..</param>
        public MessageInstitution(string companyName = default(string), string key = default(string), string name = default(string), string rfc = default(string))
        {
            this.CompanyName = companyName;
            this.Key = key;
            this.Name = name;
            this.Rfc = rfc;
        }
        
        /// <summary>
        /// Es el nombre de la institución bancaria registrada ante el Servicio de Administración Tributaria (SAT).
        /// </summary>
        /// <value>Es el nombre de la institución bancaria registrada ante el Servicio de Administración Tributaria (SAT).</value>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Es la clave de la institución bancaria.
        /// </summary>
        /// <value>Es la clave de la institución bancaria.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Es el nombre de la institución bancaria.
        /// </summary>
        /// <value>Es el nombre de la institución bancaria.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Es el Registro Federal de Contribuyentes (RFC) de la institución.
        /// </summary>
        /// <value>Es el Registro Federal de Contribuyentes (RFC) de la institución.</value>
        [DataMember(Name="rfc", EmitDefaultValue=false)]
        public string Rfc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageInstitution {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as MessageInstitution);
        }

        /// <summary>
        /// Returns true if MessageInstitution instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageInstitution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageInstitution input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
