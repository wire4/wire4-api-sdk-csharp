# MX.Wire4.Model.PaymentRequestCodiResponseDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Monto del pago. | [optional] 
**BarcodeBase64** | **string** | Imagen QR en formato Base64 para el CODI®. | [optional] 
**BarcodeUrl** | **string** | URL de la imagen QR para el CODI®. | [optional] 
**Concept** | **string** | Concepto de pago. | [optional] 
**CreationDate** | **DateTime?** | Fecha de creación. | [optional] 
**DueDate** | **DateTime?** | Fecha de vencimiento. | [optional] 
**Operations** | [**List&lt;CodiOperationResponseDTO&gt;**](CodiOperationResponseDTO.md) | Listado de pagos realizados sobre la petición. | [optional] 
**OrderId** | **string** | OrderId asignada a la solicitud. | [optional] 
**PhoneNumber** | **string** | Numero de teléfono. | [optional] 
**Status** | **string** | Estatus de la orden de pago. | [optional] 
**Type** | **string** | Tipo de petición. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

