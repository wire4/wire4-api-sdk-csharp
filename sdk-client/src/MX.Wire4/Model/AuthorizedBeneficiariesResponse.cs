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
    /// AuthorizedBeneficiariesResponse
    /// </summary>
    [DataContract]
        public partial class AuthorizedBeneficiariesResponse :  IEquatable<AuthorizedBeneficiariesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedBeneficiariesResponse" /> class.
        /// </summary>
        /// <param name="accounts">Lista de cuentas obtenidas en estado pendiente de ser autorizadas..</param>
        /// <param name="requestId">Es el identificador público generado para la petición (solicitud)..</param>
        /// <param name="url">Es la dirección URL generada para confirmación de la operación. Es para ingresar al centro de autorización..</param>
        public AuthorizedBeneficiariesResponse(List<AccountReassigned> accounts = default(List<AccountReassigned>), string requestId = default(string), string url = default(string))
        {
            this.Accounts = accounts;
            this.RequestId = requestId;
            this.Url = url;
        }
        
        /// <summary>
        /// Lista de cuentas obtenidas en estado pendiente de ser autorizadas.
        /// </summary>
        /// <value>Lista de cuentas obtenidas en estado pendiente de ser autorizadas.</value>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<AccountReassigned> Accounts { get; set; }

        /// <summary>
        /// Es el identificador público generado para la petición (solicitud).
        /// </summary>
        /// <value>Es el identificador público generado para la petición (solicitud).</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Es la dirección URL generada para confirmación de la operación. Es para ingresar al centro de autorización.
        /// </summary>
        /// <value>Es la dirección URL generada para confirmación de la operación. Es para ingresar al centro de autorización.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizedBeneficiariesResponse {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as AuthorizedBeneficiariesResponse);
        }

        /// <summary>
        /// Returns true if AuthorizedBeneficiariesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizedBeneficiariesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizedBeneficiariesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
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
