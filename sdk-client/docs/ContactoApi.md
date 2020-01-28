# MX.Wire4.Api.ContactoApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendContactUsingPOST**](ContactoApi.md#sendcontactusingpost) | **POST** /contact | Solicitud de contacto

<a name="sendcontactusingpost"></a>
# **SendContactUsingPOST**
> void SendContactUsingPOST (ContactRequest body)

Solicitud de contacto

Notifica a un asesor Monex para que se ponga en contacto con un posible cliente.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class SendContactUsingPOSTExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: wire4_aut_app
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactoApi();
            var body = new ContactRequest(); // ContactRequest | Información del contacto

            try
            {
                // Solicitud de contacto
                apiInstance.SendContactUsingPOST(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactoApi.SendContactUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactRequest**](ContactRequest.md)| Información del contacto | 

### Return type

void (empty response body)

### Authorization

[wire4_aut_app](../README.md#wire4_aut_app)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
