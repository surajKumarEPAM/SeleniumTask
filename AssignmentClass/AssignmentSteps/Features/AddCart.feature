Feature: CartFunctionality
		adding item(s) in the cart 
Background: 
		for navating to the cart page
		Given i logged in on amazon
		And i navigated to the product details page

@AddingToCartByDefaultClickAddToCart
Scenario:  by clicking simply add to cart
		from details page by default click add to the cart item should be added with single instance

	Given navigated on product detals page
	When i click on the add to cart 
	Then item should be added with single instance.

@AddingToCartBySelectingTheQuantity
Scenario:  by selecting the quantity of the item
		from details page by selecting the quantity adding in the cart with that much of instance

	Given navigated on product detals page
	When i select the quantity
	And i click on the add to cart icon
	Then item should be added with selected quantity.

@AddingToCartByDefaultIfThatItemAlreadyIntheCart
Scenario:  by defult click on the add to cart if item is already present in the cart
		from details page by clicking add to cart if that item is already present in the cart
	Given navigated on product detals page
	When i click on the add to cart icon
	Then item should be added with one more quantity into the cart.

@AddingToCartBySelectingtheQuantityIfThatItemAlreadyIntheCart
Scenario:  by selecting the quantity on the add to cart if item is already present in the cart
		from details page by clicking add to cart by selecting the quantity if that item is already present in the cart
	Given navigated on product detals page
	When i select the quantity
	And i click on the add to cart icon
	Then item should be added with selected quantity extra than previously selected item in the cart.

@TryToAddMoreQuantityWhichIsNotAvailable
Scenario: by proving more item than availble
		try to add the item with quantity which is grater than the availablity of that item
	Given navigated on product detals page
	When try to find that much quantity
	Then unable to select the item

@TryToAddProductWhichIsNotAvailable
Scenario: if item is not available
		try to add the item with quantity which is grater than the availablity of that item
	Given navigated on product detals page
	When try to add the item
	Then unable to add that item