# MX.Wire4.Model.TransactionSpeiSpid
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Es el monto de la transferencia. Se valida que sean máximo 20 dígitos y 2 decimales. Ejemplo 1000.00 | 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario, podría ser un número celular (10dígitos), tarjeta de débito (TDD) o Cuenta CLABE interbancaria (18 dígitos).  | 
**ClassificationId** | **string** | Es el identificador de la clasificación de la transferencia SPID. | 
**Concept** | **string** | Es el concepto de la transferencia. | 
**CurrencyCode** | **string** | Código de moneda en la que opera la cuenta. | [optional] 
**Email** | **List&lt;string&gt;** | Lista de correo electrónico (email) del beneficiario. Este campo es opcional. | [optional] 
**OrderId** | **string** | Es la referencia de la transferencia asignada por el cliente. Ejemplo: dae9c6ae-8c7a-42e8-99f4-ebe90566efae | 
**Reference** | **int?** | Es la referencia numérica de la transferencia. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

