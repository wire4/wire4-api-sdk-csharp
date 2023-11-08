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
        public partial class WebHookDepositAuthorizationResponse :  IEquatable<WebHookDepositAuthorizationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookDepositAuthorizationResponse" /> class.
        /// </summary>
        /// <param name="events">Tipo de evento manejado por el webhook, para mas referencia sobre los tipos de eventos soportados, revise la siguiente liga: &lt;a href&#x3D;\&quot;https://developers.wire4.mx/#section/Eventos\&quot;&gt;https://developers.wire4.mx/#section/Eventos.&lt;/a&gt;.</param>
        /// <param name="name">Es el nombre del webhook..</param>
        /// <param name="secret">Es la llave con la cuál se debe de identificar que el webhook fue enviado por Wire4. Para mayor información revisar la guía de notificaciones en la sección de  &lt;a href&#x3D;\&quot;https://wire4.mx/#/guides/notificaciones\&quot;&gt;\&quot;Comprobación de firmas de Webhook\&quot;.&lt;/a&gt;.</param>
        /// <param name="status">Es el estado (estatus) en el que se encuentra el webhook..</param>
        /// <param name="url">Es la dirección URL a la cuál Wire4 enviará las notificaciones cuando un evento ocurra..</param>
        /// <param name="whUuid"> Es el identificador del webhook..</param>
        public WebHookDepositAuthorizationResponse(List<string> events = default(List<string>), string name = default(string), string secret = default(string), string status = default(string), string url = default(string), string whUuid = default(string))
        {
            this.Events = events;
            this.Name = name;
            this.Secret = secret;
            this.Status = status;
            this.Url = url;
            this.WhUuid = whUuid;
        }
        
        /// <summary>
        /// Tipo de evento manejado por el webhook, para mas referencia sobre los tipos de eventos soportados, revise la siguiente liga: &lt;a href&#x3D;\&quot;https://developers.wire4.mx/#section/Eventos\&quot;&gt;https://developers.wire4.mx/#section/Eventos.&lt;/a&gt;
        /// </summary>
        /// <value>Tipo de evento manejado por el webhook, para mas referencia sobre los tipos de eventos soportados, revise la siguiente liga: &lt;a href&#x3D;\&quot;https://developers.wire4.mx/#section/Eventos\&quot;&gt;https://developers.wire4.mx/#section/Eventos.&lt;/a&gt;</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Es el nombre del webhook.
        /// </summary>
        /// <value>Es el nombre del webhook.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Es la llave con la cuál se debe de identificar que el webhook fue enviado por Wire4. Para mayor información revisar la guía de notificaciones en la sección de  &lt;a href&#x3D;\&quot;https://wire4.mx/#/guides/notificaciones\&quot;&gt;\&quot;Comprobación de firmas de Webhook\&quot;.&lt;/a&gt;
        /// </summary>
        /// <value>Es la llave con la cuál se debe de identificar que el webhook fue enviado por Wire4. Para mayor información revisar la guía de notificaciones en la sección de  &lt;a href&#x3D;\&quot;https://wire4.mx/#/guides/notificaciones\&quot;&gt;\&quot;Comprobación de firmas de Webhook\&quot;.&lt;/a&gt;</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Es el estado (estatus) en el que se encuentra el webhook.
        /// </summary>
        /// <value>Es el estado (estatus) en el que se encuentra el webhook.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Es la dirección URL a la cuál Wire4 enviará las notificaciones cuando un evento ocurra.
        /// </summary>
        /// <value>Es la dirección URL a la cuál Wire4 enviará las notificaciones cuando un evento ocurra.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        ///  Es el identificador del webhook.
        /// </summary>
        /// <value> Es el identificador del webhook.</value>
        [DataMember(Name="wh_uuid", EmitDefaultValue=false)]
        public string WhUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebHookDepositAuthorizationResponse {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as WebHookDepositAuthorizationResponse);
        }

        /// <summary>
        /// Returns true if WebHookDepositAuthorizationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WebHookDepositAuthorizationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHookDepositAuthorizationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
