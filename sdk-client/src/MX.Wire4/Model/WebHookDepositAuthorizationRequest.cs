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
    /// Contiene la información de un WebHook para autorización de depósitos.
    /// </summary>
    [DataContract]
        public partial class WebHookDepositAuthorizationRequest :  IEquatable<WebHookDepositAuthorizationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookDepositAuthorizationRequest" /> class.
        /// </summary>
        /// <param name="name">Es el nombre del webhook..</param>
        /// <param name="url">Es la dirección URL a la cuál Wire4 enviará las notificaciones cuando un evento ocurra..</param>
        public WebHookDepositAuthorizationRequest(string name = default(string), string url = default(string))
        {
            this.Name = name;
            this.Url = url;
        }
        
        /// <summary>
        /// Es el nombre del webhook.
        /// </summary>
        /// <value>Es el nombre del webhook.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Es la dirección URL a la cuál Wire4 enviará las notificaciones cuando un evento ocurra.
        /// </summary>
        /// <value>Es la dirección URL a la cuál Wire4 enviará las notificaciones cuando un evento ocurra.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebHookDepositAuthorizationRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as WebHookDepositAuthorizationRequest);
        }

        /// <summary>
        /// Returns true if WebHookDepositAuthorizationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebHookDepositAuthorizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHookDepositAuthorizationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
