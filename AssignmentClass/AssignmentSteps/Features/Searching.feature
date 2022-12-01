Feature: SearchingProduct
		searching item in searchbox form the amazon home page 
Background: 
		for navating Home page
		Given i navegated to the home page of amazon
		

@SeachingProductByProvidingActualName
Scenario:  by providing the actual name
		seaching item by providing the actual name of the product

	Given item searched with its name
	When i click on search icon
	Then along with this item related items should show.

@SeachingProductByProvidingItsBrandName
Scenario:  by providing the brand name of the product
		seaching item by providing the brand name of the product

	Given item searched with its brand name
	When i click on search icon
	Then along with this item related items  should show.

@SeachingProductByProvidingNameAnditsBrandName
Scenario:  by providing the name along with the brand name of the product
		seaching item by providing the name along with the brand name of the product

	Given item searched with its name and brand name
	When i click on search icon
	Then along with this item related items should show.

@SeachingProductIfUnavailableOrMismathProduct
Scenario: if item is Unavailable or not matching
		seaching item by which is not available or matching

	Given item searched 
	When i click on search icon
	Then show the best matched items present 

