# Square.Connect.Model.Transaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The transaction&#39;s unique ID, issued by Square payments servers. | [optional] 
**LocationId** | **string** | The ID of the transaction&#39;s associated location. | [optional] 
**CreatedAt** | **string** | The time when the transaction was created, in RFC 3339 format. | [optional] 
**Tenders** | [**List&lt;Tender&gt;**](Tender.md) | The tenders used to pay in the transaction. | [optional] 
**Refunds** | [**List&lt;Refund&gt;**](Refund.md) | Refunds that have been applied to any tender in the transaction. | [optional] 
**ReferenceId** | **string** | If the transaction was created with the [Charge](#endpoint-charge) endpoint, this value is the same as the value provided for the &#x60;reference_id&#x60; parameter in the request to that endpoint. Otherwise, it is not set. | [optional] 
**Product** | **ProductEnum** | The Square product that processed the transaction. | [optional] 
**ClientId** | **string** | If the transaction was created in the Square Point of Sale app, this value is the ID generated for the transaction by Square Point of Sale.  This ID has no relationship to the transaction&#39;s canonical &#x60;id&#x60;, which is generated by Square&#39;s backend servers. This value is generated for bookkeeping purposes, in case the transaction cannot immediately be completed (for example, if the transaction is processed in offline mode).  It is not currently possible with the Connect API to perform a transaction lookup by this value. | [optional] 
**Order** | [**Order**](Order.md) | The order associated with this transaction, if any. | [optional] 
**ShippingAddress** | [**Address**](Address.md) | The shipping address provided in the request, if any. | [optional] 


## ProductEnum

Name | Value
------------ | -------------
**REGISTER** | "REGISTER"
**EXTERNALAPI** | "EXTERNAL_API"
**BILLING** | "BILLING"
**APPOINTMENTS** | "APPOINTMENTS"
**INVOICES** | "INVOICES"
**ONLINESTORE** | "ONLINE_STORE"
**PAYROLL** | "PAYROLL"
**OTHER** | "OTHER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

