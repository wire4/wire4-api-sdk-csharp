# MX.Wire4.Api.PuntosDeVentaCoDiApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSalesPoint**](PuntosDeVentaCoDiApi.md#createsalespoint) | **POST** /codi/companies/{company_id}/salespoint | Registra un punto de venta asociado a una empresa
[**ObtainSalePoints**](PuntosDeVentaCoDiApi.md#obtainsalepoints) | **GET** /codi/companies/{company_id}/salespoint | Obtiene los puntos de venta asociados a una empresa

<a name="createsalespoint"></a>
# **CreateSalesPoint**
> SalesPointRespose CreateSalesPoint (SalesPointRequest body, string authorization, string companyId, string name = null)

Registra un punto de venta asociado a una empresa

Registra un punto de venta desde donde se emitaran los cobros CODI®, el punto de venta se debe asociar a un cuenta cableregistrada previamente ante Banxico para realizar cobros con CODI®

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class CreateSalesPointExample
    {
        public void main()
        {
            var apiInstance = new PuntosDeVentaCoDiApi();
            var body = new SalesPointRequest(); // SalesPointRequest | salesPointRequest
            var authorization = authorization_example;  // string | Header para token
            var companyId = companyId_example;  // string | company_id
            var name = name_example;  // string |  (optional) 

            try
            {
                // Registra un punto de venta asociado a una empresa
                SalesPointRespose result = apiInstance.CreateSalesPoint(body, authorization, companyId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PuntosDeVentaCoDiApi.CreateSalesPoint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalesPointRequest**](SalesPointRequest.md)| salesPointRequest | 
 **authorization** | **string**| Header para token | 
 **companyId** | **string**| company_id | 
 **name** | **string**|  | [optional] 

### Return type

[**SalesPointRespose**](SalesPointRespose.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="obtainsalepoints"></a>
# **ObtainSalePoints**
> List<SalesPointFound> ObtainSalePoints (string authorization, string companyId)

Obtiene los puntos de venta asociados a una empresa

Obtiene los puntos de venta asociados a una empresa en las cuales se hacen operaciones CODI®

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class ObtainSalePointsExample
    {
        public void main()
        {
            var apiInstance = new PuntosDeVentaCoDiApi();
            var authorization = authorization_example;  // string | Header para token
            var companyId = companyId_example;  // string | El identificador de la empresa

            try
            {
                // Obtiene los puntos de venta asociados a una empresa
                List&lt;SalesPointFound&gt; result = apiInstance.ObtainSalePoints(authorization, companyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PuntosDeVentaCoDiApi.ObtainSalePoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **companyId** | **string**| El identificador de la empresa | 

### Return type

[**List<SalesPointFound>**](SalesPointFound.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
