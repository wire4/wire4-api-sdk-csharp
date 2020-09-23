# MX.Wire4.Api.ContractsDetailsApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAuthorization**](ContractsDetailsApi.md#createauthorization) | **POST** /onboarding/accounts/authorize | Devuelve la URL para autorización del usuario Monex
[**ObtainAuthorizedUsers**](ContractsDetailsApi.md#obtainauthorizedusers) | **GET** /onboarding/accounts/{requestId}/authorized-users | Obtiene los usuarios autorizados
[**ObtainContractDetails**](ContractsDetailsApi.md#obtaincontractdetails) | **POST** /onboarding/accounts/details | Obtiene los detalles de la empresa del contrato

<a name="createauthorization"></a>
# **CreateAuthorization**
> TokenRequiredResponse CreateAuthorization (PreMonexAuthorization body, string authorization)

Devuelve la URL para autorización del usuario Monex

Se obtiene la URL para la autorización del usuario Monex.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class CreateAuthorizationExample
    {
        public void main()
        {
            var apiInstance = new ContractsDetailsApi();
            var body = new PreMonexAuthorization(); // PreMonexAuthorization | Información para la autorización
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Devuelve la URL para autorización del usuario Monex
                TokenRequiredResponse result = apiInstance.CreateAuthorization(body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsDetailsApi.CreateAuthorization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PreMonexAuthorization**](PreMonexAuthorization.md)| Información para la autorización | 
 **authorization** | **string**| Header para token | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="obtainauthorizedusers"></a>
# **ObtainAuthorizedUsers**
> List<AuthorizedUsers> ObtainAuthorizedUsers (string authorization, string X_ACCESS_KEY, string requestId)

Obtiene los usuarios autorizados

Obtienen los detalles de los usuarios autorizados de Monex.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class ObtainAuthorizedUsersExample
    {
        public void main()
        {
            var apiInstance = new ContractsDetailsApi();
            var authorization = authorization_example;  // string | Header para token
            var X_ACCESS_KEY = X_ACCESS_KEY_example;  // string | La llave de acceso de la aplicación
            var requestId = requestId_example;  // string | El identificador de la petición a esta API

            try
            {
                // Obtiene los usuarios autorizados
                List&lt;AuthorizedUsers&gt; result = apiInstance.ObtainAuthorizedUsers(authorization, X_ACCESS_KEY, requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsDetailsApi.ObtainAuthorizedUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **X_ACCESS_KEY** | **string**| La llave de acceso de la aplicación | 
 **requestId** | **string**| El identificador de la petición a esta API | 

### Return type

[**List<AuthorizedUsers>**](AuthorizedUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="obtaincontractdetails"></a>
# **ObtainContractDetails**
> ContractDetailResponse ObtainContractDetails (ContractDetailRequest body, string authorization, string X_ACCESS_KEY)

Obtiene los detalles de la empresa del contrato

Detalles de la compañía relacionada con el contrato de Monex.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class ObtainContractDetailsExample
    {
        public void main()
        {
            var apiInstance = new ContractsDetailsApi();
            var body = new ContractDetailRequest(); // ContractDetailRequest | Información para obtener los detalles de la companía
            var authorization = authorization_example;  // string | Header para token
            var X_ACCESS_KEY = X_ACCESS_KEY_example;  // string | La llave de acceso de la aplicación

            try
            {
                // Obtiene los detalles de la empresa del contrato
                ContractDetailResponse result = apiInstance.ObtainContractDetails(body, authorization, X_ACCESS_KEY);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsDetailsApi.ObtainContractDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractDetailRequest**](ContractDetailRequest.md)| Información para obtener los detalles de la companía | 
 **authorization** | **string**| Header para token | 
 **X_ACCESS_KEY** | **string**| La llave de acceso de la aplicación | 

### Return type

[**ContractDetailResponse**](ContractDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
