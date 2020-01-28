# MX.Wire4.Api.SuscripcionesApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PreEnrollmentMonexUserUsingPOST**](SuscripcionesApi.md#preenrollmentmonexuserusingpost) | **POST** /subscriptions/pre-subscription | registra una pre-suscripción
[**RemoveEnrollmentUserUsingDELETE**](SuscripcionesApi.md#removeenrollmentuserusingdelete) | **DELETE** /subscriptions/{subscription} | Elimna una suscripción por id
[**RemoveSubscriptionPendingStatusUsingDELETE**](SuscripcionesApi.md#removesubscriptionpendingstatususingdelete) | **DELETE** /subscriptions/pre-subscription/{subscription} | Elimna una pre-suscripción

<a name="preenrollmentmonexuserusingpost"></a>
# **PreEnrollmentMonexUserUsingPOST**
> PreEnrollmentResponse PreEnrollmentMonexUserUsingPOST (PreEnrollmentData body)

registra una pre-suscripción

Pre-registra una suscripción para operar un contrato a través de un aplicación socio de la plataforma, proporcionando una URL donde el cliente Monex debe autorizar el acceso a los datos de su cuenta a el socio.<br/>Una vez que el cuentahabiente autorice el acceso, se envia un webhook con el evento ENROLLMENT.CREATED, el cual contiene los datos de acceso.

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
            // Configure OAuth2 access token for authorization: wire4_aut_app
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuscripcionesApi();
            var body = new PreEnrollmentData(); // PreEnrollmentData | Información para el enrolamiento

            try
            {
                // registra una pre-suscripción
                PreEnrollmentResponse result = apiInstance.PreEnrollmentMonexUserUsingPOST(body);
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
 **body** | [**PreEnrollmentData**](PreEnrollmentData.md)| Información para el enrolamiento | 

### Return type

[**PreEnrollmentResponse**](PreEnrollmentResponse.md)

### Authorization

[wire4_aut_app](../README.md#wire4_aut_app)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeenrollmentuserusingdelete"></a>
# **RemoveEnrollmentUserUsingDELETE**
> void RemoveEnrollmentUserUsingDELETE (string subscription)

Elimna una suscripción por id

Elimina una suscripción, una ves eliminada la suscripcion ya no se podran realizar operacions en el API uilizando esta suscripción

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
            // Configure OAuth2 access token for authorization: wire4_aut_app_user_spei
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuscripcionesApi();
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Elimna una suscripción por id
                apiInstance.RemoveEnrollmentUserUsingDELETE(subscription);
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
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

void (empty response body)

### Authorization

[wire4_aut_app_user_spei](../README.md#wire4_aut_app_user_spei)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removesubscriptionpendingstatususingdelete"></a>
# **RemoveSubscriptionPendingStatusUsingDELETE**
> void RemoveSubscriptionPendingStatusUsingDELETE (string subscription)

Elimna una pre-suscripción

Se elimina una pre-suscripción, sólo se elimina en caso de que cliente monex no haya concedio su autorización de acceso, es decir que la pre-suscripcion este pendiente.

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
            // Configure OAuth2 access token for authorization: wire4_aut_app
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuscripcionesApi();
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Elimna una pre-suscripción
                apiInstance.RemoveSubscriptionPendingStatusUsingDELETE(subscription);
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
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

void (empty response body)

### Authorization

[wire4_aut_app](../README.md#wire4_aut_app)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
