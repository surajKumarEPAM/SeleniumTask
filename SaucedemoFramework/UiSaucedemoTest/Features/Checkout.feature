Feature: Checkout Page
Verifying the functionality of checkout page

Background: Navigation to the cart page
Given I navigated at Inventory page
And All products is added in the cart
When I click on the cart icon on inventory page
And I click on the checkout button
Then The heading of the page should show "CHECKOUT: YOUR INFORMATION"

@CheckOutWithValidCredential
Scenario: Verifying the functionality of checkoutpag
	When I Enter '<FirstName>'
	And I Enter The '<LastName>'
	And The '<ZipCode>'
	And Click on the continue button

Examples: 
| FirstName | LastName | ZipCode |
| Suraj     | Kumar    | 9000    |
| Xyz       | PQR      | 500     |
| !         | #        | &       |
| 34        | 23       | APJ     |
| @!#       | q123     | 12WE    |
