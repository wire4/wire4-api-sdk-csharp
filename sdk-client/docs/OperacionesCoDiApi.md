# MX.Wire4.Api.OperacionesCoDiApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConsultCodiOperations**](OperacionesCoDiApi.md#consultcodioperations) | **POST** /codi/charges | Obtiene las operaciones generadas a partir de peticiones de pago CoDi® de forma paginada, pudiendo aplicar filtros

<a name="consultcodioperations"></a>
# **ConsultCodiOperations**
> PagerResponseDto ConsultCodiOperations (string authorization, CodiOperationsFiltersRequestDTO body = null, string companyId = null, string page = null, string salesPointId = null, string size = null)

Obtiene las operaciones generadas a partir de peticiones de pago CoDi® de forma paginada, pudiendo aplicar filtros

Obtiene las operaciones generadas a partir de peticiones de pago CoDi® de forma paginada, pudiendo aplicar filtros

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
            var companyId = companyId_example;  // string | Identificador de empresa CoDi (optional) 
            var page = page_example;  // string | Número de pago (optional) 
            var salesPointId = salesPointId_example;  // string | Identificador del punto de venta (optional) 
            var size = size_example;  // string | Tamaño de pagina (optional) 

            try
            {
                // Obtiene las operaciones generadas a partir de peticiones de pago CoDi® de forma paginada, pudiendo aplicar filtros
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
 **companyId** | **string**| Identificador de empresa CoDi | [optional] 
 **page** | **string**| Número de pago | [optional] 
 **salesPointId** | **string**| Identificador del punto de venta | [optional] 
 **size** | **string**| Tamaño de pagina | [optional] 

### Return type

[**PagerResponseDto**](PagerResponseDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
