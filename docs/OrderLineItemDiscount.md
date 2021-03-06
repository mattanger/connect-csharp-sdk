# Square.Connect.Model.OrderLineItemDiscount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The discount&#39;s name. | [optional] 
**Type** | **TypeEnum** | The type of the discount. If it is created by API, it would be either &#x60;FIXED_PERCENTAGE&#x60; or &#x60;FIXED_AMOUNT&#x60;.  VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified.  See [OrderLineItemDiscountType](#type-orderlineitemdiscounttype) for possible values. | [optional] 
**Percentage** | **string** | The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.  The percentage won&#39;t be set for an amount-based discount. | [optional] 
**AmountMoney** | [**Money**](Money.md) | The total monetary amount of the applicable discount. If it is at order level, it is the value of the order level discount. If it is at line item level, it is the value of the line item level discount.  The amount_money won&#39;t be set for a percentage-based discount. | [optional] 
**AppliedMoney** | [**Money**](Money.md) | The amount of discount actually applied to this line item.  Represents the amount of money applied to a line item as a discount When an amount-based discount is at order-level, this value is different from &#x60;amount_money&#x60; because the discount is distributed across the line items. | [optional] 
**Scope** | **ScopeEnum** | Indicates the level at which the discount applies. See [OrderLineItemDiscountScope](#type-orderlineitemdiscountscope) for possible values. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**UNKNOWN** | "UNKNOWN"
**FIXEDPERCENTAGE** | "FIXED_PERCENTAGE"
**FIXEDAMOUNT** | "FIXED_AMOUNT"
**VARIABLEPERCENTAGE** | "VARIABLE_PERCENTAGE"
**VARIABLEAMOUNT** | "VARIABLE_AMOUNT"


## ScopeEnum

Name | Value
------------ | -------------
**LINEITEM** | "LINE_ITEM"
**ORDER** | "ORDER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

