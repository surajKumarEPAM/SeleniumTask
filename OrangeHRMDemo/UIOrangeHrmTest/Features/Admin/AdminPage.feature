Feature: AdminPage
verifying all user present in the adming page list.

Background: Navigation to dashboard page
	Given : I Navigated to the Dashboard page

@adminPage
Scenario: Verifying the all user preset in the admin page
	When : I clicked on the Admin tab in menu
	And : Search user By username
	And : Click on the search button
	Then :Related records will be displayed

	