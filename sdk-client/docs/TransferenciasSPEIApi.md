# MX.Wire4.Api.TransferenciasSPEIApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAuthorizationTransactionsGroup**](TransferenciasSPEIApi.md#createauthorizationtransactionsgroup) | **POST** /subscriptions/{subscription}/transactions/group | Agrupa transacciones bajo un request_id 
[**DropTransactionsPendingUsingDELETE**](TransferenciasSPEIApi.md#droptransactionspendingusingdelete) | **DELETE** /subscriptions/{subscription}/transactions/outcoming/spei/request/{requestId} | Eliminación de transferencias SPEI® pendientes
[**IncomingSpeiTransactionsReportUsingGET**](TransferenciasSPEIApi.md#incomingspeitransactionsreportusingget) | **GET** /subscriptions/{subscription}/transactions/incoming/spei | Consulta de transferencias recibidas
[**OutCommingSpeiRequestIdTransactionsReportUsingGET**](TransferenciasSPEIApi.md#outcommingspeirequestidtransactionsreportusingget) | **GET** /subscriptions/{subscription}/transactions/outcoming/spei/{requestId} | Consulta de transferencias de salida por identificador de petición
[**OutCommingSpeiSpidOrderIdTransactionReportUsingGET**](TransferenciasSPEIApi.md#outcommingspeispidorderidtransactionreportusingget) | **GET** /subscriptions/{subscription}/transactions/outcoming | Consulta de transferencias realizadas por order_id
[**OutCommingSpeiSpidRequestIdTransactionsReportUsingGET**](TransferenciasSPEIApi.md#outcommingspeispidrequestidtransactionsreportusingget) | **GET** /subscriptions/{subscription}/transactions/outcoming/{requestId} | Consulta de transferencias de salida por identificador de petición
[**OutgoingSpeiTransactionsReportUsingGET**](TransferenciasSPEIApi.md#outgoingspeitransactionsreportusingget) | **GET** /subscriptions/{subscription}/transactions/outcoming/spei | Consulta de transferencias realizadas
[**RegisterOutgoingSpeiTransactionUsingPOST**](TransferenciasSPEIApi.md#registeroutgoingspeitransactionusingpost) | **POST** /subscriptions/{subscription}/transactions/outcoming/spei | Registro de transferencias
[**RegisterSpeiSpidOutgoingTransactionsUsingPOST**](TransferenciasSPEIApi.md#registerspeispidoutgoingtransactionsusingpost) | **POST** /subscriptions/{subscription}/transactions/outcoming | Registro de transferencias SPEI y SPID

<a name="createauthorizationtransactionsgroup"></a>
# **CreateAuthorizationTransactionsGroup**
> TokenRequiredResponse CreateAuthorizationTransactionsGroup (AuthorizationTransactionGroup body, string authorization, string subscription)

Agrupa transacciones bajo un request_id 

Agrupa transacciones SPEI/SPID en un mismo transaction_id, posteriormente genera la dirección URL del centro de autorización para la confirmación de las transacciones. <br><br>Las transacciones deben estar en estatus PENDING y pertenecer a un mismo contrato.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class CreateAuthorizationTransactionsGroupExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPEIApi();
            var body = new AuthorizationTransactionGroup(); // AuthorizationTransactionGroup | Objeto con la información para agrupar transacciones existentes y autorizarlas de forma conjunta.
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el Identificador de la suscripción.

            try
            {
                // Agrupa transacciones bajo un request_id 
                TokenRequiredResponse result = apiInstance.CreateAuthorizationTransactionsGroup(body, authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPEIApi.CreateAuthorizationTransactionsGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthorizationTransactionGroup**](AuthorizationTransactionGroup.md)| Objeto con la información para agrupar transacciones existentes y autorizarlas de forma conjunta. | 
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el Identificador de la suscripción. | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="droptransactionspendingusingdelete"></a>
# **DropTransactionsPendingUsingDELETE**
> void DropTransactionsPendingUsingDELETE (string authorization, string requestId, string subscription, string orderId = null)

Eliminación de transferencias SPEI® pendientes

Elimina un conjunto de transferencias en estado pendiente de confirmar o autorizar, en la cuenta del cliente Monex relacionada a la suscripción.<br><br><b>Nota:</b> Las transferencias no deben haber sido confirmadas o autorizadas por el cliente.

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
            var requestId = requestId_example;  // string | Identificador de las transferencias a eliminar.
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.
            var orderId = orderId_example;  // string | Listado de identificadores dentro del request_id para eliminar. (optional) 

            try
            {
                // Eliminación de transferencias SPEI® pendientes
                apiInstance.DropTransactionsPendingUsingDELETE(authorization, requestId, subscription, orderId);
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
 **requestId** | **string**| Identificador de las transferencias a eliminar. | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 
 **orderId** | **string**| Listado de identificadores dentro del request_id para eliminar. | [optional] 

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
> List<Deposit> IncomingSpeiTransactionsReportUsingGET (string authorization, string subscription, string beginDate = null, string endDate = null)

Consulta de transferencias recibidas

Realiza una consulta de las transferencias recibidas (depósitos) en la cuenta del cliente Monex relacionada a la suscripción, las transferencias que regresa este recuso son únicamente las transferencias  recibidas durante el día en el que se realiza la consulta. Para consultar transacciones que se encuentran en otras fechas se debe utilizar los parámetros de fecha inicial (beginDate) y fecha final (endDate), siempre deben de ir las dos ya que en caso de que falte una marcará error la consulta, si faltan las dos la consulta lanzará solo las del día, como se describe al inicio. El formato para las fechas es \"yyyy-MM-dd\"

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
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.
            var beginDate = beginDate_example;  // string | Fecha inicial para filtrar los depósitos, se espera en formato 'yyyy-MM-dd' (optional) 
            var endDate = endDate_example;  // string | Fecha final para filtrar los depósitos, se espera en formato 'yyyy-MM-dd' (optional) 

            try
            {
                // Consulta de transferencias recibidas
                List&lt;Deposit&gt; result = apiInstance.IncomingSpeiTransactionsReportUsingGET(authorization, subscription, beginDate, endDate);
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
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 
 **beginDate** | **string**| Fecha inicial para filtrar los depósitos, se espera en formato &#x27;yyyy-MM-dd&#x27; | [optional] 
 **endDate** | **string**| Fecha final para filtrar los depósitos, se espera en formato &#x27;yyyy-MM-dd&#x27; | [optional] 

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

Consulta las transferencias de salida registradas en una petición, las transferencias que regresa este recuso son únicamente las transferencias de salida agrupadas al identificador de la petición que se generó al hacer el registro de las transacciones el cuál se debe especificar como parte del path de este endpoint.

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
            var requestId = requestId_example;  // string | Identificador de la petición a buscar.
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

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
 **requestId** | **string**| Identificador de la petición a buscar. | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**PaymentsRequestId**](PaymentsRequestId.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="outcommingspeispidorderidtransactionreportusingget"></a>
# **OutCommingSpeiSpidOrderIdTransactionReportUsingGET**
> PaymentsSpeiAndSpidOrderId OutCommingSpeiSpidOrderIdTransactionReportUsingGET (string authorization, string subscription, string orderId = null)

Consulta de transferencias realizadas por order_id

Consulta las transferencias que regresa este recuso son únicamente las transferencias recibidas en el día en el que se realiza la consulta o las transferencias identificadas con el <strong>order_id</strong> proporcionado, para este tipo de consultas no importa el día en el que se realizó la transferencia. <br> Es importante que conozca que la respuesta puede dar como resultado un objeto con una lista spei o una lista spid con el/los elementos ya que un identificador order_id solo puede pertenecer a una transacción sea spei o spid.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class OutCommingSpeiSpidOrderIdTransactionReportUsingGETExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.
            var orderId = orderId_example;  // string | Es el identificador de la orden a buscar. (optional) 

            try
            {
                // Consulta de transferencias realizadas por order_id
                PaymentsSpeiAndSpidOrderId result = apiInstance.OutCommingSpeiSpidOrderIdTransactionReportUsingGET(authorization, subscription, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPEIApi.OutCommingSpeiSpidOrderIdTransactionReportUsingGET: " + e.Message );
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
 **orderId** | **string**| Es el identificador de la orden a buscar. | [optional] 

### Return type

[**PaymentsSpeiAndSpidOrderId**](PaymentsSpeiAndSpidOrderId.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="outcommingspeispidrequestidtransactionsreportusingget"></a>
# **OutCommingSpeiSpidRequestIdTransactionsReportUsingGET**
> PaymentsSpeiAndSpidRequestId OutCommingSpeiSpidRequestIdTransactionsReportUsingGET (string authorization, string requestId, string subscription)

Consulta de transferencias de salida por identificador de petición

Consulta las transferencias de salida registradas en una petición, las transferencias que regresa este recuso son únicamente las transferencias de salida agrupadas al identificador de la petición que se generó al hacer el registro de las transacciones el cuál se debe especificar como parte del path de este endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class OutCommingSpeiSpidRequestIdTransactionsReportUsingGETExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPEIApi();
            var authorization = authorization_example;  // string | Header para token
            var requestId = requestId_example;  // string | Identificador de la petición a buscar.
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Consulta de transferencias de salida por identificador de petición
                PaymentsSpeiAndSpidRequestId result = apiInstance.OutCommingSpeiSpidRequestIdTransactionsReportUsingGET(authorization, requestId, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPEIApi.OutCommingSpeiSpidRequestIdTransactionsReportUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **requestId** | **string**| Identificador de la petición a buscar. | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**PaymentsSpeiAndSpidRequestId**](PaymentsSpeiAndSpidRequestId.md)

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
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.
            var orderId = orderId_example;  // string | Es el identificador de la orden a buscar. (optional) 

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
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 
 **orderId** | **string**| Es el identificador de la orden a buscar. | [optional] 

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

Se registra un conjunto de transferencias (una o más) a realizar en la cuenta del cliente Monex relacionada a la suscripción. En la respuesta se proporcionará una dirección URL que lo llevará al centro de autorización para que las transferencias sean confirmadas (autorizadas) por el cliente para que se efectúen, para ello debe ingresar la llave electrónica (Token).<br>  Nota: Debe considerar que el concepto de cada una de las transacciones solo debe contener caracteres alfanuméricos por lo que en caso de que se reciban caracteres como ñ o acentos serán sustituidos por n o en su caso por la letra sin acento. Los caracteres no alfanuméricos como pueden ser caracteres especiales serán eliminados.

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
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

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
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerspeispidoutgoingtransactionsusingpost"></a>
# **RegisterSpeiSpidOutgoingTransactionsUsingPOST**
> TokenRequiredResponse RegisterSpeiSpidOutgoingTransactionsUsingPOST (TransactionsRegister body, string authorization, string subscription)

Registro de transferencias SPEI y SPID

Se registra un conjunto de transferencias (una o más) tanto SPEI como SPID en una sola petición en la cuenta del cliente Monex relacionada a la suscripción. En la respuesta se proporcionará una dirección URL que lo llevará al centro de autorización para que las transferencias sean confirmadas (autorizadas) por el cliente para que se efectúen, para ello debe ingresar la llave electrónica (Token).<br>  Nota: Debe considerar que el concepto de cada una de las transacciones solo debe contener caracteres alfanuméricos por lo que en caso de que se reciban caracteres como ñ o acentos serán sustituidos por n o en su caso por la letra sin acento. Los caracteres no alfanuméricos como pueden ser caracteres especiales serán eliminados.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RegisterSpeiSpidOutgoingTransactionsUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPEIApi();
            var body = new TransactionsRegister(); // TransactionsRegister | Información de las transferencias SPEI y SPID de salida
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Registro de transferencias SPEI y SPID
                TokenRequiredResponse result = apiInstance.RegisterSpeiSpidOutgoingTransactionsUsingPOST(body, authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPEIApi.RegisterSpeiSpidOutgoingTransactionsUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionsRegister**](TransactionsRegister.md)| Información de las transferencias SPEI y SPID de salida | 
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
