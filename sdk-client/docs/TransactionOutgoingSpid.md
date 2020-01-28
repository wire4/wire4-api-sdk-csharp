# MX.Wire4.Model.TransactionOutgoingSpid
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Monto de la transferencia | 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario, podría ser un numero celular, TDD o Cuenta CLABE interbancaria  | 
**CancelReturnUrl** | **string** | Url a la que se redirigirá en caso de error | 
**ClassificationId** | **string** | El identificador de la clasificación de la transferencia SPID | 
**CurrencyCode** | **string** | Código de moneda en la que opera la cuenta | 
**Email** | **List&lt;string&gt;** | Lista de email del beneficiario,es opcional | [optional] 
**NumericReferenceSpid** | **int?** | Referencia numérica de la transferencia | 
**OrderId** | **string** | Referencia de la transferencia asignada por el cliente | 
**PaymentConceptSpid** | **string** | Concepto de la transferencia | 
**ReturnUrl** | **string** | Url a la que se redirigirá en caso de exito | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

