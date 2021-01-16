# MX.Wire4.Model.AccountSpid
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountLimit** | [**decimal?**](BigDecimal.md) | Monto límite permitido para la cuenta. Ejemplo: 1000.00 | 
**BankCodeBanxico** | **string** | Es el código banxico con una longitud de 5 dígitos, es requerido en caso de que la cuenta del beneficiario sea un número de celular. | [optional] 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario debe ser una cuenta CLABE. Ejemplo: 032180000118359719. | 
**CancelReturnUrl** | **string** | Es la dirección URL a la que se redirigirá en caso de que el cliente cancele el registro. Se valida hasta 512 caracteres. | [optional] 
**Email** | **List&lt;string&gt;** | Lista de correos electrónicos (emails), este dato es opcional. | [optional] 
**Institution** | [**BeneficiaryInstitution**](BeneficiaryInstitution.md) |  | 
**KindOfRelationship** | **string** | Es el tipo de relación que se tiene con el propietario de la cuenta. Para registrar una cuenta, este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt; relationships.&lt;/a&gt; &lt;br /&gt;&lt;br /&gt;&lt;b&gt;Nota:&lt;/b&gt; &lt;em&gt;Si en la respuesta de Monex esta propiedad es nula, tampoco estará presente en esta respuesta.&lt;/em&gt; | 
**NumericReference** | **string** | Es la referencia numérica. | [optional] 
**PaymentConcept** | **string** | Es el concepto de pago. | [optional] 
**Relationship** | **string** | Es la relación con el propietario de la cuenta, para registrar este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt;relationships.&lt;/a&gt; &lt;br/&gt; &lt;br/&gt; &lt;b&gt;Nota:&lt;/b&gt; Si en la respuesta de Monex, sta propiedad es nula, tampoco estará presente en esta respuesta. | 
**ReturnUrl** | **string** | Es la dirección URL a la que se redirigirá en caso exitoso. Se valida hasta 512 caracteres. | [optional] 
**Rfc** | **string** | Es el Registro federal de contribuyentes (RFC) de la persona o institución propietaria de la cuenta. &lt;br/&gt; &lt;br/&gt;&lt;b&gt;Nota:&lt;/b&gt; Se valida el formato de RFC. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

