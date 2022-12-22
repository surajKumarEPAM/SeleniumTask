Feature: LeavePage
verifying the appropriate users leave based on start and end-date 

Background: Navigation to dashboard page
	Given : I Navigated to the Dashboard page
	When : I clicked on the Leave tab in menu tab

@leavePage
Scenario: validating the user leaves
	When : I enterd the start date
	And : End date
	And : I clicked on the search button
	Then : Matching records should display

