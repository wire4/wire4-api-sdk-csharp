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
    /// Objeto que contiene la información de las transferencias SPEI de salida
    /// </summary>
    [DataContract]
        public partial class TransactionsOutgoingRegister :  IEquatable<TransactionsOutgoingRegister>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsOutgoingRegister" /> class.
        /// </summary>
        /// <param name="cancelReturnUrl">Url a la que se redirigirá en caso de error (required).</param>
        /// <param name="returnUrl">Url a la que se redirigirá en caso de exito (required).</param>
        /// <param name="transactions">Lista de transferencias de salida que se enviarán a Monex (required).</param>
        public TransactionsOutgoingRegister(string cancelReturnUrl = default(string), string returnUrl = default(string), List<TransactionOutgoing> transactions = default(List<TransactionOutgoing>))
        {
            // to ensure "cancelReturnUrl" is required (not null)
            if (cancelReturnUrl == null)
            {
                throw new InvalidDataException("cancelReturnUrl is a required property for TransactionsOutgoingRegister and cannot be null");
            }
            else
            {
                this.CancelReturnUrl = cancelReturnUrl;
            }
            // to ensure "returnUrl" is required (not null)
            if (returnUrl == null)
            {
                throw new InvalidDataException("returnUrl is a required property for TransactionsOutgoingRegister and cannot be null");
            }
            else
            {
                this.ReturnUrl = returnUrl;
            }
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new InvalidDataException("transactions is a required property for TransactionsOutgoingRegister and cannot be null");
            }
            else
            {
                this.Transactions = transactions;
            }
        }
        
        /// <summary>
        /// Url a la que se redirigirá en caso de error
        /// </summary>
        /// <value>Url a la que se redirigirá en caso de error</value>
        [DataMember(Name="cancel_return_url", EmitDefaultValue=false)]
        public string CancelReturnUrl { get; set; }

        /// <summary>
        /// Url a la que se redirigirá en caso de exito
        /// </summary>
        /// <value>Url a la que se redirigirá en caso de exito</value>
        [DataMember(Name="return_url", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Lista de transferencias de salida que se enviarán a Monex
        /// </summary>
        /// <value>Lista de transferencias de salida que se enviarán a Monex</value>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<TransactionOutgoing> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionsOutgoingRegister {\n");
            sb.Append("  CancelReturnUrl: ").Append(CancelReturnUrl).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as TransactionsOutgoingRegister);
        }

        /// <summary>
        /// Returns true if TransactionsOutgoingRegister instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionsOutgoingRegister to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionsOutgoingRegister input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CancelReturnUrl == input.CancelReturnUrl ||
                    (this.CancelReturnUrl != null &&
                    this.CancelReturnUrl.Equals(input.CancelReturnUrl))
                ) && 
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                if (this.CancelReturnUrl != null)
                    hashCode = hashCode * 59 + this.CancelReturnUrl.GetHashCode();
                if (this.ReturnUrl != null)
                    hashCode = hashCode * 59 + this.ReturnUrl.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
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
