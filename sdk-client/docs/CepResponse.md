# MX.Wire4.Model.CepResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountBeneficiary** | **string** | Es la cuenta del beneficiario. | [optional] 
**AccountSender** | **string** | Es la cuenta del ordenante. | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | Es el monto de la transferencia. | [optional] 
**Available** | **bool?** | Indica si el CEP se encuentra disponible o no. | [optional] 
**BeneficiaryBankKey** | **string** | Es la clave del banco beneficiario el cual se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt; | [optional] 
**BeneficiaryName** | **string** | Nombre del beneficiario. | [optional] 
**BeneficiaryRfc** | **string** | Es el Registro Federal de Contribuyentes (RFC) del beneficiario. | [optional] 
**CadenaOriginal** | **string** | Cadena original del CEP. | [optional] 
**CaptureDate** | **DateTime?** | Es la fecha de captura de la transferencia. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;. | [optional] 
**CertificateSerialNumber** | **string** | Número de serie del certificado. | [optional] 
**ClaveRastreo** | **string** | Es la clave de rastreo. | [optional] 
**Description** | **string** | Es la descripción de la transferencia. | [optional] 
**Iva** | [**decimal?**](BigDecimal.md) | IVA de la transferencia. | [optional] 
**OperationDate** | **DateTime?** | Es la fecha de operación de la transferencia. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;. | [optional] 
**OperationDateCep** | **DateTime?** | Es la fecha de abono registrada en el CEP.  Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;. | [optional] 
**Reference** | **string** | Es la referencia numérica de la transferencia. | [optional] 
**SenderBankKey** | **string** | Es la clave del banco emisor el cual se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt; | [optional] 
**SenderName** | **string** | Es el nombre del emisor. | [optional] 
**SenderRfc** | **string** | Es el Registro Federal de Contribuyentes (RFC) del emisor. | [optional] 
**Signature** | **string** | Firma del CEP.. | [optional] 
**Type** | **string** | Es el tiop de CEP, puede ser: &lt;strong&gt;SPEI&lt;/strong&gt; o &lt;strong&gt;SPID&lt;/strong&gt;. | [optional] 
**UrlZip** | **string** | La url al archivo zip del CEP, el cual contiene el xml y pdf | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

