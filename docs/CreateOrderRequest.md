# Square.Connect.Model.CreateOrderRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceId** | **string** | An optional ID you can associate with the order for your own purposes (such as to associate the order with an entity ID in your own database).  This value cannot exceed 40 characters. | [optional] 
**LineItems** | [**List&lt;CreateOrderRequestLineItem&gt;**](CreateOrderRequestLineItem.md) | The line items to associate with this order.  Each line item represents a different product (or a custom monetary amount) to include in a purchase. | 
**Taxes** | [**List&lt;CreateOrderRequestTax&gt;**](CreateOrderRequestTax.md) | The taxes include the custom taxes. | [optional] 
**Discounts** | [**List&lt;CreateOrderRequestDiscount&gt;**](CreateOrderRequestDiscount.md) | The discounts include the custom discounts . | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

