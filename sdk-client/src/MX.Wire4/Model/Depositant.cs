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
    /// Objeto que contiene los datos del depositante
    /// </summary>
    [DataContract]
        public partial class Depositant :  IEquatable<Depositant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Depositant" /> class.
        /// </summary>
        /// <param name="alias">Es el alias del depositante..</param>
        /// <param name="currencyCode">Es el código de divisa que opera el depositante. Es en el formato estándar de 3 dígitos. Sólo se permiten los valores &lt;b&gt;MXP&lt;/b&gt; y &lt;b&gt;USD&lt;/b&gt;..</param>
        /// <param name="depositantClabe">Es la cuenta CLABE (es de 18 dígitos) del depositante..</param>
        /// <param name="email">Es la lista de correos electrónicos (emails) del depositante..</param>
        /// <param name="name">Es el nombre del depositante..</param>
        public Depositant(string alias = default(string), string currencyCode = default(string), string depositantClabe = default(string), List<string> email = default(List<string>), string name = default(string))
        {
            this.Alias = alias;
            this.CurrencyCode = currencyCode;
            this.DepositantClabe = depositantClabe;
            this.Email = email;
            this.Name = name;
        }
        
        /// <summary>
        /// Es el alias del depositante.
        /// </summary>
        /// <value>Es el alias del depositante.</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Es el código de divisa que opera el depositante. Es en el formato estándar de 3 dígitos. Sólo se permiten los valores &lt;b&gt;MXP&lt;/b&gt; y &lt;b&gt;USD&lt;/b&gt;.
        /// </summary>
        /// <value>Es el código de divisa que opera el depositante. Es en el formato estándar de 3 dígitos. Sólo se permiten los valores &lt;b&gt;MXP&lt;/b&gt; y &lt;b&gt;USD&lt;/b&gt;.</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Es la cuenta CLABE (es de 18 dígitos) del depositante.
        /// </summary>
        /// <value>Es la cuenta CLABE (es de 18 dígitos) del depositante.</value>
        [DataMember(Name="depositant_clabe", EmitDefaultValue=false)]
        public string DepositantClabe { get; set; }

        /// <summary>
        /// Es la lista de correos electrónicos (emails) del depositante.
        /// </summary>
        /// <value>Es la lista de correos electrónicos (emails) del depositante.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public List<string> Email { get; set; }

        /// <summary>
        /// Es el nombre del depositante.
        /// </summary>
        /// <value>Es el nombre del depositante.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Depositant {\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DepositantClabe: ").Append(DepositantClabe).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Depositant);
        }

        /// <summary>
        /// Returns true if Depositant instances are equal
        /// </summary>
        /// <param name="input">Instance of Depositant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Depositant input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.DepositantClabe == input.DepositantClabe ||
                    (this.DepositantClabe != null &&
                    this.DepositantClabe.Equals(input.DepositantClabe))
                ) && 
                (
                    this.Email == input.Email ||
                    this.Email != null &&
                    input.Email != null &&
                    this.Email.SequenceEqual(input.Email)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.DepositantClabe != null)
                    hashCode = hashCode * 59 + this.DepositantClabe.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
