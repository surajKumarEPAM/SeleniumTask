Feature: AdjustItem


Background: 
		for navating to the cart page
		Given i logged in on amazon
		And i nevigated to the cart page

@emptyCart
Scenario: cart is empty

	Then unable to find the adjust button


@CarthavingOneItemWithSingleInstance
Scenario:  cart contain only one item with single instanse and remove it
		

	Given cart contain only one item with single instace
	When i click minus icon
	Then cart will become empty

@CarthavingOneItemWithSingleInstance
Scenario: cart contain only one item with single instanse and adding
		

	Given cart contain only one item with single instace
	When i click plus icon
	Then cart will contain one more instace of that item

@CarthavingOneItemWithMultipleInstanceAndRemoveItAndAddIt
Scenario:  cart contain only one item with multiple instanse
		here i remove the item if cart having one item with multiple instance

	Given cart contain only one item with multiple instace
	When i click plus or minus icon
	Then cart adjust the item

@CarthavingMultipelItemWithSingleInstance
Scenario:  cart contain only single item with multiple instanse
		here i remove the item if cart having single item with multiple instance

	Given cart contain only multiple item with multiple instace
	When i click on puls or minus icon
	Then  cart adjust the item

@CarthavingMultipelItemWithMultipleInstance
Scenario:  cart contain multiple item with multiple instanse
		here i remove the item if cart having multiple item with multiple instance

	Given cart contain only multiple item with multiple instace
	When i click on puls or minus icon
	Then cart adjust the item

@CartWithMoreitemThanAvailable
Scenario: cart contain maximum instance of the availability 
		here i remove the item if cart having multiple item with multiple instance

	Given cart contain only multiple item with multiple instace
	When i click minus icon
	Then should display connot add more items