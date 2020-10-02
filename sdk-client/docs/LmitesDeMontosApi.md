# MX.Wire4.Api.LmitesDeMontosApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ObtainConfigurationsLimits**](LmitesDeMontosApi.md#obtainconfigurationslimits) | **GET** /subscriptions/{suscription}/configurations | Consulta las configuraciones para el contrato asocaido al enrolamiento en la aplicación
[**UpdateConfigurations**](LmitesDeMontosApi.md#updateconfigurations) | **PUT** /subscriptions/{suscription}/configurations | Actualiza las configuraciones por subscripción

<a name="obtainconfigurationslimits"></a>
# **ObtainConfigurationsLimits**
> MessageConfigurationsLimits ObtainConfigurationsLimits (string authorization, string suscription)

Consulta las configuraciones para el contrato asocaido al enrolamiento en la aplicación

Consulta las configuraciones para el contrato asocaido al enrolamiento en la aplicación.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class ObtainConfigurationsLimitsExample
    {
        public void main()
        {
            var apiInstance = new LmitesDeMontosApi();
            var authorization = authorization_example;  // string | Header para token
            var suscription = suscription_example;  // string | Identificador de la suscripción a esta API

            try
            {
                // Consulta las configuraciones para el contrato asocaido al enrolamiento en la aplicación
                MessageConfigurationsLimits result = apiInstance.ObtainConfigurationsLimits(authorization, suscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LmitesDeMontosApi.ObtainConfigurationsLimits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **suscription** | **string**| Identificador de la suscripción a esta API | 

### Return type

[**MessageConfigurationsLimits**](MessageConfigurationsLimits.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateconfigurations"></a>
# **UpdateConfigurations**
> void UpdateConfigurations (UpdateConfigurationsRequestDTO body, string authorization, string suscription)

Actualiza las configuraciones por subscripción

Actualiza las configuraciones de un contrato asociado a una subscripción

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class UpdateConfigurationsExample
    {
        public void main()
        {
            var apiInstance = new LmitesDeMontosApi();
            var body = new UpdateConfigurationsRequestDTO(); // UpdateConfigurationsRequestDTO | updateConfigurationsResquestDTO
            var authorization = authorization_example;  // string | Header para token
            var suscription = suscription_example;  // string | suscription

            try
            {
                // Actualiza las configuraciones por subscripción
                apiInstance.UpdateConfigurations(body, authorization, suscription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LmitesDeMontosApi.UpdateConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateConfigurationsRequestDTO**](UpdateConfigurationsRequestDTO.md)| updateConfigurationsResquestDTO | 
 **authorization** | **string**| Header para token | 
 **suscription** | **string**| suscription | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
