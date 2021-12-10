# MX.Wire4.Model.SpidBeneficiaryResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountLimit** | [**decimal?**](BigDecimal.md) | Monto límite permitido para la cuenta. Ejemplo: 1000.00 | 
**AuthorizationDate** | **DateTime?** | La fecha en la que se registro el beneficiario. | [optional] 
**Bank** | [**Institution**](Institution.md) |  | [optional] 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario debe ser una cuenta CLABE. Ejemplo: 032180000118359719. | 
**Email** | **List&lt;string&gt;** | Lista de correos electrónicos (emails), este dato es opcional. | [optional] 
**Institution** | [**BeneficiaryInstitution**](BeneficiaryInstitution.md) |  | 
**KindOfRelationship** | **string** | Es el tipo de relación que se tiene con el propietario de la cuenta. Para registrar una cuenta, este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt; relationships.&lt;/a&gt; &lt;br /&gt;&lt;br /&gt;&lt;b&gt;Nota:&lt;/b&gt; &lt;em&gt;Si en la respuesta de Monex esta propiedad es nula, tampoco estará presente en esta respuesta.&lt;/em&gt; | 
**NumericReferenceSpid** | **string** | Referencia numérica. | [optional] 
**PaymentConceptSpid** | **string** | Concepto de pago. | [optional] 
**RegisterDate** | **DateTime?** | La fecha en la que se registro el beneficiario. | [optional] 
**Relationship** | **string** | Es la relación con el propietario de la cuenta, para registrar este valor se debe obtener del recurso &lt;a href&#x3D;\&quot;#operation/getAvailableRelationshipsMonexUsingGET\&quot;&gt;relationships.&lt;/a&gt; &lt;br/&gt; &lt;br/&gt; &lt;b&gt;Nota:&lt;/b&gt; Si en la respuesta de Monex, sta propiedad es nula, tampoco estará presente en esta respuesta. | 
**Rfc** | **string** | Es el Registro federal de contribuyentes (RFC) de la persona o institución propietaria de la cuenta. &lt;br/&gt; &lt;br/&gt;&lt;b&gt;Nota:&lt;/b&gt; Se valida el formato de RFC. | [optional] 
**Status** | **string** | El estado en el que se encuentra el registo del beneficiario.&lt;br&gt;&lt;br&gt; Los valores pueden ser: &lt;b&gt;\&quot;RECEIVED\&quot;, \&quot;DELETED\&quot;, \&quot;REQUEST_ERROR_BY_MONEX\&quot;, \&quot;REQUESTED_TO_MONEX\&quot;, \&quot;NOTIFIED_BY_MONEX\&quot;, \&quot;NOTIFIED_BY_SPEIOK\&quot;, \&quot;NOTIFIED_WITH_ERROR_BY_SPEIOK\&quot; y \&quot;PENDING\&quot;&lt;/b&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

