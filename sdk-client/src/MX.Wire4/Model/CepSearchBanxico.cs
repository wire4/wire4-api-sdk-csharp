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
    /// CepSearchBanxico
    /// </summary>
    [DataContract]
        public partial class CepSearchBanxico :  IEquatable<CepSearchBanxico>, IValidatableObject
    {
        /// <summary>
        /// Es el tipo de cep a consultar, puede ser SPEI o SPID.
        /// </summary>
        /// <value>Es el tipo de cep a consultar, puede ser SPEI o SPID.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum SPEI for value: SPEI
            /// </summary>
            [EnumMember(Value = "SPEI")]
            SPEI = 1,
            /// <summary>
            /// Enum SPID for value: SPID
            /// </summary>
            [EnumMember(Value = "SPID")]
            SPID = 2        }
        /// <summary>
        /// Es el tipo de cep a consultar, puede ser SPEI o SPID.
        /// </summary>
        /// <value>Es el tipo de cep a consultar, puede ser SPEI o SPID.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CepSearchBanxico" /> class.
        /// </summary>
        /// <param name="amount">Es el monto de la transferencia. Ejemplo 1000.00 (required).</param>
        /// <param name="beneficiaryAccount">Es la cuenta de beneficiario. (required).</param>
        /// <param name="beneficiaryBankKey">Clave del banco beneficiario. Éste valor no esta presente si obtiene de la cuenta del beneficiario, en caso de que sea un número celular éste campo es requerido. se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt;.</param>
        /// <param name="claveRastreo">Es la clave de rastreo de la transferencia. (required).</param>
        /// <param name="operationDate">Es la fecha de operación de la transferencia, formato: dd-MM-yyyy. (required).</param>
        /// <param name="reference">Es la referencia numérica de la transferencia. Se valida hasta 7 dígitos..</param>
        /// <param name="senderAccount">Es la cuenta ordenante, es requerida cuando se no se envía la clave del banco ordenante..</param>
        /// <param name="senderBankKey">Es la clave del banco ordenante, es requerida cuando no se envía la cuenta ordenante.  Se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt;.</param>
        /// <param name="type">Es el tipo de cep a consultar, puede ser SPEI o SPID..</param>
        public CepSearchBanxico(decimal? amount = default(decimal?), string beneficiaryAccount = default(string), string beneficiaryBankKey = default(string), string claveRastreo = default(string), string operationDate = default(string), string reference = default(string), string senderAccount = default(string), string senderBankKey = default(string), TypeEnum? type = default(TypeEnum?))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for CepSearchBanxico and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "beneficiaryAccount" is required (not null)
            if (beneficiaryAccount == null)
            {
                throw new InvalidDataException("beneficiaryAccount is a required property for CepSearchBanxico and cannot be null");
            }
            else
            {
                this.BeneficiaryAccount = beneficiaryAccount;
            }
            // to ensure "claveRastreo" is required (not null)
            if (claveRastreo == null)
            {
                throw new InvalidDataException("claveRastreo is a required property for CepSearchBanxico and cannot be null");
            }
            else
            {
                this.ClaveRastreo = claveRastreo;
            }
            // to ensure "operationDate" is required (not null)
            if (operationDate == null)
            {
                throw new InvalidDataException("operationDate is a required property for CepSearchBanxico and cannot be null");
            }
            else
            {
                this.OperationDate = operationDate;
            }
            this.BeneficiaryBankKey = beneficiaryBankKey;
            this.Reference = reference;
            this.SenderAccount = senderAccount;
            this.SenderBankKey = senderBankKey;
            this.Type = type;
        }
        
        /// <summary>
        /// Es el monto de la transferencia. Ejemplo 1000.00
        /// </summary>
        /// <value>Es el monto de la transferencia. Ejemplo 1000.00</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Es la cuenta de beneficiario.
        /// </summary>
        /// <value>Es la cuenta de beneficiario.</value>
        [DataMember(Name="beneficiary_account", EmitDefaultValue=false)]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// Clave del banco beneficiario. Éste valor no esta presente si obtiene de la cuenta del beneficiario, en caso de que sea un número celular éste campo es requerido. se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt;
        /// </summary>
        /// <value>Clave del banco beneficiario. Éste valor no esta presente si obtiene de la cuenta del beneficiario, en caso de que sea un número celular éste campo es requerido. se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt;</value>
        [DataMember(Name="beneficiary_bank_key", EmitDefaultValue=false)]
        public string BeneficiaryBankKey { get; set; }

        /// <summary>
        /// Es la clave de rastreo de la transferencia.
        /// </summary>
        /// <value>Es la clave de rastreo de la transferencia.</value>
        [DataMember(Name="clave_rastreo", EmitDefaultValue=false)]
        public string ClaveRastreo { get; set; }

        /// <summary>
        /// Es la fecha de operación de la transferencia, formato: dd-MM-yyyy.
        /// </summary>
        /// <value>Es la fecha de operación de la transferencia, formato: dd-MM-yyyy.</value>
        [DataMember(Name="operation_date", EmitDefaultValue=false)]
        public string OperationDate { get; set; }

        /// <summary>
        /// Es la referencia numérica de la transferencia. Se valida hasta 7 dígitos.
        /// </summary>
        /// <value>Es la referencia numérica de la transferencia. Se valida hasta 7 dígitos.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Es la cuenta ordenante, es requerida cuando se no se envía la clave del banco ordenante.
        /// </summary>
        /// <value>Es la cuenta ordenante, es requerida cuando se no se envía la clave del banco ordenante.</value>
        [DataMember(Name="sender_account", EmitDefaultValue=false)]
        public string SenderAccount { get; set; }

        /// <summary>
        /// Es la clave del banco ordenante, es requerida cuando no se envía la cuenta ordenante.  Se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt;
        /// </summary>
        /// <value>Es la clave del banco ordenante, es requerida cuando no se envía la cuenta ordenante.  Se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt;</value>
        [DataMember(Name="sender_bank_key", EmitDefaultValue=false)]
        public string SenderBankKey { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CepSearchBanxico {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BeneficiaryAccount: ").Append(BeneficiaryAccount).Append("\n");
            sb.Append("  BeneficiaryBankKey: ").Append(BeneficiaryBankKey).Append("\n");
            sb.Append("  ClaveRastreo: ").Append(ClaveRastreo).Append("\n");
            sb.Append("  OperationDate: ").Append(OperationDate).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SenderAccount: ").Append(SenderAccount).Append("\n");
            sb.Append("  SenderBankKey: ").Append(SenderBankKey).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CepSearchBanxico);
        }

        /// <summary>
        /// Returns true if CepSearchBanxico instances are equal
        /// </summary>
        /// <param name="input">Instance of CepSearchBanxico to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CepSearchBanxico input)
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
                    this.BeneficiaryBankKey == input.BeneficiaryBankKey ||
                    (this.BeneficiaryBankKey != null &&
                    this.BeneficiaryBankKey.Equals(input.BeneficiaryBankKey))
                ) && 
                (
                    this.ClaveRastreo == input.ClaveRastreo ||
                    (this.ClaveRastreo != null &&
                    this.ClaveRastreo.Equals(input.ClaveRastreo))
                ) && 
                (
                    this.OperationDate == input.OperationDate ||
                    (this.OperationDate != null &&
                    this.OperationDate.Equals(input.OperationDate))
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
                    this.SenderBankKey == input.SenderBankKey ||
                    (this.SenderBankKey != null &&
                    this.SenderBankKey.Equals(input.SenderBankKey))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.BeneficiaryBankKey != null)
                    hashCode = hashCode * 59 + this.BeneficiaryBankKey.GetHashCode();
                if (this.ClaveRastreo != null)
                    hashCode = hashCode * 59 + this.ClaveRastreo.GetHashCode();
                if (this.OperationDate != null)
                    hashCode = hashCode * 59 + this.OperationDate.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.SenderAccount != null)
                    hashCode = hashCode * 59 + this.SenderAccount.GetHashCode();
                if (this.SenderBankKey != null)
                    hashCode = hashCode * 59 + this.SenderBankKey.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
