# MX.Wire4.Api.SuscripcionesApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeSubscriptionStatusUsingPUT**](SuscripcionesApi.md#changesubscriptionstatususingput) | **PUT** /subscriptions/{subscription}/status | Cambia el estatus de la suscripción
[**ChangeSubscriptionUseUsingPATCH**](SuscripcionesApi.md#changesubscriptionuseusingpatch) | **PATCH** /subscriptions/{subscription} | Cambia el uso de la suscripción
[**PreEnrollmentMonexUserUsingPOST**](SuscripcionesApi.md#preenrollmentmonexuserusingpost) | **POST** /subscriptions/pre-subscription | Pre-registro de una suscripción
[**RemoveEnrollmentUserUsingDELETE**](SuscripcionesApi.md#removeenrollmentuserusingdelete) | **DELETE** /subscriptions/{subscription} | Elimina suscripción por su identificador.
[**RemoveSubscriptionPendingStatusUsingDELETE**](SuscripcionesApi.md#removesubscriptionpendingstatususingdelete) | **DELETE** /subscriptions/pre-subscription/{subscription} | Elimina pre-registro de suscripción

<a name="changesubscriptionstatususingput"></a>
# **ChangeSubscriptionStatusUsingPUT**
> void ChangeSubscriptionStatusUsingPUT (SubscriptionChangeStatusRequest body, string authorization, string subscription)

Cambia el estatus de la suscripción

Se cambia el estado o estatus de la suscripción a los posibles valores que son: ACTIVE o INACTIVE

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
<a name="changesubscriptionuseusingpatch"></a>
# **ChangeSubscriptionUseUsingPATCH**
> ServiceBanking ChangeSubscriptionUseUsingPATCH (ServiceBanking body, string authorization, string subscription)

Cambia el uso de la suscripción

Se asigna o cambia el uso y el estatus que se le dará a la subscripción para los servicios SPEI y SPID en el manejo de Cobros y Pagos El status puede tener los posibles valores: ACTIVE o INACTIVE. El uso puede tener los posibles valores: WITHDRAWAL_DEPOSIT o WITHDRAWAL o DEPOSIT

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class ChangeSubscriptionUseUsingPATCHExample
    {
        public void main()
        {
            var apiInstance = new SuscripcionesApi();
            var body = new ServiceBanking(); // ServiceBanking | request
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | subscription

            try
            {
                // Cambia el uso de la suscripción
                ServiceBanking result = apiInstance.ChangeSubscriptionUseUsingPATCH(body, authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuscripcionesApi.ChangeSubscriptionUseUsingPATCH: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ServiceBanking**](ServiceBanking.md)| request | 
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| subscription | 

### Return type

[**ServiceBanking**](ServiceBanking.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="preenrollmentmonexuserusingpost"></a>
# **PreEnrollmentMonexUserUsingPOST**
> PreEnrollmentResponse PreEnrollmentMonexUserUsingPOST (PreEnrollmentData body, string authorization)

Pre-registro de una suscripción

Pre-registra una suscripción para operar un contrato a través de un aplicación socio de la plataforma. Se retorna una dirección URL hacia el centro de autorización donde el cliente  Monex debe autorizar el acceso a los datos de su cuenta a el socio.<br/><br/>Una vez que el cuentahabiente autorice el acceso, se envía una notificación (webhook configurado) con el evento 'ENROLLMENT.CREATED', el cuál contiene los datos de acceso a esta API.

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
                // Pre-registro de una suscripción
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

Elimina suscripción por su identificador.

Elimina una suscripción mediante su identificador. Una vez eliminada dicha suscripción, ya no se podrán realizar operaciones en el API utilizando sus credenciales

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
            var subscription = subscription_example;  // string | El identificador de la suscripción a ésta API

            try
            {
                // Elimina suscripción por su identificador.
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
 **subscription** | **string**| El identificador de la suscripción a ésta API | 

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

Elimina pre-registro de suscripción

Se elimina el pre-registro de suscripción. Sólo se elimina en caso de que el cliente Monex no haya concedido su autorización de acceso (token), es decir que la suscripcion esté pendiente.

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
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Elimina pre-registro de suscripción
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
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
