# MX.Wire4.Api.CuentasDeBeneficiariosSPIDApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PreRegisterAccountsUsingPOST1**](CuentasDeBeneficiariosSPIDApi.md#preregisteraccountsusingpost1) | **POST** /subscriptions/{subscription}/beneficiaries/spid | Pre-registro de cuentas de beneficiarios SPID

<a name="preregisteraccountsusingpost1"></a>
# **PreRegisterAccountsUsingPOST1**
> TokenRequiredResponse PreRegisterAccountsUsingPOST1 (AccountSpid body, string subscription)

Pre-registro de cuentas de beneficiarios SPID

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class PreRegisterAccountsUsingPOST1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: wire4_aut_app_user_spid
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CuentasDeBeneficiariosSPIDApi();
            var body = new AccountSpid(); // AccountSpid | Información de la cuenta del beneficiario
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Pre-registro de cuentas de beneficiarios SPID
                TokenRequiredResponse result = apiInstance.PreRegisterAccountsUsingPOST1(body, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CuentasDeBeneficiariosSPIDApi.PreRegisterAccountsUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountSpid**](AccountSpid.md)| Información de la cuenta del beneficiario | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

[wire4_aut_app_user_spid](../README.md#wire4_aut_app_user_spid)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
