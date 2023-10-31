# MX.Wire4.Api.CuentasDeBeneficiariosSPEIApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthorizeAccountsPendingPUT**](CuentasDeBeneficiariosSPEIApi.md#authorizeaccountspendingput) | **PUT** /subscriptions/{subscription}/beneficiaries/pending | Solicitud para agrupar cuentas de beneficiarios SPEI/SPID en estado pendiente.
[**DeleteAccountUsingDELETE**](CuentasDeBeneficiariosSPEIApi.md#deleteaccountusingdelete) | **DELETE** /subscriptions/{subscription}/beneficiaries/spei/{account} | Elimina la cuenta del beneficiario
[**GetAvailableRelationshipsMonexUsingGET**](CuentasDeBeneficiariosSPEIApi.md#getavailablerelationshipsmonexusingget) | **GET** /subscriptions/{subscription}/beneficiaries/relationships | Consulta de relaciones
[**GetBeneficiariesByRequestId**](CuentasDeBeneficiariosSPEIApi.md#getbeneficiariesbyrequestid) | **GET** /subscriptions/{subscription}/beneficiaries/spei/{requestId} | Consulta los beneficiarios por el identificador de la petición de registro
[**GetBeneficiariesForAccountUsingGET**](CuentasDeBeneficiariosSPEIApi.md#getbeneficiariesforaccountusingget) | **GET** /subscriptions/{subscription}/beneficiaries/spei | Consulta los beneficiarios registrados
[**PreRegisterAccountsUsingPOST**](CuentasDeBeneficiariosSPEIApi.md#preregisteraccountsusingpost) | **POST** /subscriptions/{subscription}/beneficiaries/spei | Pre-registro de cuentas de beneficiarios SPEI®.
[**RemoveBeneficiariesPendingUsingDELETE**](CuentasDeBeneficiariosSPEIApi.md#removebeneficiariespendingusingdelete) | **DELETE** /subscriptions/{subscription}/beneficiaries/spei/request/{requestId} | Eliminación de beneficiarios SPEI® sin confirmar
[**UpdateAmountLimitAccountUsingPUT**](CuentasDeBeneficiariosSPEIApi.md#updateamountlimitaccountusingput) | **PUT** /subscriptions/{subscription}/beneficiaries/spei/{account} | Solicitud para actualizar el monto límite de una cuenta

<a name="authorizeaccountspendingput"></a>
# **AuthorizeAccountsPendingPUT**
> AuthorizedBeneficiariesResponse AuthorizeAccountsPendingPUT (UrlsRedirect body, string authorization, string subscription)

Solicitud para agrupar cuentas de beneficiarios SPEI/SPID en estado pendiente.

Solicta la agrupación de las cuentas de beneficiarios en estado pendiente para que sean autorizadas,  para ello se crea un conjunto de éstas que puede incluir tanto de SPEI como de SPID. Además se debe indicar las urls de redirección en caso de error y éxito

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class AuthorizeAccountsPendingPUTExample
    {
        public void main()
        {
            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var body = new UrlsRedirect(); // UrlsRedirect | Información de la cuenta del beneficiario
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Solicitud para agrupar cuentas de beneficiarios SPEI/SPID en estado pendiente.
                AuthorizedBeneficiariesResponse result = apiInstance.AuthorizeAccountsPendingPUT(body, authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CuentasDeBeneficiariosSPEIApi.AuthorizeAccountsPendingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UrlsRedirect**](UrlsRedirect.md)| Información de la cuenta del beneficiario | 
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**AuthorizedBeneficiariesResponse**](AuthorizedBeneficiariesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteaccountusingdelete"></a>
# **DeleteAccountUsingDELETE**
> void DeleteAccountUsingDELETE (string authorization, string account, string subscription)

Elimina la cuenta del beneficiario

Elimina la cuenta de beneficiario proporcionada relacionada al contrato perteneciente a la suscripción. La cuenta a borrar debe ser una que opere con SPEI.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class DeleteAccountUsingDELETEExample
    {
        public void main()
        {
            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var account = account_example;  // string | Es la cuenta del beneficiario que será eliminada.
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Elimina la cuenta del beneficiario
                apiInstance.DeleteAccountUsingDELETE(authorization, account, subscription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CuentasDeBeneficiariosSPEIApi.DeleteAccountUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **account** | **string**| Es la cuenta del beneficiario que será eliminada. | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getavailablerelationshipsmonexusingget"></a>
# **GetAvailableRelationshipsMonexUsingGET**
> RelationshipsResponse GetAvailableRelationshipsMonexUsingGET (string authorization, string subscription)

Consulta de relaciones

Obtiene las posibles relaciones existentes para registrar beneficiarios en Monex. Se debe invocar este recurso antes de pre-registrar una cuenta de beneficiario.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetAvailableRelationshipsMonexUsingGETExample
    {
        public void main()
        {
            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Consulta de relaciones
                RelationshipsResponse result = apiInstance.GetAvailableRelationshipsMonexUsingGET(authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CuentasDeBeneficiariosSPEIApi.GetAvailableRelationshipsMonexUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**RelationshipsResponse**](RelationshipsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbeneficiariesbyrequestid"></a>
# **GetBeneficiariesByRequestId**
> BeneficiariesResponse GetBeneficiariesByRequestId (string authorization, string requestId, string subscription)

Consulta los beneficiarios por el identificador de la petición de registro

Obtiene los beneficiarios enviados para registro en una petición al contrato relacionado con la suscripción, Los beneficiarios son los que actualmente se encuentran registrados en banca Monex, que pertenezcan a la petición que se solicita.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetBeneficiariesByRequestIdExample
    {
        public void main()
        {
            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var requestId = requestId_example;  // string | El identificador de la petición del registro de beneficiarios a esta API.
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Consulta los beneficiarios por el identificador de la petición de registro
                BeneficiariesResponse result = apiInstance.GetBeneficiariesByRequestId(authorization, requestId, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CuentasDeBeneficiariosSPEIApi.GetBeneficiariesByRequestId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **requestId** | **string**| El identificador de la petición del registro de beneficiarios a esta API. | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**BeneficiariesResponse**](BeneficiariesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbeneficiariesforaccountusingget"></a>
# **GetBeneficiariesForAccountUsingGET**
> BeneficiariesResponse GetBeneficiariesForAccountUsingGET (string authorization, string subscription, string account = null, string beneficiaryBank = null, string beneficiaryName = null, string endDate = null, string initDate = null, string page = null, string rfc = null, string size = null, string status = null)

Consulta los beneficiarios registrados

Obtiene los beneficiarios registrados al contrato relacionado con la suscripción, Los beneficiarios son los que actualmente se encuentran registrados en banca Monex.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetBeneficiariesForAccountUsingGETExample
    {
        public void main()
        {
            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.
            var account = account_example;  // string | Es la cuenta del beneficiario, podría ser teléfono celular (es de 10 dígitos), Tarjeta de débito (TDD, es de 16 dígitos) o cuenta CLABE (es de 18 dígitos). <br/><br/>Por ejemplo Teléfono celular: 5525072600, TDD: 4323 1234 5678 9123, CLABE: 032180000118359719. (optional) 
            var beneficiaryBank = beneficiaryBank_example;  // string | Es la clave del banco beneficiario. Se puede obtener del recurso de las <a href=\"#operation/getAllInstitutionsUsingGET\">instituciones.</a> (optional) 
            var beneficiaryName = beneficiaryName_example;  // string | Es el nombre del beneficiario. (optional) 
            var endDate = endDate_example;  // string | Es la fecha de inicio del perido a filtrar en formato dd-mm-yyyy. (optional) 
            var initDate = initDate_example;  // string | Es la fºecha de inicio del perido a filtrar en formato dd-mm-yyyy. (optional) 
            var page = page_example;  // string | Es el número de página. (optional)  (default to 0)
            var rfc = rfc_example;  // string | Es el Registro Federal de Controbuyentes (RFC) del beneficiario. (optional) 
            var size = size_example;  // string | Es el tamaño de página. (optional)  (default to 20)
            var status = status_example;  // string | Es el estado (estatus) de la cuenta. Los valores pueden ser <b>PENDING</b> y <b>REGISTERED</b>. (optional) 

            try
            {
                // Consulta los beneficiarios registrados
                BeneficiariesResponse result = apiInstance.GetBeneficiariesForAccountUsingGET(authorization, subscription, account, beneficiaryBank, beneficiaryName, endDate, initDate, page, rfc, size, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CuentasDeBeneficiariosSPEIApi.GetBeneficiariesForAccountUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 
 **account** | **string**| Es la cuenta del beneficiario, podría ser teléfono celular (es de 10 dígitos), Tarjeta de débito (TDD, es de 16 dígitos) o cuenta CLABE (es de 18 dígitos). &lt;br/&gt;&lt;br/&gt;Por ejemplo Teléfono celular: 5525072600, TDD: 4323 1234 5678 9123, CLABE: 032180000118359719. | [optional] 
 **beneficiaryBank** | **string**| Es la clave del banco beneficiario. Se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt; | [optional] 
 **beneficiaryName** | **string**| Es el nombre del beneficiario. | [optional] 
 **endDate** | **string**| Es la fecha de inicio del perido a filtrar en formato dd-mm-yyyy. | [optional] 
 **initDate** | **string**| Es la fºecha de inicio del perido a filtrar en formato dd-mm-yyyy. | [optional] 
 **page** | **string**| Es el número de página. | [optional] [default to 0]
 **rfc** | **string**| Es el Registro Federal de Controbuyentes (RFC) del beneficiario. | [optional] 
 **size** | **string**| Es el tamaño de página. | [optional] [default to 20]
 **status** | **string**| Es el estado (estatus) de la cuenta. Los valores pueden ser &lt;b&gt;PENDING&lt;/b&gt; y &lt;b&gt;REGISTERED&lt;/b&gt;. | [optional] 

### Return type

[**BeneficiariesResponse**](BeneficiariesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="preregisteraccountsusingpost"></a>
# **PreRegisterAccountsUsingPOST**
> TokenRequiredResponse PreRegisterAccountsUsingPOST (AccountRequest body, string authorization, string subscription)

Pre-registro de cuentas de beneficiarios SPEI®.

Pre-registra una o más cuentas de beneficiario en la plataforma de Wire4, ésta le proporcionará una URL donde lo llevará al centro de autorización para que el cuentahabiente Monex ingrese su llave digital para confirmar el alta de las cuentas de beneficiarios.<br/> Los posibles valores de <em>relationship</em> y <em>kind_of_relationship</em> se deben  obtener de <a href=\"#operation/getAvailableRelationshipsMonexUsingGET\">/subscriptions/{subscription}/beneficiaries/relationships.</a><br/><br/>La confirmación de registro en Monex se realizará a través de una notificación a los webhooks registrados con el evento de tipo <a href=\"#section/Eventos/Tipos-de-Eventos\">ACCOUNT.CREATED.</a>

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class PreRegisterAccountsUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var body = new AccountRequest(); // AccountRequest | Información de la cuenta del beneficiario
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Pre-registro de cuentas de beneficiarios SPEI®.
                TokenRequiredResponse result = apiInstance.PreRegisterAccountsUsingPOST(body, authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CuentasDeBeneficiariosSPEIApi.PreRegisterAccountsUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountRequest**](AccountRequest.md)| Información de la cuenta del beneficiario | 
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removebeneficiariespendingusingdelete"></a>
# **RemoveBeneficiariesPendingUsingDELETE**
> void RemoveBeneficiariesPendingUsingDELETE (string authorization, string requestId, string subscription)

Eliminación de beneficiarios SPEI® sin confirmar

Elimina uno o más beneficiarios que se encuentran en estado pendiente de confirmar (autorizar) de la cuenta del cliente Monex relacionada a la suscripción.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RemoveBeneficiariesPendingUsingDELETEExample
    {
        public void main()
        {
            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var requestId = requestId_example;  // string | Es el identificador con el que se dió de alta a los beneficiarios (viene en el cuerpo de la respuesta del <a href=\"#operation/getAvailableRelationshipsMonexUsingGET\">pre-registro de beneficiarios</a>), los registros bajo éste campo van a ser eliminados.
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Eliminación de beneficiarios SPEI® sin confirmar
                apiInstance.RemoveBeneficiariesPendingUsingDELETE(authorization, requestId, subscription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CuentasDeBeneficiariosSPEIApi.RemoveBeneficiariesPendingUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **requestId** | **string**| Es el identificador con el que se dió de alta a los beneficiarios (viene en el cuerpo de la respuesta del &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt;pre-registro de beneficiarios&lt;/a&gt;), los registros bajo éste campo van a ser eliminados. | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateamountlimitaccountusingput"></a>
# **UpdateAmountLimitAccountUsingPUT**
> TokenRequiredResponse UpdateAmountLimitAccountUsingPUT (AmountRequest body, string authorization, string account, string subscription)

Solicitud para actualizar el monto límite de una cuenta

Se crea una solicitud para actualizar el monto límite a la cuenta de beneficiario proporcionada y relacionada al contrato perteneciente a la subscripción. Una vez enviada la solicitud se retornará una URl que lo llevará al centro de autorización para que el cuentahabiente Monex ingrese su llave digital para confirmar la actualización del monto límite. 

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class UpdateAmountLimitAccountUsingPUTExample
    {
        public void main()
        {
            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var body = new AmountRequest(); // AmountRequest | Información de la cuenta y el monto límite a actualizar.
            var authorization = authorization_example;  // string | Header para token
            var account = account_example;  // string | Es la cuenta que va a ser actualizada.
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Solicitud para actualizar el monto límite de una cuenta
                TokenRequiredResponse result = apiInstance.UpdateAmountLimitAccountUsingPUT(body, authorization, account, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CuentasDeBeneficiariosSPEIApi.UpdateAmountLimitAccountUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AmountRequest**](AmountRequest.md)| Información de la cuenta y el monto límite a actualizar. | 
 **authorization** | **string**| Header para token | 
 **account** | **string**| Es la cuenta que va a ser actualizada. | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
