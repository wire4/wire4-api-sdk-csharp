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
    /// La información acerca de la clasificación de la operación.
    /// </summary>
    [DataContract]
        public partial class SpidClassificationDTO :  IEquatable<SpidClassificationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpidClassificationDTO" /> class.
        /// </summary>
        /// <param name="classificationId">Es el identificador de la clasificación..</param>
        /// <param name="description">Es la descripción de la clasificación de la operación..</param>
        public SpidClassificationDTO(string classificationId = default(string), string description = default(string))
        {
            this.ClassificationId = classificationId;
            this.Description = description;
        }
        
        /// <summary>
        /// Es el identificador de la clasificación.
        /// </summary>
        /// <value>Es el identificador de la clasificación.</value>
        [DataMember(Name="classification_id", EmitDefaultValue=false)]
        public string ClassificationId { get; set; }

        /// <summary>
        /// Es la descripción de la clasificación de la operación.
        /// </summary>
        /// <value>Es la descripción de la clasificación de la operación.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpidClassificationDTO {\n");
            sb.Append("  ClassificationId: ").Append(ClassificationId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as SpidClassificationDTO);
        }

        /// <summary>
        /// Returns true if SpidClassificationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SpidClassificationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpidClassificationDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassificationId == input.ClassificationId ||
                    (this.ClassificationId != null &&
                    this.ClassificationId.Equals(input.ClassificationId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ClassificationId != null)
                    hashCode = hashCode * 59 + this.ClassificationId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
