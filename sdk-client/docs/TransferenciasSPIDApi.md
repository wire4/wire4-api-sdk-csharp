# MX.Wire4.Api.TransferenciasSPIDApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSpidClassificationsUsingGET**](TransferenciasSPIDApi.md#getspidclassificationsusingget) | **GET** /subscriptions/{subscription}/beneficiaries/spid/classifications | Consulta las clasificaciones para operaciones con SPID
[**RegisterOutgoingSpidTransactionUsingPOST**](TransferenciasSPIDApi.md#registeroutgoingspidtransactionusingpost) | **POST** /subscriptions/{subscription}/transactions/outcoming/spid | Registro de transferencias SPID

<a name="getspidclassificationsusingget"></a>
# **GetSpidClassificationsUsingGET**
> SpidClassificationsResponseDTO GetSpidClassificationsUsingGET (string subscription)

Consulta las clasificaciones para operaciones con SPID

Obtiene las clasificaciones para operaciones con dólares (SPID) de Monex.<br/>Este recurso se debe invocar previo al realizar una operación SPID.<br/>Se requiere que el token de autenticación se genere con scope spid_admin.

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
            // Configure OAuth2 access token for authorization: wire4_aut_app_user_spid
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransferenciasSPIDApi();
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Consulta las clasificaciones para operaciones con SPID
                SpidClassificationsResponseDTO result = apiInstance.GetSpidClassificationsUsingGET(subscription);
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
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

[**SpidClassificationsResponseDTO**](SpidClassificationsResponseDTO.md)

### Authorization

[wire4_aut_app_user_spid](../README.md#wire4_aut_app_user_spid)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registeroutgoingspidtransactionusingpost"></a>
# **RegisterOutgoingSpidTransactionUsingPOST**
> TokenRequiredResponse RegisterOutgoingSpidTransactionUsingPOST (TransactionOutgoingSpid body, string subscription)

Registro de transferencias SPID

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
    public class RegisterOutgoingSpidTransactionUsingPOSTExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: wire4_aut_app_user_spid
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransferenciasSPIDApi();
            var body = new TransactionOutgoingSpid(); // TransactionOutgoingSpid | Información de las transferencias SPID de salida
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Registro de transferencias SPID
                TokenRequiredResponse result = apiInstance.RegisterOutgoingSpidTransactionUsingPOST(body, subscription);
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
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

[wire4_aut_app_user_spid](../README.md#wire4_aut_app_user_spid)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
