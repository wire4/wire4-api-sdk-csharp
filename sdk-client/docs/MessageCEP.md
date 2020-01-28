# MX.Wire4.Model.MessageCEP
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountBeneficiary** | **string** | Cuenta del beneficiario | [optional] 
**AccountSender** | **string** | Cuenta que envia la operación | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | Monto de la operación | [optional] 
**Available** | **bool?** | Bander para saber si el cep esta disponible | [optional] 
**BankBeneficiary** | **string** | Clave del banco beneficiario | [optional] 
**BankSender** | **string** | Clave del banco que envia la operación | [optional] 
**BeneficiaryName** | **string** | Nombre del beneficiario | [optional] 
**BeneficiaryRfc** | **string** | RFC del beneficiario | [optional] 
**CadenaOriginal** | **string** | Cadena original emita por el SAT | [optional] 
**CaptureDate** | **DateTime?** | Fecha de captura | [optional] 
**CertificateSerialNumber** | **string** | Numero de serie emitido por el SAT | [optional] 
**ClaveRastreo** | **string** | Clave de rastreo de la operación | [optional] 
**Description** | **string** | Descripción de la operación | [optional] 
**Iva** | [**decimal?**](BigDecimal.md) | Iva de la operación | [optional] 
**OperationDate** | **DateTime?** | Fecha en la que se realizó la operación | [optional] 
**OperationDateCep** | **DateTime?** | Fecha en la que genera el cep | [optional] 
**Reference** | **string** | Referencia de la operación | [optional] 
**SenderName** | **string** | Nombre de quien envia la operación | [optional] 
**SenderRfc** | **string** | RFC de quien envia la operación | [optional] 
**Signature** | **string** | Firma del Cep | [optional] 
**UrlZip** | **string** | Url que contiene el PDF y XML del CEP proporcionado por banxico | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

