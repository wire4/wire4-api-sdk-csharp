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
    /// La información del usuario autorizado para usar el API de Monex.
    /// </summary>
    [DataContract]
        public partial class AuthorizedUsers :  IEquatable<AuthorizedUsers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedUsers" /> class.
        /// </summary>
        /// <param name="account">El contrato al cual se le brinda el acceso a la API.</param>
        /// <param name="maskedAccount">El contrato enmascarado al cual se le brinda el acceso a la API.</param>
        /// <param name="maskedName">El usuario enmascarado que se autorizó.</param>
        /// <param name="maskedUserName">El nombre enmascarado del usuario de acceso que se autorizó.</param>
        /// <param name="name">El usuario que se autorizó.</param>
        /// <param name="userName">El usuario de acceso que se autorizó.</param>
        public AuthorizedUsers(string account = default(string), string maskedAccount = default(string), string maskedName = default(string), string maskedUserName = default(string), string name = default(string), string userName = default(string))
        {
            this.Account = account;
            this.MaskedAccount = maskedAccount;
            this.MaskedName = maskedName;
            this.MaskedUserName = maskedUserName;
            this.Name = name;
            this.UserName = userName;
        }
        
        /// <summary>
        /// El contrato al cual se le brinda el acceso a la API
        /// </summary>
        /// <value>El contrato al cual se le brinda el acceso a la API</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// El contrato enmascarado al cual se le brinda el acceso a la API
        /// </summary>
        /// <value>El contrato enmascarado al cual se le brinda el acceso a la API</value>
        [DataMember(Name="masked_account", EmitDefaultValue=false)]
        public string MaskedAccount { get; set; }

        /// <summary>
        /// El usuario enmascarado que se autorizó
        /// </summary>
        /// <value>El usuario enmascarado que se autorizó</value>
        [DataMember(Name="masked_name", EmitDefaultValue=false)]
        public string MaskedName { get; set; }

        /// <summary>
        /// El nombre enmascarado del usuario de acceso que se autorizó
        /// </summary>
        /// <value>El nombre enmascarado del usuario de acceso que se autorizó</value>
        [DataMember(Name="masked_user_name", EmitDefaultValue=false)]
        public string MaskedUserName { get; set; }

        /// <summary>
        /// El usuario que se autorizó
        /// </summary>
        /// <value>El usuario que se autorizó</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// El usuario de acceso que se autorizó
        /// </summary>
        /// <value>El usuario de acceso que se autorizó</value>
        [DataMember(Name="user_name", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizedUsers {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  MaskedAccount: ").Append(MaskedAccount).Append("\n");
            sb.Append("  MaskedName: ").Append(MaskedName).Append("\n");
            sb.Append("  MaskedUserName: ").Append(MaskedUserName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as AuthorizedUsers);
        }

        /// <summary>
        /// Returns true if AuthorizedUsers instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizedUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizedUsers input)
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
                    this.MaskedAccount == input.MaskedAccount ||
                    (this.MaskedAccount != null &&
                    this.MaskedAccount.Equals(input.MaskedAccount))
                ) && 
                (
                    this.MaskedName == input.MaskedName ||
                    (this.MaskedName != null &&
                    this.MaskedName.Equals(input.MaskedName))
                ) && 
                (
                    this.MaskedUserName == input.MaskedUserName ||
                    (this.MaskedUserName != null &&
                    this.MaskedUserName.Equals(input.MaskedUserName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.MaskedAccount != null)
                    hashCode = hashCode * 59 + this.MaskedAccount.GetHashCode();
                if (this.MaskedName != null)
                    hashCode = hashCode * 59 + this.MaskedName.GetHashCode();
                if (this.MaskedUserName != null)
                    hashCode = hashCode * 59 + this.MaskedUserName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
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