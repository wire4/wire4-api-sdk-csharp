# MX.Wire4.Api.InstitucionesApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllInstitutionsUsingGET**](InstitucionesApi.md#getallinstitutionsusingget) | **GET** /institutions | Consulta de instituciones bancarias

<a name="getallinstitutionsusingget"></a>
# **GetAllInstitutionsUsingGET**
> InstitutionsList GetAllInstitutionsUsingGET (string authorization)

Consulta de instituciones bancarias

Se obtiene un listado de las instituciones bancarias y la información de cada una de estas.

### Example
```csharp
using System;
using System.Diagnostics;
using MX.Wire4.Api;
using MX.Wire4.Client;
using MX.Wire4.Model;

namespace Example
{
    public class GetAllInstitutionsUsingGETExample
    {
        public void main()
        {
            var apiInstance = new InstitucionesApi();
            var authorization = authorization_example;  // string | Header para token

            try
            {
                // Consulta de instituciones bancarias
                InstitutionsList result = apiInstance.GetAllInstitutionsUsingGET(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstitucionesApi.GetAllInstitutionsUsingGET: " + e.Message );
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

[**InstitutionsList**](InstitutionsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
