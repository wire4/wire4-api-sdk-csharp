# MX.Wire4.Model.MessageWebHook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiVersion** | **string** | Es la versión de esta API. | [optional] 
**Created** | **DateTime?** | Fecha de creación del mensaje. | [optional] 
**Data** | **Object** | Es el objeto que contiene la información del evento. | [optional] 
**Id** | **string** | Es el identificador del mensaje. | [optional] 
**Livemode** | **bool?** | Indica si proviene de un entorno productivo. | [optional] 
**Object** | **string** | Tipo de objeto  que contiene el mensaje en el atributo &#x27;data&#x27;. Los posibles valores son:  &lt;ul&gt;&lt;li&gt;subscription&lt;/li&gt;, &lt;li&gt;beneficiary&lt;/li&gt;, &lt;li&gt;spei_outgoing&lt;/li&gt;, &lt;li&gt;spei_incoming&lt;/li&gt;, &lt;li&gt;spid_outgoing&lt;/li&gt;, &lt;li&gt;request_outgoing&lt;/li&gt;&lt;ul&gt;  | [optional] 
**PendingWebhooks** | **int?** | Es el número de mensajes pendientes de enviar. | [optional] 
**Request** | **string** | Es el identificador del recurso relacionado. | [optional] 
**Type** | **string** | El tipo evento que se está enviando en la notificación. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

