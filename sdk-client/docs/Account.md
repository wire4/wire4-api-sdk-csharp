# MX.Wire4.Model.Account
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountLimit** | [**decimal?**](BigDecimal.md) | Es el monto límite permitido que se registra para la cuenta. Por ejemplo 1000.00. | 
**BankKey** | **string** | Es la clave del banco, es requerido en caso de que la cuenta del beneficiario sea un número de celular. | [optional] 
**BeneficiaryAccount** | **string** | Es la cuenta del beneficiario, podría ser teléfono celular (se valida que sea de 10 dígitos), Tarjeta de débito (TDD, se valida que sea de 16 dígitos) o cuenta CLABE (se valida que sea de 18 dígitos). &lt;br/&gt;&lt;br/&gt;Por ejemplo Teléfono celular: 5525072600, TDD: 4323 1234 5678 9123, CLABE: 032180000118359719. | 
**Email** | **List&lt;string&gt;** | Es una lista de correos electrónicos (emails). Se valida el formato de email. Este campo es opcional. | [optional] 
**Institution** | [**BeneficiaryInstitution**](BeneficiaryInstitution.md) |  | [optional] 
**KindOfRelationship** | **string** | Es el tipo de relación que se tiene con el propietario de la cuenta. Para registrar una cuenta, este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt;relationships.&lt;/a&gt; &lt;br /&gt;&lt;br /&gt;&lt;b&gt;Nota:&lt;/b&gt; &lt;em&gt;Si en la respuesta de Monex esta propiedad es nula, tampoco estará presente en esta respuesta.&lt;/em&gt; | 
**NumericReferenceSpei** | **string** | Es la referencia numérica a utilizar cuando se realice una transferencia y no se especifique una referencia. | [optional] 
**PaymentConceptSpei** | **string** | Es el concepto de pago a utilizar cuando se realice una transferencia y no se especifique un concepto | [optional] 
**Person** | [**Person**](Person.md) |  | [optional] 
**Relationship** | **string** | Es la relación con el propietario de la cuenta, para registrar este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt;relationships.&lt;/a&gt; &lt;br/&gt; &lt;br/&gt; &lt;b&gt;Nota:&lt;/b&gt; Si en la respuesta de Monex, sta propiedad es nula, tampoco estará presente en esta respuesta. | 
**Rfc** | **string** | Es el Registro Federal de Contribuyentes (RFC) de la persona o institución propietaria dela cuenta. &lt;br/&gt; &lt;br/&gt;&lt;b&gt;Nota:&lt;/b&gt; Si en la respuesta de Monex esta propiedad es nula, tampoco estará presente en esta respuesta. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

