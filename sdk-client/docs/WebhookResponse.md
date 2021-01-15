# MX.Wire4.Model.WebhookResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Events** | **List&lt;string&gt;** | Tipos de eventos de los cuales Wire4 te enviará información. | [optional] 
**Name** | **string** | Es el nombre del webhook. | [optional] 
**Secret** | **string** | Llave con la cual se debe de identificar que el webhook fue enviado por Wire4, para mayor información revisar la guía de notificaciones (https://wire4.mx/#/guides/notificaciones),  en la sección de  &lt;a href&#x3D;\&quot;https://wire4.mx/#/guides/notificaciones\&quot;&gt;\&quot;Comprobación de firmas de Webhook\&quot;.&lt;/a&gt; | [optional] 
**Status** | **string** | Es el estado (estatus) en el que se encuentra el webhook. | [optional] 
**Url** | **string** | Es la dirección URL a la que Wire4 enviará las notificaciones cuando un evento ocurra. | [optional] 
**WhUuid** | **string** | Es el identificador del webhook. Ejemplo: wh_54a832866f784b439bc625c0f4e04e12. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

