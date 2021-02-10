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
    /// Es el objeto del mensaje que se envía mediante webhook con la información acerca de algún cambio en el procesamiento o estado de la petición a esta a esta API.
    /// </summary>
    [DataContract]
        public partial class MessageRequestChanged :  IEquatable<MessageRequestChanged>, IValidatableObject
    {
        /// <summary>
        /// Es el cambio a informar en el procesamiento/estado de la petición.
        /// </summary>
        /// <value>Es el cambio a informar en el procesamiento/estado de la petición.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum AUTHORIZED for value: AUTHORIZED
            /// </summary>
            [EnumMember(Value = "AUTHORIZED")]
            AUTHORIZED = 0        }
        /// <summary>
        /// Es el cambio a informar en el procesamiento/estado de la petición.
        /// </summary>
        /// <value>Es el cambio a informar en el procesamiento/estado de la petición.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequestChanged" /> class.
        /// </summary>
        /// <param name="requestId">Es el identificador de la petición realizada a esta API..</param>
        /// <param name="status">Es el cambio a informar en el procesamiento/estado de la petición..</param>
        public MessageRequestChanged(string requestId = default(string), StatusEnum? status = default(StatusEnum?))
        {
            this.RequestId = requestId;
            this.Status = status;
        }
        
        /// <summary>
        /// Es el identificador de la petición realizada a esta API.
        /// </summary>
        /// <value>Es el identificador de la petición realizada a esta API.</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageRequestChanged {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as MessageRequestChanged);
        }

        /// <summary>
        /// Returns true if MessageRequestChanged instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageRequestChanged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageRequestChanged input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
