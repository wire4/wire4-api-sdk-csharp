# MX.Wire4.Model.AccountReassigned
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountLimit** | [**decimal?**](BigDecimal.md) | Monto límite permitido registrado para la cuenta | 
**Bank** | [**Institution**](Institution.md) |  | [optional] 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario, podría ser teléfono celular, TDD o cuenta CLABE | 
**CurrencyCode** | **string** | Código de moneda, este dato es opcional, al registrar una cuenta si no se cuenta con este valor se asignara MXP | [optional] 
**Email** | **List&lt;string&gt;** | Lista de email&#x27;s, este dato es opcional | [optional] 
**Institution** | [**BeneficiaryInstitution**](BeneficiaryInstitution.md) |  | [optional] 
**KindOfRelationship** | **string** | Tipo de relación con el propietario de la cuenta, para registrar una cuenta este valor se debe obtener  del recurso relationships. &lt;br&gt; Nota: Si en la respuesta de Monex esta propiedad es nula, tampoco estará presente en esta respuesta. | 
**NumericReferenceSpei** | **string** | Referencia numérica a utilizar cuando se realice una transferencia y no se especifique una referencia | [optional] 
**PaymentConceptSpei** | **string** | Concepto de pago a utilizar cuando se realice una transferencia y no se especifique un concepto | [optional] 
**Person** | [**Person**](Person.md) |  | [optional] 
**RegisterDate** | **DateTime?** | La fecha en la que se registro el beneficiario | [optional] 
**Relationship** | **string** | Relación con el propietario de la cuenta, para registrar una cuenta este valor se debe obtener  del recurso relationships. &lt;br&gt; Nota: Si en la respuesta de Monex esta propiedad es nula, tampoco estará presente en esta respuesta. | 
**Rfc** | **string** | Registro federal de contribuyentes de la persona o institución propietaria de la cuenta. &lt;br&gt; Nota: Si en la respuesta de Monex esta propiedad es nula, tampoco estará presente en esta respuesta. | 
**Status** | **string** | El estado (status) en el que se encuentra el registro del beneficiario | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
