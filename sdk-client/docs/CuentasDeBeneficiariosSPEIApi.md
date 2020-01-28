# MX.Wire4.Api.CuentasDeBeneficiariosSPEIApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAccountUsingDELETE**](CuentasDeBeneficiariosSPEIApi.md#deleteaccountusingdelete) | **DELETE** /subscriptions/{subscription}/beneficiaries/spei/{account} | Elimina la cuenta del beneficiario
[**GetAvailableRelationshipsMonexUsingGET**](CuentasDeBeneficiariosSPEIApi.md#getavailablerelationshipsmonexusingget) | **GET** /subscriptions/{subscription}/beneficiaries/relationships | Consulta de relaciones
[**GetBeneficiariesForAccountUsingGET**](CuentasDeBeneficiariosSPEIApi.md#getbeneficiariesforaccountusingget) | **GET** /subscriptions/{subscription}/beneficiaries/spei | Consulta los beneficiarios registrados
[**PreRegisterAccountsUsingPOST**](CuentasDeBeneficiariosSPEIApi.md#preregisteraccountsusingpost) | **POST** /subscriptions/{subscription}/beneficiaries/spei | Pre-registro de cuentas de beneficiarios.
[**RemoveBeneficiariesPendingUsingDELETE**](CuentasDeBeneficiariosSPEIApi.md#removebeneficiariespendingusingdelete) | **DELETE** /subscriptions/{subscription}/beneficiaries/spei/request/{requestId} | Eliminación de beneficiarios SPEI® sin confirmar
[**UpdateAmountLimitAccountUsingPUT**](CuentasDeBeneficiariosSPEIApi.md#updateamountlimitaccountusingput) | **PUT** /subscriptions/{subscription}/beneficiaries/spei/{account} | Actualiza el monto límite

<a name="deleteaccountusingdelete"></a>
# **DeleteAccountUsingDELETE**
> void DeleteAccountUsingDELETE (string account, string subscription)

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
            // Configure OAuth2 access token for authorization: wire4_aut_app_user_spei
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var account = account_example;  // string | La cuenta del beneciario que será eliminada
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Elimina la cuenta del beneficiario
                apiInstance.DeleteAccountUsingDELETE(account, subscription);
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
 **account** | **string**| La cuenta del beneciario que será eliminada | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

void (empty response body)

### Authorization

[wire4_aut_app_user_spei](../README.md#wire4_aut_app_user_spei)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getavailablerelationshipsmonexusingget"></a>
# **GetAvailableRelationshipsMonexUsingGET**
> RelationshipsResponse GetAvailableRelationshipsMonexUsingGET (string subscription)

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
            // Configure OAuth2 access token for authorization: wire4_aut_app_user_spei
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var subscription = subscription_example;  // string | Identificador de la suscripción a esta API

            try
            {
                // Consulta de relaciones
                RelationshipsResponse result = apiInstance.GetAvailableRelationshipsMonexUsingGET(subscription);
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
 **subscription** | **string**| Identificador de la suscripción a esta API | 

### Return type

[**RelationshipsResponse**](RelationshipsResponse.md)

### Authorization

[wire4_aut_app_user_spei](../README.md#wire4_aut_app_user_spei)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbeneficiariesforaccountusingget"></a>
# **GetBeneficiariesForAccountUsingGET**
> BeneficiariesResponse GetBeneficiariesForAccountUsingGET (string subscription, string rfc = null)

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
            // Configure OAuth2 access token for authorization: wire4_aut_app_user_spei
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API
            var rfc = rfc_example;  // string | RFC del beneficiario (optional) 

            try
            {
                // Consulta los beneficiarios registrados
                BeneficiariesResponse result = apiInstance.GetBeneficiariesForAccountUsingGET(subscription, rfc);
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
 **subscription** | **string**| El identificador de la suscripción a esta API | 
 **rfc** | **string**| RFC del beneficiario | [optional] 

### Return type

[**BeneficiariesResponse**](BeneficiariesResponse.md)

### Authorization

[wire4_aut_app_user_spei](../README.md#wire4_aut_app_user_spei)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="preregisteraccountsusingpost"></a>
# **PreRegisterAccountsUsingPOST**
> TokenRequiredResponse PreRegisterAccountsUsingPOST (AccountRequest body, string subscription)

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
            // Configure OAuth2 access token for authorization: wire4_aut_app_user_spei
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var body = new AccountRequest(); // AccountRequest | Información de la cuenta del beneficiario
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Pre-registro de cuentas de beneficiarios.
                TokenRequiredResponse result = apiInstance.PreRegisterAccountsUsingPOST(body, subscription);
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
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

[wire4_aut_app_user_spei](../README.md#wire4_aut_app_user_spei)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removebeneficiariespendingusingdelete"></a>
# **RemoveBeneficiariesPendingUsingDELETE**
> void RemoveBeneficiariesPendingUsingDELETE (string requestId, string subscription)

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
            // Configure OAuth2 access token for authorization: wire4_aut_app_user_spei
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var requestId = requestId_example;  // string | Identificador de los beneficiarios a eliminar
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Eliminación de beneficiarios SPEI® sin confirmar
                apiInstance.RemoveBeneficiariesPendingUsingDELETE(requestId, subscription);
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
 **requestId** | **string**| Identificador de los beneficiarios a eliminar | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

void (empty response body)

### Authorization

[wire4_aut_app_user_spei](../README.md#wire4_aut_app_user_spei)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateamountlimitaccountusingput"></a>
# **UpdateAmountLimitAccountUsingPUT**
> void UpdateAmountLimitAccountUsingPUT (AmountRequest body, string account, string subscription)

Actualiza el monto límite

Actualiza el monto límite a la cuenta de beneficiario proporcionada relacionada al contrato perteneciente a la subscripción.

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
            // Configure OAuth2 access token for authorization: wire4_aut_app_user_spei
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CuentasDeBeneficiariosSPEIApi();
            var body = new AmountRequest(); // AmountRequest | Información de la cuenta y el monto límite a actualizar
            var account = account_example;  // string | Cuenta a actualizar
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Actualiza el monto límite
                apiInstance.UpdateAmountLimitAccountUsingPUT(body, account, subscription);
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
 **account** | **string**| Cuenta a actualizar | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

void (empty response body)

### Authorization

[wire4_aut_app_user_spei](../README.md#wire4_aut_app_user_spei)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
