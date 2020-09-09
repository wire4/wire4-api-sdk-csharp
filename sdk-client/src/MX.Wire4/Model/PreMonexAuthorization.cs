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
    /// Información para obtener la URL para la autorización
    /// </summary>
    [DataContract]
        public partial class PreMonexAuthorization :  IEquatable<PreMonexAuthorization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreMonexAuthorization" /> class.
        /// </summary>
        /// <param name="businessName">Razón social de asociada al RFC a la que debe pertenecer el contrato que se solicita (required).</param>
        /// <param name="cancelReturnUrl">Url a la que se redirigira en caso de que el cliente cancele el registro (required).</param>
        /// <param name="returnUrl">Url a la que se redirigirá en caso de exito (required).</param>
        /// <param name="rfc">RFC de la empresa a la que debe pertenecer el contrato solicitado, si no se especifica este valor no se realiza validación (required).</param>
        public PreMonexAuthorization(string businessName = default(string), string cancelReturnUrl = default(string), string returnUrl = default(string), string rfc = default(string))
        {
            // to ensure "businessName" is required (not null)
            if (businessName == null)
            {
                throw new InvalidDataException("businessName is a required property for PreMonexAuthorization and cannot be null");
            }
            else
            {
                this.BusinessName = businessName;
            }
            // to ensure "cancelReturnUrl" is required (not null)
            if (cancelReturnUrl == null)
            {
                throw new InvalidDataException("cancelReturnUrl is a required property for PreMonexAuthorization and cannot be null");
            }
            else
            {
                this.CancelReturnUrl = cancelReturnUrl;
            }
            // to ensure "returnUrl" is required (not null)
            if (returnUrl == null)
            {
                throw new InvalidDataException("returnUrl is a required property for PreMonexAuthorization and cannot be null");
            }
            else
            {
                this.ReturnUrl = returnUrl;
            }
            // to ensure "rfc" is required (not null)
            if (rfc == null)
            {
                throw new InvalidDataException("rfc is a required property for PreMonexAuthorization and cannot be null");
            }
            else
            {
                this.Rfc = rfc;
            }
        }
        
        /// <summary>
        /// Razón social de asociada al RFC a la que debe pertenecer el contrato que se solicita
        /// </summary>
        /// <value>Razón social de asociada al RFC a la que debe pertenecer el contrato que se solicita</value>
        [DataMember(Name="business_name", EmitDefaultValue=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Url a la que se redirigira en caso de que el cliente cancele el registro
        /// </summary>
        /// <value>Url a la que se redirigira en caso de que el cliente cancele el registro</value>
        [DataMember(Name="cancel_return_url", EmitDefaultValue=false)]
        public string CancelReturnUrl { get; set; }

        /// <summary>
        /// Url a la que se redirigirá en caso de exito
        /// </summary>
        /// <value>Url a la que se redirigirá en caso de exito</value>
        [DataMember(Name="return_url", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// RFC de la empresa a la que debe pertenecer el contrato solicitado, si no se especifica este valor no se realiza validación
        /// </summary>
        /// <value>RFC de la empresa a la que debe pertenecer el contrato solicitado, si no se especifica este valor no se realiza validación</value>
        [DataMember(Name="rfc", EmitDefaultValue=false)]
        public string Rfc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreMonexAuthorization {\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  CancelReturnUrl: ").Append(CancelReturnUrl).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
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
            return this.Equals(input as PreMonexAuthorization);
        }

        /// <summary>
        /// Returns true if PreMonexAuthorization instances are equal
        /// </summary>
        /// <param name="input">Instance of PreMonexAuthorization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreMonexAuthorization input)
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
                    this.CancelReturnUrl == input.CancelReturnUrl ||
                    (this.CancelReturnUrl != null &&
                    this.CancelReturnUrl.Equals(input.CancelReturnUrl))
                ) && 
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
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
                if (this.CancelReturnUrl != null)
                    hashCode = hashCode * 59 + this.CancelReturnUrl.GetHashCode();
                if (this.ReturnUrl != null)
                    hashCode = hashCode * 59 + this.ReturnUrl.GetHashCode();
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