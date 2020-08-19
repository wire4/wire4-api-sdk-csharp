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
    /// El usuario que corresponde al contrato
    /// </summary>
    [DataContract]
        public partial class UserCompany :  IEquatable<UserCompany>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCompany" /> class.
        /// </summary>
        /// <param name="emails">Una lista de los correos del usuario.</param>
        /// <param name="legalRepresentative">Indica sí es representate legal.</param>
        /// <param name="maskedName">El nombre del usuario enmascarado.</param>
        /// <param name="maskedUserName">El nombre del usuario de acceso enmascarado.</param>
        /// <param name="name">El nombre del usuario.</param>
        /// <param name="phoneNumbers">Una lista de los teléfonos del usuario.</param>
        /// <param name="surnameFather">El apellido paterno del usuario.</param>
        /// <param name="surnameMother">El apellido materno del usuario.</param>
        /// <param name="userName">El nombre del usuario de acceso.</param>
        public UserCompany(List<string> emails = default(List<string>), bool? legalRepresentative = default(bool?), string maskedName = default(string), string maskedUserName = default(string), string name = default(string), List<string> phoneNumbers = default(List<string>), string surnameFather = default(string), string surnameMother = default(string), string userName = default(string))
        {
            this.Emails = emails;
            this.LegalRepresentative = legalRepresentative;
            this.MaskedName = maskedName;
            this.MaskedUserName = maskedUserName;
            this.Name = name;
            this.PhoneNumbers = phoneNumbers;
            this.SurnameFather = surnameFather;
            this.SurnameMother = surnameMother;
            this.UserName = userName;
        }
        
        /// <summary>
        /// Una lista de los correos del usuario
        /// </summary>
        /// <value>Una lista de los correos del usuario</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Indica sí es representate legal
        /// </summary>
        /// <value>Indica sí es representate legal</value>
        [DataMember(Name="legal_representative", EmitDefaultValue=false)]
        public bool? LegalRepresentative { get; set; }

        /// <summary>
        /// El nombre del usuario enmascarado
        /// </summary>
        /// <value>El nombre del usuario enmascarado</value>
        [DataMember(Name="masked_name", EmitDefaultValue=false)]
        public string MaskedName { get; set; }

        /// <summary>
        /// El nombre del usuario de acceso enmascarado
        /// </summary>
        /// <value>El nombre del usuario de acceso enmascarado</value>
        [DataMember(Name="masked_user_name", EmitDefaultValue=false)]
        public string MaskedUserName { get; set; }

        /// <summary>
        /// El nombre del usuario
        /// </summary>
        /// <value>El nombre del usuario</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Una lista de los teléfonos del usuario
        /// </summary>
        /// <value>Una lista de los teléfonos del usuario</value>
        [DataMember(Name="phone_numbers", EmitDefaultValue=false)]
        public List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// El apellido paterno del usuario
        /// </summary>
        /// <value>El apellido paterno del usuario</value>
        [DataMember(Name="surname_father", EmitDefaultValue=false)]
        public string SurnameFather { get; set; }

        /// <summary>
        /// El apellido materno del usuario
        /// </summary>
        /// <value>El apellido materno del usuario</value>
        [DataMember(Name="surname_mother", EmitDefaultValue=false)]
        public string SurnameMother { get; set; }

        /// <summary>
        /// El nombre del usuario de acceso
        /// </summary>
        /// <value>El nombre del usuario de acceso</value>
        [DataMember(Name="user_name", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCompany {\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  LegalRepresentative: ").Append(LegalRepresentative).Append("\n");
            sb.Append("  MaskedName: ").Append(MaskedName).Append("\n");
            sb.Append("  MaskedUserName: ").Append(MaskedUserName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  SurnameFather: ").Append(SurnameFather).Append("\n");
            sb.Append("  SurnameMother: ").Append(SurnameMother).Append("\n");
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
            return this.Equals(input as UserCompany);
        }

        /// <summary>
        /// Returns true if UserCompany instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCompany input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.LegalRepresentative == input.LegalRepresentative ||
                    (this.LegalRepresentative != null &&
                    this.LegalRepresentative.Equals(input.LegalRepresentative))
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
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.SurnameFather == input.SurnameFather ||
                    (this.SurnameFather != null &&
                    this.SurnameFather.Equals(input.SurnameFather))
                ) && 
                (
                    this.SurnameMother == input.SurnameMother ||
                    (this.SurnameMother != null &&
                    this.SurnameMother.Equals(input.SurnameMother))
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
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.LegalRepresentative != null)
                    hashCode = hashCode * 59 + this.LegalRepresentative.GetHashCode();
                if (this.MaskedName != null)
                    hashCode = hashCode * 59 + this.MaskedName.GetHashCode();
                if (this.MaskedUserName != null)
                    hashCode = hashCode * 59 + this.MaskedUserName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.SurnameFather != null)
                    hashCode = hashCode * 59 + this.SurnameFather.GetHashCode();
                if (this.SurnameMother != null)
                    hashCode = hashCode * 59 + this.SurnameMother.GetHashCode();
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
