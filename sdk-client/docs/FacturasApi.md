# MX.Wire4.Api.FacturasApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillingsReportByIdUsingGET**](FacturasApi.md#billingsreportbyidusingget) | **GET** /billings/{id} | Consulta de facturas por identificador
[**BillingsReportUsingGET**](FacturasApi.md#billingsreportusingget) | **GET** /billings | Consulta de facturas

<a name="billingsreportbyidusingget"></a>
# **BillingsReportByIdUsingGET**
> Billing BillingsReportByIdUsingGET (string id)

Consulta de facturas por identificador

Consulta las facturas emitidas por conceptos de uso de la plataforma y operaciones realizadas tanto de entrada como de salida. Se debe especificar el identificador de la factura

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class BillingsReportByIdUsingGETExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: wire4_aut_app
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FacturasApi();
            var id = id_example;  // string | Identificador de la factura

            try
            {
                // Consulta de facturas por identificador
                Billing result = apiInstance.BillingsReportByIdUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FacturasApi.BillingsReportByIdUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador de la factura | 

### Return type

[**Billing**](Billing.md)

### Authorization

[wire4_aut_app](../README.md#wire4_aut_app)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="billingsreportusingget"></a>
# **BillingsReportUsingGET**
> List<Billing> BillingsReportUsingGET (string period = null)

Consulta de facturas

Consulta las facturas emitidas por conceptos de uso de la plataforma y operaciones realizadas tanto de entrada como de salida. Es posible filtrar por periodo de fecha yyyy-MM, por ejemplo 2019-11

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class BillingsReportUsingGETExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: wire4_aut_app
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FacturasApi();
            var period = period_example;  // string | Filtro de fecha yyyy-MM (optional) 

            try
            {
                // Consulta de facturas
                List&lt;Billing&gt; result = apiInstance.BillingsReportUsingGET(period);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FacturasApi.BillingsReportUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **period** | **string**| Filtro de fecha yyyy-MM | [optional] 

### Return type

[**List<Billing>**](Billing.md)

### Authorization

[wire4_aut_app](../README.md#wire4_aut_app)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
