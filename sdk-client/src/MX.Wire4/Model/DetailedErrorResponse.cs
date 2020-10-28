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
    /// DetailedErrorResponse
    /// </summary>
    [DataContract]
        public partial class DetailedErrorResponse :  IEquatable<DetailedErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedErrorResponse" /> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        /// <param name="httpStatus">httpStatus.</param>
        /// <param name="message">message.</param>
        public DetailedErrorResponse(List<TransactionErrorCode> errors = default(List<TransactionErrorCode>), int? httpStatus = default(int?), string message = default(string))
        {
            this.Errors = errors;
            this.HttpStatus = httpStatus;
            this.Message = message;
        }
        
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<TransactionErrorCode> Errors { get; set; }

        /// <summary>
        /// Gets or Sets HttpStatus
        /// </summary>
        [DataMember(Name="http_status", EmitDefaultValue=false)]
        public int? HttpStatus { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedErrorResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  HttpStatus: ").Append(HttpStatus).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as DetailedErrorResponse);
        }

        /// <summary>
        /// Returns true if DetailedErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedErrorResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.HttpStatus == input.HttpStatus ||
                    (this.HttpStatus != null &&
                    this.HttpStatus.Equals(input.HttpStatus))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.HttpStatus != null)
                    hashCode = hashCode * 59 + this.HttpStatus.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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