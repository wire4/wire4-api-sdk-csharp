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
    /// Objeto que contiene la información del punto de venta encontrada.
    /// </summary>
    [DataContract]
        public partial class SalesPointFound :  IEquatable<SalesPointFound>, IValidatableObject
    {
        /// <summary>
        /// Es el estado (estatus) del punto de venta. Puede ser \&quot;ACTIVE\&quot; o \&quot;INACTIVO\&quot;.
        /// </summary>
        /// <value>Es el estado (estatus) del punto de venta. Puede ser \&quot;ACTIVE\&quot; o \&quot;INACTIVO\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 0,
            /// <summary>
            /// Enum INACTIVE for value: INACTIVE
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            INACTIVE = 1        }
        /// <summary>
        /// Es el estado (estatus) del punto de venta. Puede ser \&quot;ACTIVE\&quot; o \&quot;INACTIVO\&quot;.
        /// </summary>
        /// <value>Es el estado (estatus) del punto de venta. Puede ser \&quot;ACTIVE\&quot; o \&quot;INACTIVO\&quot;.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesPointFound" /> class.
        /// </summary>
        /// <param name="accessIp">Es la dirección IP desde la que accede el punto de venta a wire4 y a la que se devuelven las notificaciones..</param>
        /// <param name="account">Es la cuenta registra para el punto de venta..</param>
        /// <param name="createdAt">Es la fecha en la que se creó el punto de venta. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;..</param>
        /// <param name="name">Es el nombre del punto de venta..</param>
        /// <param name="publicId">Es el identificador del punto de venta..</param>
        /// <param name="status">Es el estado (estatus) del punto de venta. Puede ser \&quot;ACTIVE\&quot; o \&quot;INACTIVO\&quot;..</param>
        /// <param name="updatedAt">Es la fecha en la que se actualizó el punto de venta. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;..</param>
        public SalesPointFound(string accessIp = default(string), string account = default(string), DateTime? createdAt = default(DateTime?), string name = default(string), string publicId = default(string), StatusEnum? status = default(StatusEnum?), DateTime? updatedAt = default(DateTime?))
        {
            this.AccessIp = accessIp;
            this.Account = account;
            this.CreatedAt = createdAt;
            this.Name = name;
            this.PublicId = publicId;
            this.Status = status;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Es la dirección IP desde la que accede el punto de venta a wire4 y a la que se devuelven las notificaciones.
        /// </summary>
        /// <value>Es la dirección IP desde la que accede el punto de venta a wire4 y a la que se devuelven las notificaciones.</value>
        [DataMember(Name="access_ip", EmitDefaultValue=false)]
        public string AccessIp { get; set; }

        /// <summary>
        /// Es la cuenta registra para el punto de venta.
        /// </summary>
        /// <value>Es la cuenta registra para el punto de venta.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// Es la fecha en la que se creó el punto de venta. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;.
        /// </summary>
        /// <value>Es la fecha en la que se creó el punto de venta. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Es el nombre del punto de venta.
        /// </summary>
        /// <value>Es el nombre del punto de venta.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Es el identificador del punto de venta.
        /// </summary>
        /// <value>Es el identificador del punto de venta.</value>
        [DataMember(Name="public_id", EmitDefaultValue=false)]
        public string PublicId { get; set; }


        /// <summary>
        /// Es la fecha en la que se actualizó el punto de venta. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;.
        /// </summary>
        /// <value>Es la fecha en la que se actualizó el punto de venta. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesPointFound {\n");
            sb.Append("  AccessIp: ").Append(AccessIp).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as SalesPointFound);
        }

        /// <summary>
        /// Returns true if SalesPointFound instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesPointFound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesPointFound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessIp == input.AccessIp ||
                    (this.AccessIp != null &&
                    this.AccessIp.Equals(input.AccessIp))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PublicId == input.PublicId ||
                    (this.PublicId != null &&
                    this.PublicId.Equals(input.PublicId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.AccessIp != null)
                    hashCode = hashCode * 59 + this.AccessIp.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PublicId != null)
                    hashCode = hashCode * 59 + this.PublicId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
