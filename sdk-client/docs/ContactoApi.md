# MX.Wire4.Api.ContactoApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendContactUsingPOST**](ContactoApi.md#sendcontactusingpost) | **POST** /contact | Solicitud de contacto

<a name="sendcontactusingpost"></a>
# **SendContactUsingPOST**
> void SendContactUsingPOST (ContactRequest body, string authorization)

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
            var apiInstance = new ContactoApi();
            var body = new ContactRequest(); // ContactRequest | Información del contacto
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Solicitud de contacto
                apiInstance.SendContactUsingPOST(body, authorization);
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
 **authorization** | **string**| Header para token | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
