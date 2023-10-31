# MX.Wire4.Model.PaymentRequestReq
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Es el monto de la solicitud de pago | 
**CancelReturnUrl** | **string** | Es la dirección URL a la que se redirigirá en caso de que el usuario cancele. | [optional] 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**DepositantAccount** | **string** | Es el número de cuenta CLABE donde se realizará el deposito. | [optional] 
**Description** | **string** | Es la descripción de la solicitud de pago. | [optional] 
**DueDate** | **DateTime?** | Es la fecha de operación de la solicitud de pago. | [optional] 
**FromDate** | **DateTime?** | Es la fecha de inicio de la solicitud de pago.  | [optional] 
**Method** | **string** |  | 
**OrderId** | **string** | Número de orden asignado por el cliente de Wire4 | 
**ReturnUrl** | **string** | Es la dirección URL a la que se redirigirá en caso de éxito. | [optional] 
**Type** | **string** | Tipo de pago por paycash | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

