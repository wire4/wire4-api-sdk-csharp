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
    /// CepResponse
    /// </summary>
    [DataContract]
        public partial class CepResponse :  IEquatable<CepResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CepResponse" /> class.
        /// </summary>
        /// <param name="accountBeneficiary">Cuenta del beneficiario.</param>
        /// <param name="accountSender">Cuenta del ordenante.</param>
        /// <param name="amount">Monto de la transferencia.</param>
        /// <param name="available">Indica si o no el CEP se encuentra disponible.</param>
        /// <param name="beneficiaryBankKey">Clave del banco beneficiario.</param>
        /// <param name="beneficiaryName">Nombre del beneficiario.</param>
        /// <param name="beneficiaryRfc">RFC del beneficiario.</param>
        /// <param name="cadenaOriginal">Cadena original del CEP.</param>
        /// <param name="captureDate">Fecha de captura de la transferencia.</param>
        /// <param name="certificateSerialNumber">Número de serie del certificado.</param>
        /// <param name="claveRastreo">Clave de rastreo.</param>
        /// <param name="description">Descripción de la transferencia.</param>
        /// <param name="iva">IVA de la transferencia.</param>
        /// <param name="operationDate">Fecha de operación de la transferencia.</param>
        /// <param name="operationDateCep">Fecha de abono registrada en el CEP.</param>
        /// <param name="reference">Referencia numérica de la transferencia.</param>
        /// <param name="senderBankKey">Clave del banco emisor.</param>
        /// <param name="senderName">Nombre del emisor.</param>
        /// <param name="senderRfc">RFC del emisor.</param>
        /// <param name="signature">Firma del CEP.</param>
        /// <param name="urlZip">La url al archivo zip del CEP, el cual contiene el xml y pdf.</param>
        public CepResponse(string accountBeneficiary = default(string), string accountSender = default(string), decimal? amount = default(decimal?), bool? available = default(bool?), string beneficiaryBankKey = default(string), string beneficiaryName = default(string), string beneficiaryRfc = default(string), string cadenaOriginal = default(string), DateTime? captureDate = default(DateTime?), string certificateSerialNumber = default(string), string claveRastreo = default(string), string description = default(string), decimal? iva = default(decimal?), DateTime? operationDate = default(DateTime?), DateTime? operationDateCep = default(DateTime?), string reference = default(string), string senderBankKey = default(string), string senderName = default(string), string senderRfc = default(string), string signature = default(string), string urlZip = default(string))
        {
            this.AccountBeneficiary = accountBeneficiary;
            this.AccountSender = accountSender;
            this.Amount = amount;
            this.Available = available;
            this.BeneficiaryBankKey = beneficiaryBankKey;
            this.BeneficiaryName = beneficiaryName;
            this.BeneficiaryRfc = beneficiaryRfc;
            this.CadenaOriginal = cadenaOriginal;
            this.CaptureDate = captureDate;
            this.CertificateSerialNumber = certificateSerialNumber;
            this.ClaveRastreo = claveRastreo;
            this.Description = description;
            this.Iva = iva;
            this.OperationDate = operationDate;
            this.OperationDateCep = operationDateCep;
            this.Reference = reference;
            this.SenderBankKey = senderBankKey;
            this.SenderName = senderName;
            this.SenderRfc = senderRfc;
            this.Signature = signature;
            this.UrlZip = urlZip;
        }
        
        /// <summary>
        /// Cuenta del beneficiario
        /// </summary>
        /// <value>Cuenta del beneficiario</value>
        [DataMember(Name="account_beneficiary", EmitDefaultValue=false)]
        public string AccountBeneficiary { get; set; }

        /// <summary>
        /// Cuenta del ordenante
        /// </summary>
        /// <value>Cuenta del ordenante</value>
        [DataMember(Name="account_sender", EmitDefaultValue=false)]
        public string AccountSender { get; set; }

        /// <summary>
        /// Monto de la transferencia
        /// </summary>
        /// <value>Monto de la transferencia</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Indica si o no el CEP se encuentra disponible
        /// </summary>
        /// <value>Indica si o no el CEP se encuentra disponible</value>
        [DataMember(Name="available", EmitDefaultValue=false)]
        public bool? Available { get; set; }

        /// <summary>
        /// Clave del banco beneficiario
        /// </summary>
        /// <value>Clave del banco beneficiario</value>
        [DataMember(Name="beneficiary_bank_key", EmitDefaultValue=false)]
        public string BeneficiaryBankKey { get; set; }

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
        /// Cadena original del CEP
        /// </summary>
        /// <value>Cadena original del CEP</value>
        [DataMember(Name="cadena_original", EmitDefaultValue=false)]
        public string CadenaOriginal { get; set; }

        /// <summary>
        /// Fecha de captura de la transferencia
        /// </summary>
        /// <value>Fecha de captura de la transferencia</value>
        [DataMember(Name="capture_date", EmitDefaultValue=false)]
        public DateTime? CaptureDate { get; set; }

        /// <summary>
        /// Número de serie del certificado
        /// </summary>
        /// <value>Número de serie del certificado</value>
        [DataMember(Name="certificate_serial_number", EmitDefaultValue=false)]
        public string CertificateSerialNumber { get; set; }

        /// <summary>
        /// Clave de rastreo
        /// </summary>
        /// <value>Clave de rastreo</value>
        [DataMember(Name="clave_rastreo", EmitDefaultValue=false)]
        public string ClaveRastreo { get; set; }

        /// <summary>
        /// Descripción de la transferencia
        /// </summary>
        /// <value>Descripción de la transferencia</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// IVA de la transferencia
        /// </summary>
        /// <value>IVA de la transferencia</value>
        [DataMember(Name="iva", EmitDefaultValue=false)]
        public decimal? Iva { get; set; }

        /// <summary>
        /// Fecha de operación de la transferencia
        /// </summary>
        /// <value>Fecha de operación de la transferencia</value>
        [DataMember(Name="operation_date", EmitDefaultValue=false)]
        public DateTime? OperationDate { get; set; }

        /// <summary>
        /// Fecha de abono registrada en el CEP
        /// </summary>
        /// <value>Fecha de abono registrada en el CEP</value>
        [DataMember(Name="operation_date_cep", EmitDefaultValue=false)]
        public DateTime? OperationDateCep { get; set; }

        /// <summary>
        /// Referencia numérica de la transferencia
        /// </summary>
        /// <value>Referencia numérica de la transferencia</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Clave del banco emisor
        /// </summary>
        /// <value>Clave del banco emisor</value>
        [DataMember(Name="sender_bank_key", EmitDefaultValue=false)]
        public string SenderBankKey { get; set; }

        /// <summary>
        /// Nombre del emisor
        /// </summary>
        /// <value>Nombre del emisor</value>
        [DataMember(Name="sender_name", EmitDefaultValue=false)]
        public string SenderName { get; set; }

        /// <summary>
        /// RFC del emisor
        /// </summary>
        /// <value>RFC del emisor</value>
        [DataMember(Name="sender_rfc", EmitDefaultValue=false)]
        public string SenderRfc { get; set; }

        /// <summary>
        /// Firma del CEP
        /// </summary>
        /// <value>Firma del CEP</value>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public string Signature { get; set; }

        /// <summary>
        /// La url al archivo zip del CEP, el cual contiene el xml y pdf
        /// </summary>
        /// <value>La url al archivo zip del CEP, el cual contiene el xml y pdf</value>
        [DataMember(Name="url_zip", EmitDefaultValue=false)]
        public string UrlZip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CepResponse {\n");
            sb.Append("  AccountBeneficiary: ").Append(AccountBeneficiary).Append("\n");
            sb.Append("  AccountSender: ").Append(AccountSender).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  BeneficiaryBankKey: ").Append(BeneficiaryBankKey).Append("\n");
            sb.Append("  BeneficiaryName: ").Append(BeneficiaryName).Append("\n");
            sb.Append("  BeneficiaryRfc: ").Append(BeneficiaryRfc).Append("\n");
            sb.Append("  CadenaOriginal: ").Append(CadenaOriginal).Append("\n");
            sb.Append("  CaptureDate: ").Append(CaptureDate).Append("\n");
            sb.Append("  CertificateSerialNumber: ").Append(CertificateSerialNumber).Append("\n");
            sb.Append("  ClaveRastreo: ").Append(ClaveRastreo).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Iva: ").Append(Iva).Append("\n");
            sb.Append("  OperationDate: ").Append(OperationDate).Append("\n");
            sb.Append("  OperationDateCep: ").Append(OperationDateCep).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SenderBankKey: ").Append(SenderBankKey).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  SenderRfc: ").Append(SenderRfc).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  UrlZip: ").Append(UrlZip).Append("\n");
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
            return this.Equals(input as CepResponse);
        }

        /// <summary>
        /// Returns true if CepResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CepResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CepResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountBeneficiary == input.AccountBeneficiary ||
                    (this.AccountBeneficiary != null &&
                    this.AccountBeneficiary.Equals(input.AccountBeneficiary))
                ) && 
                (
                    this.AccountSender == input.AccountSender ||
                    (this.AccountSender != null &&
                    this.AccountSender.Equals(input.AccountSender))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.BeneficiaryBankKey == input.BeneficiaryBankKey ||
                    (this.BeneficiaryBankKey != null &&
                    this.BeneficiaryBankKey.Equals(input.BeneficiaryBankKey))
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
                    this.CadenaOriginal == input.CadenaOriginal ||
                    (this.CadenaOriginal != null &&
                    this.CadenaOriginal.Equals(input.CadenaOriginal))
                ) && 
                (
                    this.CaptureDate == input.CaptureDate ||
                    (this.CaptureDate != null &&
                    this.CaptureDate.Equals(input.CaptureDate))
                ) && 
                (
                    this.CertificateSerialNumber == input.CertificateSerialNumber ||
                    (this.CertificateSerialNumber != null &&
                    this.CertificateSerialNumber.Equals(input.CertificateSerialNumber))
                ) && 
                (
                    this.ClaveRastreo == input.ClaveRastreo ||
                    (this.ClaveRastreo != null &&
                    this.ClaveRastreo.Equals(input.ClaveRastreo))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Iva == input.Iva ||
                    (this.Iva != null &&
                    this.Iva.Equals(input.Iva))
                ) && 
                (
                    this.OperationDate == input.OperationDate ||
                    (this.OperationDate != null &&
                    this.OperationDate.Equals(input.OperationDate))
                ) && 
                (
                    this.OperationDateCep == input.OperationDateCep ||
                    (this.OperationDateCep != null &&
                    this.OperationDateCep.Equals(input.OperationDateCep))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SenderBankKey == input.SenderBankKey ||
                    (this.SenderBankKey != null &&
                    this.SenderBankKey.Equals(input.SenderBankKey))
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
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.UrlZip == input.UrlZip ||
                    (this.UrlZip != null &&
                    this.UrlZip.Equals(input.UrlZip))
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
                if (this.AccountBeneficiary != null)
                    hashCode = hashCode * 59 + this.AccountBeneficiary.GetHashCode();
                if (this.AccountSender != null)
                    hashCode = hashCode * 59 + this.AccountSender.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.BeneficiaryBankKey != null)
                    hashCode = hashCode * 59 + this.BeneficiaryBankKey.GetHashCode();
                if (this.BeneficiaryName != null)
                    hashCode = hashCode * 59 + this.BeneficiaryName.GetHashCode();
                if (this.BeneficiaryRfc != null)
                    hashCode = hashCode * 59 + this.BeneficiaryRfc.GetHashCode();
                if (this.CadenaOriginal != null)
                    hashCode = hashCode * 59 + this.CadenaOriginal.GetHashCode();
                if (this.CaptureDate != null)
                    hashCode = hashCode * 59 + this.CaptureDate.GetHashCode();
                if (this.CertificateSerialNumber != null)
                    hashCode = hashCode * 59 + this.CertificateSerialNumber.GetHashCode();
                if (this.ClaveRastreo != null)
                    hashCode = hashCode * 59 + this.ClaveRastreo.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Iva != null)
                    hashCode = hashCode * 59 + this.Iva.GetHashCode();
                if (this.OperationDate != null)
                    hashCode = hashCode * 59 + this.OperationDate.GetHashCode();
                if (this.OperationDateCep != null)
                    hashCode = hashCode * 59 + this.OperationDateCep.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.SenderBankKey != null)
                    hashCode = hashCode * 59 + this.SenderBankKey.GetHashCode();
                if (this.SenderName != null)
                    hashCode = hashCode * 59 + this.SenderName.GetHashCode();
                if (this.SenderRfc != null)
                    hashCode = hashCode * 59 + this.SenderRfc.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.UrlZip != null)
                    hashCode = hashCode * 59 + this.UrlZip.GetHashCode();
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
