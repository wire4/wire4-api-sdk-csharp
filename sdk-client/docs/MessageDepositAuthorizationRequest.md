# MX.Wire4.Model.MessageDepositAuthorizationRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Es el monto de la transferencia. | [optional] 
**BeneficiaryAccount** | **string** | Es la cuenta del beneficiario. | [optional] 
**BeneficiaryName** | **string** | Es el nombre del beneficiario. | [optional] 
**BeneficiaryRfc** | **string** | Es el Registro Federal de Contribuyentes (RFC) del beneficiario. | [optional] 
**ClaveRastreo** | **string** | Es la clave de rastreo de la transferencia. | [optional] 
**ConfirmDate** | **DateTime?** | Es la Fecha de confirmación de la transferencia. | [optional] 
**CurrencyCode** | **string** | Es el código de divisa de la transferencia. Es en el formato estándar ISO 4217 y es de 3 dígitos. Puede ser \&quot;MXN\&quot; o \&quot;USD\&quot;. | [optional] 
**DepositDate** | **DateTime?** | Es la fecha de recepción de la transferencia. | [optional] 
**Depositant** | **string** | Es el nombre del depositante en caso de que la transferencia se reciba en una cuenta de depositante. | [optional] 
**DepositantClabe** | **string** | Es la cuenta CLABE del depositante en caso que la transferencia se reciba en una cuenta de depositante | [optional] 
**DepositantEmail** | **string** | Es el Correo electrónico (email) del depositante en caso que la transferencia se reciba en una cuenta de depositante | [optional] 
**DepositantRfc** | **string** | Es el Registro Federal de Contribuyentes (RFC) del depositante, en caso que la transferencia se reciba en una cuenta de depositante. | [optional] 
**Description** | **string** | Es el concepto de la transferencia. | [optional] 
**MonexDescription** | **string** | Es la descripción de Monex para la transferencia. | [optional] 
**MonexTransactionId** | **string** | Es el identificador asignado por Monex a la transferencia. | [optional] 
**Reference** | **string** | Es la referecia de la transferencia. | [optional] 
**SenderAccount** | **string** | Es la cuenta del ordenante que podría ser un número celular (10 dígitos), una tarjeta de débito (TDD, de 16 dígitos) o Cuenta CLABE interbancaria (18 dígitos). | [optional] 
**SenderBank** | [**MessageInstitution**](MessageInstitution.md) |  | [optional] 
**SenderName** | **string** | Es el nombre del ordenante. | [optional] 
**SenderRfc** | **string** | Es el Registro Federal de Contribuyente (RFC) del ordenante. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

