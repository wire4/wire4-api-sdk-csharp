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
    /// Objeto que contiene la información de solicitud de pago por CODI®.
    /// </summary>
    [DataContract]
        public partial class CodiOperationResponseDTO :  IEquatable<CodiOperationResponseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodiOperationResponseDTO" /> class.
        /// </summary>
        /// <param name="amount">Monto de la operacion..</param>
        /// <param name="concept">Concepto del pago..</param>
        /// <param name="id">Identificador de la operacion..</param>
        /// <param name="operationDate">Fecha de la operacion..</param>
        /// <param name="paymentType">Tipo de pago..</param>
        /// <param name="status">Estatus..</param>
        /// <param name="transactionId">Identificador de la transacción..</param>
        public CodiOperationResponseDTO(decimal? amount = default(decimal?), string concept = default(string), string id = default(string), DateTime? operationDate = default(DateTime?), string paymentType = default(string), string status = default(string), string transactionId = default(string))
        {
            this.Amount = amount;
            this.Concept = concept;
            this.Id = id;
            this.OperationDate = operationDate;
            this.PaymentType = paymentType;
            this.Status = status;
            this.TransactionId = transactionId;
        }
        
        /// <summary>
        /// Monto de la operacion.
        /// </summary>
        /// <value>Monto de la operacion.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Concepto del pago.
        /// </summary>
        /// <value>Concepto del pago.</value>
        [DataMember(Name="concept", EmitDefaultValue=false)]
        public string Concept { get; set; }

        /// <summary>
        /// Identificador de la operacion.
        /// </summary>
        /// <value>Identificador de la operacion.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Fecha de la operacion.
        /// </summary>
        /// <value>Fecha de la operacion.</value>
        [DataMember(Name="operation_date", EmitDefaultValue=false)]
        public DateTime? OperationDate { get; set; }

        /// <summary>
        /// Tipo de pago.
        /// </summary>
        /// <value>Tipo de pago.</value>
        [DataMember(Name="payment_type", EmitDefaultValue=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// Estatus.
        /// </summary>
        /// <value>Estatus.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Identificador de la transacción.
        /// </summary>
        /// <value>Identificador de la transacción.</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodiOperationResponseDTO {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Concept: ").Append(Concept).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OperationDate: ").Append(OperationDate).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as CodiOperationResponseDTO);
        }

        /// <summary>
        /// Returns true if CodiOperationResponseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of CodiOperationResponseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodiOperationResponseDTO input)
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
                    this.Concept == input.Concept ||
                    (this.Concept != null &&
                    this.Concept.Equals(input.Concept))
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
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.Concept != null)
                    hashCode = hashCode * 59 + this.Concept.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OperationDate != null)
                    hashCode = hashCode * 59 + this.OperationDate.GetHashCode();
                if (this.PaymentType != null)
                    hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
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