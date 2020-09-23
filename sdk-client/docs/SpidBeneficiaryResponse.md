# MX.Wire4.Model.SpidBeneficiaryResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountLimit** | [**decimal?**](BigDecimal.md) | Monto límite permitido para la cuenta | 
**Bank** | [**Institution**](Institution.md) |  | [optional] 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario debe ser una cuenta CLABE | 
**Email** | **List&lt;string&gt;** | Lista de email&#x27;s, este dato es opcional | [optional] 
**Institution** | [**BeneficiaryInstitution**](BeneficiaryInstitution.md) |  | 
**KindOfRelationship** | **string** | Tipo de relación de la cuenta, este valor debe ser igual a uno de los obtenidos del recurso de consulta de relationships | 
**NumericReferenceSpid** | **string** | Referencia numérica | [optional] 
**PaymentConceptSpid** | **string** | Concepto de pago | [optional] 
**RegisterDate** | **DateTime?** | La fecha en la que se registro el beneficiario | [optional] 
**Relationship** | **string** | Código de relación de la cuenta, este valor debe ser igual a uno de los obtenidos del recurso de consulta de  relationship | 
**Rfc** | **string** | Registro federal de contribuyentes | [optional] 
**Status** | **string** | El estado en el que se encuentra el registo del beneficiario | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

