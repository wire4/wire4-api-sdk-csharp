# MX.Wire4.Api.SuscripcionesApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeSubscriptionStatusUsingPUT**](SuscripcionesApi.md#changesubscriptionstatususingput) | **PUT** /subscriptions/{subscription}/status | Cambia el estatus de la suscripción
[**PreEnrollmentMonexUserUsingPOST**](SuscripcionesApi.md#preenrollmentmonexuserusingpost) | **POST** /subscriptions/pre-subscription | Registra una pre-suscripción
[**RemoveEnrollmentUserUsingDELETE**](SuscripcionesApi.md#removeenrollmentuserusingdelete) | **DELETE** /subscriptions/{subscription} | Elimina una suscripción por el identificador de la suscripción
[**RemoveSubscriptionPendingStatusUsingDELETE**](SuscripcionesApi.md#removesubscriptionpendingstatususingdelete) | **DELETE** /subscriptions/pre-subscription/{subscription} | Elimina una pre-suscripción

<a name="changesubscriptionstatususingput"></a>
# **ChangeSubscriptionStatusUsingPUT**
> void ChangeSubscriptionStatusUsingPUT (SubscriptionChangeStatusRequest body, string authorization, string subscription)

Cambia el estatus de la suscripción

Se cambia el estatus de la suscripción, los posibles valores son ACTIVE ó INACTIVE

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class ChangeSubscriptionStatusUsingPUTExample
    {
        public void main()
        {
            var apiInstance = new SuscripcionesApi();
            var body = new SubscriptionChangeStatusRequest(); // SubscriptionChangeStatusRequest | request
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | subscription

            try
            {
                // Cambia el estatus de la suscripción
                apiInstance.ChangeSubscriptionStatusUsingPUT(body, authorization, subscription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuscripcionesApi.ChangeSubscriptionStatusUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscriptionChangeStatusRequest**](SubscriptionChangeStatusRequest.md)| request | 
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| subscription | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="preenrollmentmonexuserusingpost"></a>
# **PreEnrollmentMonexUserUsingPOST**
> PreEnrollmentResponse PreEnrollmentMonexUserUsingPOST (PreEnrollmentData body, string authorization)

Registra una pre-suscripción

Registra una pre-suscripción para operar un contrato a través de un aplicación socio de la plataforma, proporcionando una URL donde el cliente Monex debe autorizar el acceso a los datos de su cuenta a el socio.<br/>Una vez que el cuentahabiente autorice el acceso, se envía un mensaje webhook con el evento 'ENROLLMENT.CREATED', el cuál contiene los datos de acceso a esta API.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class PreEnrollmentMonexUserUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new SuscripcionesApi();
            var body = new PreEnrollmentData(); // PreEnrollmentData | Información para la pre-suscripción
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Registra una pre-suscripción
                PreEnrollmentResponse result = apiInstance.PreEnrollmentMonexUserUsingPOST(body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuscripcionesApi.PreEnrollmentMonexUserUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PreEnrollmentData**](PreEnrollmentData.md)| Información para la pre-suscripción | 
 **authorization** | **string**| Header para token | 

### Return type

[**PreEnrollmentResponse**](PreEnrollmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeenrollmentuserusingdelete"></a>
# **RemoveEnrollmentUserUsingDELETE**
> void RemoveEnrollmentUserUsingDELETE (string authorization, string subscription)

Elimina una suscripción por el identificador de la suscripción

Elimina una suscripción, una vez eliminada ya no se podrán realizar operacions en el API utilizando esta suscripción

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RemoveEnrollmentUserUsingDELETEExample
    {
        public void main()
        {
            var apiInstance = new SuscripcionesApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Elimina una suscripción por el identificador de la suscripción
                apiInstance.RemoveEnrollmentUserUsingDELETE(authorization, subscription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuscripcionesApi.RemoveEnrollmentUserUsingDELETE: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removesubscriptionpendingstatususingdelete"></a>
# **RemoveSubscriptionPendingStatusUsingDELETE**
> void RemoveSubscriptionPendingStatusUsingDELETE (string authorization, string subscription)

Elimina una pre-suscripción

Se elimina una pre-suscripción, sólo se elimina en caso de que el cliente Monex no haya concedido su autorización de acceso (token), es decir que la pre-suscripcion este pendiente.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RemoveSubscriptionPendingStatusUsingDELETEExample
    {
        public void main()
        {
            var apiInstance = new SuscripcionesApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Elimina una pre-suscripción
                apiInstance.RemoveSubscriptionPendingStatusUsingDELETE(authorization, subscription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuscripcionesApi.RemoveSubscriptionPendingStatusUsingDELETE: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
