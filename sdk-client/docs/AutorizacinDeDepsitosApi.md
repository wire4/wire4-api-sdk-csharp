# MX.Wire4.Api.AutorizacinDeDepsitosApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDepositAuthConfigurations**](AutorizacinDeDepsitosApi.md#getdepositauthconfigurations) | **GET** /subscriptions/{subscription}/configurations/deposit-authorization | Consulta autorización de depósitos
[**PutDepositAuthConfigurations**](AutorizacinDeDepsitosApi.md#putdepositauthconfigurations) | **PUT** /subscriptions/{subscription}/configurations/deposit-authorization | Habilita / Deshabilita la autorización de depósitos

<a name="getdepositauthconfigurations"></a>
# **GetDepositAuthConfigurations**
> DepositsAuthorizationResponse GetDepositAuthConfigurations (string authorization, string subscription)

Consulta autorización de depósitos

Obtiene la información de la autorización de depósitos del contrato relacionado a la suscripción.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetDepositAuthConfigurationsExample
    {
        public void main()
        {
            var apiInstance = new AutorizacinDeDepsitosApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Consulta autorización de depósitos
                DepositsAuthorizationResponse result = apiInstance.GetDepositAuthConfigurations(authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutorizacinDeDepsitosApi.GetDepositAuthConfigurations: " + e.Message );
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

[**DepositsAuthorizationResponse**](DepositsAuthorizationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putdepositauthconfigurations"></a>
# **PutDepositAuthConfigurations**
> DepositsAuthorizationResponse PutDepositAuthConfigurations (DepositAuthorizationRequest body, string authorization, string subscription)

Habilita / Deshabilita la autorización de depósitos

Habilita o deshabilita la autorización de depósitos. Devuelve la información final de la autorización de depósitos del contrato relacionado a la suscripción al terminar.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class PutDepositAuthConfigurationsExample
    {
        public void main()
        {
            var apiInstance = new AutorizacinDeDepsitosApi();
            var body = new DepositAuthorizationRequest(); // DepositAuthorizationRequest | Información para habilitar / deshabilitar la autorización de depósito
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Habilita / Deshabilita la autorización de depósitos
                DepositsAuthorizationResponse result = apiInstance.PutDepositAuthConfigurations(body, authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutorizacinDeDepsitosApi.PutDepositAuthConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DepositAuthorizationRequest**](DepositAuthorizationRequest.md)| Información para habilitar / deshabilitar la autorización de depósito | 
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**DepositsAuthorizationResponse**](DepositsAuthorizationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
