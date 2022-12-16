Feature: Inventory page 
Veryfy the all add to cart icon on inventory page

Background: Navigation to the Inventory page
Given I navigated at Inventory page

@AddProductInCart
Scenario: Adding product in the cart
	When I click on the add to cart
	Then That button text should become "REMOVE"
	