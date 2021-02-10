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
    /// Objeto que contiene información de la cuenta de beneficiario SPID
    /// </summary>
    [DataContract]
        public partial class SpidBeneficiaryResponse :  IEquatable<SpidBeneficiaryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpidBeneficiaryResponse" /> class.
        /// </summary>
        /// <param name="amountLimit">Monto límite permitido para la cuenta. Ejemplo: 1000.00 (required).</param>
        /// <param name="bank">bank.</param>
        /// <param name="beneficiaryAccount">Cuenta del beneficiario debe ser una cuenta CLABE. Ejemplo: 032180000118359719. (required).</param>
        /// <param name="email">Lista de correos electrónicos (emails), este dato es opcional..</param>
        /// <param name="institution">institution (required).</param>
        /// <param name="kindOfRelationship">Es el tipo de relación que se tiene con el propietario de la cuenta. Para registrar una cuenta, este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt; relationships.&lt;/a&gt; &lt;br /&gt;&lt;br /&gt;&lt;b&gt;Nota:&lt;/b&gt; &lt;em&gt;Si en la respuesta de Monex esta propiedad es nula, tampoco estará presente en esta respuesta.&lt;/em&gt; (required).</param>
        /// <param name="numericReferenceSpid">Referencia numérica..</param>
        /// <param name="paymentConceptSpid">Concepto de pago..</param>
        /// <param name="registerDate">La fecha en la que se registro el beneficiario..</param>
        /// <param name="relationship">Es la relación con el propietario de la cuenta, para registrar este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt;relationships.&lt;/a&gt; &lt;br/&gt; &lt;br/&gt; &lt;b&gt;Nota:&lt;/b&gt; Si en la respuesta de Monex, sta propiedad es nula, tampoco estará presente en esta respuesta. (required).</param>
        /// <param name="rfc">Es el Registro federal de contribuyentes (RFC) de la persona o institución propietaria de la cuenta. &lt;br/&gt; &lt;br/&gt;&lt;b&gt;Nota:&lt;/b&gt; Se valida el formato de RFC..</param>
        /// <param name="status">El estado en el que se encuentra el registo del beneficiario.&lt;br&gt;&lt;br&gt; Los valores pueden ser: &lt;b&gt;\&quot;RECEIVED\&quot;, \&quot;DELETED\&quot;, \&quot;REQUEST_ERROR_BY_MONEX\&quot;, \&quot;REQUESTED_TO_MONEX\&quot;, \&quot;NOTIFIED_BY_MONEX\&quot;, \&quot;NOTIFIED_BY_SPEIOK\&quot;, \&quot;NOTIFIED_WITH_ERROR_BY_SPEIOK\&quot; y \&quot;PENDING\&quot;&lt;/b&gt;.</param>
        public SpidBeneficiaryResponse(decimal? amountLimit = default(decimal?), Institution bank = default(Institution), string beneficiaryAccount = default(string), List<string> email = default(List<string>), BeneficiaryInstitution institution = default(BeneficiaryInstitution), string kindOfRelationship = default(string), string numericReferenceSpid = default(string), string paymentConceptSpid = default(string), DateTime? registerDate = default(DateTime?), string relationship = default(string), string rfc = default(string), string status = default(string))
        {
            // to ensure "amountLimit" is required (not null)
            if (amountLimit == null)
            {
                throw new InvalidDataException("amountLimit is a required property for SpidBeneficiaryResponse and cannot be null");
            }
            else
            {
                this.AmountLimit = amountLimit;
            }
            // to ensure "beneficiaryAccount" is required (not null)
            if (beneficiaryAccount == null)
            {
                throw new InvalidDataException("beneficiaryAccount is a required property for SpidBeneficiaryResponse and cannot be null");
            }
            else
            {
                this.BeneficiaryAccount = beneficiaryAccount;
            }
            // to ensure "institution" is required (not null)
            if (institution == null)
            {
                throw new InvalidDataException("institution is a required property for SpidBeneficiaryResponse and cannot be null");
            }
            else
            {
                this.Institution = institution;
            }
            // to ensure "kindOfRelationship" is required (not null)
            if (kindOfRelationship == null)
            {
                throw new InvalidDataException("kindOfRelationship is a required property for SpidBeneficiaryResponse and cannot be null");
            }
            else
            {
                this.KindOfRelationship = kindOfRelationship;
            }
            // to ensure "relationship" is required (not null)
            if (relationship == null)
            {
                throw new InvalidDataException("relationship is a required property for SpidBeneficiaryResponse and cannot be null");
            }
            else
            {
                this.Relationship = relationship;
            }
            this.Bank = bank;
            this.Email = email;
            this.NumericReferenceSpid = numericReferenceSpid;
            this.PaymentConceptSpid = paymentConceptSpid;
            this.RegisterDate = registerDate;
            this.Rfc = rfc;
            this.Status = status;
        }
        
        /// <summary>
        /// Monto límite permitido para la cuenta. Ejemplo: 1000.00
        /// </summary>
        /// <value>Monto límite permitido para la cuenta. Ejemplo: 1000.00</value>
        [DataMember(Name="amount_limit", EmitDefaultValue=false)]
        public decimal? AmountLimit { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name="bank", EmitDefaultValue=false)]
        public Institution Bank { get; set; }

        /// <summary>
        /// Cuenta del beneficiario debe ser una cuenta CLABE. Ejemplo: 032180000118359719.
        /// </summary>
        /// <value>Cuenta del beneficiario debe ser una cuenta CLABE. Ejemplo: 032180000118359719.</value>
        [DataMember(Name="beneficiary_account", EmitDefaultValue=false)]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// Lista de correos electrónicos (emails), este dato es opcional.
        /// </summary>
        /// <value>Lista de correos electrónicos (emails), este dato es opcional.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public List<string> Email { get; set; }

        /// <summary>
        /// Gets or Sets Institution
        /// </summary>
        [DataMember(Name="institution", EmitDefaultValue=false)]
        public BeneficiaryInstitution Institution { get; set; }

        /// <summary>
        /// Es el tipo de relación que se tiene con el propietario de la cuenta. Para registrar una cuenta, este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt; relationships.&lt;/a&gt; &lt;br /&gt;&lt;br /&gt;&lt;b&gt;Nota:&lt;/b&gt; &lt;em&gt;Si en la respuesta de Monex esta propiedad es nula, tampoco estará presente en esta respuesta.&lt;/em&gt;
        /// </summary>
        /// <value>Es el tipo de relación que se tiene con el propietario de la cuenta. Para registrar una cuenta, este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt; relationships.&lt;/a&gt; &lt;br /&gt;&lt;br /&gt;&lt;b&gt;Nota:&lt;/b&gt; &lt;em&gt;Si en la respuesta de Monex esta propiedad es nula, tampoco estará presente en esta respuesta.&lt;/em&gt;</value>
        [DataMember(Name="kind_of_relationship", EmitDefaultValue=false)]
        public string KindOfRelationship { get; set; }

        /// <summary>
        /// Referencia numérica.
        /// </summary>
        /// <value>Referencia numérica.</value>
        [DataMember(Name="numeric_reference_spid", EmitDefaultValue=false)]
        public string NumericReferenceSpid { get; set; }

        /// <summary>
        /// Concepto de pago.
        /// </summary>
        /// <value>Concepto de pago.</value>
        [DataMember(Name="payment_concept_spid", EmitDefaultValue=false)]
        public string PaymentConceptSpid { get; set; }

        /// <summary>
        /// La fecha en la que se registro el beneficiario.
        /// </summary>
        /// <value>La fecha en la que se registro el beneficiario.</value>
        [DataMember(Name="register_date", EmitDefaultValue=false)]
        public DateTime? RegisterDate { get; set; }

        /// <summary>
        /// Es la relación con el propietario de la cuenta, para registrar este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt;relationships.&lt;/a&gt; &lt;br/&gt; &lt;br/&gt; &lt;b&gt;Nota:&lt;/b&gt; Si en la respuesta de Monex, sta propiedad es nula, tampoco estará presente en esta respuesta.
        /// </summary>
        /// <value>Es la relación con el propietario de la cuenta, para registrar este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt;relationships.&lt;/a&gt; &lt;br/&gt; &lt;br/&gt; &lt;b&gt;Nota:&lt;/b&gt; Si en la respuesta de Monex, sta propiedad es nula, tampoco estará presente en esta respuesta.</value>
        [DataMember(Name="relationship", EmitDefaultValue=false)]
        public string Relationship { get; set; }

        /// <summary>
        /// Es el Registro federal de contribuyentes (RFC) de la persona o institución propietaria de la cuenta. &lt;br/&gt; &lt;br/&gt;&lt;b&gt;Nota:&lt;/b&gt; Se valida el formato de RFC.
        /// </summary>
        /// <value>Es el Registro federal de contribuyentes (RFC) de la persona o institución propietaria de la cuenta. &lt;br/&gt; &lt;br/&gt;&lt;b&gt;Nota:&lt;/b&gt; Se valida el formato de RFC.</value>
        [DataMember(Name="rfc", EmitDefaultValue=false)]
        public string Rfc { get; set; }

        /// <summary>
        /// El estado en el que se encuentra el registo del beneficiario.&lt;br&gt;&lt;br&gt; Los valores pueden ser: &lt;b&gt;\&quot;RECEIVED\&quot;, \&quot;DELETED\&quot;, \&quot;REQUEST_ERROR_BY_MONEX\&quot;, \&quot;REQUESTED_TO_MONEX\&quot;, \&quot;NOTIFIED_BY_MONEX\&quot;, \&quot;NOTIFIED_BY_SPEIOK\&quot;, \&quot;NOTIFIED_WITH_ERROR_BY_SPEIOK\&quot; y \&quot;PENDING\&quot;&lt;/b&gt;
        /// </summary>
        /// <value>El estado en el que se encuentra el registo del beneficiario.&lt;br&gt;&lt;br&gt; Los valores pueden ser: &lt;b&gt;\&quot;RECEIVED\&quot;, \&quot;DELETED\&quot;, \&quot;REQUEST_ERROR_BY_MONEX\&quot;, \&quot;REQUESTED_TO_MONEX\&quot;, \&quot;NOTIFIED_BY_MONEX\&quot;, \&quot;NOTIFIED_BY_SPEIOK\&quot;, \&quot;NOTIFIED_WITH_ERROR_BY_SPEIOK\&quot; y \&quot;PENDING\&quot;&lt;/b&gt;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpidBeneficiaryResponse {\n");
            sb.Append("  AmountLimit: ").Append(AmountLimit).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  BeneficiaryAccount: ").Append(BeneficiaryAccount).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Institution: ").Append(Institution).Append("\n");
            sb.Append("  KindOfRelationship: ").Append(KindOfRelationship).Append("\n");
            sb.Append("  NumericReferenceSpid: ").Append(NumericReferenceSpid).Append("\n");
            sb.Append("  PaymentConceptSpid: ").Append(PaymentConceptSpid).Append("\n");
            sb.Append("  RegisterDate: ").Append(RegisterDate).Append("\n");
            sb.Append("  Relationship: ").Append(Relationship).Append("\n");
            sb.Append("  Rfc: ").Append(Rfc).Append("\n");
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
            return this.Equals(input as SpidBeneficiaryResponse);
        }

        /// <summary>
        /// Returns true if SpidBeneficiaryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SpidBeneficiaryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpidBeneficiaryResponse input)
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
                    this.Bank == input.Bank ||
                    (this.Bank != null &&
                    this.Bank.Equals(input.Bank))
                ) && 
                (
                    this.BeneficiaryAccount == input.BeneficiaryAccount ||
                    (this.BeneficiaryAccount != null &&
                    this.BeneficiaryAccount.Equals(input.BeneficiaryAccount))
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
                    this.NumericReferenceSpid == input.NumericReferenceSpid ||
                    (this.NumericReferenceSpid != null &&
                    this.NumericReferenceSpid.Equals(input.NumericReferenceSpid))
                ) && 
                (
                    this.PaymentConceptSpid == input.PaymentConceptSpid ||
                    (this.PaymentConceptSpid != null &&
                    this.PaymentConceptSpid.Equals(input.PaymentConceptSpid))
                ) && 
                (
                    this.RegisterDate == input.RegisterDate ||
                    (this.RegisterDate != null &&
                    this.RegisterDate.Equals(input.RegisterDate))
                ) && 
                (
                    this.Relationship == input.Relationship ||
                    (this.Relationship != null &&
                    this.Relationship.Equals(input.Relationship))
                ) && 
                (
                    this.Rfc == input.Rfc ||
                    (this.Rfc != null &&
                    this.Rfc.Equals(input.Rfc))
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
                if (this.AmountLimit != null)
                    hashCode = hashCode * 59 + this.AmountLimit.GetHashCode();
                if (this.Bank != null)
                    hashCode = hashCode * 59 + this.Bank.GetHashCode();
                if (this.BeneficiaryAccount != null)
                    hashCode = hashCode * 59 + this.BeneficiaryAccount.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Institution != null)
                    hashCode = hashCode * 59 + this.Institution.GetHashCode();
                if (this.KindOfRelationship != null)
                    hashCode = hashCode * 59 + this.KindOfRelationship.GetHashCode();
                if (this.NumericReferenceSpid != null)
                    hashCode = hashCode * 59 + this.NumericReferenceSpid.GetHashCode();
                if (this.PaymentConceptSpid != null)
                    hashCode = hashCode * 59 + this.PaymentConceptSpid.GetHashCode();
                if (this.RegisterDate != null)
                    hashCode = hashCode * 59 + this.RegisterDate.GetHashCode();
                if (this.Relationship != null)
                    hashCode = hashCode * 59 + this.Relationship.GetHashCode();
                if (this.Rfc != null)
                    hashCode = hashCode * 59 + this.Rfc.GetHashCode();
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
