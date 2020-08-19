# MX.Wire4.Model.CodiCodeRequestDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Monto del pago CODI® | [optional] 
**Concept** | **string** | Descripción del pago CODI® | 
**DueDate** | **DateTime?** | Fecha de operación pago CODI®, formato: yyyy-MM-dd&#x27;T&#x27;HH:mm:ss | 
**OrderId** | **string** | Referencia de la transferencia asignada por el cliente | 
**PhoneNumber** | **string** | Número de teléfono móvil en caso de ser un pago CODI® usando &#x27;PUSH_NOTIFICATION&#x27; estecampo sería obligatorio | [optional] 
**Type** | **string** | El tipo de código QR para pago con CODI® | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

