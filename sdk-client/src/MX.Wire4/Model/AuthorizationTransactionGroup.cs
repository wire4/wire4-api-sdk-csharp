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
    /// Contiene la información para agrupar transacciones existentes y autorizarlas de forma conjunta
    /// </summary>
    [DataContract]
        public partial class AuthorizationTransactionGroup :  IEquatable<AuthorizationTransactionGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationTransactionGroup" /> class.
        /// </summary>
        /// <param name="redirectUrls">redirectUrls (required).</param>
        /// <param name="transactions">Listado de order_id de las transacciones a agrupar. (required).</param>
        public AuthorizationTransactionGroup(UrlsRedirect redirectUrls = default(UrlsRedirect), List<string> transactions = default(List<string>))
        {
            // to ensure "redirectUrls" is required (not null)
            if (redirectUrls == null)
            {
                throw new InvalidDataException("redirectUrls is a required property for AuthorizationTransactionGroup and cannot be null");
            }
            else
            {
                this.RedirectUrls = redirectUrls;
            }
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new InvalidDataException("transactions is a required property for AuthorizationTransactionGroup and cannot be null");
            }
            else
            {
                this.Transactions = transactions;
            }
        }
        
        /// <summary>
        /// Gets or Sets RedirectUrls
        /// </summary>
        [DataMember(Name="redirect_urls", EmitDefaultValue=false)]
        public UrlsRedirect RedirectUrls { get; set; }

        /// <summary>
        /// Listado de order_id de las transacciones a agrupar.
        /// </summary>
        /// <value>Listado de order_id de las transacciones a agrupar.</value>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<string> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizationTransactionGroup {\n");
            sb.Append("  RedirectUrls: ").Append(RedirectUrls).Append("\n");
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
            return this.Equals(input as AuthorizationTransactionGroup);
        }

        /// <summary>
        /// Returns true if AuthorizationTransactionGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizationTransactionGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizationTransactionGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RedirectUrls == input.RedirectUrls ||
                    (this.RedirectUrls != null &&
                    this.RedirectUrls.Equals(input.RedirectUrls))
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
                if (this.RedirectUrls != null)
                    hashCode = hashCode * 59 + this.RedirectUrls.GetHashCode();
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
