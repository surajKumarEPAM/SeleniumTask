Feature: Checkout
		Checking the cart
Background: 
		for navating to the home page
		Given i logged in on amazon
		And i navigated to the Home page

@CheckingCartItem
Scenario:  Checkout the cart items
		checking the all item which is in the cart

	Given some item in the cart
	When i click on the cart icon
	Then should display all item added in the cart