Feature: Catogary
		searching item in by providing its catogray or product description 
Background: 
		for navating Home page
		Given i navegated to the home page of amazon
		

@ByPorductDescription
Scenario:  by providing the its product description
		item by providing the product description

	Given item searched with with is description
	When i click on search icon
	Then along with this item related items should show.

@ByProductType
Scenario:  by providing the type of product 
		 item by providing the product type

	Given item searched with its product type
	When i click on search icon
	Then along with this item related items  should show.