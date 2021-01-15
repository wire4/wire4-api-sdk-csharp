# MX.Wire4.Api.EmpresasCoDiApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ObtainCompanies**](EmpresasCoDiApi.md#obtaincompanies) | **GET** /codi/companies | Consulta de empresas CODI®
[**RegisterCompanyUsingPOST**](EmpresasCoDiApi.md#registercompanyusingpost) | **POST** /codi/companies | Registro de empresas CODI®

<a name="obtaincompanies"></a>
# **ObtainCompanies**
> List<CompanyRegistered> ObtainCompanies (string authorization)

Consulta de empresas CODI®

Consulta de empresas CODI® registradas para la aplicación.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class ObtainCompaniesExample
    {
        public void main()
        {
            var apiInstance = new EmpresasCoDiApi();
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Consulta de empresas CODI®
                List&lt;CompanyRegistered&gt; result = apiInstance.ObtainCompanies(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasCoDiApi.ObtainCompanies: " + e.Message );
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

[**List<CompanyRegistered>**](CompanyRegistered.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registercompanyusingpost"></a>
# **RegisterCompanyUsingPOST**
> CompanyRegistered RegisterCompanyUsingPOST (CompanyRequested body, string authorization)

Registro de empresas CODI®

Registra una empresa para hacer uso de operaciones CODI®.<br><br> <b>Nota:<b> Es requerido tener el certificado emitido por BANXICO® asi como el Nombre de la empresa, Nombre comercial y el Registro Federal de Contribuyentes (RFC) de la empresa.<br/>

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class RegisterCompanyUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new EmpresasCoDiApi();
            var body = new CompanyRequested(); // CompanyRequested | Información de la cuenta del beneficiario
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Registro de empresas CODI®
                CompanyRegistered result = apiInstance.RegisterCompanyUsingPOST(body, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasCoDiApi.RegisterCompanyUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyRequested**](CompanyRequested.md)| Información de la cuenta del beneficiario | 
 **authorization** | **string**| Header para token | 

### Return type

[**CompanyRegistered**](CompanyRegistered.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
