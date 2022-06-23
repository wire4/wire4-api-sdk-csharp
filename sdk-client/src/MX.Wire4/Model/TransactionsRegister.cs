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
    /// Objeto que contiene la información de las transferencias SPEI y SPID de salida.
    /// </summary>
    [DataContract]
        public partial class TransactionsRegister :  IEquatable<TransactionsRegister>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsRegister" /> class.
        /// </summary>
        /// <param name="cancelReturnUrl">Es la dirección URL a la que se redirigirá en caso de que el usario cancele el registro. (required).</param>
        /// <param name="returnUrl">Es la dirección URL a la que se redirigirá en caso de éxito. (required).</param>
        /// <param name="spei">Lista de transacciones SPEI.</param>
        /// <param name="spid">Lista de transacciones SPID.</param>
        public TransactionsRegister(string cancelReturnUrl = default(string), string returnUrl = default(string), List<TransactionSpeiSpid> spei = default(List<TransactionSpeiSpid>), List<TransactionSpeiSpid> spid = default(List<TransactionSpeiSpid>))
        {
            // to ensure "cancelReturnUrl" is required (not null)
            if (cancelReturnUrl == null)
            {
                throw new InvalidDataException("cancelReturnUrl is a required property for TransactionsRegister and cannot be null");
            }
            else
            {
                this.CancelReturnUrl = cancelReturnUrl;
            }
            // to ensure "returnUrl" is required (not null)
            if (returnUrl == null)
            {
                throw new InvalidDataException("returnUrl is a required property for TransactionsRegister and cannot be null");
            }
            else
            {
                this.ReturnUrl = returnUrl;
            }
            this.Spei = spei;
            this.Spid = spid;
        }
        
        /// <summary>
        /// Es la dirección URL a la que se redirigirá en caso de que el usario cancele el registro.
        /// </summary>
        /// <value>Es la dirección URL a la que se redirigirá en caso de que el usario cancele el registro.</value>
        [DataMember(Name="cancel_return_url", EmitDefaultValue=false)]
        public string CancelReturnUrl { get; set; }

        /// <summary>
        /// Es la dirección URL a la que se redirigirá en caso de éxito.
        /// </summary>
        /// <value>Es la dirección URL a la que se redirigirá en caso de éxito.</value>
        [DataMember(Name="return_url", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Lista de transacciones SPEI
        /// </summary>
        /// <value>Lista de transacciones SPEI</value>
        [DataMember(Name="spei", EmitDefaultValue=false)]
        public List<TransactionSpeiSpid> Spei { get; set; }

        /// <summary>
        /// Lista de transacciones SPID
        /// </summary>
        /// <value>Lista de transacciones SPID</value>
        [DataMember(Name="spid", EmitDefaultValue=false)]
        public List<TransactionSpeiSpid> Spid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionsRegister {\n");
            sb.Append("  CancelReturnUrl: ").Append(CancelReturnUrl).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  Spei: ").Append(Spei).Append("\n");
            sb.Append("  Spid: ").Append(Spid).Append("\n");
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
            return this.Equals(input as TransactionsRegister);
        }

        /// <summary>
        /// Returns true if TransactionsRegister instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionsRegister to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionsRegister input)
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
                    this.Spei == input.Spei ||
                    this.Spei != null &&
                    input.Spei != null &&
                    this.Spei.SequenceEqual(input.Spei)
                ) && 
                (
                    this.Spid == input.Spid ||
                    this.Spid != null &&
                    input.Spid != null &&
                    this.Spid.SequenceEqual(input.Spid)
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
                if (this.Spei != null)
                    hashCode = hashCode * 59 + this.Spei.GetHashCode();
                if (this.Spid != null)
                    hashCode = hashCode * 59 + this.Spid.GetHashCode();
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