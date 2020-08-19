# MX.Wire4 - the C# library for the Wire4RestAPI

 # Referencia de API La API de Wire4 está organizada en torno a REST. Nuestra API tiene URLs predecibles orientadas a los recursos, acepta peticiones en formato JSON, y las respuestas devueltas son formato JSON y utiliza códigos de respuesta HTTP, autenticación y verbos estándares.  Puede usar la API de Wire4 en nuestro entorno de prueba, que no afecta sus productivos ni interactúa con la red bancaria. La URL de conexión que se usa para invocar los servicios determina si la solicitud es en modo en de prueba o en modo producción.    # Autenticación La API de Wire4 utiliza el protocolo OAuth 2.0 para autenticación y autorización.   Para comenzar, es necesario que registre una cuenta en nuestro ambiente de pruebas en [registro](https://app-sndbx.wire4.mx/#/register) y obtenga las credenciales de cliente OAuth 2.0 desde la [consola de administración](https://app-sndbx.wire4.mx/#/dashboard/api-keys).   Esta página ofrece una descripción general de los escenarios de autorización de OAuth 2.0 que admite Wire4.   Después de crear su aplicación con Wire4, asegúrese de tener a la mano su `client_id` y `client_secret`. El siguiente paso es descubrir qué flujo de OAuth2 es el adecuado para sus propósitos.   ## URLS La siguiente tabla muestra las urls de los recursos de autenticación para el ambiente de pruebas.  URL                  | Descripción - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- https://sandbox-api.wire4.mx/token   | Obtener token de autorización llaves de API (*client_id*, *client_secret*), datos de suscripción (*client_id*, *client_secret*, *user_key*, *user_secret*) o (*refresh_token*) https://sandbox-api.wire4.mx/revoke  | Revocación de token  **Nota:** De acuerdo con el RFC 6749, la URL del token sólo acepta el tipo de contenido x-www-form-urlencoded. El contenido JSON no está permitido y devolverá un error.  ## Scopes Los `scopes` limitan el acceso de una aplicación a los recursos de Wire4. Se ofrecen los siguientes scopes:   Scope                    | Descripción - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- general                              | Permite llamar a operaciones que no requieren a un cliente Monex suscrito en Wire4, los recursos que se pueden consumir con este scope son: consulta de Instituciones, CEP y generación de una presuscripción. spei_admin                           | Permite llamar a operaciones que requieren de un cliente Monex suscrito en Wire4, ya que se proporciona información de saldos, administración de transacciones, cuentas de beneficiarios y cuentas de depositantes. spid_admin                           | Permite llamar sólo a operaciones SPID, se requiere de un cliente Monex suscrito en Wire4. codi_admin                           | Permite llamar sólo a operaciones CoDi. codi_report                          | Permite generar reportes de operaciones CoDi.  ## Tipos de autenticación   Wire4 cuenta con dos tipos de autenticación: Autenticación de Aplicación (OAuth 2.0  Client Credentials Grant)  y Autenticación de Usuario de Aplicación (OAuth 2.0 Password Grant).  ### Autenticación de Aplicación  Esta autenticación se obtiene proporcionando únicamente las llaves de API las cuales se pueden consultar en [Llaves de API](https://app-sndbx.wire4.mx/#/dashboard/api-keys) de la consola de administración.  La autenticación de aplicación sólo permite acceso a los recursos que no requieren una suscripción activa de un cliente Monex en Wire4.  Para este tipo de autenticación se sigue el flujo OAuth 2.0 Client Credentials Grant, que se describe más adelante en **Obtener el token de acceso de aplicación**, con este token se tiene acceso a los siguientes recursos:   * [/subscriptions/pre-subscription](link) * [/institutions](link>) * [/ceps](<link>)   ### Autenticación de Usuario de Aplicación  Esta autenticación se obtiene proporcionando las llaves de API las cuales se pueden consultar en [Llaves de API](https://app-sndbx.wire4.mx/#/dashboard/api-keys) más el ***user_key*** y ***user_secret*** que se proporcionan al momento de crear una suscripción, para más información puedes consultar la guía [creación de suscripción](https://www.wire4.mx/#/guides/subscriptions).  Con este tipo de autenticación se puede acceder a los recursos que proporcionan información de una cuenta Monex como saldos y administración de transacciones, cuentas de beneficiarios y cuentas de depositantes.    ## Obtener token de acceso Antes de que su aplicación pueda acceder a los datos mediante la API de Wire4, debe obtener un token de acceso ***(access_token)*** que le otorgue acceso a la API. En las siguientes secciones se muestra como obtener un token para cada una de las autenticaciones.     ### Obtener el token de acceso para autenticación de aplicación  El primer paso es crear la solicitud de token de acceso (*access_token*), con los parámetros que identifican su aplicación, el siguiente código muestra cómo obtener un `token`.  ``` curl -k -d \"grant_type= client_credentials&scope=general\"  -u \"<client id>:<client secret>\" https://sandbox-api.wire4.mx/token ``` **Ejemplo:**   ``` curl -k -d \"grant_type=client_credentials&scope=general\"  -u \"8e59YqaFW_Yo5dwWNxEY8Lid0u0a:AXahn79hfKWBXKzQfj011x8cvcQa\"  https://sandbox-api.wire4.mx /token ``` Obtendrá una respuesta como la que se muestra  a continuación, donde se debe obtener el *access_token* para realizar llamadas posteriores a la API.   ``` {     \"access_token\":\"eyJ4NXQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJraWQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiJpc21hZWwuZXNjYW1pbGxhQHRjcGlwLnRlY2hAc2FuZGJveC5zcGVpb2suY29tIiwiYXVkIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsIm5iZiI6MTU3MTMyMDg3NywiYXpwIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsInNjb3BlIjoiYW1fYXBwbGljYXRpb25fc2NvcGUgZ2VuZXJhbCIsImlzcyI6ImFwaW0taWRwIiwiZXhwIjoxNTcxMzI0NDc3LCJpYXQiOjE1NzEzMjA4NzcsImp0aSI6ImJkMTdjMjcyLTg4MGQtNDk0ZS1iMTMwLTBiYTkwMjYyN2M4NCJ9.AjngGylkd_Chs5zlIjyLRPu9xPGyz4dfCd_aax2_ts653xrnNMoLpVHUDmaxIDFF2XyBJKH2IAbKxjo6VsFM07QkoPhlysO1PLoAF-Vkt4xYkh-f7nJRl0oOe2utDWFlUdgiAOmx5tPcStrdCEftgNNrjwJ50LXysFjXVshpoST-zIJPLgXknM3esGrkAsLcZRM7XUB187jxLHbtefVYPMvSO31T9pd5_Co9UXdeHpuA98sk_wZknASM1phxXQZAMLRLHz3LYvjCWCr_v80oVCM9SWTzf0vrMI6xphoIfirfWloADKPTTSUpIGBw9ePF_WbEPvbMm_BZaApJcEH2w\",    \"scope\":\"am_application_scope general\",    \"token_type\":\"Bearer\",    \"expires_in\":3600 }  ```  Es posible generar tokens con mas de un scope, en caso que sea necesario utilizar dicho token para hacer mas de una operación. Para generarlo basta con agregarlo a la petición separado por un espacio.     ``` curl -k -d \"grant_type=client_credentials&scope=codi_general codi_report\"  -u \"8e59YqaFW_Yo5dwWNxEY8Lid0u0a:AXahn79hfKWBXKzQfj011x8cvcQa\"  https://sandbox-api.wire4.mx /token ```  ### Obtener el token de acceso para autenticación usuario de aplicación   Antes de que su aplicación pueda acceder a los datos de una cuenta Monex mediante la API de Wire4, debe obtener un token de acceso  (*access_token*) que le otorgue acceso a la API y contar con el  *user_key* y *user_secret* que se proporcionan al momento de crear  una suscripción para más información puedes consultar [creación de suscripción](https://wire4.mx/#/guides/subscriptions) .   El primer paso es crear la solicitud de token de acceso con los parámetros que identifican su aplicación y la suscripción y con `scope` `spei_admin`  ```   curl -k -d \"grant_type=password&scope=spei_admin&username=<user_key>&password=<user_secret>\"  -u \"<client_id>:<client_secret>\" https://sandbox-api.wire4.mx/token ``` **Ejemplo**  ``` curl -k -d \"grant_type=password&scope=spei_admin&username=6 nbC5e99tTO@sandbox.wire4com&password= Nz7IqJGe9h\" -u \" zgMlQbqmOr:plkMJoPXCI\" https://sandbox-api.wire4.mx /token  ```  ``` {     \"access_token\":\"eyJ4NXQiOiJPR1EyTURFM00yTmpObVZoTnpFeE5EWXlObUV4TURKa01qUTJaVEU0TWpGaE1tVmlZakV5TkEiLCJraWQiOiJPR1EyTURFM00yTmpObVZoTnpFeE5EWXlObUV4TURKa01qUTJaVEU0TWpGaE1tVmlZakV5TkEiLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiIzMzE0ODRlZTdjZDRkYWU5MzRmMjY2Zjc5YmY1YWFAZGV2LWllc2NhbWlsbGEuc3BlaW9rLmNvbSIsImF1ZCI6IkJVR0xjNWw1bW5CZXlPeGxtamNUZ0JoS19WTWEiLCJuYmYiOjE1NzEzNDk4ODMsImF6cCI6IkJVR0xjNWw1bW5CZXlPeGxtamNUZ0JoS19WTWEiLCJzY29wZSI6InNwZWlfYWRtaW4iLCJpc3MiOiJhcGltLWlkcCIsImV4cCI6MTU3MTM1MzQ4MywiaWF0IjoxNTcxMzQ5ODgzLCJqdGkiOiJiOWQ1M2Q0MC0xN2MwLTQxOTItYjUwNy0wZWFhN2ZkNDA1MGYifQ.hLTk8AFoIce1GpLcgch-U5aLLgiiFTo49wfBErD8D6VF-H9sG13ZyfAx9T-vQkk2m1zPapYVQjwibz3GRAJMN0Vczs6flV1mUJwFDQbEE-AELPdRcaRFOMBCfF6H9TVLfhFsGb9U2pVR9TLJcKqR57DyO_dIcc9I6d0tIkxqn2VcqypLVi5YQf36WzBbPeG-iPHYpMA-bhr4rwfjKA-O6jm1NSSxNHF4sHS0YHDPoO_x6cCc677MQEe0_CozfnQhoEWNfG8tcWUqhPtmcfjqon1p7PdQoXxriq_R85d06pVO9Se7Q6ok0V8Qgz0MOJ6z3ku6mtZSuba7niMAOt2TyA\",    \"refresh_token\":\"f962d5c6-0d99-3809-8275-11c7aa0aa020\",    \"scope\":\"spei_admin\",    \"token_type\":\"Bearer\",    \"expires_in\":3600 } ```  **Nota:** Los ejemplos anteriores se presentan considerando que se realiza una implementación desde cero,  esto se puede simplificar a sólo configurar sus llaves (*client_id*, *client_secret*),  datos de suscripción (*client_id*, *client_secret*, *user_key*, *user_secret*) si utiliza nuestros sdks.      ## Caducidad del token El token de acceso es válido durante 60 minutos (una hora), después de transcurrido este tiempo se debe solicitar un nuevo token,  cuando el token caduca se obtendrá un error ***401 Unauthorized*** con mensaje ***“Invalid Credentials”.***   El nuevo token se puede solicitar  utilizando el último token de actualización (***refresh_token***) que se devolvió en la solicitud del token,   esto sólo aplica para el token de tipo password (Autenticación de Usuario de Aplicación). El siguiente ejemplo muestra cómo obtener un toke con el token de actualización.  ``` curl -k -d \"grant_type=refresh_token&refresh_token=<refresh_token>\" -u \" Client_Id:Client_Secret\" -H \"Content-Type: application/x-www-form-urlencoded\" https://sandbox-api.wire4.mx/oauth2/token ```  **Ejemplo:**  ``` curl -k -d \"grant_type=refresh_token&refresh_token=f932d5c6-0d39-3809-8275-11c7ax0aa020\" -u \"zgMlQbqmOr:plkMJoPXCI\" -H \"Content-Type: application/x-www-form-urlencoded\" https://sandbox-api.wire4.mx/token ```  El token de actualización (***refresh_token***) tiene una duración de hasta 23 horas. Si en este periodo no se utiliza, se tienen que solicitar un nuevo token.  Un token de acceso podría dejar de funcionar por uno de estos motivos:  * El usuario ha revocado el acceso a su aplicación, si un usuario ha solicitado la baja de su aplicación de WIre4. * El token de acceso ha caducado: si el token de acceso ha pasado de una hora, recibirá un error ***401 Unauthorized*** mientras realiza una llamada a la API de Wire4. Cuando esto sucede, debe solicitar un nuevo token utilizando el token de actualización que recibió por última al solicitar un token, sólo aplica si el token en cuestión es de autenticación de usuario de aplicación, en caso contrario solicitar un nuevo token.   ## Revocar token Su aplicación puede revocar mediante programación el token de acceso, una vez revocado el token no podrá hacer uso de él para acceder a la API. El siguiente código muestra un ejemplo de cómo revocar el token:    ```  curl -X POST - -basic -u \"<client id>:<client secret>\" -H \"Content-Type: application/x-www-form-urlencoded;charset=UTF-8\" -k -d \"token=<token to revoke>&token_type_hint=access_token\" https://sandbox-api.wire4.mx/revoke ```      **Ejemplo:**  ```   curl -X POST - -basic -u \"8e59YqaFW_Yo5dwWNxEY8Lid0u0a:AXahn79hfKWBXKzQfj011x8cvcQa\" -H \"Content-Type: application/x-www-form-urlencoded;charset=UTF-8\" -k -d \"token=eyJ4NXQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJraWQiOiJZak5sWVdWa05tWmlNR1ZoTldSaU1EUXpaREJpWlRJNU1qYzFZV1ZoWWpneU5UYzJPV05sWVEiLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiJpc21hZWwuZXNjYW1pbGxhQHRjcGlwLnRlY2hAc2FuZGJveC5zcGVpb2suY29tIiwiYXVkIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsIm5iZiI6MTU3MTMyMDg3NywiYXpwIjoiOGU1OVlxYUZXX1lvNWR3V054RVk4TGlkMHUwYSIsInNjb3BlIjoiYW1fYXBwbGljYXRpb25fc2NvcGUgZ2VuZXJhbCIsImlzcyI6ImFwaW0taWRwIiwiZXhwIjoxNTcxMzI0NDc3LCJpYXQiOjE1NzEzMjA4NzcsImp0aSI6ImJkMTdjMjcyLTg4MGQtNDk0ZS1iMTMwLTBiYTkwMjYyN2M4NCJ9.AjngGylkd_Chs5zlIjyLRPu9xPGyz4dfCd_aax2_ts653xrnNMoLpVHUDmaxIDFF2XyBJKH2IAbKxjo6VsFM07QkoPhlysO1PLoAF-Vkt4xYkh-f7nJRl0oOe2utDWFlUdgiAOmx5tPcStrdCEftgNNrjwJ50LXysFjXVshpoST-zIJPLgXknM3esGrkAsLcZRM7XUB187jxLHbtefVYPMvSO31T9pd5_Co9UXdeHpuA98sk_wZknASM1phxXQZAMLRLHz3LYvjCWCr_v80oVCM9SWTzf0vrMI6xphoIfirfWloADKPTTSUpIGBw9ePF_WbEPvbMm_BZaApJcEH2w&token_type_hint=access_token\"  https://sandbox-api.wire4.mx/revoke ```  # Ambientes  Wire4 cuentas con dos ambientes Pruebas (Sandbox) y Producción, son dos ambientes separados los cuales se pueden utilizar simultáneamente. Los usuarios que han sido creados en cada uno de los ambientes no son intercambiables.   Las ligas de acceso a la `api` para cada uno de los ambientes son:  * Pruebas  https://sandbox-api.wire4.mx * Producción https://api.wire4.mx     # Eventos  Los eventos son nuestra forma de informarle cuando algo  sucede en su cuenta. Cuando ocurre un evento se crea un objeto  [Evento](#tag/Webhook-Message). Por ejemplo, cuando se recibe un depósito, se crea un evento TRANSACTION.INCOMING.UPDATED.   Los eventos ocurren cuando cambia el estado de un recurso. El recurso se encuentra dentro del objeto [Evento](#tag/Webhook-Message) en el campo data.  Por ejemplo, un evento TRANSACTION.INCOMING.UPDATED contendrá un depósito y un evento ACCOUNT.CREATED contendrá una cuenta.   Wire4 puede agregar más campos en un futuro, o agregar nuevos valores a campos existentes, por lo que es recomendado que tu endpoint pueda manejar datos adicionales desconocidos. En esta [liga](#tag/Webhook-Message) se encuentra  la definición del objeto [Evento](#tag/Webhook-Message).  ## Tipos de Eventos  Wire4 cuenta con los siguientes tipos de eventos*   | Evento                     | Tipo                               | Objeto                                        | | - -- -- -- -- -- -- -- -- -- -- -- -- - |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | Suscripción                | ENROLLMENT.CREATED                 | [suscription](#tag/subscription)              | | Cuenta de beneficiario     | ACCOUNT.CREATED                    | [beneficiary](#tag/BeneficiaryAccount)        | | Depósito recibido          | TRANSACTION.INCOMING.UPDATED       | [spei_incoming](#tag/deposit)                 | | Transferencia realizada    | TRANSACTION.OUTGOING.RECEIVED      | [spei_outgoing](#tag/transfer)                | | Transferencia SPID enviada | TRANSACTION.OUTGOING.SPID.RECEIVED | [spid_outgoing](#tag/transfer)                | | Transferencias Autorizadas | REQUEST.OUTGOING.CHANGED           | [request_outgoing](#tag/requestOutMsg)        | | Punto de venta CoDi        | SALE.POINT.CREATED                 |

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 0.0.5
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out MX.Wire4.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            var apiInstance = new ComprobanteElectrnicoDePagoCEPApi();
            var body = new CepSearchBanxico(); // CepSearchBanxico | Información para buscar un CEP
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Consulta de CEP
                CepResponse result = apiInstance.ObtainTransactionCepUsingPOST(body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComprobanteElectrnicoDePagoCEPApi.ObtainTransactionCepUsingPOST: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ComprobanteElectrnicoDePagoCEPApi* | [**ObtainTransactionCepUsingPOST**](docs/ComprobanteElectrnicoDePagoCEPApi.md#obtaintransactioncepusingpost) | **POST** /ceps | Consulta de CEP
*ContactoApi* | [**SendContactUsingPOST**](docs/ContactoApi.md#sendcontactusingpost) | **POST** /contact | Solicitud de contacto
*ContractsDetailsApi* | [**CreateAuthorization**](docs/ContractsDetailsApi.md#createauthorization) | **POST** /onboarding/accounts/authorize | Devuelve la URL para autorización del usuario Monex
*ContractsDetailsApi* | [**ObtainAuthorizedUsers**](docs/ContractsDetailsApi.md#obtainauthorizedusers) | **GET** /onboarding/accounts/{requestId}/authorized-users | Obtiene los usuarios autorizados
*ContractsDetailsApi* | [**ObtainContractDetails**](docs/ContractsDetailsApi.md#obtaincontractdetails) | **POST** /onboarding/accounts/details | Obtiene los detalles de la empresa del contrato
*CuentasDeBeneficiariosSPEIApi* | [**AuthorizeAccountsPendingPUT**](docs/CuentasDeBeneficiariosSPEIApi.md#authorizeaccountspendingput) | **PUT** /subscriptions/{subscription}/beneficiaries/pending | Recibe la solicitud para agrupar las cuentas SPEI/SPID de beneficiarios en estado pendiente que deben ser autorizadas
*CuentasDeBeneficiariosSPEIApi* | [**DeleteAccountUsingDELETE**](docs/CuentasDeBeneficiariosSPEIApi.md#deleteaccountusingdelete) | **DELETE** /subscriptions/{subscription}/beneficiaries/spei/{account} | Elimina la cuenta del beneficiario
*CuentasDeBeneficiariosSPEIApi* | [**GetAvailableRelationshipsMonexUsingGET**](docs/CuentasDeBeneficiariosSPEIApi.md#getavailablerelationshipsmonexusingget) | **GET** /subscriptions/{subscription}/beneficiaries/relationships | Consulta de relaciones
*CuentasDeBeneficiariosSPEIApi* | [**GetBeneficiariesByRequestId**](docs/CuentasDeBeneficiariosSPEIApi.md#getbeneficiariesbyrequestid) | **GET** /subscriptions/{subscription}/beneficiaries/spei/{requestId} | Consulta los beneficiarios por el identificador de la petición de registro
*CuentasDeBeneficiariosSPEIApi* | [**GetBeneficiariesForAccountUsingGET**](docs/CuentasDeBeneficiariosSPEIApi.md#getbeneficiariesforaccountusingget) | **GET** /subscriptions/{subscription}/beneficiaries/spei | Consulta los beneficiarios registrados
*CuentasDeBeneficiariosSPEIApi* | [**PreRegisterAccountsUsingPOST**](docs/CuentasDeBeneficiariosSPEIApi.md#preregisteraccountsusingpost) | **POST** /subscriptions/{subscription}/beneficiaries/spei | Pre-registro de cuentas de beneficiarios.
*CuentasDeBeneficiariosSPEIApi* | [**RemoveBeneficiariesPendingUsingDELETE**](docs/CuentasDeBeneficiariosSPEIApi.md#removebeneficiariespendingusingdelete) | **DELETE** /subscriptions/{subscription}/beneficiaries/spei/request/{requestId} | Eliminación de beneficiarios SPEI® sin confirmar
*CuentasDeBeneficiariosSPEIApi* | [**UpdateAmountLimitAccountUsingPUT**](docs/CuentasDeBeneficiariosSPEIApi.md#updateamountlimitaccountusingput) | **PUT** /subscriptions/{subscription}/beneficiaries/spei/{account} | Actualiza el monto límite
*CuentasDeBeneficiariosSPIDApi* | [**GetSpidBeneficiariesForAccount**](docs/CuentasDeBeneficiariosSPIDApi.md#getspidbeneficiariesforaccount) | **GET** /subscriptions/{subscription}/beneficiaries/spid | Consulta los beneficiarios SPID registrados
*CuentasDeBeneficiariosSPIDApi* | [**PreRegisterAccountsUsingPOST1**](docs/CuentasDeBeneficiariosSPIDApi.md#preregisteraccountsusingpost1) | **POST** /subscriptions/{subscription}/beneficiaries/spid | Pre-registro de cuentas de beneficiarios SPID
*DepositantesApi* | [**GetDepositantsUsingGET**](docs/DepositantesApi.md#getdepositantsusingget) | **GET** /subscriptions/{subscription}/depositants | Consulta de cuentas de depositantes
*DepositantesApi* | [**RegisterDepositantsUsingPOST**](docs/DepositantesApi.md#registerdepositantsusingpost) | **POST** /subscriptions/{subscription}/depositants | Registra un nuevo depositante
*EmpresasCoDiApi* | [**ObtainCompanies**](docs/EmpresasCoDiApi.md#obtaincompanies) | **GET** /codi/companies | Consulta de empresas CODI
*EmpresasCoDiApi* | [**RegisterCompanyUsingPOST**](docs/EmpresasCoDiApi.md#registercompanyusingpost) | **POST** /codi/companies | Registro de empresas CODI
*FacturasApi* | [**BillingsReportByIdUsingGET**](docs/FacturasApi.md#billingsreportbyidusingget) | **GET** /billings/{id} | Consulta de facturas por identificador
*FacturasApi* | [**BillingsReportUsingGET**](docs/FacturasApi.md#billingsreportusingget) | **GET** /billings | Consulta de facturas
*InstitucionesApi* | [**GetAllInstitutionsUsingGET**](docs/InstitucionesApi.md#getallinstitutionsusingget) | **GET** /institutions | Información de instituciones bancarias.
*OperacionesCoDiApi* | [**ConsultCodiOperations**](docs/OperacionesCoDiApi.md#consultcodioperations) | **POST** /codi/charges | Obtiene las operaciones generadas a partir de peticiones de pago CoDi® de forma paginada, pudiendo aplicar filtros
*PeticionesDePagoPorCoDiApi* | [**ConsultCodiRequestByOrderId**](docs/PeticionesDePagoPorCoDiApi.md#consultcodirequestbyorderid) | **GET** /codi/sales-point/{sales_point_id}/charges/{order_id} | Obtiene la información de una petición de pago CODI® por orderId para un punto de venta
*PeticionesDePagoPorCoDiApi* | [**GenerateCodiCodeQR**](docs/PeticionesDePagoPorCoDiApi.md#generatecodicodeqr) | **POST** /codi/sales-point/{salesPointId}/charges | Genera un código QR para un pago mediante CODI®
*PuntosDeVentaCoDiApi* | [**CreateSalesPoint**](docs/PuntosDeVentaCoDiApi.md#createsalespoint) | **POST** /codi/companies/{company_id}/salespoint | Registra un punto de venta asociado a una empresa
*PuntosDeVentaCoDiApi* | [**ObtainSalePoints**](docs/PuntosDeVentaCoDiApi.md#obtainsalepoints) | **GET** /codi/companies/{company_id}/salespoint | Obtiene los puntos de venta asociados a una empresa
*SaldoApi* | [**GetBalanceUsingGET**](docs/SaldoApi.md#getbalanceusingget) | **GET** /subscriptions/{subscription}/balance | Consulta los saldo de una cuenta
*SuscripcionesApi* | [**PreEnrollmentMonexUserUsingPOST**](docs/SuscripcionesApi.md#preenrollmentmonexuserusingpost) | **POST** /subscriptions/pre-subscription | Registra una pre-suscripción
*SuscripcionesApi* | [**RemoveEnrollmentUserUsingDELETE**](docs/SuscripcionesApi.md#removeenrollmentuserusingdelete) | **DELETE** /subscriptions/{subscription} | Elimina una suscripción por el identificador de la suscripción
*SuscripcionesApi* | [**RemoveSubscriptionPendingStatusUsingDELETE**](docs/SuscripcionesApi.md#removesubscriptionpendingstatususingdelete) | **DELETE** /subscriptions/pre-subscription/{subscription} | Elimina una pre-suscripción
*TransferenciasSPEIApi* | [**CreateAuthorizationTransactionsGroup**](docs/TransferenciasSPEIApi.md#createauthorizationtransactionsgroup) | **POST** /subscriptions/{subscription}/transactions/group | Agrupa un conjunto de transacciones bajo un mismo request_id para autorizar
*TransferenciasSPEIApi* | [**DropTransactionsPendingUsingDELETE**](docs/TransferenciasSPEIApi.md#droptransactionspendingusingdelete) | **DELETE** /subscriptions/{subscription}/transactions/outcoming/spei/request/{requestId} | Eliminación de transferencias SPEI® pendientes
*TransferenciasSPEIApi* | [**IncomingSpeiTransactionsReportUsingGET**](docs/TransferenciasSPEIApi.md#incomingspeitransactionsreportusingget) | **GET** /subscriptions/{subscription}/transactions/incoming/spei | Consulta de transferencias recibidas
*TransferenciasSPEIApi* | [**OutCommingSpeiRequestIdTransactionsReportUsingGET**](docs/TransferenciasSPEIApi.md#outcommingspeirequestidtransactionsreportusingget) | **GET** /subscriptions/{subscription}/transactions/outcoming/spei/{requestId} | Consulta de transferencias de salida por identificador de petición
*TransferenciasSPEIApi* | [**OutgoingSpeiTransactionsReportUsingGET**](docs/TransferenciasSPEIApi.md#outgoingspeitransactionsreportusingget) | **GET** /subscriptions/{subscription}/transactions/outcoming/spei | Consulta de transferencias realizadas
*TransferenciasSPEIApi* | [**RegisterOutgoingSpeiTransactionUsingPOST**](docs/TransferenciasSPEIApi.md#registeroutgoingspeitransactionusingpost) | **POST** /subscriptions/{subscription}/transactions/outcoming/spei | Registro de transferencias
*TransferenciasSPIDApi* | [**GetSpidClassificationsUsingGET**](docs/TransferenciasSPIDApi.md#getspidclassificationsusingget) | **GET** /subscriptions/{subscription}/beneficiaries/spid/classifications | Consulta las clasificaciones para operaciones con SPID
*TransferenciasSPIDApi* | [**RegisterOutgoingSpidTransactionUsingPOST**](docs/TransferenciasSPIDApi.md#registeroutgoingspidtransactionusingpost) | **POST** /subscriptions/{subscription}/transactions/outcoming/spid | Registro de transferencias SPID
*WebhooksApi* | [**GetWebhook**](docs/WebhooksApi.md#getwebhook) | **GET** /webhooks/{id} | Consulta de Webhook
*WebhooksApi* | [**GetWebhooks**](docs/WebhooksApi.md#getwebhooks) | **GET** /webhooks | Consulta de Webhooks
*WebhooksApi* | [**RegisterWebhook**](docs/WebhooksApi.md#registerwebhook) | **POST** /webhooks | Alta de Webhook

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Account](docs/Account.md)
 - [Model.AccountDetail](docs/AccountDetail.md)
 - [Model.AccountReassigned](docs/AccountReassigned.md)
 - [Model.AccountRequest](docs/AccountRequest.md)
 - [Model.AccountResponse](docs/AccountResponse.md)
 - [Model.AccountSpid](docs/AccountSpid.md)
 - [Model.AddressCompany](docs/AddressCompany.md)
 - [Model.AmountRequest](docs/AmountRequest.md)
 - [Model.AuthorizationTransactionGroup](docs/AuthorizationTransactionGroup.md)
 - [Model.AuthorizedBeneficiariesResponse](docs/AuthorizedBeneficiariesResponse.md)
 - [Model.AuthorizedUsers](docs/AuthorizedUsers.md)
 - [Model.Balance](docs/Balance.md)
 - [Model.BalanceListResponse](docs/BalanceListResponse.md)
 - [Model.BeneficiariesQueryRegisterStatus](docs/BeneficiariesQueryRegisterStatus.md)
 - [Model.BeneficiariesResponse](docs/BeneficiariesResponse.md)
 - [Model.BeneficiaryInstitution](docs/BeneficiaryInstitution.md)
 - [Model.Billing](docs/Billing.md)
 - [Model.BillingTransaction](docs/BillingTransaction.md)
 - [Model.CepResponse](docs/CepResponse.md)
 - [Model.CepSearchBanxico](docs/CepSearchBanxico.md)
 - [Model.CertificateRequest](docs/CertificateRequest.md)
 - [Model.CodiCodeQrResponseDTO](docs/CodiCodeQrResponseDTO.md)
 - [Model.CodiCodeRequestDTO](docs/CodiCodeRequestDTO.md)
 - [Model.CodiOperationsFiltersRequestDTO](docs/CodiOperationsFiltersRequestDTO.md)
 - [Model.CompanyRegistered](docs/CompanyRegistered.md)
 - [Model.CompanyRequested](docs/CompanyRequested.md)
 - [Model.Compay](docs/Compay.md)
 - [Model.ContactRequest](docs/ContactRequest.md)
 - [Model.ContractDetailRequest](docs/ContractDetailRequest.md)
 - [Model.ContractDetailResponse](docs/ContractDetailResponse.md)
 - [Model.Deposit](docs/Deposit.md)
 - [Model.Depositant](docs/Depositant.md)
 - [Model.DepositantsRegister](docs/DepositantsRegister.md)
 - [Model.DepositantsResponse](docs/DepositantsResponse.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.GetDepositants](docs/GetDepositants.md)
 - [Model.Institution](docs/Institution.md)
 - [Model.InstitutionsList](docs/InstitutionsList.md)
 - [Model.MessageAccountBeneficiary](docs/MessageAccountBeneficiary.md)
 - [Model.MessageCEP](docs/MessageCEP.md)
 - [Model.MessageDepositReceived](docs/MessageDepositReceived.md)
 - [Model.MessageInstitution](docs/MessageInstitution.md)
 - [Model.MessagePayment](docs/MessagePayment.md)
 - [Model.MessagePaymentStatePending](docs/MessagePaymentStatePending.md)
 - [Model.MessageRequestChanged](docs/MessageRequestChanged.md)
 - [Model.MessageSubscription](docs/MessageSubscription.md)
 - [Model.MessageWebHook](docs/MessageWebHook.md)
 - [Model.Operations](docs/Operations.md)
 - [Model.PagerResponseDto](docs/PagerResponseDto.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.PaymentRequestCodiResponseDTO](docs/PaymentRequestCodiResponseDTO.md)
 - [Model.PaymentsRequestId](docs/PaymentsRequestId.md)
 - [Model.Person](docs/Person.md)
 - [Model.PreEnrollmentData](docs/PreEnrollmentData.md)
 - [Model.PreEnrollmentResponse](docs/PreEnrollmentResponse.md)
 - [Model.PreMonexAuthorization](docs/PreMonexAuthorization.md)
 - [Model.Relationship](docs/Relationship.md)
 - [Model.RelationshipsResponse](docs/RelationshipsResponse.md)
 - [Model.SalesPoint](docs/SalesPoint.md)
 - [Model.SalesPointFound](docs/SalesPointFound.md)
 - [Model.SalesPointRequest](docs/SalesPointRequest.md)
 - [Model.SalesPointRespose](docs/SalesPointRespose.md)
 - [Model.SpidBeneficiariesResponse](docs/SpidBeneficiariesResponse.md)
 - [Model.SpidBeneficiaryResponse](docs/SpidBeneficiaryResponse.md)
 - [Model.SpidClassificationDTO](docs/SpidClassificationDTO.md)
 - [Model.SpidClassificationsResponseDTO](docs/SpidClassificationsResponseDTO.md)
 - [Model.Timestamp](docs/Timestamp.md)
 - [Model.TokenRequiredResponse](docs/TokenRequiredResponse.md)
 - [Model.TransactionOutgoing](docs/TransactionOutgoing.md)
 - [Model.TransactionOutgoingSpid](docs/TransactionOutgoingSpid.md)
 - [Model.TransactionsOutgoingRegister](docs/TransactionsOutgoingRegister.md)
 - [Model.UrlsRedirect](docs/UrlsRedirect.md)
 - [Model.UserCompany](docs/UserCompany.md)
 - [Model.Webhook](docs/Webhook.md)
 - [Model.WebhookRequest](docs/WebhookRequest.md)
 - [Model.WebhookResponse](docs/WebhookResponse.md)
 - [Model.WebhooksList](docs/WebhooksList.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
