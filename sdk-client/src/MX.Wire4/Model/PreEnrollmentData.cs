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
    /// PreEnrollmentData
    /// </summary>
    [DataContract]
        public partial class PreEnrollmentData :  IEquatable<PreEnrollmentData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreEnrollmentData" /> class.
        /// </summary>
        /// <param name="cancelReturnUrl">Es la dirección URL a la que se redirigirá en caso de que el cliente cancele el registro. Se valida una longitud de 512 caracteres y que la URL sea por ejemplo: http://mysite.com/return. (required).</param>
        /// <param name="returnUrl">Es la dirección URL a la que se redirigirá en caso de exito. Se valida una longitud de 512 caracteres  y que la URL sea por ejemplo: http://mysite.com/cancel. (required).</param>
        public PreEnrollmentData(string cancelReturnUrl = default(string), string returnUrl = default(string))
        {
            // to ensure "cancelReturnUrl" is required (not null)
            if (cancelReturnUrl == null)
            {
                throw new InvalidDataException("cancelReturnUrl is a required property for PreEnrollmentData and cannot be null");
            }
            else
            {
                this.CancelReturnUrl = cancelReturnUrl;
            }
            // to ensure "returnUrl" is required (not null)
            if (returnUrl == null)
            {
                throw new InvalidDataException("returnUrl is a required property for PreEnrollmentData and cannot be null");
            }
            else
            {
                this.ReturnUrl = returnUrl;
            }
        }
        
        /// <summary>
        /// Es la dirección URL a la que se redirigirá en caso de que el cliente cancele el registro. Se valida una longitud de 512 caracteres y que la URL sea por ejemplo: http://mysite.com/return.
        /// </summary>
        /// <value>Es la dirección URL a la que se redirigirá en caso de que el cliente cancele el registro. Se valida una longitud de 512 caracteres y que la URL sea por ejemplo: http://mysite.com/return.</value>
        [DataMember(Name="cancel_return_url", EmitDefaultValue=false)]
        public string CancelReturnUrl { get; set; }

        /// <summary>
        /// Es la dirección URL a la que se redirigirá en caso de exito. Se valida una longitud de 512 caracteres  y que la URL sea por ejemplo: http://mysite.com/cancel.
        /// </summary>
        /// <value>Es la dirección URL a la que se redirigirá en caso de exito. Se valida una longitud de 512 caracteres  y que la URL sea por ejemplo: http://mysite.com/cancel.</value>
        [DataMember(Name="return_url", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreEnrollmentData {\n");
            sb.Append("  CancelReturnUrl: ").Append(CancelReturnUrl).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
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
            return this.Equals(input as PreEnrollmentData);
        }

        /// <summary>
        /// Returns true if PreEnrollmentData instances are equal
        /// </summary>
        /// <param name="input">Instance of PreEnrollmentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreEnrollmentData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CancelReturnUrl == input.CancelReturnUrl ||
                    (this.CancelReturnUrl != null &&
                    this.CancelReturnUrl.Equals(input.CancelReturnUrl))
                ) && 
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
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
                if (this.CancelReturnUrl != null)
                    hashCode = hashCode * 59 + this.CancelReturnUrl.GetHashCode();
                if (this.ReturnUrl != null)
                    hashCode = hashCode * 59 + this.ReturnUrl.GetHashCode();
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
