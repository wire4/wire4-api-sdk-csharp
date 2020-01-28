# MX.Wire4.Model.AccountSpid
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountLimit** | [**decimal?**](BigDecimal.md) | Monto límite permitido para la cuenta | 
**BankCodeBanxico** | **string** | Código banxico con una longitud de 5 dígitos, es requerido en caso de que la cuenta del beneficiario sea un número de celular | [optional] 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario debe ser una cuenta CLABE | 
**CancelReturnUrl** | **string** | Url a la que se redirigira en caso no exitoso | [optional] 
**Email** | **List&lt;string&gt;** | Lista de email&#x27;s, este dato es opcional | [optional] 
**Institution** | [**BeneficiaryInstitution**](BeneficiaryInstitution.md) |  | 
**KindOfRelationship** | **string** | Tipo de relación de la cuentaobtained of endpoint relationships | 
**NumericReference** | **string** | Referencia numérica | [optional] 
**PaymentConcept** | **string** | Concepto de pago | [optional] 
**Relationship** | **string** | Código de relación de la cuenta, este valor debe ser igual a un valor obtenido del endpoint relationship | 
**ReturnUrl** | **string** | Url a la que se redireccionara en caso exitoso | [optional] 
**Rfc** | **string** | Registro federal de contribuyentes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

