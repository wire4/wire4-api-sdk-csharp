/* 
 * Wire4RestAPI
 *
 *  # Referencia de API La API de Wire4 está organizada en torno a REST. Nuestra API tiene URLs predecibles orientadas a los recursos, acepta peticiones en formato JSON, y las respuestas devueltas son formato JSON y utiliza códigos de respuesta HTTP, autenticación y verbos estándares.  Puede usar la API de Wire4 en nuestro entorno de prueba, que no afecta sus productivos ni interactúa con la red bancaria. La URL de conexión que se usa para invocar los servicios determina si la solicitud es en modo en de prueba o en modo producción.    # Autenticación La API de Wire4 utiliza el protocolo OAuth 2.0 para autenticación y autorización.   Para comenzar, es necesario que registre una cuenta en nuestro ambiente de pruebas en [registro](https://app-sndbx.wire4.mx/#/register) y obtenga las credenciales de cliente OAuth 2.0 desde la [consola de administración](https://app-sndbx.wire4.mx/#/dashboard/api-keys).   Esta página ofrece una descripción general de los escenarios de autorización de OAuth 2.0 que admite Wire4.   Después de crear su aplicación con Wire4, asegúrese de tener a la mano su `client_id` y `client_secret`. El siguiente paso es descubrir qué flujo de OAuth2 es el adecuado para sus propósitos.   ## URLS La siguiente tabla muestra las urls de los recursos de autenticación para el ambiente de pruebas.  URL                  | Descripción - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- https://sandbox-api.wire4.mx/token   | Obtener token de autorización llaves de API (*client_id*, *client_secret*), datos de suscripción (*client_id*, *client_secret*, *user_key*, *user_secret*) o (*refresh_token*) https://sandbox-api.wire4.mx/revoke  | Revocación de token  **Nota:** De acuerdo con el RFC 6749, la URL del token sólo acepta el tipo de contenido x-www-form-urlencoded. El contenido JSON no está permitido y devolverá un error.  ## Scopes Los `scopes` limitan el acceso de una aplicación a los recursos de Wire4. Se ofrecen los siguientes scopes de acuerdo al producto:  Producto                             |Scope                      | Descripción - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- SPEI-SPID                            |general                              | Permite llamar a operaciones que no requieren a un cliente Monex suscrito en Wire4, los recursos que se pueden consumir con este scope son: consulta de Instituciones, CEP y generación de una presuscripción. SPEI-SPID                            |spei_admin                           | Permite llamar a operaciones que requieren de un cliente Monex suscrito en Wire4, ya que se proporciona información de saldos, administración de transacciones, cuentas de beneficiarios y cuentas de depositantes. SPEI-SPID                            |spid_admin                           | Permite llamar sólo a operaciones SPID, se requiere de un cliente Monex suscrito en Wire4. CODI                                 |codi_general                         | Permite llamar a operaciones de administración sobre el producto CoDi, como creación y listado de empresas  CODI                                 |codi_admin                           | Permite llamar sólo a operaciones CoDi dentro de un punto de venta, las operaciones incluyen creación, consulta, listado, etc de peticiones de pago CODI                                 |codi_report                          | Permite generar reportes de operaciones CoDi. TODOS                                |device_[dispositivo]                 | Se debe especificar cuándo se gestionan token's desde distintos dispositivos.  ## Tipos de autenticación   Wire4 cuenta con dos tipos de autenticación: Autenticación de Aplicación (OAuth 2.0  Client Credentials Grant)  y Autenticación de Usuario de Aplicación (OAuth 2.0 Password Grant).  ### Autenticación de Aplicación  Esta autenticación se obtiene proporcionando únicamente las llaves de API las cuáles se pueden consultar en [Llaves de API](https://app-sndbx.wire4.mx/#/dashboard/api-keys) de la consola de administración.  La autenticación de aplicación permite accesso a recursos generales y de administración que dependeran del scope.  Para este tipo de autenticación se sigue el flujo OAuth 2.0 Client Credentials Grant, que se describe más adelante en **Obtener el token de acceso de aplicación**, algunos de los recursos que requieren este tipo de autenticación son:   * [/subscriptions/pre-subscription](link) * [/institutions](link>) * [/ceps](<link>) * [/codi/compaies](<link>)  ### Autenticación de Usuario de Aplicación  Esta autenticación se obtiene proporcionando las llaves de API las cuáles se pueden consultar en [Llaves de API](https://app-sndbx.wire4.mx/#/dashboard/api-keys) más el ***user_key*** y ***user_secret*** que se proporcionan al momento de crear una suscripción o un punto de venta, para más información puedes consultar las guías [creación de suscripción](https://www.wire4.mx/#/guides/subscriptions), [creación de punto de venta](https://www.wire4.mx/#/guides/salespoint).  Con este tipo de autenticación se puede acceder a los recursos especificos que requieren configuraciones y acceso más puntual como información de una cuentas, saldos y administración de transacciones SPEID-SPID o CODI.    ## Obtener token de acceso Antes de que su aplicación pueda acceder a los datos mediante la API de Wire4, debe obtener un token de acceso ***(access_token)*** que le otorgue acceso a la API. En las siguientes secciones se muestra como obtener un token para cada una de las autenticaciones.     ### Obtener el token de acceso para autenticación de aplicación  El primer paso es crear la solicitud de token de acceso (*access_token*), con los parámetros que identifican su aplicación, el siguiente código muestra cómo obtener un `token`.  ``` curl -k -d \"grant_type= client_credentials&scope=general\"  -u \"<client id>:<client secret>\" https://sandbox-api.wire4.mx/token ``` **Ejemplo:**   ``` curl -k -d \"grant_type=client_credentials&scope=general\"  -u \"8e59YqaFW_Yo5dwWNxEY8Lid0u0a:AXahn79hfKWBXKzQfj011x8cvcQa\"  https://sandbox-api.wire4.mx /token ``` Obtendrá una respuesta como la que se muestra a continuación, donde se debe obtener el *access_token* para realizar llamadas posteriores a la API.   ``` {     \"access_token\":\"eyJ4NXQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJraWQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiJpc21hZWwuZXNjYW1pbGxhQHRjcGlwLnRlY2hAc2FuZGJveC5zcGVpb2suY29tIiwiYXVkIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsIm5iZiI6MTU3MTMyMDg3NywiYXpwIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsInNjb3BlIjoiYW1fYXBwbGljYXRpb25fc2NvcGUgZ2VuZXJhbCIsImlzcyI6ImFwaW0taWRwIiwiZXhwIjoxNTcxMzI0NDc3LCJpYXQiOjE1NzEzMjA4NzcsImp0aSI6ImJkMTdjMjcyLTg4MGQtNDk0ZS1iMTMwLTBiYTkwMjYyN2M4NCJ9.AjngGylkd_Chs5zlIjyLRPu9xPGyz4dfCd_aax2_ts653xrnNMoLpVHUDmaxIDFF2XyBJKH2IAbKxjo6VsFM07QkoPhlysO1PLoAF-Vkt4xYkh-f7nJRl0oOe2utDWFlUdgiAOmx5tPcStrdCEftgNNrjwJ50LXysFjXVshpoST-zIJPLgXknM3esGrkAsLcZRM7XUB187jxLHbtefVYPMvSO31T9pd5_Co9UXdeHpuA98sk_wZknASM1phxXQZAMLRLHz3LYvjCWCr_v80oVCM9SWTzf0vrMI6xphoIfirfWloADKPTTSUpIGBw9ePF_WbEPvbMm_BZaApJcEH2w\",    \"scope\":\"am_application_scope general\",    \"token_type\":\"Bearer\",    \"expires_in\":3600 }  ```  Es posible generar tokens con más de un scope, en caso que sea necesario utilizar dicho token para hacer más de una operación. Para generarlo basta con agregarlo a la petición separado por un espacio.     ``` curl -k -d \"grant_type=client_credentials&scope=codi_general codi_report\"  -u \"8e59YqaFW_Yo5dwWNxEY8Lid0u0a:AXahn79hfKWBXKzQfj011x8cvcQa\"  https://sandbox-api.wire4.mx /token ```  ### Obtener el token de acceso para autenticación usuario de aplicación   Antes de que su aplicación pueda acceder a los datos de una cuenta Monex mediante la API de Wire4, debe obtener un token de acceso  (*access_token*) que le otorgue acceso a la API y contar con el  *user_key* y *user_secret* que se proporcionan al momento de crear  una suscripción para más información puedes consultar [creación de suscripción](https://wire4.mx/#/guides/subscriptions) .   El primer paso es crear la solicitud de token de acceso con los parámetros que identifican su aplicación y la suscripción y con `scope` `spei_admin`  ```   curl -k -d \"grant_type=password&scope=spei_admin&username=<user_key>&password=<user_secret>\"  -u \"<client_id>:<client_secret>\" https://sandbox-api.wire4.mx/token ``` **Ejemplo**  ``` curl -k -d \"grant_type=password&scope=spei_admin&username=6 nbC5e99tTO@sandbox.wire4com&password= Nz7IqJGe9h\" -u \" zgMlQbqmOr:plkMJoPXCI\" https://sandbox-api.wire4.mx /token  ```  ``` {     \"access_token\":\"eyJ4NXQiOiJPR1EyTURFM00yTmpObVZoTnpFeE5EWXlObUV4TURKa01qUTJaVEU0TWpGaE1tVmlZakV5TkEiLCJraWQiOiJPR1EyTURFM00yTmpObVZoTnpFeE5EWXlObUV4TURKa01qUTJaVEU0TWpGaE1tVmlZakV5TkEiLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiIzMzE0ODRlZTdjZDRkYWU5MzRmMjY2Zjc5YmY1YWFAZGV2LWllc2NhbWlsbGEuc3BlaW9rLmNvbSIsImF1ZCI6IkJVR0xjNWw1bW5CZXlPeGxtamNUZ0JoS19WTWEiLCJuYmYiOjE1NzEzNDk4ODMsImF6cCI6IkJVR0xjNWw1bW5CZXlPeGxtamNUZ0JoS19WTWEiLCJzY29wZSI6InNwZWlfYWRtaW4iLCJpc3MiOiJhcGltLWlkcCIsImV4cCI6MTU3MTM1MzQ4MywiaWF0IjoxNTcxMzQ5ODgzLCJqdGkiOiJiOWQ1M2Q0MC0xN2MwLTQxOTItYjUwNy0wZWFhN2ZkNDA1MGYifQ.hLTk8AFoIce1GpLcgch-U5aLLgiiFTo49wfBErD8D6VF-H9sG13ZyfAx9T-vQkk2m1zPapYVQjwibz3GRAJMN0Vczs6flV1mUJwFDQbEE-AELPdRcaRFOMBCfF6H9TVLfhFsGb9U2pVR9TLJcKqR57DyO_dIcc9I6d0tIkxqn2VcqypLVi5YQf36WzBbPeG-iPHYpMA-bhr4rwfjKA-O6jm1NSSxNHF4sHS0YHDPoO_x6cCc677MQEe0_CozfnQhoEWNfG8tcWUqhPtmcfjqon1p7PdQoXxriq_R85d06pVO9Se7Q6ok0V8Qgz0MOJ6z3ku6mtZSuba7niMAOt2TyA\",    \"refresh_token\":\"f962d5c6-0d99-3809-8275-11c7aa0aa020\",    \"scope\":\"spei_admin\",    \"token_type\":\"Bearer\",    \"expires_in\":3600 } ```  **Suscripciones in activas**   En caso de intentar obtener el token de acceso para una suscriptión que no esta activa obtendra una respuesta de error con código 400 ``` curl -k -d \"grant_type=password&scope=spei_admin&username=6 nbC5e99tTO@sandbox.wire4com&password= Nz7IqJGe9h\" -u \" zgMlQbqmOr:plkMJoPXCI\" https://sandbox-api.wire4.mx /token  ``` ``` {     \"error_description\": \"Error while authenticating user from user store\",     \"error\": \"invalid_grant\" } ```    Una vez que la suscripción se reactive podrá generar el token de acceso de forma normal.    **Nota:** Los ejemplos anteriores se presentan considerando que se realiza una implementación desde cero,  esto se puede simplificar a sólo configurar sus llaves (*client_id*, *client_secret*),  datos de suscripción (*client_id*, *client_secret*, *user_key*, *user_secret*) si utiliza nuestros sdks.      **Consideraci&oacute;n:** Si la aplicaci&oacute;n en la que implementar&aacute; Wire4 estar&aacute; desplegada en más de una instancia o servidor en cada solicitud de token debe especificar un scope adicional. La forma de hacer esto es que, cuándo se solicita un token se debe especificar un scope adicional con el prefijo \"device_\" +  el dispositivo, por ejemplo:                                                                                                                                                                                                                     device_server1<br> device_server2  en consecuencia cada instancia debe operar con el token gestionado. ***Si se opera con el mismo token en instancias diferentes encontrará problemas de Credenciales Inv&aacute;lidas.***  **Ejemplo de solicitud de token para instancias diferentes:**  ``` curl -k -d \"grant_type=password&username=0883b97333046abb76367698b57d9e@sandbox.wire4.mx&password=9e0d81f95705079b9fe1e129315c25&scope=device_server1 codi_admin\" -H \"Authorization: Basic dmZSeURpTHdFbVZqd2VIclp0OWRMbXFmb3YwYTpJQJBuamBac3V6SllLWlJHUkJEYUZrN1BhRmNh\" https://sandbox-api.wire4.mx/token  curl -k -d \"grant_type=password&username=0883b97333046abb76367698b57d9e@sandbox.wire4.mx&password=9e0d81f95705079b9fe1e129315c25&scope=device_server2 codi_admin\" -H \"Authorization: Basic dmZSeURpTHdFbVZqd2VIclp0OWRMbXFmb3YwYTpJQJBuamBac3V6SllLWlJHUkJEYUZrN1BhRmNh\" https://sandbox-api.wire4.mx/token ```  ## Caducidad del token El token de acceso es válido durante 60 minutos (una hora), después de transcurrido este tiempo se debe solicitar un nuevo token,  cuando el token caduca se obtendrá un error ***401 Unauthorized*** con mensaje ***“Invalid Credentials”.***   El nuevo token se puede solicitar  utilizando el último token de actualización (***refresh_token***) que se devolvió en la solicitud del token,   esto sólo aplica para el token de tipo password (Autenticación de Usuario de Aplicación). El siguiente ejemplo muestra cómo obtener un toke con el token de actualización.  ``` curl -k -d \"grant_type=refresh_token&refresh_token=<refresh_token>\" -u \" Client_Id:Client_Secret\" -H \"Content-Type: application/x-www-form-urlencoded\" https://sandbox-api.wire4.mx/oauth2/token ```  **Ejemplo:**  ``` curl -k -d \"grant_type=refresh_token&refresh_token=f932d5c6-0d39-3809-8275-11c7ax0aa020\" -u \"zgMlQbqmOr:plkMJoPXCI\" -H \"Content-Type: application/x-www-form-urlencoded\" https://sandbox-api.wire4.mx/token ```  El token de actualización (***refresh_token***) tiene una duración de hasta 23 horas. Si en este periodo no se utiliza, se tienen que solicitar un nuevo token.  Un token de acceso podría dejar de funcionar por uno de estos motivos:  * El usuario ha revocado el acceso a su aplicación, si un usuario ha solicitado la baja de su aplicación de WIre4. * El token de acceso ha caducado: si el token de acceso ha pasado de una hora, recibirá un error ***401 Unauthorized*** mientras realiza una llamada a la API de Wire4. Cuando esto sucede, debe solicitar un nuevo token utilizando el token de actualización que recibió por última al solicitar un token, sólo aplica si el token en cuestión es de autenticación de usuario de aplicación, en caso contrario solicitar un nuevo token.   ## Revocar token Su aplicación puede revocar mediante programación el token de acceso, una vez revocado el token no podrá hacer uso de él para acceder a la API. El siguiente código muestra un ejemplo de cómo revocar el token:    ```  curl -X POST - -basic -u \"<client id>:<client secret>\" -H \"Content-Type: application/x-www-form-urlencoded;charset=UTF-8\" -k -d \"token=<token to revoke>&token_type_hint=access_token\" https://sandbox-api.wire4.mx/revoke ```      **Ejemplo:**  ```   curl -X POST - -basic -u \"8e59YqaFW_Yo5dwWNxEY8Lid0u0a:AXahn79hfKWBXKzQfj011x8cvcQa\" -H \"Content-Type: application/x-www-form-urlencoded;charset=UTF-8\" -k -d \"token=eyJ4NXQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJraWQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiJpc21hZWwuZXNjYW1pbGxhQHRjcGlwLnRlY2hAc2FuZGJveC5zcGVpb2suY29tIiwiYXVkIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsIm5iZiI6MTU3MTMyMDg3NywiYXpwIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsInNjb3BlIjoiYW1fYXBwbGljYXRpb25fc2NvcGUgZ2VuZXJhbCIsImlzcyI6ImFwaW0taWRwIiwiZXhwIjoxNTcxMzI0NDc3LCJpYXQiOjE1NzEzMjA4NzcsImp0aSI6ImJkMTdjMjcyLTg4MGQtNDk0ZS1iMTMwLTBiYTkwMjYyN2M4NCJ9.AjngGylkd_Chs5zlIjyLRPu9xPGyz4dfCd_aax2_ts653xrnNMoLpVHUDmaxIDFF2XyBJKH2IAbKxjo6VsFM07QkoPhlysO1PLoAF-Vkt4xYkh-f7nJRl0oOe2utDWFlUdgiAOmx5tPcStrdCEftgNNrjwJ50LXysFjXVshpoST-zIJPLgXknM3esGrkAsLcZRM7XUB187jxLHbtefVYPMvSO31T9pd5_Co9UXdeHpuA98sk_wZknASM1phxXQZAMLRLHz3LYvjCWCr_v80oVCM9SWTzf0vrMI6xphoIfirfWloADKPTTSUpIGBw9ePF_WbEPvbMm_BZaApJcEH2w&token_type_hint=access_token\"  https://sandbox-api.wire4.mx/revoke ```  # Ambientes  Wire4 cuentas con dos ambientes Pruebas (Sandbox) y Producción, son dos ambientes separados los cuáles se pueden utilizar simultáneamente. Los usuarios que han sido creados en cada uno de los ambientes no son intercambiables.   Las ligas de acceso a la `api` para cada uno de los ambientes son:  * Pruebas  https://sandbox-api.wire4.mx * Producción https://api.wire4.mx     # Eventos  Los eventos son nuestra forma de informarle cuando algo sucede en su cuenta. Cuando ocurre un evento se crea un objeto  [Evento](#tag/Webhook-Message). Por ejemplo, cuando se recibe un depósito, se crea un evento TRANSACTION.INCOMING.UPDATED.   Los eventos ocurren cuando cambia el estado de un recurso. El recurso se encuentra dentro del objeto [Evento](#tag/Webhook-Message) en el campo data.  Por ejemplo, un evento TRANSACTION.INCOMING.UPDATED contendrá un depósito y un evento ACCOUNT.CREATED contendrá una cuenta.   Wire4 puede agregar más campos en un futuro, o agregar nuevos valores a campos existentes, por lo que es recomendado que tu endpoint pueda manejar datos adicionales desconocidos. En esta [liga](#tag/Webhook-Message) se encuentra  la definición del objeto [Evento](#tag/Webhook-Message).  ## Tipos de Eventos  Wire4 cuenta con los siguientes tipos de eventos*   | Evento                               | Tipo                               | Objeto                                                  | | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | Suscripción                          | ENROLLMENT.CREATED                 | [suscription](#tag/subscription)                        | | Cuenta de beneficiario               | ACCOUNT.CREATED                    | [beneficiary](#tag/BeneficiaryAccount)                  | | Depósito recibido                    | TRANSACTION.INCOMING.UPDATED       | [spei_incoming](#tag/deposit)                           | | Solicitud de autorización de depósito| TRANSACTION.INCOMING.AUTHORIZATION | [spei_incoming_authorization](#tag/depositAuthorization)| | Transferencia realizada              | TRANSACTION.OUTGOING.RECEIVED      | [spei_outgoing](#tag/transfer)                          | | Transferencia SPID enviada           | TRANSACTION.OUTGOING.SPID.RECEIVED | [spid_outgoing](#tag/transfer)                          | | Transferencias Autorizadas           | REQUEST.OUTGOING.CHANGED           | [request_outgoing](#tag/requestOutMsg)                  | | Operación CoDi                       | CODI.ACTIONS                       | [codi_actions](#tag/codiActions)                        | | Punto de venta CoDi                  | SALE.POINT.CREATED                 | [codi_sales_point](#tag/codiSalesPoint)                 |   # Codigos de Error Al registrar transferencias tanto SPEI como SPID se aplican las validaciones de formato de datos a la petición descritas en la definición de cada recurso. Si la petición contiene errores, se genera una respuesta de error 409 que contiene el listado de las validaciones que no fueran exitosas.  Por cada error detectado se genera un elemento \"error\" que contiene el order_id de la transacción que genero el error, el código de error y un mensaje con más información sobre el mismo.  Si una misma transacción contiene varios errores, la respuesta  tendrá un elemento en la lista \"errors\" por cada validación que no fue exitosa.  Existen dos casos por los cuales alguno de los elementos en el listado de errores puede no contener order_id:  * Si alguna transacción no provee esta información  * En caso de transacciones SPEI, si el error está en las URLs ya que son datos relacionados a un lote de transacciones     **Ejemplo:**    ```   {      \"http_status\": 409,     \"message\": \"La divisa es incorrecta para esta transacción se espera: MXP, y se recibió: MXPD., El identificador 18e9c4a3-8c7a-42e8-99f4-ebi7r5r6y034 esta duplicado.\",     \"errors\": [         {             \"error\": \"La divisa es incorrecta para esta transacción se espera: MXP, y se recibió: MXPD.\",             \"code\": \"TR-1010\",             \"order_id\": \"18e9c4a3-8c7a-42e8-99f4-ebi7r5r6y034\"         },         {             \"error\": \"El identificador 18e9c4a3-8c7a-42e8-99f4-ebi7r5r6y034 esta duplicado.\",             \"code\": \"TR-1004\",             \"order_id\": \"18e9c4a3-8c7a-42e8-99f4-ebi7r5r6y034\"         }     ] }  ```      ## Códigos de error para generación de transferencias SPEI/SPID | Código                        | Descripción                                                                        | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| |A-1001     |La URL para éxito es requerida                                                                         | | A-1002  |La URL para retorno en caso de error es requerida                                                      | | TR-1001  |La petición debe incluir al menos una transacción                                                      | | TR-1002  |El identificador de la transacción es requerido                                                         | | TR-1003  |El identificador de la transacción no es valido                                                         | | TR-1004  |El identificador de la transacción esta duplicado                                                       | | TR-1005  |El monto de la transacción es requerido                                                                | | TR-1006  |El valor del monto no es valido                                                                        | | TR-1007  |La cuenta de beneficiario es requerida                                                                  | | TR-1008  |La cuenta de beneficiario no es valida                                                                  | | TR-1009  |El código de moneda es requerido                                                                       | | TR-1010  |El código de moneda no es valido                                                                       | | TR-1011  |El listado de email supera 10 elementos                                                                | | TR-1012  |La referencia es requerida                                                                             | | TR-1013  |La referencia no es valida                                                                             | | TR-1014  |El concepto es requerido                                                                               | | TR-1015  |El concepto no es valido                                                                               | | TR-1016  |El identificador de clasificación SPID es requerido                                                      |
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace MX.Wire4.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IPeticionesDePagoPorCoDiApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Consulta información de petición por orderId
        /// </summary>
        /// <remarks>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>PaymentRequestCodiResponseDTO</returns>
        PaymentRequestCodiResponseDTO ConsultCodiRequestByOrderId (string authorization, string orderId, string salesPointId);

        /// <summary>
        /// Consulta información de petición por orderId
        /// </summary>
        /// <remarks>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>ApiResponse of PaymentRequestCodiResponseDTO</returns>
        ApiResponse<PaymentRequestCodiResponseDTO> ConsultCodiRequestByOrderIdWithHttpInfo (string authorization, string orderId, string salesPointId);
        /// <summary>
        /// Genera código QR
        /// </summary>
        /// <remarks>
        /// Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>CodiCodeQrResponseDTO</returns>
        CodiCodeQrResponseDTO GenerateCodiCodeQR (CodiCodeRequestDTO body, string authorization, string salesPointId);

        /// <summary>
        /// Genera código QR
        /// </summary>
        /// <remarks>
        /// Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>ApiResponse of CodiCodeQrResponseDTO</returns>
        ApiResponse<CodiCodeQrResponseDTO> GenerateCodiCodeQRWithHttpInfo (CodiCodeRequestDTO body, string authorization, string salesPointId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Consulta información de petición por orderId
        /// </summary>
        /// <remarks>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of PaymentRequestCodiResponseDTO</returns>
        System.Threading.Tasks.Task<PaymentRequestCodiResponseDTO> ConsultCodiRequestByOrderIdAsync (string authorization, string orderId, string salesPointId);

        /// <summary>
        /// Consulta información de petición por orderId
        /// </summary>
        /// <remarks>
        /// Obtiene la información de una petición de pago CODI® por orderId para un punto de venta.
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of ApiResponse (PaymentRequestCodiResponseDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentRequestCodiResponseDTO>> ConsultCodiRequestByOrderIdAsyncWithHttpInfo (string authorization, string orderId, string salesPointId);
        /// <summary>
        /// Genera código QR
        /// </summary>
        /// <remarks>
        /// Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of CodiCodeQrResponseDTO</returns>
        System.Threading.Tasks.Task<CodiCodeQrResponseDTO> GenerateCodiCodeQRAsync (CodiCodeRequestDTO body, string authorization, string salesPointId);

        /// <summary>
        /// Genera código QR
        /// </summary>
        /// <remarks>
        /// Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </remarks>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of ApiResponse (CodiCodeQrResponseDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<CodiCodeQrResponseDTO>> GenerateCodiCodeQRAsyncWithHttpInfo (CodiCodeRequestDTO body, string authorization, string salesPointId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class PeticionesDePagoPorCoDiApi : IPeticionesDePagoPorCoDiApi
    {
        private MX.Wire4.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PeticionesDePagoPorCoDiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PeticionesDePagoPorCoDiApi(String basePath)
        {
            this.Configuration = new MX.Wire4.Client.Configuration { BasePath = basePath };

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeticionesDePagoPorCoDiApi"/> class
        /// </summary>
        /// <returns></returns>
        public PeticionesDePagoPorCoDiApi()
        {
            this.Configuration = MX.Wire4.Client.Configuration.Default;

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeticionesDePagoPorCoDiApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PeticionesDePagoPorCoDiApi(MX.Wire4.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = MX.Wire4.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = MX.Wire4.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public MX.Wire4.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public MX.Wire4.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Consulta información de petición por orderId Obtiene la información de una petición de pago CODI® por orderId para un punto de venta.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>PaymentRequestCodiResponseDTO</returns>
        public PaymentRequestCodiResponseDTO ConsultCodiRequestByOrderId (string authorization, string orderId, string salesPointId)
        {
             ApiResponse<PaymentRequestCodiResponseDTO> localVarResponse = ConsultCodiRequestByOrderIdWithHttpInfo(authorization, orderId, salesPointId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta información de petición por orderId Obtiene la información de una petición de pago CODI® por orderId para un punto de venta.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>ApiResponse of PaymentRequestCodiResponseDTO</returns>
        public ApiResponse< PaymentRequestCodiResponseDTO > ConsultCodiRequestByOrderIdWithHttpInfo (string authorization, string orderId, string salesPointId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");
            // verify the required parameter 'salesPointId' is set
            if (salesPointId == null)
                throw new ApiException(400, "Missing required parameter 'salesPointId' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");

            var localVarPath = "/codi/sales-point/charges";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (orderId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "orderId", orderId)); // query parameter
            if (salesPointId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "salesPointId", salesPointId)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ConsultCodiRequestByOrderId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentRequestCodiResponseDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PaymentRequestCodiResponseDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentRequestCodiResponseDTO)));
        }

        /// <summary>
        /// Consulta información de petición por orderId Obtiene la información de una petición de pago CODI® por orderId para un punto de venta.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of PaymentRequestCodiResponseDTO</returns>
        public async System.Threading.Tasks.Task<PaymentRequestCodiResponseDTO> ConsultCodiRequestByOrderIdAsync (string authorization, string orderId, string salesPointId)
        {
             ApiResponse<PaymentRequestCodiResponseDTO> localVarResponse = await ConsultCodiRequestByOrderIdAsyncWithHttpInfo(authorization, orderId, salesPointId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta información de petición por orderId Obtiene la información de una petición de pago CODI® por orderId para un punto de venta.
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Header para token</param>
        /// <param name="orderId">Identificador del pago CODI®</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of ApiResponse (PaymentRequestCodiResponseDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentRequestCodiResponseDTO>> ConsultCodiRequestByOrderIdAsyncWithHttpInfo (string authorization, string orderId, string salesPointId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");
            // verify the required parameter 'salesPointId' is set
            if (salesPointId == null)
                throw new ApiException(400, "Missing required parameter 'salesPointId' when calling PeticionesDePagoPorCoDiApi->ConsultCodiRequestByOrderId");

            var localVarPath = "/codi/sales-point/charges";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (orderId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "orderId", orderId)); // query parameter
            if (salesPointId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "salesPointId", salesPointId)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ConsultCodiRequestByOrderId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentRequestCodiResponseDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PaymentRequestCodiResponseDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentRequestCodiResponseDTO)));
        }

        /// <summary>
        /// Genera código QR Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>CodiCodeQrResponseDTO</returns>
        public CodiCodeQrResponseDTO GenerateCodiCodeQR (CodiCodeRequestDTO body, string authorization, string salesPointId)
        {
             ApiResponse<CodiCodeQrResponseDTO> localVarResponse = GenerateCodiCodeQRWithHttpInfo(body, authorization, salesPointId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Genera código QR Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>ApiResponse of CodiCodeQrResponseDTO</returns>
        public ApiResponse< CodiCodeQrResponseDTO > GenerateCodiCodeQRWithHttpInfo (CodiCodeRequestDTO body, string authorization, string salesPointId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");
            // verify the required parameter 'salesPointId' is set
            if (salesPointId == null)
                throw new ApiException(400, "Missing required parameter 'salesPointId' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");

            var localVarPath = "/codi/sales-point/charges";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (salesPointId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "salesPointId", salesPointId)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GenerateCodiCodeQR", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CodiCodeQrResponseDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CodiCodeQrResponseDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodiCodeQrResponseDTO)));
        }

        /// <summary>
        /// Genera código QR Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of CodiCodeQrResponseDTO</returns>
        public async System.Threading.Tasks.Task<CodiCodeQrResponseDTO> GenerateCodiCodeQRAsync (CodiCodeRequestDTO body, string authorization, string salesPointId)
        {
             ApiResponse<CodiCodeQrResponseDTO> localVarResponse = await GenerateCodiCodeQRAsyncWithHttpInfo(body, authorization, salesPointId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Genera código QR Genera un código QR solicitado por un punto de venta para un pago mediante CODI®
        /// </summary>
        /// <exception cref="MX.Wire4.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Información del pago CODI®</param>
        /// <param name="authorization">Header para token</param>
        /// <param name="salesPointId">Identificador del punto de venta</param>
        /// <returns>Task of ApiResponse (CodiCodeQrResponseDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CodiCodeQrResponseDTO>> GenerateCodiCodeQRAsyncWithHttpInfo (CodiCodeRequestDTO body, string authorization, string salesPointId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");
            // verify the required parameter 'salesPointId' is set
            if (salesPointId == null)
                throw new ApiException(400, "Missing required parameter 'salesPointId' when calling PeticionesDePagoPorCoDiApi->GenerateCodiCodeQR");

            var localVarPath = "/codi/sales-point/charges";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (salesPointId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "salesPointId", salesPointId)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GenerateCodiCodeQR", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CodiCodeQrResponseDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CodiCodeQrResponseDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CodiCodeQrResponseDTO)));
        }

    }
}
