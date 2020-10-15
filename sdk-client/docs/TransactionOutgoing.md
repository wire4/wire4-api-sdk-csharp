# MX.Wire4.Model.TransactionOutgoing
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Monto de la transferencia | 
**Beneficiary** | [**Account**](Account.md) |  | [optional] 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario, podría ser un número celular, TDD o Cuenta CLABE interbancaria  | 
**BeneficiaryBankKey** | **string** | La clave del banco beneficiario, proprocionada por BANXICO, este campo solo es obligatario cuando la cuenta beneficiaria es un número celular (*). | [optional] 
**Concept** | **string** | Concepto de la transferencia | 
**CurrencyCode** | **string** | Código de moneda en la que opera la cuenta | 
**Email** | **List&lt;string&gt;** | Lista de email del beneficiario,es opcional | [optional] 
**OrderId** | **string** | Referencia de la transferencia asignada por el cliente | 
**Reference** | **int?** | Referencia numérica de la transferencia | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

