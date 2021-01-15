# MX.Wire4.Model.WebHookDepositAuthorizationResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Events** | **List&lt;string&gt;** | Tipo de evento manejado por el webhook, para mas referencia sobre los tipos de eventos soportados, revise la siguiente liga: &lt;a href&#x3D;\&quot;https://developers.wire4.mx/#section/Eventos\&quot;&gt;https://developers.wire4.mx/#section/Eventos.&lt;/a&gt; | [optional] 
**Name** | **string** | Es el nombre del webhook. | [optional] 
**Secret** | **string** | Es la llave con la cuál se debe de identificar que el webhook fue enviado por Wire4. Para mayor información revisar la guía de notificaciones en la sección de  &lt;a href&#x3D;\&quot;https://wire4.mx/#/guides/notificaciones\&quot;&gt;\&quot;Comprobación de firmas de Webhook\&quot;.&lt;/a&gt; | [optional] 
**Status** | **string** | Es el estado (estatus) en el que se encuentra el webhook. | [optional] 
**Url** | **string** | Es la dirección URL a la cuál Wire4 enviará las notificaciones cuando un evento ocurra. | [optional] 
**WhUuid** | **string** |  Es el identificador del webhook. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

