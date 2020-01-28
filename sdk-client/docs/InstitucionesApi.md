# MX.Wire4.Api.InstitucionesApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllInstitutionsUsingGET**](InstitucionesApi.md#getallinstitutionsusingget) | **GET** /institutions | Información de instituciones bancarias.

<a name="getallinstitutionsusingget"></a>
# **GetAllInstitutionsUsingGET**
> InstitutionsList GetAllInstitutionsUsingGET ()

Información de instituciones bancarias.

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
            // Configure OAuth2 access token for authorization: wire4_aut_app
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstitucionesApi();

            try
            {
                // Información de instituciones bancarias.
                InstitutionsList result = apiInstance.GetAllInstitutionsUsingGET();
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
This endpoint does not need any parameter.

### Return type

[**InstitutionsList**](InstitutionsList.md)

### Authorization

[wire4_aut_app](../README.md#wire4_aut_app)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
