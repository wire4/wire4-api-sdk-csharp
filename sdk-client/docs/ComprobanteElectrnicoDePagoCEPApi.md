# MX.Wire4.Api.ComprobanteElectrnicoDePagoCEPApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ObtainTransactionCepUsingPOST**](ComprobanteElectrnicoDePagoCEPApi.md#obtaintransactioncepusingpost) | **POST** /ceps | Consulta de CEP

<a name="obtaintransactioncepusingpost"></a>
# **ObtainTransactionCepUsingPOST**
> CepResponse ObtainTransactionCepUsingPOST (CepSearchBanxico body, string authorization)

Consulta de CEP

Consulta el CEP de un pago realizado a través del SPEI, si es que este se encuentra disponible en BANXICO.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class ObtainTransactionCepUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new ComprobanteElectrnicoDePagoCEPApi();
            var body = new CepSearchBanxico(); // CepSearchBanxico | Información para buscar un CEP
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Consulta de CEP
                CepResponse result = apiInstance.ObtainTransactionCepUsingPOST(body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComprobanteElectrnicoDePagoCEPApi.ObtainTransactionCepUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CepSearchBanxico**](CepSearchBanxico.md)| Información para buscar un CEP | 
 **authorization** | **string**| Header para token | 

### Return type

[**CepResponse**](CepResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
