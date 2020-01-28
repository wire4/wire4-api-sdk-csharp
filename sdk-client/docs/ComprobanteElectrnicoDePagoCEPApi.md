# MX.Wire4.Api.ComprobanteElectrnicoDePagoCEPApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ObtainTransactionCepUsingPOST**](ComprobanteElectrnicoDePagoCEPApi.md#obtaintransactioncepusingpost) | **POST** /ceps | Consulta de CEP

<a name="obtaintransactioncepusingpost"></a>
# **ObtainTransactionCepUsingPOST**
> CepResponse ObtainTransactionCepUsingPOST (CepSearchBanxico body)

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
            // Configure OAuth2 access token for authorization: wire4_aut_app
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComprobanteElectrnicoDePagoCEPApi();
            var body = new CepSearchBanxico(); // CepSearchBanxico | Información para buscar un CEP

            try
            {
                // Consulta de CEP
                CepResponse result = apiInstance.ObtainTransactionCepUsingPOST(body);
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

### Return type

[**CepResponse**](CepResponse.md)

### Authorization

[wire4_aut_app](../README.md#wire4_aut_app)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
