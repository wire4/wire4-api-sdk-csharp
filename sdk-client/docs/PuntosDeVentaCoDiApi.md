# MX.Wire4.Api.PuntosDeVentaCoDiApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSalesPoint**](PuntosDeVentaCoDiApi.md#createsalespoint) | **POST** /codi/companies/salespoint | Registro de punto de venta.
[**ObtainSalePoints**](PuntosDeVentaCoDiApi.md#obtainsalepoints) | **GET** /codi/companies/salespoint | Consulta de puntos de venta

<a name="createsalespoint"></a>
# **CreateSalesPoint**
> SalesPointRespose CreateSalesPoint (SalesPointRequest body, string authorization, string companyId)

Registro de punto de venta.

Se registra un punto de venta (TPV) desde donde se emitarán los cobros CODI®. El punto de venta se debe asociar a un cuenta CLABE registrada previamente ante Banxico para realizar cobros con CODI®.

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
            var body = new SalesPointRequest(); // SalesPointRequest | Es el objeto que contiene información del punto de venta CODI®.
            var authorization = authorization_example;  // string | Header para token
            var companyId = companyId_example;  // string | Es el identificador de la empresa.

            try
            {
                // Registro de punto de venta.
                SalesPointRespose result = apiInstance.CreateSalesPoint(body, authorization, companyId);
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
 **body** | [**SalesPointRequest**](SalesPointRequest.md)| Es el objeto que contiene información del punto de venta CODI®. | 
 **authorization** | **string**| Header para token | 
 **companyId** | **string**| Es el identificador de la empresa. | 

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

Consulta de puntos de venta

Obtiene los puntos de venta asociados a una empresa en las cuales se hacen operaciones CODI®.

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
            var companyId = companyId_example;  // string | Es el identificador de la empresa. Ejemplo: 8838d513-5916-4662-bb30-2448f0f543ed

            try
            {
                // Consulta de puntos de venta
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
 **companyId** | **string**| Es el identificador de la empresa. Ejemplo: 8838d513-5916-4662-bb30-2448f0f543ed | 

### Return type

[**List<SalesPointFound>**](SalesPointFound.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
