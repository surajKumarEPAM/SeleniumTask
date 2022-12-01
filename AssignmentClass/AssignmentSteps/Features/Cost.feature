Feature: Cart
		adding item(s) in the cart 
Background: 
		for navating to the cart page
		Given i logged in on amazon
		And i navigated to the Home page
		When  i click on the cart icon

@EmptyCart
Scenario:  cart is empty
	Then shoud display your cart is empty


@CartWithOneItem
Scenario:  cart having one item
		cart contain one item with single instance

	Then display its amount.

@CartWithOneItemButMultipleinstance
Scenario:  cart having one item with multiple instance

	Then display its amount and its quantity.

@CartWithMultipleItemButSingleinstance
Scenario:  cart having multiple items with single instance

	Then display its amount indivisully and its quantity.

@CartWithMultipleItemAndMultipoleinstance
Scenario:  cart having multiple items with multiple instance

	Then display its amount indivisully and its quantity.
