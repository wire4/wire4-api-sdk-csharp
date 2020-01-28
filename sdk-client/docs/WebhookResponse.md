# MX.Wire4.Model.WebhookResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Events** | **List&lt;string&gt;** | Tipos de eventos de los cuales Wire4 te enviará información. | [optional] 
**Name** | **string** | Nombre del webhook. | [optional] 
**Secret** | **string** | Llave con la cual se debe de identificar que el webhook fue enviado por Wire4, para mayor información revisar la guía de notificaciones (https://wire4.mx/#/guides/notificaciones), en la sección de  \&quot;Comprobación de firmas de Webhook\&quot;. | [optional] 
**Status** | **string** | Estatus en el que se encuentra el webhook | [optional] 
**Url** | **string** | URL a la cual Wire4 enviará las notificaciones cuando un evento ocurra. | [optional] 
**WhUuid** | **string** | Identificador del webhook. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

