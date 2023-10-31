# MX.Wire4.Api.CuentasDeBeneficiariosSPIDApi

All URIs are relative to *https://sandbox-api.wire4.mx/wire4/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSpidBeneficiariesForAccount**](CuentasDeBeneficiariosSPIDApi.md#getspidbeneficiariesforaccount) | **GET** /subscriptions/{subscription}/beneficiaries/spid | Consulta los beneficiarios SPID registrados
[**PreRegisterAccountsUsingPOST1**](CuentasDeBeneficiariosSPIDApi.md#preregisteraccountsusingpost1) | **POST** /subscriptions/{subscription}/beneficiaries/spid | Pre-registro de cuentas de beneficiarios SPID®

<a name="getspidbeneficiariesforaccount"></a>
# **GetSpidBeneficiariesForAccount**
> SpidBeneficiariesResponse GetSpidBeneficiariesForAccount (string authorization, string subscription, string account = null, string beneficiaryBank = null, string beneficiaryName = null, string endDate = null, string initDate = null, string page = null, string rfc = null, string size = null, string status = null)

Consulta los beneficiarios SPID registrados

Obtiene los beneficiarios SPID registrados al contrato relacionado con la suscripción. Los beneficiarios son los que actualmente se encuentran registrados en banca Monex.

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
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.
            var account = account_example;  // string | Cuenta del beneficiario, puede ser CLABE (18 dígitos), Tarjeta de débito  (TDD, 16 dígitos) o número de celular (10 dígitos). (optional) 
            var beneficiaryBank = beneficiaryBank_example;  // string | Es la clave del banco beneficiario. Se puede obtener del catalogo de <a href=\"#operation/getAllInstitutionsUsingGET\">instituciones.</a> (optional) 
            var beneficiaryName = beneficiaryName_example;  // string | Es el nombre del beneficiario. (optional) 
            var endDate = endDate_example;  // string | Es la fecha de inicio del periodo a filtrar en formato dd-mm-yyyy. (optional) 
            var initDate = initDate_example;  // string | Es la fecha de inicio del periodo a filtrar en formato dd-mm-yyyy. (optional) 
            var page = page_example;  // string | Es el número de página. (optional)  (default to 0)
            var rfc = rfc_example;  // string | Es el Registro Federal de Contribuyentes (RFC) del beneficiario. (optional) 
            var size = size_example;  // string | Es el tamaño de página. (optional)  (default to 20)
            var status = status_example;  // string | Es el estado (estatus) de la cuenta, Los valores pueden ser <b>PENDING</b> y <b>REGISTERED</b>. (optional) 

            try
            {
                // Consulta los beneficiarios SPID registrados
                SpidBeneficiariesResponse result = apiInstance.GetSpidBeneficiariesForAccount(authorization, subscription, account, beneficiaryBank, beneficiaryName, endDate, initDate, page, rfc, size, status);
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
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 
 **account** | **string**| Cuenta del beneficiario, puede ser CLABE (18 dígitos), Tarjeta de débito  (TDD, 16 dígitos) o número de celular (10 dígitos). | [optional] 
 **beneficiaryBank** | **string**| Es la clave del banco beneficiario. Se puede obtener del catalogo de &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt; | [optional] 
 **beneficiaryName** | **string**| Es el nombre del beneficiario. | [optional] 
 **endDate** | **string**| Es la fecha de inicio del periodo a filtrar en formato dd-mm-yyyy. | [optional] 
 **initDate** | **string**| Es la fecha de inicio del periodo a filtrar en formato dd-mm-yyyy. | [optional] 
 **page** | **string**| Es el número de página. | [optional] [default to 0]
 **rfc** | **string**| Es el Registro Federal de Contribuyentes (RFC) del beneficiario. | [optional] 
 **size** | **string**| Es el tamaño de página. | [optional] [default to 20]
 **status** | **string**| Es el estado (estatus) de la cuenta, Los valores pueden ser &lt;b&gt;PENDING&lt;/b&gt; y &lt;b&gt;REGISTERED&lt;/b&gt;. | [optional] 

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

Pre-registro de cuentas de beneficiarios SPID®

Pre-registra una o más cuentas de beneficiario SPID® en la plataforma de Wire4, ésta le proporcionaará una URL donde lo llevará al centro de autorización para que el cuentahabiente Monex ingrese su llave digital para confirmar el alta de las cuentas de beneficiarios.<br/> Los posibles valores de <em>relationship</em> y <em>kind_of_relationship</em> se deben  obtener de <a href=\"#operation/getAvailableRelationshipsMonexUsingGET\">/subscriptions/{subscription}/beneficiaries/relationships.</a><br/><br/>La confirmación de registro en Monex se realizará a través de una notificación a los webhooks registrados con el evento de tipo <a href=\"#section/Eventos/Tipos-de-Eventos\">ACCOUNT.CREATED.</a>

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
            var subscription = subscription_example;  // string | Es el identificador de la suscripción a esta API.

            try
            {
                // Pre-registro de cuentas de beneficiarios SPID®
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
 **subscription** | **string**| Es el identificador de la suscripción a esta API. | 

### Return type

[**TokenRequiredResponse**](TokenRequiredResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
