Feature: DetailsOfProduct

Background: 
	for naviating on the products page
	Given  navated to the amazon home page
	When search any item on searchbox
	And click on the enter

@ProductDetailsByClickOnDetails
Scenario: Verify the Detail Text click
		 verifying that if i click on the details of that product then able to see the product price and specifiactions 

	Given navigated on the search products page
	When i click on the details text
	Then product details should show

@ProductDetailsByClickOnDescription
Scenario: Verify the product description click
		 verifying that if i click on the product description then able to see the product price and specifiactions 

	Given navigated on the search products page
	When i click on the description of product
	Then product details should show