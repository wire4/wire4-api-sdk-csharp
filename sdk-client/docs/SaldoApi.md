# MX.Wire4.Api.SaldoApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBalanceUsingGET**](SaldoApi.md#getbalanceusingget) | **GET** /subscriptions/{subscription}/balance | Consulta los saldo de una cuenta

<a name="getbalanceusingget"></a>
# **GetBalanceUsingGET**
> BalanceListResponse GetBalanceUsingGET (string authorization, string subscription)

Consulta los saldo de una cuenta

Obtiene el de las divisas que se manejen en el contrato.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetBalanceUsingGETExample
    {
        public void main()
        {
            var apiInstance = new SaldoApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Consulta los saldo de una cuenta
                BalanceListResponse result = apiInstance.GetBalanceUsingGET(authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SaldoApi.GetBalanceUsingGET: " + e.Message );
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

[**BalanceListResponse**](BalanceListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
