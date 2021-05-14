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
    /// Cada Item especifica el valor configurado para límite de monto permitido o número de operaciones permitidas. Debe especificar un item por cada configuración
    /// </summary>
    [DataContract]
        public partial class Item :  IEquatable<Item>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="key">Debe ser BY_AMOUNT para indicar la configuración por monto o BY_OPERATION para indicar la configuración por número de operaciones. Si se quiere configurar el horario de operaciones entonces se debe usar START_OPERATIONS_TIME para la hora de inicio de operaciones y END_OPERATIONS_TIME para la hora de fin de operaciones..</param>
        /// <param name="type">El tipo de dato del grupo de configuraciones. Puede ser: &lt;ul&gt;&lt;li&gt;DECIMAL&lt;/li&gt;&lt;li&gt;INT&lt;/li&gt;&lt;li&gt;BOOLEAN&lt;/li&gt;&lt;li&gt;TIME&lt;/li&gt;.</param>
        /// <param name="value">Valor configurado.</param>
        public Item(string key = default(string), string type = default(string), string value = default(string))
        {
            this.Key = key;
            this.Type = type;
            this.Value = value;
        }
        
        /// <summary>
        /// Debe ser BY_AMOUNT para indicar la configuración por monto o BY_OPERATION para indicar la configuración por número de operaciones. Si se quiere configurar el horario de operaciones entonces se debe usar START_OPERATIONS_TIME para la hora de inicio de operaciones y END_OPERATIONS_TIME para la hora de fin de operaciones.
        /// </summary>
        /// <value>Debe ser BY_AMOUNT para indicar la configuración por monto o BY_OPERATION para indicar la configuración por número de operaciones. Si se quiere configurar el horario de operaciones entonces se debe usar START_OPERATIONS_TIME para la hora de inicio de operaciones y END_OPERATIONS_TIME para la hora de fin de operaciones.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// El tipo de dato del grupo de configuraciones. Puede ser: &lt;ul&gt;&lt;li&gt;DECIMAL&lt;/li&gt;&lt;li&gt;INT&lt;/li&gt;&lt;li&gt;BOOLEAN&lt;/li&gt;&lt;li&gt;TIME&lt;/li&gt;
        /// </summary>
        /// <value>El tipo de dato del grupo de configuraciones. Puede ser: &lt;ul&gt;&lt;li&gt;DECIMAL&lt;/li&gt;&lt;li&gt;INT&lt;/li&gt;&lt;li&gt;BOOLEAN&lt;/li&gt;&lt;li&gt;TIME&lt;/li&gt;</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Valor configurado
        /// </summary>
        /// <value>Valor configurado</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
