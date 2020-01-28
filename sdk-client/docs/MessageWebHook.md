# MX.Wire4.Model.MessageWebHook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiVersion** | **string** | La versión de la API | [optional] 
**Created** | **DateTime?** | Fecha de creación del mensaje | [optional] 
**Data** | **Object** | Objeto que contiene la información del evento | [optional] 
**Id** | **string** | El identificador del mensaje | [optional] 
**Livemode** | **bool?** | Indica si proviene de un entorno productivo | [optional] 
**Object** | **string** | Tipo de objeto  que contiene el mensaje en el atributo data los posibles valores son: subscription, beneficiary, spei_outgoing, spei_incoming, spid_outgoing  | [optional] 
**PendingWebhooks** | **int?** | Número de  mensajes pendientes de enviar | [optional] 
**Request** | **string** | Identificador del recurso relacionado | [optional] 
**Type** | **string** | El tipo evento que se esta enviando en la notifiación | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

