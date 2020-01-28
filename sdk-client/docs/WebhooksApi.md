# MX.Wire4.Api.WebhooksApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWebhook**](WebhooksApi.md#getwebhook) | **GET** /webhooks/{id} | Consulta de Webhook
[**GetWebhooks**](WebhooksApi.md#getwebhooks) | **GET** /webhooks | Consulta de Webhooks
[**RegisterWebhook**](WebhooksApi.md#registerwebhook) | **POST** /webhooks | Alta de Webhook

<a name="getwebhook"></a>
# **GetWebhook**
> WebhookResponse GetWebhook (string id)

Consulta de Webhook

Obtiene un webhook registrado en la plataforma mediante su identificador.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetWebhookExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: wire4_aut_app
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var id = id_example;  // string | Identificador del webhook

            try
            {
                // Consulta de Webhook
                WebhookResponse result = apiInstance.GetWebhook(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identificador del webhook | 

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

[wire4_aut_app](../README.md#wire4_aut_app)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhooks"></a>
# **GetWebhooks**
> WebhooksList GetWebhooks ()

Consulta de Webhooks

Obtiene los webhooks registrados en la plataforma que tengan estatus 'ACTIVE' e 'INACTIVE'.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: wire4_aut_app
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();

            try
            {
                // Consulta de Webhooks
                WebhooksList result = apiInstance.GetWebhooks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WebhooksList**](WebhooksList.md)

### Authorization

[wire4_aut_app](../README.md#wire4_aut_app)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerwebhook"></a>
# **RegisterWebhook**
> WebhookResponse RegisterWebhook (WebhookRequest body)

Alta de Webhook

Registra un webhook en la plataforma para su uso como notificador de eventos cuando estos ocurran.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RegisterWebhookExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: wire4_aut_app
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var body = new WebhookRequest(); // WebhookRequest | Información para registrar un Webhook

            try
            {
                // Alta de Webhook
                WebhookResponse result = apiInstance.RegisterWebhook(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.RegisterWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhookRequest**](WebhookRequest.md)| Información para registrar un Webhook | 

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

[wire4_aut_app](../README.md#wire4_aut_app)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
