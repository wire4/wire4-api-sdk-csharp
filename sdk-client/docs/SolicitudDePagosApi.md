# MX.Wire4.Api.SolicitudDePagosApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RegisterPaymentRequestUsingPOST**](SolicitudDePagosApi.md#registerpaymentrequestusingpost) | **POST** /payment-request | Registro de solicitud de pagos

<a name="registerpaymentrequestusingpost"></a>
# **RegisterPaymentRequestUsingPOST**
> PaymentRequestResponse RegisterPaymentRequestUsingPOST (PaymentRequestReq body, string authorization)

Registro de solicitud de pagos

 Se registra una solicitud de pagos. En la respuesta se proporcionará una dirección URL que lo llevará al sitio donde se le solicitará ingresar los datos de tarjeta a la que se aplicarán los cargos.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RegisterPaymentRequestUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new SolicitudDePagosApi();
            var body = new PaymentRequestReq(); // PaymentRequestReq | Información de la solicitud de pagos
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Registro de solicitud de pagos
                PaymentRequestResponse result = apiInstance.RegisterPaymentRequestUsingPOST(body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SolicitudDePagosApi.RegisterPaymentRequestUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PaymentRequestReq**](PaymentRequestReq.md)| Información de la solicitud de pagos | 
 **authorization** | **string**| Header para token | 

### Return type

[**PaymentRequestResponse**](PaymentRequestResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
