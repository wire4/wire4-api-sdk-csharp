# MX.Wire4.Api.DepositantesApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDepositantsTotalsUsingGET**](DepositantesApi.md#getdepositantstotalsusingget) | **GET** /subscriptions/{subscription}/depositants/count | Número de depositantes por suscripción
[**GetDepositantsUsingGET**](DepositantesApi.md#getdepositantsusingget) | **GET** /subscriptions/{subscription}/depositants | Consulta de cuentas de depositantes
[**RegisterDepositantsUsingPOST**](DepositantesApi.md#registerdepositantsusingpost) | **POST** /subscriptions/{subscription}/depositants | Registra un nuevo depositante
[**UpdateStatusDepositantsNoSuscrptionUsingPATCH**](DepositantesApi.md#updatestatusdepositantsnosuscrptionusingpatch) | **PATCH** /depositants/{account}/{action} | Solicitud para actualizar el estado de un depositante sin utilizar la suscripción
[**UpdateStatusDepositantsUsingPATCH**](DepositantesApi.md#updatestatusdepositantsusingpatch) | **PATCH** /subscriptions/{subscription}/depositants/{account}/{action} | Solicitud para actualizar el estado de un depossitante

<a name="getdepositantstotalsusingget"></a>
# **GetDepositantsTotalsUsingGET**
> DepositantCountResponse GetDepositantsTotalsUsingGET (string authorization, string subscription)

Número de depositantes por suscripción

Obtiene la cantidad el total de depositantes asociados al contrato relacionado a la suscripción.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetDepositantsTotalsUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DepositantesApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Número de depositantes por suscripción
                DepositantCountResponse result = apiInstance.GetDepositantsTotalsUsingGET(authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositantesApi.GetDepositantsTotalsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**DepositantCountResponse**](DepositantCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdepositantsusingget"></a>
# **GetDepositantsUsingGET**
> GetDepositants GetDepositantsUsingGET (string authorization, string subscription)

Consulta de cuentas de depositantes

Obtiene una lista de depositantes asociados al contrato relacionado a la suscripción.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetDepositantsUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DepositantesApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Consulta de cuentas de depositantes
                GetDepositants result = apiInstance.GetDepositantsUsingGET(authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositantesApi.GetDepositantsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**GetDepositants**](GetDepositants.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerdepositantsusingpost"></a>
# **RegisterDepositantsUsingPOST**
> DepositantsResponse RegisterDepositantsUsingPOST (DepositantsRegister body, string authorization, string subscription)

Registra un nuevo depositante

Registra un nuevo depositante en el contrato asociado a la suscripción. Si intenta registrar un depositante que previamente se había registrado, se devolverá la cuenta clabe asociada al Álias que está intentando registrar. Queda bajo responsabilidad del cliente verificar que los álias sean únicos en sus sistemas.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RegisterDepositantsUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new DepositantesApi();
            var body = new DepositantsRegister(); // DepositantsRegister | Depositant info
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Registra un nuevo depositante
                DepositantsResponse result = apiInstance.RegisterDepositantsUsingPOST(body, authorization, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositantesApi.RegisterDepositantsUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DepositantsRegister**](DepositantsRegister.md)| Depositant info | 
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**DepositantsResponse**](DepositantsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatestatusdepositantsnosuscrptionusingpatch"></a>
# **UpdateStatusDepositantsNoSuscrptionUsingPATCH**
> Depositant UpdateStatusDepositantsNoSuscrptionUsingPATCH (string authorization, string account, string action, string body = null)

Solicitud para actualizar el estado de un depositante sin utilizar la suscripción

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class UpdateStatusDepositantsNoSuscrptionUsingPATCHExample
    {
        public void main()
        {
            var apiInstance = new DepositantesApi();
            var authorization = authorization_example;  // string | Header para token
            var account = account_example;  // string | Es la cuenta que va a ser actualizada.
            var action = action_example;  // string | Es la cuenta que va a ser actualizada.
            var body = new string(); // string | Empty value (optional) 

            try
            {
                // Solicitud para actualizar el estado de un depositante sin utilizar la suscripción
                Depositant result = apiInstance.UpdateStatusDepositantsNoSuscrptionUsingPATCH(authorization, account, action, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositantesApi.UpdateStatusDepositantsNoSuscrptionUsingPATCH: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **account** | **string**| Es la cuenta que va a ser actualizada. | 
 **action** | **string**| Es la cuenta que va a ser actualizada. | 
 **body** | [**string**](string.md)| Empty value | [optional] 

### Return type

[**Depositant**](Depositant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatestatusdepositantsusingpatch"></a>
# **UpdateStatusDepositantsUsingPATCH**
> Depositant UpdateStatusDepositantsUsingPATCH (string authorization, string account, string action, string body = null)

Solicitud para actualizar el estado de un depossitante

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class UpdateStatusDepositantsUsingPATCHExample
    {
        public void main()
        {
            var apiInstance = new DepositantesApi();
            var authorization = authorization_example;  // string | Header para token
            var account = account_example;  // string | Es la cuenta que va a ser actualizada.
            var action = action_example;  // string | Es la cuenta que va a ser actualizada.
            var body = new string(); // string | Empty value (optional) 

            try
            {
                // Solicitud para actualizar el estado de un depossitante
                Depositant result = apiInstance.UpdateStatusDepositantsUsingPATCH(authorization, account, action, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositantesApi.UpdateStatusDepositantsUsingPATCH: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **account** | **string**| Es la cuenta que va a ser actualizada. | 
 **action** | **string**| Es la cuenta que va a ser actualizada. | 
 **body** | [**string**](string.md)| Empty value | [optional] 

### Return type

[**Depositant**](Depositant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
