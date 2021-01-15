# MX.Wire4.Model.MessageCEP
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountBeneficiary** | **string** | Es la cuenta del beneficiario. | [optional] 
**AccountSender** | **string** | Es la cuenta que envía la operación. | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | Es el monto de la operación. | [optional] 
**Available** | **bool?** | Indica sí el CEP está disponible. | [optional] 
**BankBeneficiary** | **string** | Es la clave del banco beneficiario. | [optional] 
**BankSender** | **string** | Es la clave del banco que envía la operación. | [optional] 
**BeneficiaryName** | **string** | Es el nombre del beneficiario. | [optional] 
**BeneficiaryRfc** | **string** | Es el Registro Federal de Contribuyentes (RFC) del beneficiario. | [optional] 
**CadenaOriginal** | **string** | Es la cadena original emitida por el Servicio de Administración Tributaria (SAT). | [optional] 
**CaptureDate** | **DateTime?** | Es la fecha de captura. | [optional] 
**CertificateSerialNumber** | **string** | Es el número de serie emitido por el SAT | [optional] 
**ClaveRastreo** | **string** | Es la clave de rastreo de la operación. | [optional] 
**Description** | **string** | Es la descripción de la operación. | [optional] 
**Iva** | [**decimal?**](BigDecimal.md) | Es el Impuesto al Valor Agregado (IVA) de la operación. | [optional] 
**OperationDate** | **DateTime?** | Es la fecha en la que se realizó la operación. | [optional] 
**OperationDateCep** | **DateTime?** | Es la fecha en la que se genera el CEP. | [optional] 
**Reference** | **string** | Es la Referencia de la operación | [optional] 
**SenderName** | **string** | Es el nombre de quién envía la operación. | [optional] 
**SenderRfc** | **string** | Es el Registro Federal de Contrinuyentes (RFC) de quién envía la operación. | [optional] 
**Signature** | **string** | Firma del CEP | [optional] 
**UrlZip** | **string** | Dirección URL de descarga del archivo ZIP que contiene el PDF y XML del CEP proporcionado por BANXICO | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

