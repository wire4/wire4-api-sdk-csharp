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
    /// Objeto que contiene la información de las operaciones
    /// </summary>
    [DataContract]
        public partial class Operations :  IEquatable<Operations>, IValidatableObject
    {
        /// <summary>
        /// Estatus de la petición
        /// </summary>
        /// <value>Estatus de la petición</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum RECEIVED for value: RECEIVED
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            RECEIVED = 0,
            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 1,
            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 2        }
        /// <summary>
        /// Estatus de la petición
        /// </summary>
        /// <value>Estatus de la petición</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Tipo de petición de cobro
        /// </summary>
        /// <value>Tipo de petición de cobro</value>
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
            QRCODE = 1        }
        /// <summary>
        /// Tipo de petición de cobro
        /// </summary>
        /// <value>Tipo de petición de cobro</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Operations" /> class.
        /// </summary>
        /// <param name="amount">Monto de la petición.</param>
        /// <param name="company">company.</param>
        /// <param name="description">Descripción de la petición.</param>
        /// <param name="dueDate">Fecha de vencimiento de la petición.</param>
        /// <param name="orderId">Order id de la petición.</param>
        /// <param name="payment">payment.</param>
        /// <param name="phoneNumber">Numero de telefono.</param>
        /// <param name="salesPoint">salesPoint.</param>
        /// <param name="status">Estatus de la petición.</param>
        /// <param name="type">Tipo de petición de cobro.</param>
        public Operations(decimal? amount = default(decimal?), Compay company = default(Compay), string description = default(string), DateTime? dueDate = default(DateTime?), string orderId = default(string), Payment payment = default(Payment), string phoneNumber = default(string), SalesPoint salesPoint = default(SalesPoint), StatusEnum? status = default(StatusEnum?), TypeEnum? type = default(TypeEnum?))
        {
            this.Amount = amount;
            this.Company = company;
            this.Description = description;
            this.DueDate = dueDate;
            this.OrderId = orderId;
            this.Payment = payment;
            this.PhoneNumber = phoneNumber;
            this.SalesPoint = salesPoint;
            this.Status = status;
            this.Type = type;
        }
        
        /// <summary>
        /// Monto de la petición
        /// </summary>
        /// <value>Monto de la petición</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public Compay Company { get; set; }

        /// <summary>
        /// Descripción de la petición
        /// </summary>
        /// <value>Descripción de la petición</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Fecha de vencimiento de la petición
        /// </summary>
        /// <value>Fecha de vencimiento de la petición</value>
        [DataMember(Name="due_date", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Order id de la petición
        /// </summary>
        /// <value>Order id de la petición</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=false)]
        public Payment Payment { get; set; }

        /// <summary>
        /// Numero de telefono
        /// </summary>
        /// <value>Numero de telefono</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets SalesPoint
        /// </summary>
        [DataMember(Name="sales_point", EmitDefaultValue=false)]
        public SalesPoint SalesPoint { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operations {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  SalesPoint: ").Append(SalesPoint).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Operations);
        }

        /// <summary>
        /// Returns true if Operations instances are equal
        /// </summary>
        /// <param name="input">Instance of Operations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Operations input)
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
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Payment == input.Payment ||
                    (this.Payment != null &&
                    this.Payment.Equals(input.Payment))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.SalesPoint == input.SalesPoint ||
                    (this.SalesPoint != null &&
                    this.SalesPoint.Equals(input.SalesPoint))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Payment != null)
                    hashCode = hashCode * 59 + this.Payment.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.SalesPoint != null)
                    hashCode = hashCode * 59 + this.SalesPoint.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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