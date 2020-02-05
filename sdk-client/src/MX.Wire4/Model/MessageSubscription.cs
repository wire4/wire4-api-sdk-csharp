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
    /// El mensaje que se envía mediante (webHook) con la información del la suscripción a esta a esta API
    /// </summary>
    [DataContract]
        public partial class MessageSubscription :  IEquatable<MessageSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSubscription" /> class.
        /// </summary>
        /// <param name="contract">Contrato Monex, con el cual se suscribió el cliente Monex en Wire4.</param>
        /// <param name="maskedContract">Contrato enmascarado de Monex, con el cual se suscribió el cliente Monex en Wire4.</param>
        /// <param name="subscription">Identificador de la suscripción, el cual se utiliza en las operaciones que solicitan una suscripción.</param>
        /// <param name="user">Usuario enmascardo, con el cual se suscribió el cliente Monex en Wire4.</param>
        /// <param name="userKey">Usuario proporcionado por Wire4, el cual se debe utilizar para autenticar a esta suscripción.</param>
        /// <param name="userSecret">Contraseña proporcionada por Wire4, la cual se debe utilizar para autenticar a esta suscripción.</param>
        public MessageSubscription(string contract = default(string), string maskedContract = default(string), string subscription = default(string), string user = default(string), string userKey = default(string), string userSecret = default(string))
        {
            this.Contract = contract;
            this.MaskedContract = maskedContract;
            this.Subscription = subscription;
            this.User = user;
            this.UserKey = userKey;
            this.UserSecret = userSecret;
        }
        
        /// <summary>
        /// Contrato Monex, con el cual se suscribió el cliente Monex en Wire4
        /// </summary>
        /// <value>Contrato Monex, con el cual se suscribió el cliente Monex en Wire4</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public string Contract { get; set; }

        /// <summary>
        /// Contrato enmascarado de Monex, con el cual se suscribió el cliente Monex en Wire4
        /// </summary>
        /// <value>Contrato enmascarado de Monex, con el cual se suscribió el cliente Monex en Wire4</value>
        [DataMember(Name="masked_contract", EmitDefaultValue=false)]
        public string MaskedContract { get; set; }

        /// <summary>
        /// Identificador de la suscripción, el cual se utiliza en las operaciones que solicitan una suscripción
        /// </summary>
        /// <value>Identificador de la suscripción, el cual se utiliza en las operaciones que solicitan una suscripción</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public string Subscription { get; set; }

        /// <summary>
        /// Usuario enmascardo, con el cual se suscribió el cliente Monex en Wire4
        /// </summary>
        /// <value>Usuario enmascardo, con el cual se suscribió el cliente Monex en Wire4</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// Usuario proporcionado por Wire4, el cual se debe utilizar para autenticar a esta suscripción
        /// </summary>
        /// <value>Usuario proporcionado por Wire4, el cual se debe utilizar para autenticar a esta suscripción</value>
        [DataMember(Name="user_key", EmitDefaultValue=false)]
        public string UserKey { get; set; }

        /// <summary>
        /// Contraseña proporcionada por Wire4, la cual se debe utilizar para autenticar a esta suscripción
        /// </summary>
        /// <value>Contraseña proporcionada por Wire4, la cual se debe utilizar para autenticar a esta suscripción</value>
        [DataMember(Name="user_secret", EmitDefaultValue=false)]
        public string UserSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageSubscription {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  MaskedContract: ").Append(MaskedContract).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserKey: ").Append(UserKey).Append("\n");
            sb.Append("  UserSecret: ").Append(UserSecret).Append("\n");
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
            return this.Equals(input as MessageSubscription);
        }

        /// <summary>
        /// Returns true if MessageSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageSubscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.MaskedContract == input.MaskedContract ||
                    (this.MaskedContract != null &&
                    this.MaskedContract.Equals(input.MaskedContract))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserKey == input.UserKey ||
                    (this.UserKey != null &&
                    this.UserKey.Equals(input.UserKey))
                ) && 
                (
                    this.UserSecret == input.UserSecret ||
                    (this.UserSecret != null &&
                    this.UserSecret.Equals(input.UserSecret))
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
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.MaskedContract != null)
                    hashCode = hashCode * 59 + this.MaskedContract.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserKey != null)
                    hashCode = hashCode * 59 + this.UserKey.GetHashCode();
                if (this.UserSecret != null)
                    hashCode = hashCode * 59 + this.UserSecret.GetHashCode();
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
