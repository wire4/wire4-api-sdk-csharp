# MX.Wire4.Api.CuentasDeBeneficiariosSPIDApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSpidBeneficiariesForAccount**](CuentasDeBeneficiariosSPIDApi.md#getspidbeneficiariesforaccount) | **GET** /subscriptions/{subscription}/beneficiaries/spid | Consulta los beneficiarios SPID registrados
[**PreRegisterAccountsUsingPOST1**](CuentasDeBeneficiariosSPIDApi.md#preregisteraccountsusingpost1) | **POST** /subscriptions/{subscription}/beneficiaries/spid | Pre-registro de cuentas de beneficiarios SPID

<a name="getspidbeneficiariesforaccount"></a>
# **GetSpidBeneficiariesForAccount**
> SpidBeneficiariesResponse GetSpidBeneficiariesForAccount (string authorization, string subscription, string account = null, string beneficiaryBank = null, string beneficiaryName = null, string endDate = null, string initDate = null, string rfc = null, string status = null)

Consulta los beneficiarios SPID registrados

Obtiene los beneficiarios SPID registrados al contrato relacionado con la suscripción, Los beneficiarios son los que actualmente se encuentran registrados en banca Monex.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetSpidBeneficiariesForAccountExample
    {
        public void main()
        {
            var apiInstance = new CuentasDeBeneficiariosSPIDApi();
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API
            var account = account_example;  // string | Cuenta del beneficiario, puede ser Clabe, TDD o Celular (optional) 
            var beneficiaryBank = beneficiaryBank_example;  // string | Clave del banco beneficiario (optional) 
            var beneficiaryName = beneficiaryName_example;  // string | Nombre del beneficiario (optional) 
            var endDate = endDate_example;  // string | Fecha de inicio del perido a filtrar en formato dd-mm-yyyy (optional) 
            var initDate = initDate_example;  // string | Fecha de inicio del perido a filtrar en formato dd-mm-yyyy (optional) 
            var rfc = rfc_example;  // string | RFC del beneficiario (optional) 
            var status = status_example;  // string | Estatus de la cuenta (optional) 

            try
            {
                // Consulta los beneficiarios SPID registrados
                SpidBeneficiariesResponse result = apiInstance.GetSpidBeneficiariesForAccount(authorization, subscription, account, beneficiaryBank, beneficiaryName, endDate, initDate, rfc, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CuentasDeBeneficiariosSPIDApi.GetSpidBeneficiariesForAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 
 **account** | **string**| Cuenta del beneficiario, puede ser Clabe, TDD o Celular | [optional] 
 **beneficiaryBank** | **string**| Clave del banco beneficiario | [optional] 
 **beneficiaryName** | **string**| Nombre del beneficiario | [optional] 
 **endDate** | **string**| Fecha de inicio del perido a filtrar en formato dd-mm-yyyy | [optional] 
 **initDate** | **string**| Fecha de inicio del perido a filtrar en formato dd-mm-yyyy | [optional] 
 **rfc** | **string**| RFC del beneficiario | [optional] 
 **status** | **string**| Estatus de la cuenta | [optional] 

### Return type

[**SpidBeneficiariesResponse**](SpidBeneficiariesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="preregisteraccountsusingpost1"></a>
# **PreRegisterAccountsUsingPOST1**
> TokenRequiredResponse PreRegisterAccountsUsingPOST1 (AccountSpid body, string authorization, string subscription)

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
            var apiInstance = new CuentasDeBeneficiariosSPIDApi();
            var body = new AccountSpid(); // AccountSpid | Información de la cuenta del beneficiario
            var authorization = authorization_example;  // string | Header para token
            var subscription = subscription_example;  // string | El identificador de la suscripción a esta API

            try
            {
                // Pre-registro de cuentas de beneficiarios SPID
                TokenRequiredResponse result = apiInstance.PreRegisterAccountsUsingPOST1(body, authorization, subscription);
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
 **authorization** | **string**| Header para token | 
 **subscription** | **string**| El identificador de la suscripción a esta API | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
