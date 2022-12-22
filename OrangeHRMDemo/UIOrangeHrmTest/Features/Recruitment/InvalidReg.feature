Feature: InvalidReg
Invalid registration


Background: Navigation on Recruitment page
	Given : I Navigated to the Dashboard page
	When : I clicked on the Recruitment tab in menu tab

@WithInValidCredential
Scenario: Registration with last Name is missing
	When Click on the Add button
	And : Enter the first name
	And email ID
	And Click on the save button
	Then should display some "Required" field

