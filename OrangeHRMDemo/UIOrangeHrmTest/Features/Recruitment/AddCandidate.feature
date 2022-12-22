Feature: AddCandidate
verifyiing the addcandidate page

Background: Navigation on Recruitment page
	Given : I Navigated to the Dashboard page
	When : I clicked on the Recruitment tab in menu tab

@WithValidCredential
Scenario: Adding condidate on recruitment page
	When Click on the Add button
	And : Enter the first name
	And : last name
	And email ID
	And Click on the save button
	Then user must be present in the application area
