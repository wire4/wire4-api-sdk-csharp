# MX.Wire4.Api.WebhooksApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWebhook**](WebhooksApi.md#getwebhook) | **GET** /webhooks/{id} | Consulta de Webhook
[**GetWebhooks**](WebhooksApi.md#getwebhooks) | **GET** /webhooks | Consulta la lista de Webhooks
[**RegisterWebhook**](WebhooksApi.md#registerwebhook) | **POST** /webhooks | Alta de Webhook

<a name="getwebhook"></a>
# **GetWebhook**
> WebhookResponse GetWebhook (string authorization, string webhookId)

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
            var apiInstance = new WebhooksApi();
            var authorization = authorization_example;  // string | Header para token
            var webhookId = webhookId_example;  // string | Es el identificador del webhook. Ejemplo: wh_54a932866f784b439bc625c0f4e04e12

            try
            {
                // Consulta de Webhook
                WebhookResponse result = apiInstance.GetWebhook(authorization, webhookId);
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
 **authorization** | **string**| Header para token | 
 **webhookId** | **string**| Es el identificador del webhook. Ejemplo: wh_54a932866f784b439bc625c0f4e04e12 | 

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhooks"></a>
# **GetWebhooks**
> WebhooksList GetWebhooks (string authorization)

Consulta la lista de Webhooks

Obtiene una lista de los webhooks registrados en la plataforma que tengan el estado (estatus)  Activo (ACTIVE) e Inactivo (INACTIVE).

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
            var apiInstance = new WebhooksApi();
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Consulta la lista de Webhooks
                WebhooksList result = apiInstance.GetWebhooks(authorization);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 

### Return type

[**WebhooksList**](WebhooksList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerwebhook"></a>
# **RegisterWebhook**
> WebhookResponse RegisterWebhook (WebhookRequest body, string authorization)

Alta de Webhook

Registra un webhook en la plataforma para su uso como notificador de eventos, cuándo estos ocurran.

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
            var apiInstance = new WebhooksApi();
            var body = new WebhookRequest(); // WebhookRequest | Información para registrar un Webhook
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Alta de Webhook
                WebhookResponse result = apiInstance.RegisterWebhook(body, authorization);
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
 **authorization** | **string**| Header para token | 

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
