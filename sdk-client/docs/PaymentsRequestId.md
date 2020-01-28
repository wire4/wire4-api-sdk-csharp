# MX.Wire4.Model.PaymentsRequestId
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthorizationDate** | **DateTime?** | Fecha en que el usuario propietario del token emitió la autorización | [optional] 
**RequestDate** | **DateTime?** | Fecha en que se realizó la petición de registro de transacciones | [optional] 
**RequestId** | **string** | Identificador de la petición del registro de transacciones | [optional] 
**TotalAmount** | [**decimal?**](BigDecimal.md) | Monto total de las transacciones registradas | [optional] 
**TotalTransactions** | **int?** | Total de transacciones en la petición | [optional] 
**Transactions** | [**List&lt;Payment&gt;**](Payment.md) | Lista de las transacciones registradas | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

