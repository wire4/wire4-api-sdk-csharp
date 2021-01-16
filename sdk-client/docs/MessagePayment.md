# MX.Wire4.Model.MessagePayment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Es la cuenta del ordenante. | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | Es el monto de la transferencia. | [optional] 
**BeneficiaryAccount** | **string** | Es la cuenta del beneficiario. | [optional] 
**BeneficiaryBank** | [**MessageInstitution**](MessageInstitution.md) |  | [optional] 
**BeneficiaryName** | **string** | Es el nombre del beneficiario. | [optional] 
**Cep** | [**MessageCEP**](MessageCEP.md) |  | [optional] 
**ClaveRastreo** | **string** | Es la clave de rastreo de la transferencia. | [optional] 
**Concept** | **string** | Es el concepto de la transferencia de salida. | [optional] 
**ConfirmDate** | **DateTime?** | Es la fecha de confirmación de la transferencia de salida. | [optional] 
**CurrencyCode** | **string** | Código de divisa de la transferencia de salida. Es en el formato estándar ISO 4217 y es de 3 dígitos. Ejemplo: \&quot;MXN\&quot;. | [optional] 
**DetentionMessage** | **string** | Es el mensaje de detención de Monex de la transferencia de salida. | [optional] 
**ErrorMessage** | **string** | Mensaje de error. | [optional] 
**MonexDescription** | **string** | La descripción de Monex de la transferencia de salida. | [optional] 
**OrderId** | **string** | Es el identificador de la transferencia de salida. | [optional] 
**PaymentOrderId** | **int?** | Es el identificador de la orden de pago de Monex de la transferencia de salida. | [optional] 
**PendingReason** | **string** | Es la razón de porque está pendiente aún cuando se autorizó la transferencia. | [optional] 
**Reference** | **int?** | Es la referecia de la transferencia. | [optional] 
**RequestId** | **string** | El identificador en esta API de la petición de envío de la transferencia de salida. | [optional] 
**StatusCode** | **string** | Es el estado de la transferencia de salida. | [optional] 
**TransactionId** | **int?** | Es el identificador de Monex de la transferencia de salida. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

