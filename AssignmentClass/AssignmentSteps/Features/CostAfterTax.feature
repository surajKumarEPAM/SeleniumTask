Feature: CostAfterTax
        veryfying the cost of selected items after tax

Background: 
		Given i navigated to the payment page
		And enterd all valid card details

@WithEmptyCart
Scenario: total cost if no item in the cart
	Then should show the cart is empty 


@CartHavingitem
Scenario: total cost if cart is not empty
	Given enterd all valid card details
	When i click on make a payment
	Then show the total cost after tax