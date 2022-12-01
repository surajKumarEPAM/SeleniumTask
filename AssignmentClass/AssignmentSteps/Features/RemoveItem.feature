Feature: RemoveItem
		Removing item from the cart

Background: 
		for navating to the cart page
		Given i logged in on amazon
		And i nevigated to the cart page

@emptyCart
Scenario: cart is empty

	Then unable to find the removeItem button


@CarthavingOneItemWithSingleInstance
Scenario:  cart contain only one item with single instanse
		here i remove the item if cart having one item with single instance

	Given cart contain only one item with single instace
	When i click remove item
	Then cart will become empty

@CarthavingOneItemWithMultipleInstance
Scenario: cart contain only one item with multiple instanse
		here i remove the item if cart having one item with multiple instance

	Given cart contain only one item with multiple instace
	When i click remove item
	Then cart will become empty

@CarthavingMultipelItemWithSingleInstance
Scenario: cart contain only single item with multiple instanse
		here i remove the item if cart having single item with multiple instance

	Given cart contain only multiple item with multiple instace
	When i click remove item
	Then cart will remove that item

@CarthavingMultipelItemWithMultipleInstance
Scenario: cart contain only multiple item with multiple instanse
		here i remove the item if cart having multiple item with multiple instance

	Given cart contain only multiple item with multiple instace
	When i click remove item
	Then cart will remove that item


		
