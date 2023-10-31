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
    /// La dirección de la companía
    /// </summary>
    [DataContract]
        public partial class AddressCompany :  IEquatable<AddressCompany>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressCompany" /> class.
        /// </summary>
        /// <param name="city">La ciudad.</param>
        /// <param name="countryCode">La clabe del país.</param>
        /// <param name="exteriorNumber">Número exterior.</param>
        /// <param name="interiorNumber">Número interior.</param>
        /// <param name="municipality">El municipio.</param>
        /// <param name="postalCode">Código postal.</param>
        /// <param name="settlement">El asentamiento.</param>
        /// <param name="settlementName">El nombre del asentamiento.</param>
        /// <param name="state">El estado.</param>
        /// <param name="streetAddress">La calle.</param>
        public AddressCompany(string city = default(string), string countryCode = default(string), string exteriorNumber = default(string), string interiorNumber = default(string), string municipality = default(string), string postalCode = default(string), string settlement = default(string), string settlementName = default(string), string state = default(string), string streetAddress = default(string))
        {
            this.City = city;
            this.CountryCode = countryCode;
            this.ExteriorNumber = exteriorNumber;
            this.InteriorNumber = interiorNumber;
            this.Municipality = municipality;
            this.PostalCode = postalCode;
            this.Settlement = settlement;
            this.SettlementName = settlementName;
            this.State = state;
            this.StreetAddress = streetAddress;
        }
        
        /// <summary>
        /// La ciudad
        /// </summary>
        /// <value>La ciudad</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// La clabe del país
        /// </summary>
        /// <value>La clabe del país</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Número exterior
        /// </summary>
        /// <value>Número exterior</value>
        [DataMember(Name="exterior_number", EmitDefaultValue=false)]
        public string ExteriorNumber { get; set; }

        /// <summary>
        /// Número interior
        /// </summary>
        /// <value>Número interior</value>
        [DataMember(Name="interior_number", EmitDefaultValue=false)]
        public string InteriorNumber { get; set; }

        /// <summary>
        /// El municipio
        /// </summary>
        /// <value>El municipio</value>
        [DataMember(Name="municipality", EmitDefaultValue=false)]
        public string Municipality { get; set; }

        /// <summary>
        /// Código postal
        /// </summary>
        /// <value>Código postal</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// El asentamiento
        /// </summary>
        /// <value>El asentamiento</value>
        [DataMember(Name="settlement", EmitDefaultValue=false)]
        public string Settlement { get; set; }

        /// <summary>
        /// El nombre del asentamiento
        /// </summary>
        /// <value>El nombre del asentamiento</value>
        [DataMember(Name="settlement_name", EmitDefaultValue=false)]
        public string SettlementName { get; set; }

        /// <summary>
        /// El estado
        /// </summary>
        /// <value>El estado</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// La calle
        /// </summary>
        /// <value>La calle</value>
        [DataMember(Name="street_address", EmitDefaultValue=false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressCompany {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  ExteriorNumber: ").Append(ExteriorNumber).Append("\n");
            sb.Append("  InteriorNumber: ").Append(InteriorNumber).Append("\n");
            sb.Append("  Municipality: ").Append(Municipality).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Settlement: ").Append(Settlement).Append("\n");
            sb.Append("  SettlementName: ").Append(SettlementName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
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
            return this.Equals(input as AddressCompany);
        }

        /// <summary>
        /// Returns true if AddressCompany instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressCompany input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.ExteriorNumber == input.ExteriorNumber ||
                    (this.ExteriorNumber != null &&
                    this.ExteriorNumber.Equals(input.ExteriorNumber))
                ) && 
                (
                    this.InteriorNumber == input.InteriorNumber ||
                    (this.InteriorNumber != null &&
                    this.InteriorNumber.Equals(input.InteriorNumber))
                ) && 
                (
                    this.Municipality == input.Municipality ||
                    (this.Municipality != null &&
                    this.Municipality.Equals(input.Municipality))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Settlement == input.Settlement ||
                    (this.Settlement != null &&
                    this.Settlement.Equals(input.Settlement))
                ) && 
                (
                    this.SettlementName == input.SettlementName ||
                    (this.SettlementName != null &&
                    this.SettlementName.Equals(input.SettlementName))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StreetAddress == input.StreetAddress ||
                    (this.StreetAddress != null &&
                    this.StreetAddress.Equals(input.StreetAddress))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.ExteriorNumber != null)
                    hashCode = hashCode * 59 + this.ExteriorNumber.GetHashCode();
                if (this.InteriorNumber != null)
                    hashCode = hashCode * 59 + this.InteriorNumber.GetHashCode();
                if (this.Municipality != null)
                    hashCode = hashCode * 59 + this.Municipality.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Settlement != null)
                    hashCode = hashCode * 59 + this.Settlement.GetHashCode();
                if (this.SettlementName != null)
                    hashCode = hashCode * 59 + this.SettlementName.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StreetAddress != null)
                    hashCode = hashCode * 59 + this.StreetAddress.GetHashCode();
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
