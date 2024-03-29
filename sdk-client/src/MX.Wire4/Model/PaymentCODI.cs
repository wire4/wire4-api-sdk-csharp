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
    /// Objeto que contiene la información del pago realizado
    /// </summary>
    [DataContract]
        public partial class PaymentCODI :  IEquatable<PaymentCODI>, IValidatableObject
    {
        /// <summary>
        /// Estatus del pago
        /// </summary>
        /// <value>Estatus del pago</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum ACCEPTED for value: ACCEPTED
            /// </summary>
            [EnumMember(Value = "ACCEPTED")]
            ACCEPTED = 1,
            /// <summary>
            /// Enum RECEIVED for value: RECEIVED
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            RECEIVED = 2,
            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 3,
            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 4,
            /// <summary>
            /// Enum POSTPONED for value: POSTPONED
            /// </summary>
            [EnumMember(Value = "POSTPONED")]
            POSTPONED = 5,
            /// <summary>
            /// Enum REJECTED for value: REJECTED
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED = 6,
            /// <summary>
            /// Enum REVERSED for value: REVERSED
            /// </summary>
            [EnumMember(Value = "REVERSED")]
            REVERSED = 7,
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 8        }
        /// <summary>
        /// Estatus del pago
        /// </summary>
        /// <value>Estatus del pago</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCODI" /> class.
        /// </summary>
        /// <param name="amount">Monto del pago.</param>
        /// <param name="description">Descripción del pago.</param>
        /// <param name="errorMessage">Mensaje de error.</param>
        /// <param name="id">Identificador del pago.</param>
        /// <param name="operationDate">Fecha en que se efectuo el pago.</param>
        /// <param name="status">Estatus del pago.</param>
        public PaymentCODI(decimal? amount = default(decimal?), string description = default(string), string errorMessage = default(string), string id = default(string), DateTime? operationDate = default(DateTime?), StatusEnum? status = default(StatusEnum?))
        {
            this.Amount = amount;
            this.Description = description;
            this.ErrorMessage = errorMessage;
            this.Id = id;
            this.OperationDate = operationDate;
            this.Status = status;
        }
        
        /// <summary>
        /// Monto del pago
        /// </summary>
        /// <value>Monto del pago</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Descripción del pago
        /// </summary>
        /// <value>Descripción del pago</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Mensaje de error
        /// </summary>
        /// <value>Mensaje de error</value>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Identificador del pago
        /// </summary>
        /// <value>Identificador del pago</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Fecha en que se efectuo el pago
        /// </summary>
        /// <value>Fecha en que se efectuo el pago</value>
        [DataMember(Name="operation_date", EmitDefaultValue=false)]
        public DateTime? OperationDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCODI {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OperationDate: ").Append(OperationDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as PaymentCODI);
        }

        /// <summary>
        /// Returns true if PaymentCODI instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCODI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCODI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OperationDate == input.OperationDate ||
                    (this.OperationDate != null &&
                    this.OperationDate.Equals(input.OperationDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OperationDate != null)
                    hashCode = hashCode * 59 + this.OperationDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
