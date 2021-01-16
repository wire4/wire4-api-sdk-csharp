# MX.Wire4.Model.PaymentRequestCodiResponseDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Es el Monto del pago. Ejemplo 1000.00 | [optional] 
**BarcodeBase64** | **string** | Es la imagen QR en formato Base64 para el CODI®. | [optional] 
**BarcodeUrl** | **string** | Es la dirección URL de la imagen QR para el CODI®. | [optional] 
**Concept** | **string** | Es el concepto de pago. | [optional] 
**CreationDate** | **DateTime?** | Es la fecha de creación. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;. | [optional] 
**DueDate** | **DateTime?** | Es la fecha de vencimiento. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;. | [optional] 
**Operations** | [**List&lt;CodiOperationResponseDTO&gt;**](CodiOperationResponseDTO.md) | Es el listado de pagos realizados sobre la petición. | [optional] 
**OrderId** | **string** | Es el orderId asignado a la solicitud. | [optional] 
**PhoneNumber** | **string** | Es el número de teléfono. | [optional] 
**Status** | **string** | Es el estado (estatus) de la orden de pago. Los valores pueden ser: &lt;b&gt;RECEIVED, COMPLETED Y CANCELLED&lt;/b&gt; | [optional] 
**Type** | **string** | Es el tipo de petición. Los valores pueden ser: &lt;b&gt;QR_CODE o PUSH_NOTIFICATION&lt;/b&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

