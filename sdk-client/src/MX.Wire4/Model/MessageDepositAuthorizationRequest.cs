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
    /// El mensaje que se envía mediante (webHook) con la información de un deposito que necesita ser autorizado
    /// </summary>
    [DataContract]
        public partial class MessageDepositAuthorizationRequest :  IEquatable<MessageDepositAuthorizationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDepositAuthorizationRequest" /> class.
        /// </summary>
        /// <param name="amount">Monto de la transferencia.</param>
        /// <param name="beneficiaryAccount">Cuenta del beneficiario.</param>
        /// <param name="beneficiaryName">Nombre del beneficiario.</param>
        /// <param name="beneficiaryRfc">RFC del beneficiario.</param>
        /// <param name="claveRastreo">Clave de rastreo de la transferencia.</param>
        /// <param name="confirmDate">Fecha de confirmación de la transferencia.</param>
        /// <param name="currencyCode">Código de moneda de la transferencia, puede ser MXP, USD.</param>
        /// <param name="depositDate">Fecha de recepción de la transferencia.</param>
        /// <param name="depositant">Nombre del depositante, en caso que la transferencia se reciba en una cuenta de depositante.</param>
        /// <param name="depositantClabe">CLABE del depositante, en caso que la transferencia se reciba en una cuenta de depositante.</param>
        /// <param name="depositantEmail">Correo electrónico del depositante, en caso que la transferencia se reciba en una cuenta de depositante.</param>
        /// <param name="depositantRfc">RFC del depositante, en caso que la transferencia se reciba en una cuenta de depositante.</param>
        /// <param name="description">Concepto de la transferencia.</param>
        /// <param name="monexDescription">Descripción de Monex para la transferencia.</param>
        /// <param name="monexTransactionId">Identificador asignado por Monex a la transferencia.</param>
        /// <param name="reference">Referecia de la transferencia.</param>
        /// <param name="senderAccount">Cuenta del ordenante, podría ser un número celular, TDD o Cuenta CLABE interbancaria.</param>
        /// <param name="senderBank">senderBank.</param>
        /// <param name="senderName">Nombre del ordenante.</param>
        /// <param name="senderRfc">RFC del ordenante.</param>
        public MessageDepositAuthorizationRequest(decimal? amount = default(decimal?), string beneficiaryAccount = default(string), string beneficiaryName = default(string), string beneficiaryRfc = default(string), string claveRastreo = default(string), DateTime? confirmDate = default(DateTime?), string currencyCode = default(string), DateTime? depositDate = default(DateTime?), string depositant = default(string), string depositantClabe = default(string), string depositantEmail = default(string), string depositantRfc = default(string), string description = default(string), string monexDescription = default(string), string monexTransactionId = default(string), string reference = default(string), string senderAccount = default(string), MessageInstitution senderBank = default(MessageInstitution), string senderName = default(string), string senderRfc = default(string))
        {
            this.Amount = amount;
            this.BeneficiaryAccount = beneficiaryAccount;
            this.BeneficiaryName = beneficiaryName;
            this.BeneficiaryRfc = beneficiaryRfc;
            this.ClaveRastreo = claveRastreo;
            this.ConfirmDate = confirmDate;
            this.CurrencyCode = currencyCode;
            this.DepositDate = depositDate;
            this.Depositant = depositant;
            this.DepositantClabe = depositantClabe;
            this.DepositantEmail = depositantEmail;
            this.DepositantRfc = depositantRfc;
            this.Description = description;
            this.MonexDescription = monexDescription;
            this.MonexTransactionId = monexTransactionId;
            this.Reference = reference;
            this.SenderAccount = senderAccount;
            this.SenderBank = senderBank;
            this.SenderName = senderName;
            this.SenderRfc = senderRfc;
        }
        
        /// <summary>
        /// Monto de la transferencia
        /// </summary>
        /// <value>Monto de la transferencia</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Cuenta del beneficiario
        /// </summary>
        /// <value>Cuenta del beneficiario</value>
        [DataMember(Name="beneficiary_account", EmitDefaultValue=false)]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// Nombre del beneficiario
        /// </summary>
        /// <value>Nombre del beneficiario</value>
        [DataMember(Name="beneficiary_name", EmitDefaultValue=false)]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// RFC del beneficiario
        /// </summary>
        /// <value>RFC del beneficiario</value>
        [DataMember(Name="beneficiary_rfc", EmitDefaultValue=false)]
        public string BeneficiaryRfc { get; set; }

        /// <summary>
        /// Clave de rastreo de la transferencia
        /// </summary>
        /// <value>Clave de rastreo de la transferencia</value>
        [DataMember(Name="clave_rastreo", EmitDefaultValue=false)]
        public string ClaveRastreo { get; set; }

        /// <summary>
        /// Fecha de confirmación de la transferencia
        /// </summary>
        /// <value>Fecha de confirmación de la transferencia</value>
        [DataMember(Name="confirm_date", EmitDefaultValue=false)]
        public DateTime? ConfirmDate { get; set; }

        /// <summary>
        /// Código de moneda de la transferencia, puede ser MXP, USD
        /// </summary>
        /// <value>Código de moneda de la transferencia, puede ser MXP, USD</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Fecha de recepción de la transferencia
        /// </summary>
        /// <value>Fecha de recepción de la transferencia</value>
        [DataMember(Name="deposit_date", EmitDefaultValue=false)]
        public DateTime? DepositDate { get; set; }

        /// <summary>
        /// Nombre del depositante, en caso que la transferencia se reciba en una cuenta de depositante
        /// </summary>
        /// <value>Nombre del depositante, en caso que la transferencia se reciba en una cuenta de depositante</value>
        [DataMember(Name="depositant", EmitDefaultValue=false)]
        public string Depositant { get; set; }

        /// <summary>
        /// CLABE del depositante, en caso que la transferencia se reciba en una cuenta de depositante
        /// </summary>
        /// <value>CLABE del depositante, en caso que la transferencia se reciba en una cuenta de depositante</value>
        [DataMember(Name="depositant_clabe", EmitDefaultValue=false)]
        public string DepositantClabe { get; set; }

        /// <summary>
        /// Correo electrónico del depositante, en caso que la transferencia se reciba en una cuenta de depositante
        /// </summary>
        /// <value>Correo electrónico del depositante, en caso que la transferencia se reciba en una cuenta de depositante</value>
        [DataMember(Name="depositant_email", EmitDefaultValue=false)]
        public string DepositantEmail { get; set; }

        /// <summary>
        /// RFC del depositante, en caso que la transferencia se reciba en una cuenta de depositante
        /// </summary>
        /// <value>RFC del depositante, en caso que la transferencia se reciba en una cuenta de depositante</value>
        [DataMember(Name="depositant_rfc", EmitDefaultValue=false)]
        public string DepositantRfc { get; set; }

        /// <summary>
        /// Concepto de la transferencia
        /// </summary>
        /// <value>Concepto de la transferencia</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Descripción de Monex para la transferencia
        /// </summary>
        /// <value>Descripción de Monex para la transferencia</value>
        [DataMember(Name="monex_description", EmitDefaultValue=false)]
        public string MonexDescription { get; set; }

        /// <summary>
        /// Identificador asignado por Monex a la transferencia
        /// </summary>
        /// <value>Identificador asignado por Monex a la transferencia</value>
        [DataMember(Name="monex_transaction_id", EmitDefaultValue=false)]
        public string MonexTransactionId { get; set; }

        /// <summary>
        /// Referecia de la transferencia
        /// </summary>
        /// <value>Referecia de la transferencia</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Cuenta del ordenante, podría ser un número celular, TDD o Cuenta CLABE interbancaria
        /// </summary>
        /// <value>Cuenta del ordenante, podría ser un número celular, TDD o Cuenta CLABE interbancaria</value>
        [DataMember(Name="sender_account", EmitDefaultValue=false)]
        public string SenderAccount { get; set; }

        /// <summary>
        /// Gets or Sets SenderBank
        /// </summary>
        [DataMember(Name="sender_bank", EmitDefaultValue=false)]
        public MessageInstitution SenderBank { get; set; }

        /// <summary>
        /// Nombre del ordenante
        /// </summary>
        /// <value>Nombre del ordenante</value>
        [DataMember(Name="sender_name", EmitDefaultValue=false)]
        public string SenderName { get; set; }

        /// <summary>
        /// RFC del ordenante
        /// </summary>
        /// <value>RFC del ordenante</value>
        [DataMember(Name="sender_rfc", EmitDefaultValue=false)]
        public string SenderRfc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageDepositAuthorizationRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BeneficiaryAccount: ").Append(BeneficiaryAccount).Append("\n");
            sb.Append("  BeneficiaryName: ").Append(BeneficiaryName).Append("\n");
            sb.Append("  BeneficiaryRfc: ").Append(BeneficiaryRfc).Append("\n");
            sb.Append("  ClaveRastreo: ").Append(ClaveRastreo).Append("\n");
            sb.Append("  ConfirmDate: ").Append(ConfirmDate).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DepositDate: ").Append(DepositDate).Append("\n");
            sb.Append("  Depositant: ").Append(Depositant).Append("\n");
            sb.Append("  DepositantClabe: ").Append(DepositantClabe).Append("\n");
            sb.Append("  DepositantEmail: ").Append(DepositantEmail).Append("\n");
            sb.Append("  DepositantRfc: ").Append(DepositantRfc).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MonexDescription: ").Append(MonexDescription).Append("\n");
            sb.Append("  MonexTransactionId: ").Append(MonexTransactionId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SenderAccount: ").Append(SenderAccount).Append("\n");
            sb.Append("  SenderBank: ").Append(SenderBank).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  SenderRfc: ").Append(SenderRfc).Append("\n");
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
            return this.Equals(input as MessageDepositAuthorizationRequest);
        }

        /// <summary>
        /// Returns true if MessageDepositAuthorizationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageDepositAuthorizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageDepositAuthorizationRequest input)
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
                    this.BeneficiaryName == input.BeneficiaryName ||
                    (this.BeneficiaryName != null &&
                    this.BeneficiaryName.Equals(input.BeneficiaryName))
                ) && 
                (
                    this.BeneficiaryRfc == input.BeneficiaryRfc ||
                    (this.BeneficiaryRfc != null &&
                    this.BeneficiaryRfc.Equals(input.BeneficiaryRfc))
                ) && 
                (
                    this.ClaveRastreo == input.ClaveRastreo ||
                    (this.ClaveRastreo != null &&
                    this.ClaveRastreo.Equals(input.ClaveRastreo))
                ) && 
                (
                    this.ConfirmDate == input.ConfirmDate ||
                    (this.ConfirmDate != null &&
                    this.ConfirmDate.Equals(input.ConfirmDate))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.DepositDate == input.DepositDate ||
                    (this.DepositDate != null &&
                    this.DepositDate.Equals(input.DepositDate))
                ) && 
                (
                    this.Depositant == input.Depositant ||
                    (this.Depositant != null &&
                    this.Depositant.Equals(input.Depositant))
                ) && 
                (
                    this.DepositantClabe == input.DepositantClabe ||
                    (this.DepositantClabe != null &&
                    this.DepositantClabe.Equals(input.DepositantClabe))
                ) && 
                (
                    this.DepositantEmail == input.DepositantEmail ||
                    (this.DepositantEmail != null &&
                    this.DepositantEmail.Equals(input.DepositantEmail))
                ) && 
                (
                    this.DepositantRfc == input.DepositantRfc ||
                    (this.DepositantRfc != null &&
                    this.DepositantRfc.Equals(input.DepositantRfc))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MonexDescription == input.MonexDescription ||
                    (this.MonexDescription != null &&
                    this.MonexDescription.Equals(input.MonexDescription))
                ) && 
                (
                    this.MonexTransactionId == input.MonexTransactionId ||
                    (this.MonexTransactionId != null &&
                    this.MonexTransactionId.Equals(input.MonexTransactionId))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SenderAccount == input.SenderAccount ||
                    (this.SenderAccount != null &&
                    this.SenderAccount.Equals(input.SenderAccount))
                ) && 
                (
                    this.SenderBank == input.SenderBank ||
                    (this.SenderBank != null &&
                    this.SenderBank.Equals(input.SenderBank))
                ) && 
                (
                    this.SenderName == input.SenderName ||
                    (this.SenderName != null &&
                    this.SenderName.Equals(input.SenderName))
                ) && 
                (
                    this.SenderRfc == input.SenderRfc ||
                    (this.SenderRfc != null &&
                    this.SenderRfc.Equals(input.SenderRfc))
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
                if (this.BeneficiaryName != null)
                    hashCode = hashCode * 59 + this.BeneficiaryName.GetHashCode();
                if (this.BeneficiaryRfc != null)
                    hashCode = hashCode * 59 + this.BeneficiaryRfc.GetHashCode();
                if (this.ClaveRastreo != null)
                    hashCode = hashCode * 59 + this.ClaveRastreo.GetHashCode();
                if (this.ConfirmDate != null)
                    hashCode = hashCode * 59 + this.ConfirmDate.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.DepositDate != null)
                    hashCode = hashCode * 59 + this.DepositDate.GetHashCode();
                if (this.Depositant != null)
                    hashCode = hashCode * 59 + this.Depositant.GetHashCode();
                if (this.DepositantClabe != null)
                    hashCode = hashCode * 59 + this.DepositantClabe.GetHashCode();
                if (this.DepositantEmail != null)
                    hashCode = hashCode * 59 + this.DepositantEmail.GetHashCode();
                if (this.DepositantRfc != null)
                    hashCode = hashCode * 59 + this.DepositantRfc.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MonexDescription != null)
                    hashCode = hashCode * 59 + this.MonexDescription.GetHashCode();
                if (this.MonexTransactionId != null)
                    hashCode = hashCode * 59 + this.MonexTransactionId.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.SenderAccount != null)
                    hashCode = hashCode * 59 + this.SenderAccount.GetHashCode();
                if (this.SenderBank != null)
                    hashCode = hashCode * 59 + this.SenderBank.GetHashCode();
                if (this.SenderName != null)
                    hashCode = hashCode * 59 + this.SenderName.GetHashCode();
                if (this.SenderRfc != null)
                    hashCode = hashCode * 59 + this.SenderRfc.GetHashCode();
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