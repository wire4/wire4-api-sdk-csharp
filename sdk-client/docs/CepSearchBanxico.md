# MX.Wire4.Model.CepSearchBanxico
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Es el monto de la transferencia. Ejemplo 1000.00 | 
**BeneficiaryAccount** | **string** | Es la cuenta de beneficiario. | 
**BeneficiaryBankKey** | **string** | Clave del banco beneficiario. Éste valor no esta presente si obtiene de la cuenta del beneficiario, en caso de que sea un número celular éste campo es requerido. se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt; | [optional] 
**ClaveRastreo** | **string** | Es la clave de rastreo de la transferencia. | 
**OperationDate** | **string** | Es la fecha de operación de la transferencia, formato: dd-MM-yyyy. | 
**Reference** | **string** | Es la referencia numérica de la transferencia. Se valida hasta 7 dígitos. | [optional] 
**SenderAccount** | **string** | Es la cuenta ordenante, es requerida cuando se no se envía la clave del banco ordenante. | [optional] 
**SenderBankKey** | **string** | Es la clave del banco ordenante, es requerida cuando no se envía la cuenta ordenante.  Se puede obtener del recurso de las &lt;a href&#x3D;\&quot;#operation/getAllInstitutionsUsingGET\&quot;&gt;instituciones.&lt;/a&gt; | [optional] 
**Type** | **string** | Es el tipo de cep a consultar, puede ser SPEI o SPID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

