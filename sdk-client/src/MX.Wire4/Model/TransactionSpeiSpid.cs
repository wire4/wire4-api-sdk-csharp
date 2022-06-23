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
    /// Objeto que contiene la información de una transferencia SPID® de salida.
    /// </summary>
    [DataContract]
        public partial class TransactionSpeiSpid :  IEquatable<TransactionSpeiSpid>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSpeiSpid" /> class.
        /// </summary>
        /// <param name="amount">Es el monto de la transferencia. Se valida que sean máximo 20 dígitos y 2 decimales. Ejemplo 1000.00 (required).</param>
        /// <param name="beneficiaryAccount">Cuenta del beneficiario, podría ser un número celular (10dígitos), tarjeta de débito (TDD) o Cuenta CLABE interbancaria (18 dígitos).  (required).</param>
        /// <param name="classificationId">Es el identificador de la clasificación de la transferencia SPID. (required).</param>
        /// <param name="concept">Es el concepto de la transferencia. (required).</param>
        /// <param name="currencyCode">Código de moneda en la que opera la cuenta..</param>
        /// <param name="email">Lista de correo electrónico (email) del beneficiario. Este campo es opcional..</param>
        /// <param name="orderId">Es la referencia de la transferencia asignada por el cliente. Ejemplo: dae9c6ae-8c7a-42e8-99f4-ebe90566efae (required).</param>
        /// <param name="reference">Es la referencia numérica de la transferencia. (required).</param>
        public TransactionSpeiSpid(decimal? amount = default(decimal?), string beneficiaryAccount = default(string), string classificationId = default(string), string concept = default(string), string currencyCode = default(string), List<string> email = default(List<string>), string orderId = default(string), int? reference = default(int?))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for TransactionSpeiSpid and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "beneficiaryAccount" is required (not null)
            if (beneficiaryAccount == null)
            {
                throw new InvalidDataException("beneficiaryAccount is a required property for TransactionSpeiSpid and cannot be null");
            }
            else
            {
                this.BeneficiaryAccount = beneficiaryAccount;
            }
            // to ensure "classificationId" is required (not null)
            if (classificationId == null)
            {
                throw new InvalidDataException("classificationId is a required property for TransactionSpeiSpid and cannot be null");
            }
            else
            {
                this.ClassificationId = classificationId;
            }
            // to ensure "concept" is required (not null)
            if (concept == null)
            {
                throw new InvalidDataException("concept is a required property for TransactionSpeiSpid and cannot be null");
            }
            else
            {
                this.Concept = concept;
            }
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for TransactionSpeiSpid and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new InvalidDataException("reference is a required property for TransactionSpeiSpid and cannot be null");
            }
            else
            {
                this.Reference = reference;
            }
            this.CurrencyCode = currencyCode;
            this.Email = email;
        }
        
        /// <summary>
        /// Es el monto de la transferencia. Se valida que sean máximo 20 dígitos y 2 decimales. Ejemplo 1000.00
        /// </summary>
        /// <value>Es el monto de la transferencia. Se valida que sean máximo 20 dígitos y 2 decimales. Ejemplo 1000.00</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Cuenta del beneficiario, podría ser un número celular (10dígitos), tarjeta de débito (TDD) o Cuenta CLABE interbancaria (18 dígitos). 
        /// </summary>
        /// <value>Cuenta del beneficiario, podría ser un número celular (10dígitos), tarjeta de débito (TDD) o Cuenta CLABE interbancaria (18 dígitos). </value>
        [DataMember(Name="beneficiary_account", EmitDefaultValue=false)]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// Es el identificador de la clasificación de la transferencia SPID.
        /// </summary>
        /// <value>Es el identificador de la clasificación de la transferencia SPID.</value>
        [DataMember(Name="classification_id", EmitDefaultValue=false)]
        public string ClassificationId { get; set; }

        /// <summary>
        /// Es el concepto de la transferencia.
        /// </summary>
        /// <value>Es el concepto de la transferencia.</value>
        [DataMember(Name="concept", EmitDefaultValue=false)]
        public string Concept { get; set; }

        /// <summary>
        /// Código de moneda en la que opera la cuenta.
        /// </summary>
        /// <value>Código de moneda en la que opera la cuenta.</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Lista de correo electrónico (email) del beneficiario. Este campo es opcional.
        /// </summary>
        /// <value>Lista de correo electrónico (email) del beneficiario. Este campo es opcional.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public List<string> Email { get; set; }

        /// <summary>
        /// Es la referencia de la transferencia asignada por el cliente. Ejemplo: dae9c6ae-8c7a-42e8-99f4-ebe90566efae
        /// </summary>
        /// <value>Es la referencia de la transferencia asignada por el cliente. Ejemplo: dae9c6ae-8c7a-42e8-99f4-ebe90566efae</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Es la referencia numérica de la transferencia.
        /// </summary>
        /// <value>Es la referencia numérica de la transferencia.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public int? Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionSpeiSpid {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BeneficiaryAccount: ").Append(BeneficiaryAccount).Append("\n");
            sb.Append("  ClassificationId: ").Append(ClassificationId).Append("\n");
            sb.Append("  Concept: ").Append(Concept).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as TransactionSpeiSpid);
        }

        /// <summary>
        /// Returns true if TransactionSpeiSpid instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionSpeiSpid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionSpeiSpid input)
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
                    this.BeneficiaryAccount == input.BeneficiaryAccount ||
                    (this.BeneficiaryAccount != null &&
                    this.BeneficiaryAccount.Equals(input.BeneficiaryAccount))
                ) && 
                (
                    this.ClassificationId == input.ClassificationId ||
                    (this.ClassificationId != null &&
                    this.ClassificationId.Equals(input.ClassificationId))
                ) && 
                (
                    this.Concept == input.Concept ||
                    (this.Concept != null &&
                    this.Concept.Equals(input.Concept))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Email == input.Email ||
                    this.Email != null &&
                    input.Email != null &&
                    this.Email.SequenceEqual(input.Email)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.BeneficiaryAccount != null)
                    hashCode = hashCode * 59 + this.BeneficiaryAccount.GetHashCode();
                if (this.ClassificationId != null)
                    hashCode = hashCode * 59 + this.ClassificationId.GetHashCode();
                if (this.Concept != null)
                    hashCode = hashCode * 59 + this.Concept.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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