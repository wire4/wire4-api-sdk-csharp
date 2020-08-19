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
    /// Objeto que contiene información de la cuenta
    /// </summary>
    [DataContract]
        public partial class AccountSpid :  IEquatable<AccountSpid>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSpid" /> class.
        /// </summary>
        /// <param name="amountLimit">Monto límite permitido para la cuenta (required).</param>
        /// <param name="bankCodeBanxico">Código banxico con una longitud de 5 dígitos, es requerido en caso de que la cuenta del beneficiario sea un número de celular.</param>
        /// <param name="beneficiaryAccount">Cuenta del beneficiario debe ser una cuenta CLABE (required).</param>
        /// <param name="cancelReturnUrl">Url a la que se redirigira en caso no exitoso.</param>
        /// <param name="email">Lista de email&#x27;s, este dato es opcional.</param>
        /// <param name="institution">institution (required).</param>
        /// <param name="kindOfRelationship">Tipo de relación de la cuenta, este valor debe ser igual a uno de los obtenidos del recurso de consulta de relationships (required).</param>
        /// <param name="numericReference">Referencia numérica.</param>
        /// <param name="paymentConcept">Concepto de pago.</param>
        /// <param name="relationship">Código de relación de la cuenta, este valor debe ser igual a uno de los obtenidos del recurso de consulta de  relationship (required).</param>
        /// <param name="returnUrl">Url a la que se redireccionara en caso exitoso.</param>
        /// <param name="rfc">Registro federal de contribuyentes.</param>
        public AccountSpid(decimal? amountLimit = default(decimal?), string bankCodeBanxico = default(string), string beneficiaryAccount = default(string), string cancelReturnUrl = default(string), List<string> email = default(List<string>), BeneficiaryInstitution institution = default(BeneficiaryInstitution), string kindOfRelationship = default(string), string numericReference = default(string), string paymentConcept = default(string), string relationship = default(string), string returnUrl = default(string), string rfc = default(string))
        {
            // to ensure "amountLimit" is required (not null)
            if (amountLimit == null)
            {
                throw new InvalidDataException("amountLimit is a required property for AccountSpid and cannot be null");
            }
            else
            {
                this.AmountLimit = amountLimit;
            }
            // to ensure "beneficiaryAccount" is required (not null)
            if (beneficiaryAccount == null)
            {
                throw new InvalidDataException("beneficiaryAccount is a required property for AccountSpid and cannot be null");
            }
            else
            {
                this.BeneficiaryAccount = beneficiaryAccount;
            }
            // to ensure "institution" is required (not null)
            if (institution == null)
            {
                throw new InvalidDataException("institution is a required property for AccountSpid and cannot be null");
            }
            else
            {
                this.Institution = institution;
            }
            // to ensure "kindOfRelationship" is required (not null)
            if (kindOfRelationship == null)
            {
                throw new InvalidDataException("kindOfRelationship is a required property for AccountSpid and cannot be null");
            }
            else
            {
                this.KindOfRelationship = kindOfRelationship;
            }
            // to ensure "relationship" is required (not null)
            if (relationship == null)
            {
                throw new InvalidDataException("relationship is a required property for AccountSpid and cannot be null");
            }
            else
            {
                this.Relationship = relationship;
            }
            this.BankCodeBanxico = bankCodeBanxico;
            this.CancelReturnUrl = cancelReturnUrl;
            this.Email = email;
            this.NumericReference = numericReference;
            this.PaymentConcept = paymentConcept;
            this.ReturnUrl = returnUrl;
            this.Rfc = rfc;
        }
        
        /// <summary>
        /// Monto límite permitido para la cuenta
        /// </summary>
        /// <value>Monto límite permitido para la cuenta</value>
        [DataMember(Name="amount_limit", EmitDefaultValue=false)]
        public decimal? AmountLimit { get; set; }

        /// <summary>
        /// Código banxico con una longitud de 5 dígitos, es requerido en caso de que la cuenta del beneficiario sea un número de celular
        /// </summary>
        /// <value>Código banxico con una longitud de 5 dígitos, es requerido en caso de que la cuenta del beneficiario sea un número de celular</value>
        [DataMember(Name="bank_code_banxico", EmitDefaultValue=false)]
        public string BankCodeBanxico { get; set; }

        /// <summary>
        /// Cuenta del beneficiario debe ser una cuenta CLABE
        /// </summary>
        /// <value>Cuenta del beneficiario debe ser una cuenta CLABE</value>
        [DataMember(Name="beneficiary_account", EmitDefaultValue=false)]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// Url a la que se redirigira en caso no exitoso
        /// </summary>
        /// <value>Url a la que se redirigira en caso no exitoso</value>
        [DataMember(Name="cancel_return_url", EmitDefaultValue=false)]
        public string CancelReturnUrl { get; set; }

        /// <summary>
        /// Lista de email&#x27;s, este dato es opcional
        /// </summary>
        /// <value>Lista de email&#x27;s, este dato es opcional</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public List<string> Email { get; set; }

        /// <summary>
        /// Gets or Sets Institution
        /// </summary>
        [DataMember(Name="institution", EmitDefaultValue=false)]
        public BeneficiaryInstitution Institution { get; set; }

        /// <summary>
        /// Tipo de relación de la cuenta, este valor debe ser igual a uno de los obtenidos del recurso de consulta de relationships
        /// </summary>
        /// <value>Tipo de relación de la cuenta, este valor debe ser igual a uno de los obtenidos del recurso de consulta de relationships</value>
        [DataMember(Name="kind_of_relationship", EmitDefaultValue=false)]
        public string KindOfRelationship { get; set; }

        /// <summary>
        /// Referencia numérica
        /// </summary>
        /// <value>Referencia numérica</value>
        [DataMember(Name="numeric_reference", EmitDefaultValue=false)]
        public string NumericReference { get; set; }

        /// <summary>
        /// Concepto de pago
        /// </summary>
        /// <value>Concepto de pago</value>
        [DataMember(Name="payment_concept", EmitDefaultValue=false)]
        public string PaymentConcept { get; set; }

        /// <summary>
        /// Código de relación de la cuenta, este valor debe ser igual a uno de los obtenidos del recurso de consulta de  relationship
        /// </summary>
        /// <value>Código de relación de la cuenta, este valor debe ser igual a uno de los obtenidos del recurso de consulta de  relationship</value>
        [DataMember(Name="relationship", EmitDefaultValue=false)]
        public string Relationship { get; set; }

        /// <summary>
        /// Url a la que se redireccionara en caso exitoso
        /// </summary>
        /// <value>Url a la que se redireccionara en caso exitoso</value>
        [DataMember(Name="return_url", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Registro federal de contribuyentes
        /// </summary>
        /// <value>Registro federal de contribuyentes</value>
        [DataMember(Name="rfc", EmitDefaultValue=false)]
        public string Rfc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSpid {\n");
            sb.Append("  AmountLimit: ").Append(AmountLimit).Append("\n");
            sb.Append("  BankCodeBanxico: ").Append(BankCodeBanxico).Append("\n");
            sb.Append("  BeneficiaryAccount: ").Append(BeneficiaryAccount).Append("\n");
            sb.Append("  CancelReturnUrl: ").Append(CancelReturnUrl).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Institution: ").Append(Institution).Append("\n");
            sb.Append("  KindOfRelationship: ").Append(KindOfRelationship).Append("\n");
            sb.Append("  NumericReference: ").Append(NumericReference).Append("\n");
            sb.Append("  PaymentConcept: ").Append(PaymentConcept).Append("\n");
            sb.Append("  Relationship: ").Append(Relationship).Append("\n");
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
            return this.Equals(input as AccountSpid);
        }

        /// <summary>
        /// Returns true if AccountSpid instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountSpid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSpid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmountLimit == input.AmountLimit ||
                    (this.AmountLimit != null &&
                    this.AmountLimit.Equals(input.AmountLimit))
                ) && 
                (
                    this.BankCodeBanxico == input.BankCodeBanxico ||
                    (this.BankCodeBanxico != null &&
                    this.BankCodeBanxico.Equals(input.BankCodeBanxico))
                ) && 
                (
                    this.BeneficiaryAccount == input.BeneficiaryAccount ||
                    (this.BeneficiaryAccount != null &&
                    this.BeneficiaryAccount.Equals(input.BeneficiaryAccount))
                ) && 
                (
                    this.CancelReturnUrl == input.CancelReturnUrl ||
                    (this.CancelReturnUrl != null &&
                    this.CancelReturnUrl.Equals(input.CancelReturnUrl))
                ) && 
                (
                    this.Email == input.Email ||
                    this.Email != null &&
                    input.Email != null &&
                    this.Email.SequenceEqual(input.Email)
                ) && 
                (
                    this.Institution == input.Institution ||
                    (this.Institution != null &&
                    this.Institution.Equals(input.Institution))
                ) && 
                (
                    this.KindOfRelationship == input.KindOfRelationship ||
                    (this.KindOfRelationship != null &&
                    this.KindOfRelationship.Equals(input.KindOfRelationship))
                ) && 
                (
                    this.NumericReference == input.NumericReference ||
                    (this.NumericReference != null &&
                    this.NumericReference.Equals(input.NumericReference))
                ) && 
                (
                    this.PaymentConcept == input.PaymentConcept ||
                    (this.PaymentConcept != null &&
                    this.PaymentConcept.Equals(input.PaymentConcept))
                ) && 
                (
                    this.Relationship == input.Relationship ||
                    (this.Relationship != null &&
                    this.Relationship.Equals(input.Relationship))
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
                if (this.AmountLimit != null)
                    hashCode = hashCode * 59 + this.AmountLimit.GetHashCode();
                if (this.BankCodeBanxico != null)
                    hashCode = hashCode * 59 + this.BankCodeBanxico.GetHashCode();
                if (this.BeneficiaryAccount != null)
                    hashCode = hashCode * 59 + this.BeneficiaryAccount.GetHashCode();
                if (this.CancelReturnUrl != null)
                    hashCode = hashCode * 59 + this.CancelReturnUrl.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Institution != null)
                    hashCode = hashCode * 59 + this.Institution.GetHashCode();
                if (this.KindOfRelationship != null)
                    hashCode = hashCode * 59 + this.KindOfRelationship.GetHashCode();
                if (this.NumericReference != null)
                    hashCode = hashCode * 59 + this.NumericReference.GetHashCode();
                if (this.PaymentConcept != null)
                    hashCode = hashCode * 59 + this.PaymentConcept.GetHashCode();
                if (this.Relationship != null)
                    hashCode = hashCode * 59 + this.Relationship.GetHashCode();
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
