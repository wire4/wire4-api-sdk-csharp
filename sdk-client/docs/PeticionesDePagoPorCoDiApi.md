# MX.Wire4.Api.PeticionesDePagoPorCoDiApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConsultCodiRequestByOrderId**](PeticionesDePagoPorCoDiApi.md#consultcodirequestbyorderid) | **GET** /codi/sales-point/charges | Consulta información de petición por orderId
[**GenerateCodiCodeQR**](PeticionesDePagoPorCoDiApi.md#generatecodicodeqr) | **POST** /codi/sales-point/charges | Genera código QR

<a name="consultcodirequestbyorderid"></a>
# **ConsultCodiRequestByOrderId**
> PaymentRequestCodiResponseDTO ConsultCodiRequestByOrderId (string authorization, string orderId, string salesPointId)

Consulta información de petición por orderId

Obtiene la información de una petición de pago CODI® por orderId para un punto de venta.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class ConsultCodiRequestByOrderIdExample
    {
        public void main()
        {
            var apiInstance = new PeticionesDePagoPorCoDiApi();
            var authorization = authorization_example;  // string | Header para token
            var orderId = orderId_example;  // string | Identificador del pago CODI®
            var salesPointId = salesPointId_example;  // string | Identificador del punto de venta

            try
            {
                // Consulta información de petición por orderId
                PaymentRequestCodiResponseDTO result = apiInstance.ConsultCodiRequestByOrderId(authorization, orderId, salesPointId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeticionesDePagoPorCoDiApi.ConsultCodiRequestByOrderId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **orderId** | **string**| Identificador del pago CODI® | 
 **salesPointId** | **string**| Identificador del punto de venta | 

### Return type

[**PaymentRequestCodiResponseDTO**](PaymentRequestCodiResponseDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="generatecodicodeqr"></a>
# **GenerateCodiCodeQR**
> CodiCodeQrResponseDTO GenerateCodiCodeQR (CodiCodeRequestDTO body, string authorization, string salesPointId)

Genera código QR

Genera un código QR solicitado por un punto de venta para un pago mediante CODI®

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GenerateCodiCodeQRExample
    {
        public void main()
        {
            var apiInstance = new PeticionesDePagoPorCoDiApi();
            var body = new CodiCodeRequestDTO(); // CodiCodeRequestDTO | Información del pago CODI®
            var authorization = authorization_example;  // string | Header para token
            var salesPointId = salesPointId_example;  // string | Identificador del punto de venta

            try
            {
                // Genera código QR
                CodiCodeQrResponseDTO result = apiInstance.GenerateCodiCodeQR(body, authorization, salesPointId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeticionesDePagoPorCoDiApi.GenerateCodiCodeQR: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CodiCodeRequestDTO**](CodiCodeRequestDTO.md)| Información del pago CODI® | 
 **authorization** | **string**| Header para token | 
 **salesPointId** | **string**| Identificador del punto de venta | 

### Return type

[**CodiCodeQrResponseDTO**](CodiCodeQrResponseDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
