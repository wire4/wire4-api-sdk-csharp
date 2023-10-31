# MX.Wire4.Api.OperacionesCoDiApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConsultCodiOperations**](OperacionesCoDiApi.md#consultcodioperations) | **POST** /codi/charges | Consulta de operaciones

<a name="consultcodioperations"></a>
# **ConsultCodiOperations**
> PagerResponseDto ConsultCodiOperations (string authorization, CodiOperationsFiltersRequestDTO body = null, string companyId = null, string page = null, string salesPointId = null, string size = null)

Consulta de operaciones

Obtiene las operaciones generadas a partir de peticiones de pago CODI® de forma paginada, pudiendo aplicar filtros.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class ConsultCodiOperationsExample
    {
        public void main()
        {
            var apiInstance = new OperacionesCoDiApi();
            var authorization = authorization_example;  // string | Header para token
            var body = new CodiOperationsFiltersRequestDTO(); // CodiOperationsFiltersRequestDTO | Filtros de busqueda (optional) 
            var companyId = companyId_example;  // string | Es el identificador de empresa CODI®. (optional) 
            var page = page_example;  // string | Es el número de pago. (optional)  (default to 0)
            var salesPointId = salesPointId_example;  // string | Es el identificador del punto de venta. (optional) 
            var size = size_example;  // string | Es el tamaño de página. (optional)  (default to 20)

            try
            {
                // Consulta de operaciones
                PagerResponseDto result = apiInstance.ConsultCodiOperations(authorization, body, companyId, page, salesPointId, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperacionesCoDiApi.ConsultCodiOperations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **body** | [**CodiOperationsFiltersRequestDTO**](CodiOperationsFiltersRequestDTO.md)| Filtros de busqueda | [optional] 
 **companyId** | **string**| Es el identificador de empresa CODI®. | [optional] 
 **page** | **string**| Es el número de pago. | [optional] [default to 0]
 **salesPointId** | **string**| Es el identificador del punto de venta. | [optional] 
 **size** | **string**| Es el tamaño de página. | [optional] [default to 20]

### Return type

[**PagerResponseDto**](PagerResponseDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
