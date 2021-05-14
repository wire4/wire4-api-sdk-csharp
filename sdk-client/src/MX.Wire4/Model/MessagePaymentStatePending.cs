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
    /// Es el objeto del mensaje que se envía mediante webhook con la información de una transferencia que está pendiente de ser completada.
    /// </summary>
    [DataContract]
        public partial class MessagePaymentStatePending :  IEquatable<MessagePaymentStatePending>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagePaymentStatePending" /> class.
        /// </summary>
        /// <param name="account">Es la cuenta del ordenante..</param>
        /// <param name="amount">Es el monto de la transferencia..</param>
        /// <param name="beneficiaryAccount">Es la cuenta del beneficiario..</param>
        /// <param name="beneficiaryBank">beneficiaryBank.</param>
        /// <param name="beneficiaryName">Es el nombre del beneficiario..</param>
        /// <param name="concept">Es el concepto de la transferencia de salida..</param>
        /// <param name="currencyCode">Código de divisa de la transferencia de salida. Es en el formato estándar ISO 4217 y es de 3 dígitos. Ejemplo: \&quot;MXN\&quot;..</param>
        /// <param name="detentionMessage">Es el Mensaje de detención de Monex, indica la causa por la cuál esta detenida la operación en Monex..</param>
        /// <param name="errorMessage">Es el mensaje de error..</param>
        /// <param name="orderId">El identificador de la transferencia de salida..</param>
        /// <param name="paymentOrderId">Es el identificador de la orden de pago de Monex de la transferencia de salida..</param>
        /// <param name="pendingReason">Es el esaado que identifica la causa por la que la transferencia se ecuentra detenida o  pendiente de procesarse. Los posibles estados son: &lt;ul&gt;&lt;li&gt;FI&#x3D;Fondos Insuficientes&lt;/li&gt;&lt;li&gt;FM&#x3D;Firma mancomunada, en espera de ingreso de segundo token de autorización&lt;/li&gt;&lt;li&gt;DP&#x3D;Se detecto una transferencia duplicada que esta en wspera de confirmación o de eliminación&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="reference">Es la referecia de la transferencia..</param>
        /// <param name="requestId">Es el identificador, en esta API, de la petición de envío de la transferencia de salida..</param>
        /// <param name="statusCode">Es el estado (estatus) de la transferencia de salida. Deberá ser \&quot;PENDING\&quot;..</param>
        /// <param name="transactionId">Es el identificador de Monex de la transferencia de salida, podría no estar presente por lo que Usted debería hacer referencias mediate el paymentOrderID..</param>
        public MessagePaymentStatePending(string account = default(string), decimal? amount = default(decimal?), string beneficiaryAccount = default(string), MessageInstitution beneficiaryBank = default(MessageInstitution), string beneficiaryName = default(string), string concept = default(string), string currencyCode = default(string), string detentionMessage = default(string), string errorMessage = default(string), string orderId = default(string), int? paymentOrderId = default(int?), string pendingReason = default(string), int? reference = default(int?), string requestId = default(string), string statusCode = default(string), int? transactionId = default(int?))
        {
            this.Account = account;
            this.Amount = amount;
            this.BeneficiaryAccount = beneficiaryAccount;
            this.BeneficiaryBank = beneficiaryBank;
            this.BeneficiaryName = beneficiaryName;
            this.Concept = concept;
            this.CurrencyCode = currencyCode;
            this.DetentionMessage = detentionMessage;
            this.ErrorMessage = errorMessage;
            this.OrderId = orderId;
            this.PaymentOrderId = paymentOrderId;
            this.PendingReason = pendingReason;
            this.Reference = reference;
            this.RequestId = requestId;
            this.StatusCode = statusCode;
            this.TransactionId = transactionId;
        }
        
        /// <summary>
        /// Es la cuenta del ordenante.
        /// </summary>
        /// <value>Es la cuenta del ordenante.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

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
        /// Gets or Sets BeneficiaryBank
        /// </summary>
        [DataMember(Name="beneficiary_bank", EmitDefaultValue=false)]
        public MessageInstitution BeneficiaryBank { get; set; }

        /// <summary>
        /// Es el nombre del beneficiario.
        /// </summary>
        /// <value>Es el nombre del beneficiario.</value>
        [DataMember(Name="beneficiary_name", EmitDefaultValue=false)]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// Es el concepto de la transferencia de salida.
        /// </summary>
        /// <value>Es el concepto de la transferencia de salida.</value>
        [DataMember(Name="concept", EmitDefaultValue=false)]
        public string Concept { get; set; }

        /// <summary>
        /// Código de divisa de la transferencia de salida. Es en el formato estándar ISO 4217 y es de 3 dígitos. Ejemplo: \&quot;MXN\&quot;.
        /// </summary>
        /// <value>Código de divisa de la transferencia de salida. Es en el formato estándar ISO 4217 y es de 3 dígitos. Ejemplo: \&quot;MXN\&quot;.</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Es el Mensaje de detención de Monex, indica la causa por la cuál esta detenida la operación en Monex.
        /// </summary>
        /// <value>Es el Mensaje de detención de Monex, indica la causa por la cuál esta detenida la operación en Monex.</value>
        [DataMember(Name="detention_message", EmitDefaultValue=false)]
        public string DetentionMessage { get; set; }

        /// <summary>
        /// Es el mensaje de error.
        /// </summary>
        /// <value>Es el mensaje de error.</value>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// El identificador de la transferencia de salida.
        /// </summary>
        /// <value>El identificador de la transferencia de salida.</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Es el identificador de la orden de pago de Monex de la transferencia de salida.
        /// </summary>
        /// <value>Es el identificador de la orden de pago de Monex de la transferencia de salida.</value>
        [DataMember(Name="payment_order_id", EmitDefaultValue=false)]
        public int? PaymentOrderId { get; set; }

        /// <summary>
        /// Es el esaado que identifica la causa por la que la transferencia se ecuentra detenida o  pendiente de procesarse. Los posibles estados son: &lt;ul&gt;&lt;li&gt;FI&#x3D;Fondos Insuficientes&lt;/li&gt;&lt;li&gt;FM&#x3D;Firma mancomunada, en espera de ingreso de segundo token de autorización&lt;/li&gt;&lt;li&gt;DP&#x3D;Se detecto una transferencia duplicada que esta en wspera de confirmación o de eliminación&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Es el esaado que identifica la causa por la que la transferencia se ecuentra detenida o  pendiente de procesarse. Los posibles estados son: &lt;ul&gt;&lt;li&gt;FI&#x3D;Fondos Insuficientes&lt;/li&gt;&lt;li&gt;FM&#x3D;Firma mancomunada, en espera de ingreso de segundo token de autorización&lt;/li&gt;&lt;li&gt;DP&#x3D;Se detecto una transferencia duplicada que esta en wspera de confirmación o de eliminación&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="pending_reason", EmitDefaultValue=false)]
        public string PendingReason { get; set; }

        /// <summary>
        /// Es la referecia de la transferencia.
        /// </summary>
        /// <value>Es la referecia de la transferencia.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public int? Reference { get; set; }

        /// <summary>
        /// Es el identificador, en esta API, de la petición de envío de la transferencia de salida.
        /// </summary>
        /// <value>Es el identificador, en esta API, de la petición de envío de la transferencia de salida.</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Es el estado (estatus) de la transferencia de salida. Deberá ser \&quot;PENDING\&quot;.
        /// </summary>
        /// <value>Es el estado (estatus) de la transferencia de salida. Deberá ser \&quot;PENDING\&quot;.</value>
        [DataMember(Name="status_code", EmitDefaultValue=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Es el identificador de Monex de la transferencia de salida, podría no estar presente por lo que Usted debería hacer referencias mediate el paymentOrderID.
        /// </summary>
        /// <value>Es el identificador de Monex de la transferencia de salida, podría no estar presente por lo que Usted debería hacer referencias mediate el paymentOrderID.</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagePaymentStatePending {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BeneficiaryAccount: ").Append(BeneficiaryAccount).Append("\n");
            sb.Append("  BeneficiaryBank: ").Append(BeneficiaryBank).Append("\n");
            sb.Append("  BeneficiaryName: ").Append(BeneficiaryName).Append("\n");
            sb.Append("  Concept: ").Append(Concept).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DetentionMessage: ").Append(DetentionMessage).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PaymentOrderId: ").Append(PaymentOrderId).Append("\n");
            sb.Append("  PendingReason: ").Append(PendingReason).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as MessagePaymentStatePending);
        }

        /// <summary>
        /// Returns true if MessagePaymentStatePending instances are equal
        /// </summary>
        /// <param name="input">Instance of MessagePaymentStatePending to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagePaymentStatePending input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
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
                    this.BeneficiaryBank == input.BeneficiaryBank ||
                    (this.BeneficiaryBank != null &&
                    this.BeneficiaryBank.Equals(input.BeneficiaryBank))
                ) && 
                (
                    this.BeneficiaryName == input.BeneficiaryName ||
                    (this.BeneficiaryName != null &&
                    this.BeneficiaryName.Equals(input.BeneficiaryName))
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
                    this.DetentionMessage == input.DetentionMessage ||
                    (this.DetentionMessage != null &&
                    this.DetentionMessage.Equals(input.DetentionMessage))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PaymentOrderId == input.PaymentOrderId ||
                    (this.PaymentOrderId != null &&
                    this.PaymentOrderId.Equals(input.PaymentOrderId))
                ) && 
                (
                    this.PendingReason == input.PendingReason ||
                    (this.PendingReason != null &&
                    this.PendingReason.Equals(input.PendingReason))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BeneficiaryAccount != null)
                    hashCode = hashCode * 59 + this.BeneficiaryAccount.GetHashCode();
                if (this.BeneficiaryBank != null)
                    hashCode = hashCode * 59 + this.BeneficiaryBank.GetHashCode();
                if (this.BeneficiaryName != null)
                    hashCode = hashCode * 59 + this.BeneficiaryName.GetHashCode();
                if (this.Concept != null)
                    hashCode = hashCode * 59 + this.Concept.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.DetentionMessage != null)
                    hashCode = hashCode * 59 + this.DetentionMessage.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PaymentOrderId != null)
                    hashCode = hashCode * 59 + this.PaymentOrderId.GetHashCode();
                if (this.PendingReason != null)
                    hashCode = hashCode * 59 + this.PendingReason.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
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
