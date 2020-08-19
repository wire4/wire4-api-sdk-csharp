# MX.Wire4.Model.MessagePaymentStatePending
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Cuenta del ordenante | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | Monto de la transferencia | [optional] 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario | [optional] 
**BeneficiaryBank** | [**MessageInstitution**](MessageInstitution.md) |  | [optional] 
**BeneficiaryName** | **string** | Nombre del beneficiario | [optional] 
**Concept** | **string** | Concepto de la transferencia de salida | [optional] 
**CurrencyCode** | **string** | Código de la moneda de la transferencia de salida | [optional] 
**DetentionMessage** | **string** | Mensaje de detención de Monex, indica la causa por la cuál esta detenida la operación en Monex | [optional] 
**ErrorMessage** | **string** | Mensaje de error | [optional] 
**OrderId** | **string** | El identificador de la transferencia de salida | [optional] 
**PaymentOrderId** | **int?** | El identificador de la orden de pago de Monex de la transferencia de salida | [optional] 
**PendingReason** | **string** | Estatus que identifica la causa por la que la transferencia esta en pendiente, los posibles estatus son: FI&#x3D;Fondos Insuficientes | FM&#x3D;Firma mancomunada, en espera de ingreso de segundo token de autorización | DP&#x3D;Se detecto una transferencia duplicada que esta en espera de confirmación o de eliminación | [optional] 
**Reference** | **int?** | Referecia de la transferencia | [optional] 
**RequestId** | **string** | El identificador, en esta API, de la petición de envío de la transferencia de salida | [optional] 
**StatusCode** | **string** | El estado de la transferencia de salida, deberá ser PENDING | [optional] 
**TransactionId** | **int?** | El identificador de Monex de la transferencia de salida, podría no estar presente por lo que Usted debería hacer referencias mediate el paymentOrderID | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

