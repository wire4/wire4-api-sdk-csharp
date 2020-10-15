# MX.Wire4.Api.CuentasDeBeneficiariosSPEIApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthorizeAccountsPendingPUT**](CuentasDeBeneficiariosSPEIApi.md#authorizeaccountspendingput) | **PUT** /subscriptions/{subscription}/beneficiaries/pending | Recibe la solicitud para agrupar las cuentas SPEI/SPID de beneficiarios en estado pendiente que deben ser autorizadas
[**DeleteAccountUsingDELETE**](CuentasDeBeneficiariosSPEIApi.md#deleteaccountusingdelete) | **DELETE** /subscriptions/{subscription}/beneficiaries/spei/{account} | Elimina la cuenta del beneficiario
[**GetAvailableRelationshipsMonexUsingGET**](CuentasDeBeneficiariosSPEIApi.md#getavailablerelationshipsmonexusingget) | **GET** /subscriptions/{subscription}/beneficiaries/relationships | Consulta de relaciones
[**GetBeneficiariesByRequestId**](CuentasDeBeneficiariosSPEIApi.md#getbeneficiariesbyrequestid) | **GET** /subscriptions/{subscription}/beneficiaries/spei/{requestId} | Consulta los beneficiarios por el identificador de la petición de registro
[**GetBeneficiariesForAccountUsingGET**](CuentasDeBeneficiariosSPEIApi.md#getbeneficiariesforaccountusingget) | **GET** /subscriptions/{subscription}/beneficiaries/spei | Consulta los beneficiarios registrados
[**PreRegisterAccountsUsingPOST**](CuentasDeBeneficiariosSPEIApi.md#preregisteraccountsusingpost) | **POST** /subscriptions/{subscription}/beneficiaries/spei | Pre-registro de cuentas de beneficiarios.
[**RemoveBeneficiariesPendingUsingDELETE**](CuentasDeBeneficiariosSPEIApi.md#removebeneficiariespendingusingdelete) | **DELETE** /subscriptions/{subscription}/beneficiaries/spei/request/{requestId} | Eliminación de beneficiarios SPEI® sin confirmar
[**UpdateAmountLimitAccountUsingPUT**](CuentasDeBeneficiariosSPEIApi.md#updateamountlimitaccountusingput) | **PUT** /subscriptions/{subscription}/beneficiaries/spei/{account} | Solicitud para actualizar el monto límite

<a name="authorizeaccountspendingput"></a>
# **AuthorizeAccountsPendingPUT**
> AuthorizedBeneficiariesResponse AuthorizeAccountsPendingPUT (UrlsRedirect body, string authorization, string subscription)

Recibe la solicitud para agrupar las cuentas SPEI/SPID de beneficiarios en estado pendiente que deben ser autorizadas

Solicta autorizar las cuentas de beneficiarios en estado pendiente agrupandolas en un set de cuentas que pueden incluir tanto cuentas de SPI como de SPID, debe indicar las urls de redireccion en caso de error y en caso de exito<br/>

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
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Recibe la solicitud para agrupar las cuentas SPEI/SPID de beneficiarios en estado pendiente que deben ser autorizadas
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
 **subscription** | **string**| El identificador de la suscripción a esta API | 

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

Borra la cuenta de beneficiario proporcionada relacionada al contrato perteneciente a la subscripción. La cuenta a borrar debe ser una cuenta que opere con SPEI.

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
            var account = account_example;  // string | La cuenta del beneciario que será eliminada
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

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
 **account** | **string**| La cuenta del beneciario que será eliminada | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

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
            var subscription = subscription_example;  // string | Identificador de la suscripción a esta API

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
 **subscription** | **string**| Identificador de la suscripción a esta API | 

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
            var requestId = requestId_example;  // string | El identificador de la petición del registro de beneficiarios a esta API
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

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
 **requestId** | **string**| El identificador de la petición del registro de beneficiarios a esta API | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

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
> BeneficiariesResponse GetBeneficiariesForAccountUsingGET (string authorization, string subscription, string account = null, string beneficiaryBank = null, string beneficiaryName = null, string endDate = null, string initDate = null, string rfc = null, string status = null)

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
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API
            var account = account_example;  // string | Cuenta del beneficiario, puede ser Clabe, TDD o Celular (optional) 
            var beneficiaryBank = beneficiaryBank_example;  // string | Clave del banco beneficiario (optional) 
            var beneficiaryName = beneficiaryName_example;  // string | Nombre del beneficiario (optional) 
            var endDate = endDate_example;  // string | Fecha de inicio del perido a filtrar en formato dd-mm-yyyy (optional) 
            var initDate = initDate_example;  // string | Fecha de inicio del perido a filtrar en formato dd-mm-yyyy (optional) 
            var rfc = rfc_example;  // string | RFC del beneficiario (optional) 
            var status = status_example;  // string | Estatus de la cuenta (optional) 

            try
            {
                // Consulta los beneficiarios registrados
                BeneficiariesResponse result = apiInstance.GetBeneficiariesForAccountUsingGET(authorization, subscription, account, beneficiaryBank, beneficiaryName, endDate, initDate, rfc, status);
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
 **subscription** | **string**| El identificador de la suscripción a esta API | 
 **account** | **string**| Cuenta del beneficiario, puede ser Clabe, TDD o Celular | [optional] 
 **beneficiaryBank** | **string**| Clave del banco beneficiario | [optional] 
 **beneficiaryName** | **string**| Nombre del beneficiario | [optional] 
 **endDate** | **string**| Fecha de inicio del perido a filtrar en formato dd-mm-yyyy | [optional] 
 **initDate** | **string**| Fecha de inicio del perido a filtrar en formato dd-mm-yyyy | [optional] 
 **rfc** | **string**| RFC del beneficiario | [optional] 
 **status** | **string**| Estatus de la cuenta | [optional] 

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

Pre-registro de cuentas de beneficiarios.

Pre-registra una o más cuentas de beneficiario en la plataforma, proporcionando una URL donde el cuentahabiente Monex debe ingresar un valor de su llave digital para confirmar el alta de las cuentas de beneficiarios.<br/>Los posibles valores de <i>relationship</i> y <i>kind_of_relationship</i> se deben  obtener de /subscriptions/{subscription}/beneficiaries/relationships.<br/><br/>La confirmación de registro en Monex se realiza a través de una llamada a los webhooks registrados con el evento ACCOUNT.CREATED.

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
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Pre-registro de cuentas de beneficiarios.
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
 **subscription** | **string**| El identificador de la suscripción a esta API | 

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

Elimina un conjunto de beneficiarios a registrar en la cuenta del cliente Monex relacionada a la suscripción, los beneficiarios no deben haber sido confirmados por el cliente.

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
            var requestId = requestId_example;  // string | Identificador de los beneficiarios a eliminar
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

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
 **requestId** | **string**| Identificador de los beneficiarios a eliminar | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

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

Solicitud para actualizar el monto límite

Inicia una solicitud para actualizar el monto límite a la cuenta de beneficiario proporcionada relacionada al contrato perteneciente a la subscripción.

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
            var body = new AmountRequest(); // AmountRequest | Información de la cuenta y el monto límite a actualizar
            var authorization = authorization_example;  // string | Header para token
            var account = account_example;  // string | Cuenta a actualizar
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Solicitud para actualizar el monto límite
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
 **body** | [**AmountRequest**](AmountRequest.md)| Información de la cuenta y el monto límite a actualizar | 
 **authorization** | **string**| Header para token | 
 **account** | **string**| Cuenta a actualizar | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
