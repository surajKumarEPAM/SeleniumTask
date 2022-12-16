Feature: Cart page

verifying the all items added in the cart

Background: Navigation to the inventory page
Given I navigated at Inventory page
And All products is added in the cart

@ItemInTheCart
Scenario: Verify the item added in the cart
	When I click on the cart icon
	Then All item added in the cart should display
	