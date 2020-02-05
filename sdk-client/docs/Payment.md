# MX.Wire4.Model.Payment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Cuenta emisora | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | Monto de la transferencia | [optional] 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario | [optional] 
**BeneficiaryBank** | [**Institution**](Institution.md) |  | [optional] 
**BeneficiaryName** | **string** | Nombre del Beneficiario | [optional] 
**Cep** | [**MessageCEP**](MessageCEP.md) |  | [optional] 
**ClaveRastreo** | **string** | Clave de rastreo de la transferencia | [optional] 
**Concept** | **string** | Concepto de pago | [optional] 
**ConfirmDate** | **DateTime?** | Fecha de aplicación de la transferencia | [optional] 
**CurrencyCode** | **string** | Código de moneda de la transferencia | [optional] 
**DetentionMessage** | **string** | Mensaje proporcionado por Monex para la transferencia | [optional] 
**MonexDescription** | **string** | Descripción | [optional] 
**OrderId** | **string** | Identificador asignado por la aplciación a la transferencia | [optional] 
**PaymentOrderId** | **int?** | Identificador de la orden de pago en Monex | [optional] 
**Reference** | **int?** | Referencia numérica | [optional] 
**StatusCode** | **string** | Estado de la transferencia de la transferencia, los posibles valores son: PENDING, COMPLETED, FAILED, CANCELLED | [optional] 
**TransactionId** | **int?** | Identificador de la transferencia asignado por Monex | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

