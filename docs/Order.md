# Square.Connect.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationId** | **string** | The ID of the merchant location this order is associated with. | [optional] 
**ReferenceId** | **string** | A client specified identifier to associate an entity in another system with this order. | [optional] 
**LineItems** | [**List&lt;OrderLineItem&gt;**](OrderLineItem.md) | The line items included in the order. Every order has at least one line item. | [optional] 
**TotalMoney** | [**Money**](Money.md) | The total amount of money to collect for the order. | [optional] 
**TotalTaxMoney** | [**Money**](Money.md) | The total tax amount of money to collect for the order. | [optional] 
**TotalDiscountMoney** | [**Money**](Money.md) | The total discount amount of money to collect for the order. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

