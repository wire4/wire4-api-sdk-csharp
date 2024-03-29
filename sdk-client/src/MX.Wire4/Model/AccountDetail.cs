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
    /// La información de la compañía que corresponde al contrato.
    /// </summary>
    [DataContract]
        public partial class AccountDetail :  IEquatable<AccountDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetail" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="businessName">El nombre del negocio.</param>
        /// <param name="constitutionDate">La fecha de constitución del negocio.</param>
        /// <param name="emails">La lista de correos del negocio.</param>
        /// <param name="legalRepresentatives">La lista de los representantes legales negocio.</param>
        /// <param name="rfc">El RFC del negocio.</param>
        public AccountDetail(AddressCompany address = default(AddressCompany), string businessName = default(string), string constitutionDate = default(string), List<string> emails = default(List<string>), List<string> legalRepresentatives = default(List<string>), string rfc = default(string))
        {
            this.Address = address;
            this.BusinessName = businessName;
            this.ConstitutionDate = constitutionDate;
            this.Emails = emails;
            this.LegalRepresentatives = legalRepresentatives;
            this.Rfc = rfc;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public AddressCompany Address { get; set; }

        /// <summary>
        /// El nombre del negocio
        /// </summary>
        /// <value>El nombre del negocio</value>
        [DataMember(Name="business_name", EmitDefaultValue=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// La fecha de constitución del negocio
        /// </summary>
        /// <value>La fecha de constitución del negocio</value>
        [DataMember(Name="constitution_date", EmitDefaultValue=false)]
        public string ConstitutionDate { get; set; }

        /// <summary>
        /// La lista de correos del negocio
        /// </summary>
        /// <value>La lista de correos del negocio</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// La lista de los representantes legales negocio
        /// </summary>
        /// <value>La lista de los representantes legales negocio</value>
        [DataMember(Name="legal_representatives", EmitDefaultValue=false)]
        public List<string> LegalRepresentatives { get; set; }

        /// <summary>
        /// El RFC del negocio
        /// </summary>
        /// <value>El RFC del negocio</value>
        [DataMember(Name="rfc", EmitDefaultValue=false)]
        public string Rfc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDetail {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  ConstitutionDate: ").Append(ConstitutionDate).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  LegalRepresentatives: ").Append(LegalRepresentatives).Append("\n");
            sb.Append("  Rfc: ").Append(Rfc).Append("\n");
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
            return this.Equals(input as AccountDetail);
        }

        /// <summary>
        /// Returns true if AccountDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BusinessName == input.BusinessName ||
                    (this.BusinessName != null &&
                    this.BusinessName.Equals(input.BusinessName))
                ) && 
                (
                    this.ConstitutionDate == input.ConstitutionDate ||
                    (this.ConstitutionDate != null &&
                    this.ConstitutionDate.Equals(input.ConstitutionDate))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.LegalRepresentatives == input.LegalRepresentatives ||
                    this.LegalRepresentatives != null &&
                    input.LegalRepresentatives != null &&
                    this.LegalRepresentatives.SequenceEqual(input.LegalRepresentatives)
                ) && 
                (
                    this.Rfc == input.Rfc ||
                    (this.Rfc != null &&
                    this.Rfc.Equals(input.Rfc))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.BusinessName != null)
                    hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.ConstitutionDate != null)
                    hashCode = hashCode * 59 + this.ConstitutionDate.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.LegalRepresentatives != null)
                    hashCode = hashCode * 59 + this.LegalRepresentatives.GetHashCode();
                if (this.Rfc != null)
                    hashCode = hashCode * 59 + this.Rfc.GetHashCode();
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
