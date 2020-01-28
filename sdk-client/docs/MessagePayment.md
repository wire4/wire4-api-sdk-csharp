# MX.Wire4.Model.MessagePayment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Cuenta del ordenante | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | Monto de la transferencia | [optional] 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario | [optional] 
**BeneficiaryBank** | [**MessageInstitution**](MessageInstitution.md) |  | [optional] 
**BeneficiaryName** | **string** | Nombre del beneficiario | [optional] 
**Cep** | [**MessageCEP**](MessageCEP.md) |  | [optional] 
**ClaveRastreo** | **string** | Clave de rastreo de la transferencia | [optional] 
**Concept** | **string** | Concepto de la transferencia de salida | [optional] 
**ConfirmDate** | **DateTime?** | Fecha de confirmación de la transferencia de salida | [optional] 
**CurrencyCode** | **string** | Código de la moneda de la transferencia de salida | [optional] 
**DetentionMessage** | **string** | Mensaje de detención de Monex de la transferencia de salida | [optional] 
**MonexDescription** | **string** | La descripción de Monex de la transferencia de salida | [optional] 
**OrderId** | **string** | El identificador de la transferencia de salida | [optional] 
**PaymentOrderId** | **int?** | El identificador de la orden de pago de Monex de la transferencia de salida | [optional] 
**Reference** | **int?** | Referecia de la transferencia | [optional] 
**RequestId** | **string** | El identificador, en esta API, de la petición de envío de la transferencia de salida | [optional] 
**StatusCode** | **string** | El estado de la transferencia de salida | [optional] 
**TransactionId** | **int?** | El identificador de Monex de la transferencia de salida | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

