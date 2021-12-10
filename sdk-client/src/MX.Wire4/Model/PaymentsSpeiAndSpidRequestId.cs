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
        public partial class PaymentsSpeiAndSpidRequestId :  IEquatable<PaymentsSpeiAndSpidRequestId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsSpeiAndSpidRequestId" /> class.
        /// </summary>
        /// <param name="authorizationDate">Fecha en que el usuario propietario del token emitió la autorización.</param>
        /// <param name="requestDate">Fecha en que se realizó la petición de registro de transacciones.</param>
        /// <param name="requestId">Identificador de la petición del registro de transacciones.</param>
        /// <param name="spei">Lista de las transacciones spei registradas.</param>
        /// <param name="spid">Lista de las transacciones spid registradas.</param>
        public PaymentsSpeiAndSpidRequestId(DateTime? authorizationDate = default(DateTime?), DateTime? requestDate = default(DateTime?), string requestId = default(string), List<Payment> spei = default(List<Payment>), List<Payment> spid = default(List<Payment>))
        {
            this.AuthorizationDate = authorizationDate;
            this.RequestDate = requestDate;
            this.RequestId = requestId;
            this.Spei = spei;
            this.Spid = spid;
        }
        
        /// <summary>
        /// Fecha en que el usuario propietario del token emitió la autorización
        /// </summary>
        /// <value>Fecha en que el usuario propietario del token emitió la autorización</value>
        [DataMember(Name="authorization_date", EmitDefaultValue=false)]
        public DateTime? AuthorizationDate { get; set; }

        /// <summary>
        /// Fecha en que se realizó la petición de registro de transacciones
        /// </summary>
        /// <value>Fecha en que se realizó la petición de registro de transacciones</value>
        [DataMember(Name="request_date", EmitDefaultValue=false)]
        public DateTime? RequestDate { get; set; }

        /// <summary>
        /// Identificador de la petición del registro de transacciones
        /// </summary>
        /// <value>Identificador de la petición del registro de transacciones</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }

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
            sb.Append("class PaymentsSpeiAndSpidRequestId {\n");
            sb.Append("  AuthorizationDate: ").Append(AuthorizationDate).Append("\n");
            sb.Append("  RequestDate: ").Append(RequestDate).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as PaymentsSpeiAndSpidRequestId);
        }

        /// <summary>
        /// Returns true if PaymentsSpeiAndSpidRequestId instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsSpeiAndSpidRequestId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsSpeiAndSpidRequestId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorizationDate == input.AuthorizationDate ||
                    (this.AuthorizationDate != null &&
                    this.AuthorizationDate.Equals(input.AuthorizationDate))
                ) && 
                (
                    this.RequestDate == input.RequestDate ||
                    (this.RequestDate != null &&
                    this.RequestDate.Equals(input.RequestDate))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
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
                if (this.AuthorizationDate != null)
                    hashCode = hashCode * 59 + this.AuthorizationDate.GetHashCode();
                if (this.RequestDate != null)
                    hashCode = hashCode * 59 + this.RequestDate.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
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
