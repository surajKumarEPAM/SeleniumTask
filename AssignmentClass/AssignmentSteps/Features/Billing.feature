Feature: Billing

Background: 
		for navating to the cart page
		Given  logged in on amazon
		And  navigated to the Cart page
		And cart should not be empty

@CurrentLocation
Scenario:locating shipping address using current location
		by enabling the current location shiping address lacating

	Given navigated to the shipping address form
	When i click on locate me
	Then should locate my current location

@ValidLocation
Scenario: By providing the valid location
		provide the all valid location details in all the fields

	Given navigated to the shipping address form
	When i filled all the  necessary valid details
	Then should redirect to the payment page

@InValidLocation
Scenario: By providing the invalid location
		provide the all valid location details in all the fields

	Given navigated to the shipping address form
	When i filled invalid details
	Then should show invalid details

@ValidLocationButNotAllMandatoryFields
Scenario: By providing the valid details but not filled all mandatory details
		provide the all valid location details but not filled all mandatory details

	Given navigated to the shipping address form
	When i filled valid details but not in all mandatory fields
	Then should show please fill all mandatroy filled
