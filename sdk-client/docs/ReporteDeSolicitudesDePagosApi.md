# MX.Wire4.Api.ReporteDeSolicitudesDePagosApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PaymentRequestIdReportByOrderIdUsingGET**](ReporteDeSolicitudesDePagosApi.md#paymentrequestidreportbyorderidusingget) | **GET** /payment-request | Consulta de solicitudes de pago por numero de orden.
[**PaymentRequestIdReportUsingGET**](ReporteDeSolicitudesDePagosApi.md#paymentrequestidreportusingget) | **GET** /payment-request/{requestId} | Consulta de solicitudes de pago por identificador de petición

<a name="paymentrequestidreportbyorderidusingget"></a>
# **PaymentRequestIdReportByOrderIdUsingGET**
> PaymentRequestReportDTO PaymentRequestIdReportByOrderIdUsingGET (string authorization, string orderId = null)

Consulta de solicitudes de pago por numero de orden.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class PaymentRequestIdReportByOrderIdUsingGETExample
    {
        public void main()
        {
            var apiInstance = new ReporteDeSolicitudesDePagosApi();
            var authorization = authorization_example;  // string | Header para token
            var orderId = orderId_example;  // string | Es el identificador de la orden a buscar. (optional) 

            try
            {
                // Consulta de solicitudes de pago por numero de orden.
                PaymentRequestReportDTO result = apiInstance.PaymentRequestIdReportByOrderIdUsingGET(authorization, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReporteDeSolicitudesDePagosApi.PaymentRequestIdReportByOrderIdUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **orderId** | **string**| Es el identificador de la orden a buscar. | [optional] 

### Return type

[**PaymentRequestReportDTO**](PaymentRequestReportDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="paymentrequestidreportusingget"></a>
# **PaymentRequestIdReportUsingGET**
> PaymentRequestReportDTO PaymentRequestIdReportUsingGET (string authorization, string requestId)

Consulta de solicitudes de pago por identificador de petición

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class PaymentRequestIdReportUsingGETExample
    {
        public void main()
        {
            var apiInstance = new ReporteDeSolicitudesDePagosApi();
            var authorization = authorization_example;  // string | Header para token
            var requestId = requestId_example;  // string | Identificador de la petición a buscar.

            try
            {
                // Consulta de solicitudes de pago por identificador de petición
                PaymentRequestReportDTO result = apiInstance.PaymentRequestIdReportUsingGET(authorization, requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReporteDeSolicitudesDePagosApi.PaymentRequestIdReportUsingGET: " + e.Message );
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

### Return type

[**PaymentRequestReportDTO**](PaymentRequestReportDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
