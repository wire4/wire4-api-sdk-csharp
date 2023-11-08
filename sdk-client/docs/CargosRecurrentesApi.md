# MX.Wire4.Api.CargosRecurrentesApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRecurringChargeUsingDELETE**](CargosRecurrentesApi.md#deleterecurringchargeusingdelete) | **DELETE** /recurring-charge/{orderId} | Cancelación/desubscripción de cargos recurrentes
[**RegisterRecurringChargeUsingPOST**](CargosRecurrentesApi.md#registerrecurringchargeusingpost) | **POST** /recurring-charge | Registro de cargos recurrentes

<a name="deleterecurringchargeusingdelete"></a>
# **DeleteRecurringChargeUsingDELETE**
> ConfirmRecurringCharge DeleteRecurringChargeUsingDELETE (string authorization, string orderId)

Cancelación/desubscripción de cargos recurrentes

 Se solicita la desuscripción de un cargo recurrente activo. En el request llevará el orderId que identifica el cargo recurrente a eliminar/dar de baja se deshabilitará tanto de openpay como del sistem wire4.<br> Nota: Debe considerar que para hacer uso de esta funcionalidad debe contar con un scope  especial

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class DeleteRecurringChargeUsingDELETEExample
    {
        public void main()
        {
            var apiInstance = new CargosRecurrentesApi();
            var authorization = authorization_example;  // string | Header para token
            var orderId = orderId_example;  // string | orderId

            try
            {
                // Cancelación/desubscripción de cargos recurrentes
                ConfirmRecurringCharge result = apiInstance.DeleteRecurringChargeUsingDELETE(authorization, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CargosRecurrentesApi.DeleteRecurringChargeUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **orderId** | **string**| orderId | 

### Return type

[**ConfirmRecurringCharge**](ConfirmRecurringCharge.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerrecurringchargeusingpost"></a>
# **RegisterRecurringChargeUsingPOST**
> ConfirmRecurringCharge RegisterRecurringChargeUsingPOST (RecurringChargeRequest body, string authorization)

Registro de cargos recurrentes

 Se registra una solicitud para generar un plan de cargos recurrentes. En la respuesta se proporcionará una dirección URL que lo llevará al sitio donde se le solicitará ingresar los datos de tarjeta a la que se aplicarán los cargos de acuerdo al plan seleccionado.<br> Nota: Debe considerar que para hacer uso de esta funcionalidad debe contar con un scope  especial

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RegisterRecurringChargeUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new CargosRecurrentesApi();
            var body = new RecurringChargeRequest(); // RecurringChargeRequest | Información de la solicitud para aplicar cargos recurrentes
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Registro de cargos recurrentes
                ConfirmRecurringCharge result = apiInstance.RegisterRecurringChargeUsingPOST(body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CargosRecurrentesApi.RegisterRecurringChargeUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecurringChargeRequest**](RecurringChargeRequest.md)| Información de la solicitud para aplicar cargos recurrentes | 
 **authorization** | **string**| Header para token | 

### Return type

[**ConfirmRecurringCharge**](ConfirmRecurringCharge.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
