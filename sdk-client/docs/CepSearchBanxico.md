# MX.Wire4.Model.CepSearchBanxico
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Monto de la transferencia | 
**BeneficiaryAccount** | **string** | Cuenta de beneficiario | 
**BeneficiaryBankKey** | **string** | Clave del banco beneficiario, se puede obtener este valor del listado de institucines &#x27;/institutions&#x27;. Si este valor no esta presente se obtiene de la cuenta del beneficiario, si la cuenta de beneficiario es un número celular este campo es requerido | [optional] 
**ClaveRastreo** | **string** | Clave de rastreo de la transferencia | 
**OperationDate** | **string** | Fecha de operación de la transferencia, formato: dd-MM-yyyy | 
**Reference** | **string** | Referencia numérica de la transferencia | [optional] 
**SenderAccount** | **string** | Cuenta ordenante, es requerida cuando se no se envía la clave del banco ordenante  | [optional] 
**SenderBankKey** | **string** | Clave del banco ordenante, se puede obtener este valor del listado de institucines &#x27;/institutions&#x27;. Es requerida cuando no se envía la cuenta ordenante | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

