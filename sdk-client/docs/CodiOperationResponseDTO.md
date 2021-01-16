# MX.Wire4.Model.CodiOperationResponseDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Es el monto de la operacion. Ejemplo: 1000.00 | [optional] 
**Concept** | **string** | Es el concepto del pago. | [optional] 
**Id** | **string** | Es el identificador de la operacion. | [optional] 
**OperationDate** | **DateTime?** | Es la fecha de la operacion. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;. | [optional] 
**PaymentType** | **string** | Es el tipo de pago. | [optional] 
**Status** | **string** | Es el estado (estatus) de la operación. Los valores pueden ser: &lt;b&gt;COMPLETED, CANCELLED Y POSTPONED&lt;/b&gt; | [optional] 
**TransactionId** | **string** | Es el identificador de la transacción. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

