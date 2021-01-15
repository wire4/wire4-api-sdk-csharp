# MX.Wire4.Model.BeneficiariesQueryRegisterStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthorizationDate** | **DateTime?** | Fecha en que el usuario propietario del token autorizo el registro de beneficiarios | [optional] 
**Beneficiaries** | [**List&lt;AccountResponse&gt;**](AccountResponse.md) | Es una lista de beneficiarios obtenidos. | [optional] 
**RequestDate** | **DateTime?** | Fecha en que se realizó la petición de registro de beneficiarios,  | [optional] 
**RequestId** | **string** | Identificador de la petición del registro de beneficiarios | [optional] 
**StatusRequest** | **string** | Indica sí la petición ya fue autorizada usando el token del usuario | [optional] 
**TotalBeneficiaries** | **int?** | Total de beneficiarios enviados en la petición | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

