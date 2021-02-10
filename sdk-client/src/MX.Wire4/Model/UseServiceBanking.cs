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
    /// Uso y estado de la subscripción
    /// </summary>
    [DataContract]
        public partial class UseServiceBanking :  IEquatable<UseServiceBanking>, IValidatableObject
    {
        /// <summary>
        /// Estatus que se le asigna a la subscripción
        /// </summary>
        /// <value>Estatus que se le asigna a la subscripción</value>
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
        /// Estatus que se le asigna a la subscripción
        /// </summary>
        /// <value>Estatus que se le asigna a la subscripción</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Uso que se le desea dar a la subscripción
        /// </summary>
        /// <value>Uso que se le desea dar a la subscripción</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UseEnum
        {
            /// <summary>
            /// Enum WITHDRAWALDEPOSIT for value: WITHDRAWAL_DEPOSIT
            /// </summary>
            [EnumMember(Value = "WITHDRAWAL_DEPOSIT")]
            WITHDRAWALDEPOSIT = 0,
            /// <summary>
            /// Enum WITHDRAWAL for value: WITHDRAWAL
            /// </summary>
            [EnumMember(Value = "WITHDRAWAL")]
            WITHDRAWAL = 1,
            /// <summary>
            /// Enum DEPOSIT for value: DEPOSIT
            /// </summary>
            [EnumMember(Value = "DEPOSIT")]
            DEPOSIT = 2        }
        /// <summary>
        /// Uso que se le desea dar a la subscripción
        /// </summary>
        /// <value>Uso que se le desea dar a la subscripción</value>
        [DataMember(Name="use", EmitDefaultValue=false)]
        public UseEnum Use { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UseServiceBanking" /> class.
        /// </summary>
        /// <param name="status">Estatus que se le asigna a la subscripción (required).</param>
        /// <param name="use">Uso que se le desea dar a la subscripción (required).</param>
        public UseServiceBanking(StatusEnum status = default(StatusEnum), UseEnum use = default(UseEnum))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for UseServiceBanking and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "use" is required (not null)
            if (use == null)
            {
                throw new InvalidDataException("use is a required property for UseServiceBanking and cannot be null");
            }
            else
            {
                this.Use = use;
            }
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UseServiceBanking {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Use: ").Append(Use).Append("\n");
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
            return this.Equals(input as UseServiceBanking);
        }

        /// <summary>
        /// Returns true if UseServiceBanking instances are equal
        /// </summary>
        /// <param name="input">Instance of UseServiceBanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UseServiceBanking input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Use == input.Use ||
                    (this.Use != null &&
                    this.Use.Equals(input.Use))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Use != null)
                    hashCode = hashCode * 59 + this.Use.GetHashCode();
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
