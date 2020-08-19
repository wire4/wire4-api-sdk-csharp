/* 
 * Wire4RestAPI
 *
 *  # Referencia de API La API de Wire4 está organizada en torno a REST. Nuestra API tiene URLs predecibles orientadas a los recursos, acepta peticiones en formato JSON, y las respuestas devueltas son formato JSON y utiliza códigos de respuesta HTTP, autenticación y verbos estándares.  Puede usar la API de Wire4 en nuestro entorno de prueba, que no afecta sus productivos ni interactúa con la red bancaria. La URL de conexión que se usa para invocar los servicios determina si la solicitud es en modo en de prueba o en modo producción.    # Autenticación La API de Wire4 utiliza el protocolo OAuth 2.0 para autenticación y autorización.   Para comenzar, es necesario que registre una cuenta en nuestro ambiente de pruebas en [registro](https://app-sndbx.wire4.mx/#/register) y obtenga las credenciales de cliente OAuth 2.0 desde la [consola de administración](https://app-sndbx.wire4.mx/#/dashboard/api-keys).   Esta página ofrece una descripción general de los escenarios de autorización de OAuth 2.0 que admite Wire4.   Después de crear su aplicación con Wire4, asegúrese de tener a la mano su `client_id` y `client_secret`. El siguiente paso es descubrir qué flujo de OAuth2 es el adecuado para sus propósitos.   ## URLS La siguiente tabla muestra las urls de los recursos de autenticación para el ambiente de pruebas.  URL                  | Descripción - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- https://sandbox-api.wire4.mx/token   | Obtener token de autorización llaves de API (*client_id*, *client_secret*), datos de suscripción (*client_id*, *client_secret*, *user_key*, *user_secret*) o (*refresh_token*) https://sandbox-api.wire4.mx/revoke  | Revocación de token  **Nota:** De acuerdo con el RFC 6749, la URL del token sólo acepta el tipo de contenido x-www-form-urlencoded. El contenido JSON no está permitido y devolverá un error.  ## Scopes Los `scopes` limitan el acceso de una aplicación a los recursos de Wire4. Se ofrecen los siguientes scopes:   Scope                    | Descripción - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- general                              | Permite llamar a operaciones que no requieren a un cliente Monex suscrito en Wire4, los recursos que se pueden consumir con este scope son: consulta de Instituciones, CEP y generación de una presuscripción. spei_admin                           | Permite llamar a operaciones que requieren de un cliente Monex suscrito en Wire4, ya que se proporciona información de saldos, administración de transacciones, cuentas de beneficiarios y cuentas de depositantes. spid_admin                           | Permite llamar sólo a operaciones SPID, se requiere de un cliente Monex suscrito en Wire4. codi_admin                           | Permite llamar sólo a operaciones CoDi. codi_report                          | Permite generar reportes de operaciones CoDi.  ## Tipos de autenticación   Wire4 cuenta con dos tipos de autenticación: Autenticación de Aplicación (OAuth 2.0  Client Credentials Grant)  y Autenticación de Usuario de Aplicación (OAuth 2.0 Password Grant).  ### Autenticación de Aplicación  Esta autenticación se obtiene proporcionando únicamente las llaves de API las cuales se pueden consultar en [Llaves de API](https://app-sndbx.wire4.mx/#/dashboard/api-keys) de la consola de administración.  La autenticación de aplicación sólo permite acceso a los recursos que no requieren una suscripción activa de un cliente Monex en Wire4.  Para este tipo de autenticación se sigue el flujo OAuth 2.0 Client Credentials Grant, que se describe más adelante en **Obtener el token de acceso de aplicación**, con este token se tiene acceso a los siguientes recursos:   * [/subscriptions/pre-subscription](link) * [/institutions](link>) * [/ceps](<link>)   ### Autenticación de Usuario de Aplicación  Esta autenticación se obtiene proporcionando las llaves de API las cuales se pueden consultar en [Llaves de API](https://app-sndbx.wire4.mx/#/dashboard/api-keys) más el ***user_key*** y ***user_secret*** que se proporcionan al momento de crear una suscripción, para más información puedes consultar la guía [creación de suscripción](https://www.wire4.mx/#/guides/subscriptions).  Con este tipo de autenticación se puede acceder a los recursos que proporcionan información de una cuenta Monex como saldos y administración de transacciones, cuentas de beneficiarios y cuentas de depositantes.    ## Obtener token de acceso Antes de que su aplicación pueda acceder a los datos mediante la API de Wire4, debe obtener un token de acceso ***(access_token)*** que le otorgue acceso a la API. En las siguientes secciones se muestra como obtener un token para cada una de las autenticaciones.     ### Obtener el token de acceso para autenticación de aplicación  El primer paso es crear la solicitud de token de acceso (*access_token*), con los parámetros que identifican su aplicación, el siguiente código muestra cómo obtener un `token`.  ``` curl -k -d \"grant_type= client_credentials&scope=general\"  -u \"<client id>:<client secret>\" https://sandbox-api.wire4.mx/token ``` **Ejemplo:**   ``` curl -k -d \"grant_type=client_credentials&scope=general\"  -u \"8e59YqaFW_Yo5dwWNxEY8Lid0u0a:AXahn79hfKWBXKzQfj011x8cvcQa\"  https://sandbox-api.wire4.mx /token ``` Obtendrá una respuesta como la que se muestra  a continuación, donde se debe obtener el *access_token* para realizar llamadas posteriores a la API.   ``` {     \"access_token\":\"eyJ4NXQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJraWQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiJpc21hZWwuZXNjYW1pbGxhQHRjcGlwLnRlY2hAc2FuZGJveC5zcGVpb2suY29tIiwiYXVkIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsIm5iZiI6MTU3MTMyMDg3NywiYXpwIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsInNjb3BlIjoiYW1fYXBwbGljYXRpb25fc2NvcGUgZ2VuZXJhbCIsImlzcyI6ImFwaW0taWRwIiwiZXhwIjoxNTcxMzI0NDc3LCJpYXQiOjE1NzEzMjA4NzcsImp0aSI6ImJkMTdjMjcyLTg4MGQtNDk0ZS1iMTMwLTBiYTkwMjYyN2M4NCJ9.AjngGylkd_Chs5zlIjyLRPu9xPGyz4dfCd_aax2_ts653xrnNMoLpVHUDmaxIDFF2XyBJKH2IAbKxjo6VsFM07QkoPhlysO1PLoAF-Vkt4xYkh-f7nJRl0oOe2utDWFlUdgiAOmx5tPcStrdCEftgNNrjwJ50LXysFjXVshpoST-zIJPLgXknM3esGrkAsLcZRM7XUB187jxLHbtefVYPMvSO31T9pd5_Co9UXdeHpuA98sk_wZknASM1phxXQZAMLRLHz3LYvjCWCr_v80oVCM9SWTzf0vrMI6xphoIfirfWloADKPTTSUpIGBw9ePF_WbEPvbMm_BZaApJcEH2w\",    \"scope\":\"am_application_scope general\",    \"token_type\":\"Bearer\",    \"expires_in\":3600 }  ```  Es posible generar tokens con mas de un scope, en caso que sea necesario utilizar dicho token para hacer mas de una operación. Para generarlo basta con agregarlo a la petición separado por un espacio.     ``` curl -k -d \"grant_type=client_credentials&scope=codi_general codi_report\"  -u \"8e59YqaFW_Yo5dwWNxEY8Lid0u0a:AXahn79hfKWBXKzQfj011x8cvcQa\"  https://sandbox-api.wire4.mx /token ```  ### Obtener el token de acceso para autenticación usuario de aplicación   Antes de que su aplicación pueda acceder a los datos de una cuenta Monex mediante la API de Wire4, debe obtener un token de acceso  (*access_token*) que le otorgue acceso a la API y contar con el  *user_key* y *user_secret* que se proporcionan al momento de crear  una suscripción para más información puedes consultar [creación de suscripción](https://wire4.mx/#/guides/subscriptions) .   El primer paso es crear la solicitud de token de acceso con los parámetros que identifican su aplicación y la suscripción y con `scope` `spei_admin`  ```   curl -k -d \"grant_type=password&scope=spei_admin&username=<user_key>&password=<user_secret>\"  -u \"<client_id>:<client_secret>\" https://sandbox-api.wire4.mx/token ``` **Ejemplo**  ``` curl -k -d \"grant_type=password&scope=spei_admin&username=6 nbC5e99tTO@sandbox.wire4com&password= Nz7IqJGe9h\" -u \" zgMlQbqmOr:plkMJoPXCI\" https://sandbox-api.wire4.mx /token  ```  ``` {     \"access_token\":\"eyJ4NXQiOiJPR1EyTURFM00yTmpObVZoTnpFeE5EWXlObUV4TURKa01qUTJaVEU0TWpGaE1tVmlZakV5TkEiLCJraWQiOiJPR1EyTURFM00yTmpObVZoTnpFeE5EWXlObUV4TURKa01qUTJaVEU0TWpGaE1tVmlZakV5TkEiLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiIzMzE0ODRlZTdjZDRkYWU5MzRmMjY2Zjc5YmY1YWFAZGV2LWllc2NhbWlsbGEuc3BlaW9rLmNvbSIsImF1ZCI6IkJVR0xjNWw1bW5CZXlPeGxtamNUZ0JoS19WTWEiLCJuYmYiOjE1NzEzNDk4ODMsImF6cCI6IkJVR0xjNWw1bW5CZXlPeGxtamNUZ0JoS19WTWEiLCJzY29wZSI6InNwZWlfYWRtaW4iLCJpc3MiOiJhcGltLWlkcCIsImV4cCI6MTU3MTM1MzQ4MywiaWF0IjoxNTcxMzQ5ODgzLCJqdGkiOiJiOWQ1M2Q0MC0xN2MwLTQxOTItYjUwNy0wZWFhN2ZkNDA1MGYifQ.hLTk8AFoIce1GpLcgch-U5aLLgiiFTo49wfBErD8D6VF-H9sG13ZyfAx9T-vQkk2m1zPapYVQjwibz3GRAJMN0Vczs6flV1mUJwFDQbEE-AELPdRcaRFOMBCfF6H9TVLfhFsGb9U2pVR9TLJcKqR57DyO_dIcc9I6d0tIkxqn2VcqypLVi5YQf36WzBbPeG-iPHYpMA-bhr4rwfjKA-O6jm1NSSxNHF4sHS0YHDPoO_x6cCc677MQEe0_CozfnQhoEWNfG8tcWUqhPtmcfjqon1p7PdQoXxriq_R85d06pVO9Se7Q6ok0V8Qgz0MOJ6z3ku6mtZSuba7niMAOt2TyA\",    \"refresh_token\":\"f962d5c6-0d99-3809-8275-11c7aa0aa020\",    \"scope\":\"spei_admin\",    \"token_type\":\"Bearer\",    \"expires_in\":3600 } ```  **Nota:** Los ejemplos anteriores se presentan considerando que se realiza una implementación desde cero,  esto se puede simplificar a sólo configurar sus llaves (*client_id*, *client_secret*),  datos de suscripción (*client_id*, *client_secret*, *user_key*, *user_secret*) si utiliza nuestros sdks.      ## Caducidad del token El token de acceso es válido durante 60 minutos (una hora), después de transcurrido este tiempo se debe solicitar un nuevo token,  cuando el token caduca se obtendrá un error ***401 Unauthorized*** con mensaje ***“Invalid Credentials”.***   El nuevo token se puede solicitar  utilizando el último token de actualización (***refresh_token***) que se devolvió en la solicitud del token,   esto sólo aplica para el token de tipo password (Autenticación de Usuario de Aplicación). El siguiente ejemplo muestra cómo obtener un toke con el token de actualización.  ``` curl -k -d \"grant_type=refresh_token&refresh_token=<refresh_token>\" -u \" Client_Id:Client_Secret\" -H \"Content-Type: application/x-www-form-urlencoded\" https://sandbox-api.wire4.mx/oauth2/token ```  **Ejemplo:**  ``` curl -k -d \"grant_type=refresh_token&refresh_token=f932d5c6-0d39-3809-8275-11c7ax0aa020\" -u \"zgMlQbqmOr:plkMJoPXCI\" -H \"Content-Type: application/x-www-form-urlencoded\" https://sandbox-api.wire4.mx/token ```  El token de actualización (***refresh_token***) tiene una duración de hasta 23 horas. Si en este periodo no se utiliza, se tienen que solicitar un nuevo token.  Un token de acceso podría dejar de funcionar por uno de estos motivos:  * El usuario ha revocado el acceso a su aplicación, si un usuario ha solicitado la baja de su aplicación de WIre4. * El token de acceso ha caducado: si el token de acceso ha pasado de una hora, recibirá un error ***401 Unauthorized*** mientras realiza una llamada a la API de Wire4. Cuando esto sucede, debe solicitar un nuevo token utilizando el token de actualización que recibió por última al solicitar un token, sólo aplica si el token en cuestión es de autenticación de usuario de aplicación, en caso contrario solicitar un nuevo token.   ## Revocar token Su aplicación puede revocar mediante programación el token de acceso, una vez revocado el token no podrá hacer uso de él para acceder a la API. El siguiente código muestra un ejemplo de cómo revocar el token:    ```  curl -X POST - -basic -u \"<client id>:<client secret>\" -H \"Content-Type: application/x-www-form-urlencoded;charset=UTF-8\" -k -d \"token=<token to revoke>&token_type_hint=access_token\" https://sandbox-api.wire4.mx/revoke ```      **Ejemplo:**  ```   curl -X POST - -basic -u \"8e59YqaFW_Yo5dwWNxEY8Lid0u0a:AXahn79hfKWBXKzQfj011x8cvcQa\" -H \"Content-Type: application/x-www-form-urlencoded;charset=UTF-8\" -k -d \"token=eyJ4NXQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJraWQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiJpc21hZWwuZXNjYW1pbGxhQHRjcGlwLnRlY2hAc2FuZGJveC5zcGVpb2suY29tIiwiYXVkIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsIm5iZiI6MTU3MTMyMDg3NywiYXpwIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsInNjb3BlIjoiYW1fYXBwbGljYXRpb25fc2NvcGUgZ2VuZXJhbCIsImlzcyI6ImFwaW0taWRwIiwiZXhwIjoxNTcxMzI0NDc3LCJpYXQiOjE1NzEzMjA4NzcsImp0aSI6ImJkMTdjMjcyLTg4MGQtNDk0ZS1iMTMwLTBiYTkwMjYyN2M4NCJ9.AjngGylkd_Chs5zlIjyLRPu9xPGyz4dfCd_aax2_ts653xrnNMoLpVHUDmaxIDFF2XyBJKH2IAbKxjo6VsFM07QkoPhlysO1PLoAF-Vkt4xYkh-f7nJRl0oOe2utDWFlUdgiAOmx5tPcStrdCEftgNNrjwJ50LXysFjXVshpoST-zIJPLgXknM3esGrkAsLcZRM7XUB187jxLHbtefVYPMvSO31T9pd5_Co9UXdeHpuA98sk_wZknASM1phxXQZAMLRLHz3LYvjCWCr_v80oVCM9SWTzf0vrMI6xphoIfirfWloADKPTTSUpIGBw9ePF_WbEPvbMm_BZaApJcEH2w&token_type_hint=access_token\"  https://sandbox-api.wire4.mx/revoke ```  # Ambientes  Wire4 cuentas con dos ambientes Pruebas (Sandbox) y Producción, son dos ambientes separados los cuales se pueden utilizar simultáneamente. Los usuarios que han sido creados en cada uno de los ambientes no son intercambiables.   Las ligas de acceso a la `api` para cada uno de los ambientes son:  * Pruebas  https://sandbox-api.wire4.mx * Producción https://api.wire4.mx     # Eventos  Los eventos son nuestra forma de informarle cuando algo  sucede en su cuenta. Cuando ocurre un evento se crea un objeto  [Evento](#tag/Webhook-Message). Por ejemplo, cuando se recibe un depósito, se crea un evento TRANSACTION.INCOMING.UPDATED.   Los eventos ocurren cuando cambia el estado de un recurso. El recurso se encuentra dentro del objeto [Evento](#tag/Webhook-Message) en el campo data.  Por ejemplo, un evento TRANSACTION.INCOMING.UPDATED contendrá un depósito y un evento ACCOUNT.CREATED contendrá una cuenta.   Wire4 puede agregar más campos en un futuro, o agregar nuevos valores a campos existentes, por lo que es recomendado que tu endpoint pueda manejar datos adicionales desconocidos. En esta [liga](#tag/Webhook-Message) se encuentra  la definición del objeto [Evento](#tag/Webhook-Message).  ## Tipos de Eventos  Wire4 cuenta con los siguientes tipos de eventos*   | Evento                     | Tipo                               | Objeto                                        | | - -- -- -- -- -- -- -- -- -- -- -- -- - |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | Suscripción                | ENROLLMENT.CREATED                 | [suscription](#tag/subscription)              | | Cuenta de beneficiario     | ACCOUNT.CREATED                    | [beneficiary](#tag/BeneficiaryAccount)        | | Depósito recibido          | TRANSACTION.INCOMING.UPDATED       | [spei_incoming](#tag/deposit)                 | | Transferencia realizada    | TRANSACTION.OUTGOING.RECEIVED      | [spei_outgoing](#tag/transfer)                | | Transferencia SPID enviada | TRANSACTION.OUTGOING.SPID.RECEIVED | [spid_outgoing](#tag/transfer)                | | Transferencias Autorizadas | REQUEST.OUTGOING.CHANGED           | [request_outgoing](#tag/requestOutMsg)        | | Punto de venta CoDi        | SALE.POINT.CREATED                 |
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
    /// Payment
    /// </summary>
    [DataContract]
        public partial class Payment :  IEquatable<Payment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        /// <param name="account">Cuenta emisora.</param>
        /// <param name="amount">Monto de la transferencia.</param>
        /// <param name="beneficiaryAccount">Cuenta del beneficiario.</param>
        /// <param name="beneficiaryBank">beneficiaryBank.</param>
        /// <param name="beneficiaryName">Nombre del Beneficiario.</param>
        /// <param name="cep">cep.</param>
        /// <param name="claveRastreo">Clave de rastreo de la transferencia.</param>
        /// <param name="concept">Concepto de pago.</param>
        /// <param name="confirmDate">Fecha de aplicación de la transferencia.</param>
        /// <param name="currencyCode">Código de moneda de la transferencia.</param>
        /// <param name="detentionMessage">Mensaje proporcionado por Monex para la transferencia.</param>
        /// <param name="errorMessage">Mensaje de error, en caso de algún error se informará aquí.</param>
        /// <param name="monexDescription">Descripción.</param>
        /// <param name="orderId">Identificador asignado por la aplciación a la transferencia.</param>
        /// <param name="paymentOrderId">Identificador de la orden de pago en Monex.</param>
        /// <param name="pendingReason">Razón de porque esta pendiente aun cuando se autorizó la transferencia.</param>
        /// <param name="reference">Referencia numérica.</param>
        /// <param name="statusCode">Estado de la transferencia de la transferencia, los posibles valores son: PENDING, COMPLETED, FAILED, CANCELLED.</param>
        /// <param name="transactionId">Identificador de la transferencia asignado por Monex.</param>
        public Payment(string account = default(string), decimal? amount = default(decimal?), string beneficiaryAccount = default(string), Institution beneficiaryBank = default(Institution), string beneficiaryName = default(string), MessageCEP cep = default(MessageCEP), string claveRastreo = default(string), string concept = default(string), DateTime? confirmDate = default(DateTime?), string currencyCode = default(string), string detentionMessage = default(string), string errorMessage = default(string), string monexDescription = default(string), string orderId = default(string), int? paymentOrderId = default(int?), string pendingReason = default(string), int? reference = default(int?), string statusCode = default(string), int? transactionId = default(int?))
        {
            this.Account = account;
            this.Amount = amount;
            this.BeneficiaryAccount = beneficiaryAccount;
            this.BeneficiaryBank = beneficiaryBank;
            this.BeneficiaryName = beneficiaryName;
            this.Cep = cep;
            this.ClaveRastreo = claveRastreo;
            this.Concept = concept;
            this.ConfirmDate = confirmDate;
            this.CurrencyCode = currencyCode;
            this.DetentionMessage = detentionMessage;
            this.ErrorMessage = errorMessage;
            this.MonexDescription = monexDescription;
            this.OrderId = orderId;
            this.PaymentOrderId = paymentOrderId;
            this.PendingReason = pendingReason;
            this.Reference = reference;
            this.StatusCode = statusCode;
            this.TransactionId = transactionId;
        }
        
        /// <summary>
        /// Cuenta emisora
        /// </summary>
        /// <value>Cuenta emisora</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// Monto de la transferencia
        /// </summary>
        /// <value>Monto de la transferencia</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Cuenta del beneficiario
        /// </summary>
        /// <value>Cuenta del beneficiario</value>
        [DataMember(Name="beneficiary_account", EmitDefaultValue=false)]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// Gets or Sets BeneficiaryBank
        /// </summary>
        [DataMember(Name="beneficiary_bank", EmitDefaultValue=false)]
        public Institution BeneficiaryBank { get; set; }

        /// <summary>
        /// Nombre del Beneficiario
        /// </summary>
        /// <value>Nombre del Beneficiario</value>
        [DataMember(Name="beneficiary_name", EmitDefaultValue=false)]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// Gets or Sets Cep
        /// </summary>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public MessageCEP Cep { get; set; }

        /// <summary>
        /// Clave de rastreo de la transferencia
        /// </summary>
        /// <value>Clave de rastreo de la transferencia</value>
        [DataMember(Name="clave_rastreo", EmitDefaultValue=false)]
        public string ClaveRastreo { get; set; }

        /// <summary>
        /// Concepto de pago
        /// </summary>
        /// <value>Concepto de pago</value>
        [DataMember(Name="concept", EmitDefaultValue=false)]
        public string Concept { get; set; }

        /// <summary>
        /// Fecha de aplicación de la transferencia
        /// </summary>
        /// <value>Fecha de aplicación de la transferencia</value>
        [DataMember(Name="confirm_date", EmitDefaultValue=false)]
        public DateTime? ConfirmDate { get; set; }

        /// <summary>
        /// Código de moneda de la transferencia
        /// </summary>
        /// <value>Código de moneda de la transferencia</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Mensaje proporcionado por Monex para la transferencia
        /// </summary>
        /// <value>Mensaje proporcionado por Monex para la transferencia</value>
        [DataMember(Name="detention_message", EmitDefaultValue=false)]
        public string DetentionMessage { get; set; }

        /// <summary>
        /// Mensaje de error, en caso de algún error se informará aquí
        /// </summary>
        /// <value>Mensaje de error, en caso de algún error se informará aquí</value>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Descripción
        /// </summary>
        /// <value>Descripción</value>
        [DataMember(Name="monex_description", EmitDefaultValue=false)]
        public string MonexDescription { get; set; }

        /// <summary>
        /// Identificador asignado por la aplciación a la transferencia
        /// </summary>
        /// <value>Identificador asignado por la aplciación a la transferencia</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Identificador de la orden de pago en Monex
        /// </summary>
        /// <value>Identificador de la orden de pago en Monex</value>
        [DataMember(Name="payment_order_id", EmitDefaultValue=false)]
        public int? PaymentOrderId { get; set; }

        /// <summary>
        /// Razón de porque esta pendiente aun cuando se autorizó la transferencia
        /// </summary>
        /// <value>Razón de porque esta pendiente aun cuando se autorizó la transferencia</value>
        [DataMember(Name="pending_reason", EmitDefaultValue=false)]
        public string PendingReason { get; set; }

        /// <summary>
        /// Referencia numérica
        /// </summary>
        /// <value>Referencia numérica</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public int? Reference { get; set; }

        /// <summary>
        /// Estado de la transferencia de la transferencia, los posibles valores son: PENDING, COMPLETED, FAILED, CANCELLED
        /// </summary>
        /// <value>Estado de la transferencia de la transferencia, los posibles valores son: PENDING, COMPLETED, FAILED, CANCELLED</value>
        [DataMember(Name="status_code", EmitDefaultValue=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Identificador de la transferencia asignado por Monex
        /// </summary>
        /// <value>Identificador de la transferencia asignado por Monex</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BeneficiaryAccount: ").Append(BeneficiaryAccount).Append("\n");
            sb.Append("  BeneficiaryBank: ").Append(BeneficiaryBank).Append("\n");
            sb.Append("  BeneficiaryName: ").Append(BeneficiaryName).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  ClaveRastreo: ").Append(ClaveRastreo).Append("\n");
            sb.Append("  Concept: ").Append(Concept).Append("\n");
            sb.Append("  ConfirmDate: ").Append(ConfirmDate).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DetentionMessage: ").Append(DetentionMessage).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  MonexDescription: ").Append(MonexDescription).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PaymentOrderId: ").Append(PaymentOrderId).Append("\n");
            sb.Append("  PendingReason: ").Append(PendingReason).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BeneficiaryAccount == input.BeneficiaryAccount ||
                    (this.BeneficiaryAccount != null &&
                    this.BeneficiaryAccount.Equals(input.BeneficiaryAccount))
                ) && 
                (
                    this.BeneficiaryBank == input.BeneficiaryBank ||
                    (this.BeneficiaryBank != null &&
                    this.BeneficiaryBank.Equals(input.BeneficiaryBank))
                ) && 
                (
                    this.BeneficiaryName == input.BeneficiaryName ||
                    (this.BeneficiaryName != null &&
                    this.BeneficiaryName.Equals(input.BeneficiaryName))
                ) && 
                (
                    this.Cep == input.Cep ||
                    (this.Cep != null &&
                    this.Cep.Equals(input.Cep))
                ) && 
                (
                    this.ClaveRastreo == input.ClaveRastreo ||
                    (this.ClaveRastreo != null &&
                    this.ClaveRastreo.Equals(input.ClaveRastreo))
                ) && 
                (
                    this.Concept == input.Concept ||
                    (this.Concept != null &&
                    this.Concept.Equals(input.Concept))
                ) && 
                (
                    this.ConfirmDate == input.ConfirmDate ||
                    (this.ConfirmDate != null &&
                    this.ConfirmDate.Equals(input.ConfirmDate))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.DetentionMessage == input.DetentionMessage ||
                    (this.DetentionMessage != null &&
                    this.DetentionMessage.Equals(input.DetentionMessage))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.MonexDescription == input.MonexDescription ||
                    (this.MonexDescription != null &&
                    this.MonexDescription.Equals(input.MonexDescription))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PaymentOrderId == input.PaymentOrderId ||
                    (this.PaymentOrderId != null &&
                    this.PaymentOrderId.Equals(input.PaymentOrderId))
                ) && 
                (
                    this.PendingReason == input.PendingReason ||
                    (this.PendingReason != null &&
                    this.PendingReason.Equals(input.PendingReason))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BeneficiaryAccount != null)
                    hashCode = hashCode * 59 + this.BeneficiaryAccount.GetHashCode();
                if (this.BeneficiaryBank != null)
                    hashCode = hashCode * 59 + this.BeneficiaryBank.GetHashCode();
                if (this.BeneficiaryName != null)
                    hashCode = hashCode * 59 + this.BeneficiaryName.GetHashCode();
                if (this.Cep != null)
                    hashCode = hashCode * 59 + this.Cep.GetHashCode();
                if (this.ClaveRastreo != null)
                    hashCode = hashCode * 59 + this.ClaveRastreo.GetHashCode();
                if (this.Concept != null)
                    hashCode = hashCode * 59 + this.Concept.GetHashCode();
                if (this.ConfirmDate != null)
                    hashCode = hashCode * 59 + this.ConfirmDate.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.DetentionMessage != null)
                    hashCode = hashCode * 59 + this.DetentionMessage.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.MonexDescription != null)
                    hashCode = hashCode * 59 + this.MonexDescription.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PaymentOrderId != null)
                    hashCode = hashCode * 59 + this.PaymentOrderId.GetHashCode();
                if (this.PendingReason != null)
                    hashCode = hashCode * 59 + this.PendingReason.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
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
