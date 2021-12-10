# MX.Wire4.Model.CodiCodeRequestDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Monto del pago CODI® | [optional] 
**Beneficiary2** | [**BeneficiaryDTO**](BeneficiaryDTO.md) |  | [optional] 
**Concept** | **string** | Descripción del pago CODI® | 
**DueDate** | **DateTime?** | Fecha de operación pago CODI®, formato: yyyy-MM-dd&#x27;T&#x27;HH:mm:ss | 
**Metadata** | **string** | Campo de metada CODI®, longitud máxima determinada por configuracion de la empresa, por defecto 100 caracteres | [optional] 
**OrderId** | **string** | Referencia de la transferencia asignada por el cliente | 
**PaymentType** | **string** | El tipo de pago ya sea en una ocasión (ONE_OCCASION) o recurrente (RECURRENT) | 
**PhoneNumber** | **string** | Número de teléfono móvil en caso de ser un pago CODI® usando &#x27;PUSH_NOTIFICATION&#x27; estecampo sería obligatorio | [optional] 
**Reference** | **int?** | Referencia numérica del pago CODI®. Debe ser de 7 dígitos | 
**Type** | **string** | El tipo de solicitud QR o PUSH para pago con CODI® | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

