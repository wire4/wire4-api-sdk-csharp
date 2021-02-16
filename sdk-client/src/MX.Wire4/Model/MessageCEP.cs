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
    /// Es el objeto del Comprobante Electrónico de Pago (CEP) de la transferencia, que es emitido por Banxico. Se muestra sólo cuando esté disponible, en otro caso se podrá usar la &lt;a href&#x3D;\&quot;#operation/obtainTransactionCepUsingPOST\&quot;&gt;Consulta de CEP&lt;/a&gt; que ésta misma API ofrece.
    /// </summary>
    [DataContract]
        public partial class MessageCEP :  IEquatable<MessageCEP>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageCEP" /> class.
        /// </summary>
        /// <param name="accountBeneficiary">Es la cuenta del beneficiario..</param>
        /// <param name="accountSender">Es la cuenta que envía la operación..</param>
        /// <param name="amount">Es el monto de la operación..</param>
        /// <param name="available">Indica sí el CEP está disponible..</param>
        /// <param name="bankBeneficiary">Es la clave del banco beneficiario..</param>
        /// <param name="bankSender">Es la clave del banco que envía la operación..</param>
        /// <param name="beneficiaryName">Es el nombre del beneficiario..</param>
        /// <param name="beneficiaryRfc">Es el Registro Federal de Contribuyentes (RFC) del beneficiario..</param>
        /// <param name="cadenaOriginal">Es la cadena original emitida por el Servicio de Administración Tributaria (SAT)..</param>
        /// <param name="captureDate">Es la fecha de captura..</param>
        /// <param name="certificateSerialNumber">Es el número de serie emitido por el SAT.</param>
        /// <param name="claveRastreo">Es la clave de rastreo de la operación..</param>
        /// <param name="description">Es la descripción de la operación..</param>
        /// <param name="iva">Es el Impuesto al Valor Agregado (IVA) de la operación..</param>
        /// <param name="operationDate">Es la fecha en la que se realizó la operación..</param>
        /// <param name="operationDateCep">Es la fecha en la que se genera el CEP..</param>
        /// <param name="reference">Es la Referencia de la operación.</param>
        /// <param name="senderName">Es el nombre de quién envía la operación..</param>
        /// <param name="senderRfc">Es el Registro Federal de Contrinuyentes (RFC) de quién envía la operación..</param>
        /// <param name="signature">Firma del CEP.</param>
        /// <param name="urlZip">Dirección URL de descarga del archivo ZIP que contiene el PDF y XML del CEP proporcionado por BANXICO.</param>
        public MessageCEP(string accountBeneficiary = default(string), string accountSender = default(string), decimal? amount = default(decimal?), bool? available = default(bool?), string bankBeneficiary = default(string), string bankSender = default(string), string beneficiaryName = default(string), string beneficiaryRfc = default(string), string cadenaOriginal = default(string), DateTime? captureDate = default(DateTime?), string certificateSerialNumber = default(string), string claveRastreo = default(string), string description = default(string), decimal? iva = default(decimal?), DateTime? operationDate = default(DateTime?), DateTime? operationDateCep = default(DateTime?), string reference = default(string), string senderName = default(string), string senderRfc = default(string), string signature = default(string), string urlZip = default(string))
        {
            this.AccountBeneficiary = accountBeneficiary;
            this.AccountSender = accountSender;
            this.Amount = amount;
            this.Available = available;
            this.BankBeneficiary = bankBeneficiary;
            this.BankSender = bankSender;
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
            this.SenderName = senderName;
            this.SenderRfc = senderRfc;
            this.Signature = signature;
            this.UrlZip = urlZip;
        }
        
        /// <summary>
        /// Es la cuenta del beneficiario.
        /// </summary>
        /// <value>Es la cuenta del beneficiario.</value>
        [DataMember(Name="account_beneficiary", EmitDefaultValue=false)]
        public string AccountBeneficiary { get; set; }

        /// <summary>
        /// Es la cuenta que envía la operación.
        /// </summary>
        /// <value>Es la cuenta que envía la operación.</value>
        [DataMember(Name="account_sender", EmitDefaultValue=false)]
        public string AccountSender { get; set; }

        /// <summary>
        /// Es el monto de la operación.
        /// </summary>
        /// <value>Es el monto de la operación.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Indica sí el CEP está disponible.
        /// </summary>
        /// <value>Indica sí el CEP está disponible.</value>
        [DataMember(Name="available", EmitDefaultValue=false)]
        public bool? Available { get; set; }

        /// <summary>
        /// Es la clave del banco beneficiario.
        /// </summary>
        /// <value>Es la clave del banco beneficiario.</value>
        [DataMember(Name="bank_beneficiary", EmitDefaultValue=false)]
        public string BankBeneficiary { get; set; }

        /// <summary>
        /// Es la clave del banco que envía la operación.
        /// </summary>
        /// <value>Es la clave del banco que envía la operación.</value>
        [DataMember(Name="bank_sender", EmitDefaultValue=false)]
        public string BankSender { get; set; }

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
        /// Es la cadena original emitida por el Servicio de Administración Tributaria (SAT).
        /// </summary>
        /// <value>Es la cadena original emitida por el Servicio de Administración Tributaria (SAT).</value>
        [DataMember(Name="cadena_original", EmitDefaultValue=false)]
        public string CadenaOriginal { get; set; }

        /// <summary>
        /// Es la fecha de captura.
        /// </summary>
        /// <value>Es la fecha de captura.</value>
        [DataMember(Name="capture_date", EmitDefaultValue=false)]
        public DateTime? CaptureDate { get; set; }

        /// <summary>
        /// Es el número de serie emitido por el SAT
        /// </summary>
        /// <value>Es el número de serie emitido por el SAT</value>
        [DataMember(Name="certificate_serial_number", EmitDefaultValue=false)]
        public string CertificateSerialNumber { get; set; }

        /// <summary>
        /// Es la clave de rastreo de la operación.
        /// </summary>
        /// <value>Es la clave de rastreo de la operación.</value>
        [DataMember(Name="clave_rastreo", EmitDefaultValue=false)]
        public string ClaveRastreo { get; set; }

        /// <summary>
        /// Es la descripción de la operación.
        /// </summary>
        /// <value>Es la descripción de la operación.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Es el Impuesto al Valor Agregado (IVA) de la operación.
        /// </summary>
        /// <value>Es el Impuesto al Valor Agregado (IVA) de la operación.</value>
        [DataMember(Name="iva", EmitDefaultValue=false)]
        public decimal? Iva { get; set; }

        /// <summary>
        /// Es la fecha en la que se realizó la operación.
        /// </summary>
        /// <value>Es la fecha en la que se realizó la operación.</value>
        [DataMember(Name="operation_date", EmitDefaultValue=false)]
        public DateTime? OperationDate { get; set; }

        /// <summary>
        /// Es la fecha en la que se genera el CEP.
        /// </summary>
        /// <value>Es la fecha en la que se genera el CEP.</value>
        [DataMember(Name="operation_date_cep", EmitDefaultValue=false)]
        public DateTime? OperationDateCep { get; set; }

        /// <summary>
        /// Es la Referencia de la operación
        /// </summary>
        /// <value>Es la Referencia de la operación</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Es el nombre de quién envía la operación.
        /// </summary>
        /// <value>Es el nombre de quién envía la operación.</value>
        [DataMember(Name="sender_name", EmitDefaultValue=false)]
        public string SenderName { get; set; }

        /// <summary>
        /// Es el Registro Federal de Contrinuyentes (RFC) de quién envía la operación.
        /// </summary>
        /// <value>Es el Registro Federal de Contrinuyentes (RFC) de quién envía la operación.</value>
        [DataMember(Name="sender_rfc", EmitDefaultValue=false)]
        public string SenderRfc { get; set; }

        /// <summary>
        /// Firma del CEP
        /// </summary>
        /// <value>Firma del CEP</value>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public string Signature { get; set; }

        /// <summary>
        /// Dirección URL de descarga del archivo ZIP que contiene el PDF y XML del CEP proporcionado por BANXICO
        /// </summary>
        /// <value>Dirección URL de descarga del archivo ZIP que contiene el PDF y XML del CEP proporcionado por BANXICO</value>
        [DataMember(Name="url_zip", EmitDefaultValue=false)]
        public string UrlZip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageCEP {\n");
            sb.Append("  AccountBeneficiary: ").Append(AccountBeneficiary).Append("\n");
            sb.Append("  AccountSender: ").Append(AccountSender).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  BankBeneficiary: ").Append(BankBeneficiary).Append("\n");
            sb.Append("  BankSender: ").Append(BankSender).Append("\n");
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
            return this.Equals(input as MessageCEP);
        }

        /// <summary>
        /// Returns true if MessageCEP instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageCEP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageCEP input)
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
                    this.BankBeneficiary == input.BankBeneficiary ||
                    (this.BankBeneficiary != null &&
                    this.BankBeneficiary.Equals(input.BankBeneficiary))
                ) && 
                (
                    this.BankSender == input.BankSender ||
                    (this.BankSender != null &&
                    this.BankSender.Equals(input.BankSender))
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
                if (this.BankBeneficiary != null)
                    hashCode = hashCode * 59 + this.BankBeneficiary.GetHashCode();
                if (this.BankSender != null)
                    hashCode = hashCode * 59 + this.BankSender.GetHashCode();
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
