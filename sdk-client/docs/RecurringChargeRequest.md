# MX.Wire4.Model.RecurringChargeRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CancelReturnUrl** | **string** | Es la dirección URL a la que se redirigirá en caso de que el usuario cancele. | 
**Charges** | **int?** | Número de cargos que se aplicarán a la tarjeta del cliente final a partir de la fecha del primer cargo | 
**Customer** | [**Customer**](Customer.md) |  | 
**FirstChargeDate** | **DateTime?** | Fecha en la que se aplicará el primer cargo a la tarjeta del cliente final  | 
**OrderId** | **string** | Número de orden asignado por el cliente de Wire4 | 
**Product** | [**Product**](Product.md) |  | 
**ReturnUrl** | **string** | Es la dirección URL a la que se redirigirá en caso de éxito. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

