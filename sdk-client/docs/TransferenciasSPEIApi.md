# MX.Wire4.Api.TransferenciasSPEIApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DropTransactionsPendingUsingDELETE**](TransferenciasSPEIApi.md#droptransactionspendingusingdelete) | **DELETE** /subscriptions/{subscription}/transactions/outcoming/spei/request/{requestId} | Eliminación de transferencias SPEI® pendientes
[**IncomingSpeiTransactionsReportUsingGET**](TransferenciasSPEIApi.md#incomingspeitransactionsreportusingget) | **GET** /subscriptions/{subscription}/transactions/incoming/spei | Consulta de transferencias recibidas
[**OutCommingSpeiRequestIdTransactionsReportUsingGET**](TransferenciasSPEIApi.md#outcommingspeirequestidtransactionsreportusingget) | **GET** /subscriptions/{subscription}/transactions/outcoming/spei/{requestId} | Consulta de transferencias de salida por identificador de petición
[**OutgoingSpeiTransactionsReportUsingGET**](TransferenciasSPEIApi.md#outgoingspeitransactionsreportusingget) | **GET** /subscriptions/{subscription}/transactions/outcoming/spei | Consulta de transferencias realizadas
[**RegisterOutgoingSpeiTransactionUsingPOST**](TransferenciasSPEIApi.md#registeroutgoingspeitransactionusingpost) | **POST** /subscriptions/{subscription}/transactions/outcoming/spei | Registro de transferencias

<a name="droptransactionspendingusingdelete"></a>
# **DropTransactionsPendingUsingDELETE**
> void DropTransactionsPendingUsingDELETE (string authorization, string requestId, string subscription)

Eliminación de transferencias SPEI® pendientes

Elimina un conjunto de transferencias a realizar en la cuenta del cliente Monex relacionada a la suscripción, las transferencias no deben haber sido confirmadas por el cliente.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class DropTransactionsPendingUsingDELETEExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var requestId = requestId_example;  // string | Identificador de las transferencias a eliminar
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Eliminación de transferencias SPEI® pendientes
                apiInstance.DropTransactionsPendingUsingDELETE(authorization, requestId, subscription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPEIApi.DropTransactionsPendingUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **requestId** | **string**| Identificador de las transferencias a eliminar | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="incomingspeitransactionsreportusingget"></a>
# **IncomingSpeiTransactionsReportUsingGET**
> List<Deposit> IncomingSpeiTransactionsReportUsingGET (string authorization, string subscription)

Consulta de transferencias recibidas

Realiza una consulta de las transferencias recibidas (depósitos) en la cuenta del cliente Monex relacionada a la suscripción, las transferencias que regresa este recuso son únicamente las transferencias  recibidas durante el día en el que se realiza la consulta.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class IncomingSpeiTransactionsReportUsingGETExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Consulta de transferencias recibidas
                List&lt;Deposit&gt; result = apiInstance.IncomingSpeiTransactionsReportUsingGET(authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPEIApi.IncomingSpeiTransactionsReportUsingGET: " + e.Message );
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

[**List<Deposit>**](Deposit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="outcommingspeirequestidtransactionsreportusingget"></a>
# **OutCommingSpeiRequestIdTransactionsReportUsingGET**
> PaymentsRequestId OutCommingSpeiRequestIdTransactionsReportUsingGET (string authorization, string requestId, string subscription)

Consulta de transferencias de salida por identificador de petición

Consulta las transferencias de salida registradas en una petición, las transferencias que regresa este recuso son únicamente las transferenciasde salida agrupadas al identificador de la petición que se generó al hacer el registro de las transacciones el cual se debe especificar como parte del path de este endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class OutCommingSpeiRequestIdTransactionsReportUsingGETExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var requestId = requestId_example;  // string | Identificador de la petición a buscar
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Consulta de transferencias de salida por identificador de petición
                PaymentsRequestId result = apiInstance.OutCommingSpeiRequestIdTransactionsReportUsingGET(authorization, requestId, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPEIApi.OutCommingSpeiRequestIdTransactionsReportUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **requestId** | **string**| Identificador de la petición a buscar | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

[**PaymentsRequestId**](PaymentsRequestId.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="outgoingspeitransactionsreportusingget"></a>
# **OutgoingSpeiTransactionsReportUsingGET**
> List<Payment> OutgoingSpeiTransactionsReportUsingGET (string authorization, string subscription, string orderId = null)

Consulta de transferencias realizadas

Consulta las transferencias realizadas en la cuenta del cliente Monex relacionada a la suscripción, las transferencias que regresa este recuso son únicamente las transferencias recibidas en el día en el que se realiza la consulta.<br>Se pueden realizar consultas por <strong>order_id</strong> al realizar este tipo de consultas no importa el día en el que se realizó la transferencia

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class OutgoingSpeiTransactionsReportUsingGETExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API
            var orderId = orderId_example;  // string | Identificador de la orden a buscar (optional) 

            try
            {
                // Consulta de transferencias realizadas
                List&lt;Payment&gt; result = apiInstance.OutgoingSpeiTransactionsReportUsingGET(authorization, subscription, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPEIApi.OutgoingSpeiTransactionsReportUsingGET: " + e.Message );
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
 **orderId** | **string**| Identificador de la orden a buscar | [optional] 

### Return type

[**List<Payment>**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registeroutgoingspeitransactionusingpost"></a>
# **RegisterOutgoingSpeiTransactionUsingPOST**
> TokenRequiredResponse RegisterOutgoingSpeiTransactionUsingPOST (TransactionsOutgoingRegister body, string authorization, string subscription)

Registro de transferencias

Registra un conjunto de transferencias a realizar en la cuenta del cliente Monex relacionada a la suscripción, las transferencias deben ser confirmadas por el cliente para que se efectuen.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RegisterOutgoingSpeiTransactionUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPEIApi();
            var body = new TransactionsOutgoingRegister(); // TransactionsOutgoingRegister | Información de las transferencias SPEI de salida
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Registro de transferencias
                TokenRequiredResponse result = apiInstance.RegisterOutgoingSpeiTransactionUsingPOST(body, authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPEIApi.RegisterOutgoingSpeiTransactionUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionsOutgoingRegister**](TransactionsOutgoingRegister.md)| Información de las transferencias SPEI de salida | 
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
