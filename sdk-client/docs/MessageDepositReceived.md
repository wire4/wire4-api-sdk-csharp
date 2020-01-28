# MX.Wire4.Model.MessageDepositReceived
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**decimal?**](BigDecimal.md) | Monto de la transferencia | [optional] 
**BeneficiaryAccount** | **string** | Cuenta del beneficiario | [optional] 
**BeneficiaryName** | **string** | Nombre del beneficiario | [optional] 
**BeneficiaryRfc** | **string** | RFC del beneficiario | [optional] 
**ClaveRastreo** | **string** | Clave de rastreo de la transferencia | [optional] 
**ConfirmDate** | **DateTime?** | Fecha de confirmación de la transferencia | [optional] 
**CurrencyCode** | **string** | Código de moneda de la transferencia, puede ser MXP, USD | [optional] 
**DepositDate** | **DateTime?** | Fecha de recepción de la transferencia | [optional] 
**Depositant** | **string** | Nombre del depositante, en caso que la transferencia se reciba en una cuenta de depositante | [optional] 
**DepositantClabe** | **string** | CLABE del depositante, en caso que la transferencia se reciba en una cuenta de depositante | [optional] 
**DepositantEmail** | **string** | Correo electrónico del depositante, en caso que la transferencia se reciba en una cuenta de depositante | [optional] 
**DepositantRfc** | **string** | RFC del depositante, en caso que la transferencia se reciba en una cuenta de depositante | [optional] 
**Description** | **string** | Concepto de la transferencia | [optional] 
**MonexDescription** | **string** | Descripción de Monex para la transferencia | [optional] 
**MonexTransactionId** | **string** | Identificador asignado por Monex a la transferencia | [optional] 
**Reference** | **string** | Referecia de la transferencia | [optional] 
**SenderAccount** | **string** | Cuenta del ordenante, podría ser un número celular, TDD o Cuenta CLABE interbancaria | [optional] 
**SenderBank** | [**MessageInstitution**](MessageInstitution.md) |  | [optional] 
**SenderName** | **string** | Nombre del ordenante | [optional] 
**SenderRfc** | **string** | RFC del ordenante | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

