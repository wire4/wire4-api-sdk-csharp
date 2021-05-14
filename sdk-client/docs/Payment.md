# MX.Wire4.Model.Payment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Es la cuenta emisora. | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | Es el monto de la transferencia. | [optional] 
**BeneficiaryAccount** | **string** | Es la cuenta del beneficiario. | [optional] 
**BeneficiaryBank** | [**Institution**](Institution.md) |  | [optional] 
**BeneficiaryName** | **string** | Es el nombre del Beneficiario. | [optional] 
**Cep** | [**MessageCEP**](MessageCEP.md) |  | [optional] 
**ClaveRastreo** | **string** | Es la clave de rastreo de la transferencia. | [optional] 
**Concept** | **string** | Es el concepto de pago. | [optional] 
**ConfirmDate** | **DateTime?** | Es la fecha de aplicación de la transferencia. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;. | [optional] 
**CurrencyCode** | **string** | Es el código de divisa de la transferencia. Es en el formato estándar de 3 dígitos. Ejemplo del peso mexicano: &lt;b&gt;MXP&lt;/b&gt;, ejemplo del dólar estadounidense: &lt;b&gt;USD&lt;/b&gt;. | [optional] 
**DetentionMessage** | **string** | Es el mensaje proporcionado por Monex para la transferencia. | [optional] 
**ErrorMessage** | **string** | Es el mensaje de error, en caso de algún error se informará aquí. | [optional] 
**MonexDescription** | **string** | Es la descripción de Monex. | [optional] 
**OrderId** | **string** | Es el identificador asignado por la aplciación a la transferencia. | [optional] 
**PaymentOrderId** | **int?** | Es el identificador de la orden de pago en Monex. | [optional] 
**PendingReason** | **string** | Es la razón de porque esta pendiente aún cuando se autorizó la transferencia. | [optional] 
**Reference** | **int?** | Es la referencia numérica. | [optional] 
**StatusCode** | **string** | Es el estado de la transferencia de la transferencia, los posibles valores son: &lt;b&gt;PENDING, COMPLETED, FAILED, CANCELLED&lt;/b&gt; | [optional] 
**TransactionId** | **int?** | Es el identificador de la transferencia asignado por Monex. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

