# MX.Wire4.Api.DepositantesApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDepositantsUsingGET**](DepositantesApi.md#getdepositantsusingget) | **GET** /subscriptions/{subscription}/depositants | Consulta de cuentas de depositantes
[**RegisterDepositantsUsingPOST**](DepositantesApi.md#registerdepositantsusingpost) | **POST** /subscriptions/{subscription}/depositants | Registra un nuevo depositante

<a name="getdepositantsusingget"></a>
# **GetDepositantsUsingGET**
> GetDepositants GetDepositantsUsingGET (string authorization, string subscription)

Consulta de cuentas de depositantes

Obtiene una lista de depositantes asociados al contrato relacionado a la suscripción.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetDepositantsUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DepositantesApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Consulta de cuentas de depositantes
                GetDepositants result = apiInstance.GetDepositantsUsingGET(authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositantesApi.GetDepositantsUsingGET: " + e.Message );
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

[**GetDepositants**](GetDepositants.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerdepositantsusingpost"></a>
# **RegisterDepositantsUsingPOST**
> DepositantsResponse RegisterDepositantsUsingPOST (DepositantsRegister body, string authorization, string subscription)

Registra un nuevo depositante

Registra un nuevo depositante en el contrato asociado a la suscripción.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RegisterDepositantsUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new DepositantesApi();
            var body = new DepositantsRegister(); // DepositantsRegister | Depositant info
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Registra un nuevo depositante
                DepositantsResponse result = apiInstance.RegisterDepositantsUsingPOST(body, authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositantesApi.RegisterDepositantsUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DepositantsRegister**](DepositantsRegister.md)| Depositant info | 
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**DepositantsResponse**](DepositantsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
