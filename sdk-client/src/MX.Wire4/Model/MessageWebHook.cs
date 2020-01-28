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
    /// El objeto que se envía mediante un mensaje WebHook
    /// </summary>
    [DataContract]
        public partial class MessageWebHook :  IEquatable<MessageWebHook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebHook" /> class.
        /// </summary>
        /// <param name="apiVersion">La versión de la API.</param>
        /// <param name="created">Fecha de creación del mensaje.</param>
        /// <param name="data">Objeto que contiene la información del evento.</param>
        /// <param name="id">El identificador del mensaje.</param>
        /// <param name="livemode">Indica si proviene de un entorno productivo.</param>
        /// <param name="_object">Tipo de objeto  que contiene el mensaje en el atributo data los posibles valores son: subscription, beneficiary, spei_outgoing, spei_incoming, spid_outgoing .</param>
        /// <param name="pendingWebhooks">Número de  mensajes pendientes de enviar.</param>
        /// <param name="request">Identificador del recurso relacionado.</param>
        /// <param name="type">El tipo evento que se esta enviando en la notifiación.</param>
        public MessageWebHook(string apiVersion = default(string), DateTime? created = default(DateTime?), Object data = default(Object), string id = default(string), bool? livemode = default(bool?), string _object = default(string), int? pendingWebhooks = default(int?), string request = default(string), string type = default(string))
        {
            this.ApiVersion = apiVersion;
            this.Created = created;
            this.Data = data;
            this.Id = id;
            this.Livemode = livemode;
            this.Object = _object;
            this.PendingWebhooks = pendingWebhooks;
            this.Request = request;
            this.Type = type;
        }
        
        /// <summary>
        /// La versión de la API
        /// </summary>
        /// <value>La versión de la API</value>
        [DataMember(Name="api_version", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Fecha de creación del mensaje
        /// </summary>
        /// <value>Fecha de creación del mensaje</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Objeto que contiene la información del evento
        /// </summary>
        /// <value>Objeto que contiene la información del evento</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Object Data { get; set; }

        /// <summary>
        /// El identificador del mensaje
        /// </summary>
        /// <value>El identificador del mensaje</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Indica si proviene de un entorno productivo
        /// </summary>
        /// <value>Indica si proviene de un entorno productivo</value>
        [DataMember(Name="livemode", EmitDefaultValue=false)]
        public bool? Livemode { get; set; }

        /// <summary>
        /// Tipo de objeto  que contiene el mensaje en el atributo data los posibles valores son: subscription, beneficiary, spei_outgoing, spei_incoming, spid_outgoing 
        /// </summary>
        /// <value>Tipo de objeto  que contiene el mensaje en el atributo data los posibles valores son: subscription, beneficiary, spei_outgoing, spei_incoming, spid_outgoing </value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Número de  mensajes pendientes de enviar
        /// </summary>
        /// <value>Número de  mensajes pendientes de enviar</value>
        [DataMember(Name="pending_webhooks", EmitDefaultValue=false)]
        public int? PendingWebhooks { get; set; }

        /// <summary>
        /// Identificador del recurso relacionado
        /// </summary>
        /// <value>Identificador del recurso relacionado</value>
        [DataMember(Name="request", EmitDefaultValue=false)]
        public string Request { get; set; }

        /// <summary>
        /// El tipo evento que se esta enviando en la notifiación
        /// </summary>
        /// <value>El tipo evento que se esta enviando en la notifiación</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageWebHook {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  PendingWebhooks: ").Append(PendingWebhooks).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as MessageWebHook);
        }

        /// <summary>
        /// Returns true if MessageWebHook instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageWebHook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageWebHook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Livemode == input.Livemode ||
                    (this.Livemode != null &&
                    this.Livemode.Equals(input.Livemode))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.PendingWebhooks == input.PendingWebhooks ||
                    (this.PendingWebhooks != null &&
                    this.PendingWebhooks.Equals(input.PendingWebhooks))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Livemode != null)
                    hashCode = hashCode * 59 + this.Livemode.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.PendingWebhooks != null)
                    hashCode = hashCode * 59 + this.PendingWebhooks.GetHashCode();
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
