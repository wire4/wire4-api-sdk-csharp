# MX.Wire4.Api.TransferenciasSPIDApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSpidClassificationsUsingGET**](TransferenciasSPIDApi.md#getspidclassificationsusingget) | **GET** /subscriptions/{subscription}/beneficiaries/spid/classifications | Consulta de clasificaciones para operaciones SPID®
[**RegisterOutgoingSpidTransactionUsingPOST**](TransferenciasSPIDApi.md#registeroutgoingspidtransactionusingpost) | **POST** /subscriptions/{subscription}/transactions/outcoming/spid | Registro de transferencias SPID®

<a name="getspidclassificationsusingget"></a>
# **GetSpidClassificationsUsingGET**
> SpidClassificationsResponseDTO GetSpidClassificationsUsingGET (string authorization, string subscription)

Consulta de clasificaciones para operaciones SPID®

Obtiene las clasificaciones para operaciones con dólares (SPID®) de Monex.<br/><br/>Este recurso se debe invocar previo al realizar una operación SPID.<br/><br/>

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetSpidClassificationsUsingGETExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPIDApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Consulta de clasificaciones para operaciones SPID®
                SpidClassificationsResponseDTO result = apiInstance.GetSpidClassificationsUsingGET(authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPIDApi.GetSpidClassificationsUsingGET: " + e.Message );
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

[**SpidClassificationsResponseDTO**](SpidClassificationsResponseDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registeroutgoingspidtransactionusingpost"></a>
# **RegisterOutgoingSpidTransactionUsingPOST**
> TokenRequiredResponse RegisterOutgoingSpidTransactionUsingPOST (TransactionOutgoingSpid body, string authorization, string subscription)

Registro de transferencias SPID®

Registra un conjunto de transferencias a realizar en la cuenta del cliente Monex relacionada a la suscripción. En la respuesta se proporcionará una dirección URL que lo llevará al centro de autorización para que las transferencias sean confirmadas (autorizadas) por el cliente para que se efectúen, para ello debe ingresar la llave electrónica (Token).<br> Nota: Debe considerar que el concepto de cada una de las transacciones solo debe contener caracteres alfanuméricos por lo que en caso de que se reciban caracteres como ñ o acentos serán sustituidos por n o en su caso por la letra sin acento. Los caracteres no alfanuméricos como pueden ser caracteres especiales serán eliminados.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RegisterOutgoingSpidTransactionUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new TransferenciasSPIDApi();
            var body = new TransactionOutgoingSpid(); // TransactionOutgoingSpid | Información de las transferencias SPID de salida
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Registro de transferencias SPID®
                TokenRequiredResponse result = apiInstance.RegisterOutgoingSpidTransactionUsingPOST(body, authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferenciasSPIDApi.RegisterOutgoingSpidTransactionUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionOutgoingSpid**](TransactionOutgoingSpid.md)| Información de las transferencias SPID de salida | 
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
