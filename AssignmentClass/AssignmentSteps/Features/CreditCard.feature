Feature: CreditCard
verifying the Creditcard details

Background: 
		for navating to the cart page
		Given  logged in on amazon
		And  filled valid  location details

@WithValidDetails
Scenario: with valid credit card details
          provide all valid creditiantial of the the credit card 
	Given i nevigated to the payment page
	When provide all valid credit card details
	And click on the make a payement
	Then payment got successfull

@withInvalidDetails
Scenario: with invalid credit card details
          invalid creditiantial of the the credit card 
	Given i nevigated to the payment page
	When provide invalid credit card details
	Then invalid credit card credential should show


