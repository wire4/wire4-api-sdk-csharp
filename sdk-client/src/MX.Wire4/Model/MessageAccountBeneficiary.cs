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
    /// Es el objeto del mensaje que se envía mediante webhook con la información del registro de la cuenta del beneficiario.
    /// </summary>
    [DataContract]
        public partial class MessageAccountBeneficiary :  IEquatable<MessageAccountBeneficiary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAccountBeneficiary" /> class.
        /// </summary>
        /// <param name="account">Es la cuenta del beneficiario registrado..</param>
        /// <param name="errorMessage">Es el mensaje de error que se informa en caso de existir uno..</param>
        /// <param name="requestId">Es el identificador en esta API de la petición de registro de la cuenta del beneficiario..</param>
        public MessageAccountBeneficiary(string account = default(string), string errorMessage = default(string), string requestId = default(string))
        {
            this.Account = account;
            this.ErrorMessage = errorMessage;
            this.RequestId = requestId;
        }
        
        /// <summary>
        /// Es la cuenta del beneficiario registrado.
        /// </summary>
        /// <value>Es la cuenta del beneficiario registrado.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// Es el mensaje de error que se informa en caso de existir uno.
        /// </summary>
        /// <value>Es el mensaje de error que se informa en caso de existir uno.</value>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Es el identificador en esta API de la petición de registro de la cuenta del beneficiario.
        /// </summary>
        /// <value>Es el identificador en esta API de la petición de registro de la cuenta del beneficiario.</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageAccountBeneficiary {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as MessageAccountBeneficiary);
        }

        /// <summary>
        /// Returns true if MessageAccountBeneficiary instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageAccountBeneficiary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageAccountBeneficiary input)
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
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
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
