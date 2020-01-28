# MX.Wire4.Model.CepResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountBeneficiary** | **string** | Cuenta del beneficiario | [optional] 
**AccountSender** | **string** | Cuenta del ordenante | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | Monto de la transferencia | [optional] 
**Available** | **bool?** | Indica si o no el CEP se encuentra disponible | [optional] 
**BeneficiaryBankKey** | **string** | Clave del banco beneficiario | [optional] 
**BeneficiaryName** | **string** | Nombre del beneficiario | [optional] 
**BeneficiaryRfc** | **string** | RFC del beneficiario | [optional] 
**CadenaOriginal** | **string** | Cadena original del CEP | [optional] 
**CaptureDate** | **DateTime?** | Fecha de captura de la transferencia | [optional] 
**CertificateSerialNumber** | **string** | Número de serie del certificado | [optional] 
**ClaveRastreo** | **string** | Clave de rastreo | [optional] 
**Description** | **string** | Descripción de la transferencia | [optional] 
**Iva** | [**decimal?**](BigDecimal.md) | IVA de la transferencia | [optional] 
**OperationDate** | **DateTime?** | Fecha de operación de la transferencia | [optional] 
**OperationDateCep** | **DateTime?** | Fecha de abono registrada en el CEP | [optional] 
**Reference** | **string** | Referencia numérica de la transferencia | [optional] 
**SenderBankKey** | **string** | Clave del banco emisor | [optional] 
**SenderName** | **string** | Nombre del emisor | [optional] 
**SenderRfc** | **string** | RFC del emisor | [optional] 
**Signature** | **string** | Firma del CEP | [optional] 
**UrlZip** | **string** | La url al archivo zip del CEP, el cual contiene el xml y pdf | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

