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
    /// Deposit
    /// </summary>
    [DataContract]
        public partial class Deposit :  IEquatable<Deposit>, IValidatableObject
    {
        /// <summary>
        /// Es el estatus del depósito (COMPLETED/RETURNED).
        /// </summary>
        /// <value>Es el estatus del depósito (COMPLETED/RETURNED).</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 1,
            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 2,
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 3,
            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 4,
            /// <summary>
            /// Enum AUTHORIZING for value: AUTHORIZING
            /// </summary>
            [EnumMember(Value = "AUTHORIZING")]
            AUTHORIZING = 5,
            /// <summary>
            /// Enum REJECTED for value: REJECTED
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED = 6        }
        /// <summary>
        /// Es el estatus del depósito (COMPLETED/RETURNED).
        /// </summary>
        /// <value>Es el estatus del depósito (COMPLETED/RETURNED).</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Deposit" /> class.
        /// </summary>
        /// <param name="amount">Es el monto de la transferencia..</param>
        /// <param name="beneficiaryAccount">Es la cuenta del beneficiario..</param>
        /// <param name="beneficiaryName">Es el nombre del beneficiario..</param>
        /// <param name="beneficiaryRfc">Es el Registro Federal de Contribuyentes (RFC) del beneficiario..</param>
        /// <param name="cep">cep.</param>
        /// <param name="claveRastreo">Es la clave de rastreo de la transferencia..</param>
        /// <param name="confirmDate">Es la fecha de confirmación del deposito. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;..</param>
        /// <param name="currencyCode">Es el código de divisa de la transferencia. Es en el formato estándar de 3 dígitos, por ejemplo para el peso mexicano: &lt;b&gt;MXP&lt;/b&gt;, para el dólar estadounidense: &lt;b&gt;USD&lt;/b&gt;..</param>
        /// <param name="depositDate">Es la fecha del deposito.  Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;..</param>
        /// <param name="depositant">Es el depositante..</param>
        /// <param name="depositantAlias">Es el alias asignado a la cuenta CABLE del depositante..</param>
        /// <param name="depositantClabe">Es la Cuenta CLABE interbancaria (de 18 dígitos) del depositante..</param>
        /// <param name="depositantEmail">Es el correo electrónico (email) del depositante..</param>
        /// <param name="depositantRfc">Es el Registro Federal de Contribuyentes (RFC) del depositante..</param>
        /// <param name="description">Es la descripción del traspaso..</param>
        /// <param name="monexDescription">Es la descripción directa de Monex..</param>
        /// <param name="monexTransactionId">es el identificador de la transferencia en Monex..</param>
        /// <param name="reference">Es la referencia del depósito..</param>
        /// <param name="senderAccount">Es la cuenta del ordenante..</param>
        /// <param name="senderBank">senderBank.</param>
        /// <param name="senderName">Es el nombre del ordenante..</param>
        /// <param name="senderRfc">Es el Registro Federal de Contribuyentes (RFC) de la cuenta ordenante..</param>
        /// <param name="status">Es el estatus del depósito (COMPLETED/RETURNED)..</param>
        public Deposit(decimal? amount = default(decimal?), string beneficiaryAccount = default(string), string beneficiaryName = default(string), string beneficiaryRfc = default(string), MessageCEP cep = default(MessageCEP), string claveRastreo = default(string), DateTime? confirmDate = default(DateTime?), string currencyCode = default(string), DateTime? depositDate = default(DateTime?), string depositant = default(string), string depositantAlias = default(string), string depositantClabe = default(string), string depositantEmail = default(string), string depositantRfc = default(string), string description = default(string), string monexDescription = default(string), string monexTransactionId = default(string), string reference = default(string), string senderAccount = default(string), MessageInstitution senderBank = default(MessageInstitution), string senderName = default(string), string senderRfc = default(string), StatusEnum? status = default(StatusEnum?))
        {
            this.Amount = amount;
            this.BeneficiaryAccount = beneficiaryAccount;
            this.BeneficiaryName = beneficiaryName;
            this.BeneficiaryRfc = beneficiaryRfc;
            this.Cep = cep;
            this.ClaveRastreo = claveRastreo;
            this.ConfirmDate = confirmDate;
            this.CurrencyCode = currencyCode;
            this.DepositDate = depositDate;
            this.Depositant = depositant;
            this.DepositantAlias = depositantAlias;
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
            this.Status = status;
        }
        
        /// <summary>
        /// Es el monto de la transferencia.
        /// </summary>
        /// <value>Es el monto de la transferencia.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Es la cuenta del beneficiario.
        /// </summary>
        /// <value>Es la cuenta del beneficiario.</value>
        [DataMember(Name="beneficiary_account", EmitDefaultValue=false)]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// Es el nombre del beneficiario.
        /// </summary>
        /// <value>Es el nombre del beneficiario.</value>
        [DataMember(Name="beneficiary_name", EmitDefaultValue=false)]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// Es el Registro Federal de Contribuyentes (RFC) del beneficiario.
        /// </summary>
        /// <value>Es el Registro Federal de Contribuyentes (RFC) del beneficiario.</value>
        [DataMember(Name="beneficiary_rfc", EmitDefaultValue=false)]
        public string BeneficiaryRfc { get; set; }

        /// <summary>
        /// Gets or Sets Cep
        /// </summary>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public MessageCEP Cep { get; set; }

        /// <summary>
        /// Es la clave de rastreo de la transferencia.
        /// </summary>
        /// <value>Es la clave de rastreo de la transferencia.</value>
        [DataMember(Name="clave_rastreo", EmitDefaultValue=false)]
        public string ClaveRastreo { get; set; }

        /// <summary>
        /// Es la fecha de confirmación del deposito. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;.
        /// </summary>
        /// <value>Es la fecha de confirmación del deposito. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;.</value>
        [DataMember(Name="confirm_date", EmitDefaultValue=false)]
        public DateTime? ConfirmDate { get; set; }

        /// <summary>
        /// Es el código de divisa de la transferencia. Es en el formato estándar de 3 dígitos, por ejemplo para el peso mexicano: &lt;b&gt;MXP&lt;/b&gt;, para el dólar estadounidense: &lt;b&gt;USD&lt;/b&gt;.
        /// </summary>
        /// <value>Es el código de divisa de la transferencia. Es en el formato estándar de 3 dígitos, por ejemplo para el peso mexicano: &lt;b&gt;MXP&lt;/b&gt;, para el dólar estadounidense: &lt;b&gt;USD&lt;/b&gt;.</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Es la fecha del deposito.  Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;.
        /// </summary>
        /// <value>Es la fecha del deposito.  Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;.</value>
        [DataMember(Name="deposit_date", EmitDefaultValue=false)]
        public DateTime? DepositDate { get; set; }

        /// <summary>
        /// Es el depositante.
        /// </summary>
        /// <value>Es el depositante.</value>
        [DataMember(Name="depositant", EmitDefaultValue=false)]
        public string Depositant { get; set; }

        /// <summary>
        /// Es el alias asignado a la cuenta CABLE del depositante.
        /// </summary>
        /// <value>Es el alias asignado a la cuenta CABLE del depositante.</value>
        [DataMember(Name="depositant_alias", EmitDefaultValue=false)]
        public string DepositantAlias { get; set; }

        /// <summary>
        /// Es la Cuenta CLABE interbancaria (de 18 dígitos) del depositante.
        /// </summary>
        /// <value>Es la Cuenta CLABE interbancaria (de 18 dígitos) del depositante.</value>
        [DataMember(Name="depositant_clabe", EmitDefaultValue=false)]
        public string DepositantClabe { get; set; }

        /// <summary>
        /// Es el correo electrónico (email) del depositante.
        /// </summary>
        /// <value>Es el correo electrónico (email) del depositante.</value>
        [DataMember(Name="depositant_email", EmitDefaultValue=false)]
        public string DepositantEmail { get; set; }

        /// <summary>
        /// Es el Registro Federal de Contribuyentes (RFC) del depositante.
        /// </summary>
        /// <value>Es el Registro Federal de Contribuyentes (RFC) del depositante.</value>
        [DataMember(Name="depositant_rfc", EmitDefaultValue=false)]
        public string DepositantRfc { get; set; }

        /// <summary>
        /// Es la descripción del traspaso.
        /// </summary>
        /// <value>Es la descripción del traspaso.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Es la descripción directa de Monex.
        /// </summary>
        /// <value>Es la descripción directa de Monex.</value>
        [DataMember(Name="monex_description", EmitDefaultValue=false)]
        public string MonexDescription { get; set; }

        /// <summary>
        /// es el identificador de la transferencia en Monex.
        /// </summary>
        /// <value>es el identificador de la transferencia en Monex.</value>
        [DataMember(Name="monex_transaction_id", EmitDefaultValue=false)]
        public string MonexTransactionId { get; set; }

        /// <summary>
        /// Es la referencia del depósito.
        /// </summary>
        /// <value>Es la referencia del depósito.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Es la cuenta del ordenante.
        /// </summary>
        /// <value>Es la cuenta del ordenante.</value>
        [DataMember(Name="sender_account", EmitDefaultValue=false)]
        public string SenderAccount { get; set; }

        /// <summary>
        /// Gets or Sets SenderBank
        /// </summary>
        [DataMember(Name="sender_bank", EmitDefaultValue=false)]
        public MessageInstitution SenderBank { get; set; }

        /// <summary>
        /// Es el nombre del ordenante.
        /// </summary>
        /// <value>Es el nombre del ordenante.</value>
        [DataMember(Name="sender_name", EmitDefaultValue=false)]
        public string SenderName { get; set; }

        /// <summary>
        /// Es el Registro Federal de Contribuyentes (RFC) de la cuenta ordenante.
        /// </summary>
        /// <value>Es el Registro Federal de Contribuyentes (RFC) de la cuenta ordenante.</value>
        [DataMember(Name="sender_rfc", EmitDefaultValue=false)]
        public string SenderRfc { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Deposit {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BeneficiaryAccount: ").Append(BeneficiaryAccount).Append("\n");
            sb.Append("  BeneficiaryName: ").Append(BeneficiaryName).Append("\n");
            sb.Append("  BeneficiaryRfc: ").Append(BeneficiaryRfc).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  ClaveRastreo: ").Append(ClaveRastreo).Append("\n");
            sb.Append("  ConfirmDate: ").Append(ConfirmDate).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DepositDate: ").Append(DepositDate).Append("\n");
            sb.Append("  Depositant: ").Append(Depositant).Append("\n");
            sb.Append("  DepositantAlias: ").Append(DepositantAlias).Append("\n");
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
            return this.Equals(input as Deposit);
        }

        /// <summary>
        /// Returns true if Deposit instances are equal
        /// </summary>
        /// <param name="input">Instance of Deposit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Deposit input)
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
                    this.Cep == input.Cep ||
                    (this.Cep != null &&
                    this.Cep.Equals(input.Cep))
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
                    this.DepositantAlias == input.DepositantAlias ||
                    (this.DepositantAlias != null &&
                    this.DepositantAlias.Equals(input.DepositantAlias))
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
                if (this.BeneficiaryAccount != null)
                    hashCode = hashCode * 59 + this.BeneficiaryAccount.GetHashCode();
                if (this.BeneficiaryName != null)
                    hashCode = hashCode * 59 + this.BeneficiaryName.GetHashCode();
                if (this.BeneficiaryRfc != null)
                    hashCode = hashCode * 59 + this.BeneficiaryRfc.GetHashCode();
                if (this.Cep != null)
                    hashCode = hashCode * 59 + this.Cep.GetHashCode();
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
                if (this.DepositantAlias != null)
                    hashCode = hashCode * 59 + this.DepositantAlias.GetHashCode();
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
