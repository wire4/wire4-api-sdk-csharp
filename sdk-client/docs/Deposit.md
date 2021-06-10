# MX.Wire4.Model.Deposit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Es el monto de la transferencia. | [optional] 
**BeneficiaryAccount** | **string** | Es la cuenta del beneficiario. | [optional] 
**BeneficiaryName** | **string** | Es el nombre del beneficiario. | [optional] 
**BeneficiaryRfc** | **string** | Es el Registro Federal de Contribuyentes (RFC) del beneficiario. | [optional] 
**Cep** | [**MessageCEP**](MessageCEP.md) |  | [optional] 
**ClaveRastreo** | **string** | Es la clave de rastreo de la transferencia. | [optional] 
**ConfirmDate** | **DateTime?** | Es la fecha de confirmación del deposito. Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;. | [optional] 
**CurrencyCode** | **string** | Es el código de divisa de la transferencia. Es en el formato estándar de 3 dígitos, por ejemplo para el peso mexicano: &lt;b&gt;MXP&lt;/b&gt;, para el dólar estadounidense: &lt;b&gt;USD&lt;/b&gt;. | [optional] 
**DepositDate** | **DateTime?** | Es la fecha del deposito.  Ésta fecha viene en formato ISO 8601 con zona horaria, ejemplo: &lt;strong&gt;2020-10-27T11:03:15.000-06:00&lt;/strong&gt;. | [optional] 
**Depositant** | **string** | Es el depositante. | [optional] 
**DepositantAlias** | **string** | Es el alias asignado a la cuenta CABLE del depositante. | [optional] 
**DepositantClabe** | **string** | Es la Cuenta CLABE interbancaria (de 18 dígitos) del depositante. | [optional] 
**DepositantEmail** | **string** | Es el correo electrónico (email) del depositante. | [optional] 
**DepositantRfc** | **string** | Es el Registro Federal de Contribuyentes (RFC) del depositante. | [optional] 
**Description** | **string** | Es la descripción del traspaso. | [optional] 
**MonexDescription** | **string** | Es la descripción directa de Monex. | [optional] 
**MonexTransactionId** | **string** | es el identificador de la transferencia en Monex. | [optional] 
**Reference** | **string** | Es la referencia del depósito. | [optional] 
**SenderAccount** | **string** | Es la cuenta del ordenante. | [optional] 
**SenderBank** | [**MessageInstitution**](MessageInstitution.md) |  | [optional] 
**SenderName** | **string** | Es el nombre del ordenante. | [optional] 
**SenderRfc** | **string** | Es el Registro Federal de Contribuyentes (RFC) de la cuenta ordenante. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

