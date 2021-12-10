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
    /// CodiCodeRequestDTO
    /// </summary>
    [DataContract]
        public partial class CodiCodeRequestDTO :  IEquatable<CodiCodeRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// El tipo de pago ya sea en una ocasión (ONE_OCCASION) o recurrente (RECURRENT)
        /// </summary>
        /// <value>El tipo de pago ya sea en una ocasión (ONE_OCCASION) o recurrente (RECURRENT)</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PaymentTypeEnum
        {
            /// <summary>
            /// Enum ONEOCCASION for value: ONE_OCCASION
            /// </summary>
            [EnumMember(Value = "ONE_OCCASION")]
            ONEOCCASION = 0,
            /// <summary>
            /// Enum RECURRENT for value: RECURRENT
            /// </summary>
            [EnumMember(Value = "RECURRENT")]
            RECURRENT = 1,
            /// <summary>
            /// Enum RECURRENTNORECURRENT for value: RECURRENT_NO_RECURRENT
            /// </summary>
            [EnumMember(Value = "RECURRENT_NO_RECURRENT")]
            RECURRENTNORECURRENT = 2,
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 3        }
        /// <summary>
        /// El tipo de pago ya sea en una ocasión (ONE_OCCASION) o recurrente (RECURRENT)
        /// </summary>
        /// <value>El tipo de pago ya sea en una ocasión (ONE_OCCASION) o recurrente (RECURRENT)</value>
        [DataMember(Name="payment_type", EmitDefaultValue=false)]
        public PaymentTypeEnum PaymentType { get; set; }
        /// <summary>
        /// El tipo de solicitud QR o PUSH para pago con CODI®
        /// </summary>
        /// <value>El tipo de solicitud QR o PUSH para pago con CODI®</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum PUSHNOTIFICATION for value: PUSH_NOTIFICATION
            /// </summary>
            [EnumMember(Value = "PUSH_NOTIFICATION")]
            PUSHNOTIFICATION = 0,
            /// <summary>
            /// Enum QRCODE for value: QR_CODE
            /// </summary>
            [EnumMember(Value = "QR_CODE")]
            QRCODE = 1,
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 2        }
        /// <summary>
        /// El tipo de solicitud QR o PUSH para pago con CODI®
        /// </summary>
        /// <value>El tipo de solicitud QR o PUSH para pago con CODI®</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CodiCodeRequestDTO" /> class.
        /// </summary>
        /// <param name="amount">Monto del pago CODI®.</param>
        /// <param name="beneficiary2">beneficiary2.</param>
        /// <param name="concept">Descripción del pago CODI® (required).</param>
        /// <param name="dueDate">Fecha de operación pago CODI®, formato: yyyy-MM-dd&#x27;T&#x27;HH:mm:ss (required).</param>
        /// <param name="metadata">Campo de metada CODI®, longitud máxima determinada por configuracion de la empresa, por defecto 100 caracteres.</param>
        /// <param name="orderId">Referencia de la transferencia asignada por el cliente (required).</param>
        /// <param name="paymentType">El tipo de pago ya sea en una ocasión (ONE_OCCASION) o recurrente (RECURRENT) (required).</param>
        /// <param name="phoneNumber">Número de teléfono móvil en caso de ser un pago CODI® usando &#x27;PUSH_NOTIFICATION&#x27; estecampo sería obligatorio.</param>
        /// <param name="reference">Referencia numérica del pago CODI®. Debe ser de 7 dígitos (required).</param>
        /// <param name="type">El tipo de solicitud QR o PUSH para pago con CODI® (required).</param>
        public CodiCodeRequestDTO(decimal? amount = default(decimal?), BeneficiaryDTO beneficiary2 = default(BeneficiaryDTO), string concept = default(string), DateTime? dueDate = default(DateTime?), string metadata = default(string), string orderId = default(string), PaymentTypeEnum paymentType = default(PaymentTypeEnum), string phoneNumber = default(string), int? reference = default(int?), TypeEnum type = default(TypeEnum))
        {
            // to ensure "concept" is required (not null)
            if (concept == null)
            {
                throw new InvalidDataException("concept is a required property for CodiCodeRequestDTO and cannot be null");
            }
            else
            {
                this.Concept = concept;
            }
            // to ensure "dueDate" is required (not null)
            if (dueDate == null)
            {
                throw new InvalidDataException("dueDate is a required property for CodiCodeRequestDTO and cannot be null");
            }
            else
            {
                this.DueDate = dueDate;
            }
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for CodiCodeRequestDTO and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }
            // to ensure "paymentType" is required (not null)
            if (paymentType == null)
            {
                throw new InvalidDataException("paymentType is a required property for CodiCodeRequestDTO and cannot be null");
            }
            else
            {
                this.PaymentType = paymentType;
            }
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new InvalidDataException("reference is a required property for CodiCodeRequestDTO and cannot be null");
            }
            else
            {
                this.Reference = reference;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CodiCodeRequestDTO and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Amount = amount;
            this.Beneficiary2 = beneficiary2;
            this.Metadata = metadata;
            this.PhoneNumber = phoneNumber;
        }
        
        /// <summary>
        /// Monto del pago CODI®
        /// </summary>
        /// <value>Monto del pago CODI®</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Beneficiary2
        /// </summary>
        [DataMember(Name="beneficiary2", EmitDefaultValue=false)]
        public BeneficiaryDTO Beneficiary2 { get; set; }

        /// <summary>
        /// Descripción del pago CODI®
        /// </summary>
        /// <value>Descripción del pago CODI®</value>
        [DataMember(Name="concept", EmitDefaultValue=false)]
        public string Concept { get; set; }

        /// <summary>
        /// Fecha de operación pago CODI®, formato: yyyy-MM-dd&#x27;T&#x27;HH:mm:ss
        /// </summary>
        /// <value>Fecha de operación pago CODI®, formato: yyyy-MM-dd&#x27;T&#x27;HH:mm:ss</value>
        [DataMember(Name="due_date", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Campo de metada CODI®, longitud máxima determinada por configuracion de la empresa, por defecto 100 caracteres
        /// </summary>
        /// <value>Campo de metada CODI®, longitud máxima determinada por configuracion de la empresa, por defecto 100 caracteres</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Referencia de la transferencia asignada por el cliente
        /// </summary>
        /// <value>Referencia de la transferencia asignada por el cliente</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }


        /// <summary>
        /// Número de teléfono móvil en caso de ser un pago CODI® usando &#x27;PUSH_NOTIFICATION&#x27; estecampo sería obligatorio
        /// </summary>
        /// <value>Número de teléfono móvil en caso de ser un pago CODI® usando &#x27;PUSH_NOTIFICATION&#x27; estecampo sería obligatorio</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Referencia numérica del pago CODI®. Debe ser de 7 dígitos
        /// </summary>
        /// <value>Referencia numérica del pago CODI®. Debe ser de 7 dígitos</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public int? Reference { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodiCodeRequestDTO {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Beneficiary2: ").Append(Beneficiary2).Append("\n");
            sb.Append("  Concept: ").Append(Concept).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as CodiCodeRequestDTO);
        }

        /// <summary>
        /// Returns true if CodiCodeRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of CodiCodeRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodiCodeRequestDTO input)
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
                    this.Beneficiary2 == input.Beneficiary2 ||
                    (this.Beneficiary2 != null &&
                    this.Beneficiary2.Equals(input.Beneficiary2))
                ) && 
                (
                    this.Concept == input.Concept ||
                    (this.Concept != null &&
                    this.Concept.Equals(input.Concept))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.Beneficiary2 != null)
                    hashCode = hashCode * 59 + this.Beneficiary2.GetHashCode();
                if (this.Concept != null)
                    hashCode = hashCode * 59 + this.Concept.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PaymentType != null)
                    hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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
