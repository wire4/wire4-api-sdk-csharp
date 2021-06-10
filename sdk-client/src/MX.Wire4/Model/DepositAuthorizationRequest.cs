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
    /// Contiene la información de la autorización de depósitos
    /// </summary>
    [DataContract]
        public partial class DepositAuthorizationRequest :  IEquatable<DepositAuthorizationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositAuthorizationRequest" /> class.
        /// </summary>
        /// <param name="enabled">Indica sí se aplica la autorización de depósitos..</param>
        /// <param name="webhook">webhook.</param>
        /// <param name="whUuid">Identificador del webhook..</param>
        public DepositAuthorizationRequest(bool? enabled = default(bool?), WebHookDepositAuthorizationRequest webhook = default(WebHookDepositAuthorizationRequest), string whUuid = default(string))
        {
            this.Enabled = enabled;
            this.Webhook = webhook;
            this.WhUuid = whUuid;
        }
        
        /// <summary>
        /// Indica sí se aplica la autorización de depósitos.
        /// </summary>
        /// <value>Indica sí se aplica la autorización de depósitos.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name="webhook", EmitDefaultValue=false)]
        public WebHookDepositAuthorizationRequest Webhook { get; set; }

        /// <summary>
        /// Identificador del webhook.
        /// </summary>
        /// <value>Identificador del webhook.</value>
        [DataMember(Name="wh_uuid", EmitDefaultValue=false)]
        public string WhUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepositAuthorizationRequest {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
            sb.Append("  WhUuid: ").Append(WhUuid).Append("\n");
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
            return this.Equals(input as DepositAuthorizationRequest);
        }

        /// <summary>
        /// Returns true if DepositAuthorizationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositAuthorizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositAuthorizationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Webhook == input.Webhook ||
                    (this.Webhook != null &&
                    this.Webhook.Equals(input.Webhook))
                ) && 
                (
                    this.WhUuid == input.WhUuid ||
                    (this.WhUuid != null &&
                    this.WhUuid.Equals(input.WhUuid))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Webhook != null)
                    hashCode = hashCode * 59 + this.Webhook.GetHashCode();
                if (this.WhUuid != null)
                    hashCode = hashCode * 59 + this.WhUuid.GetHashCode();
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
