Feature: Login
veryfying Login functionality

Background: Navigation to OrangeHRM website login page
	Given I Navigated to orangeHRM website login page

@loginWithValidCredential
Scenario: Loigin in orange HRM with valid credential
	When I entered the valid username
	And entered the valid password
	And Clicked on the login button
	Then user should be able to login sucessessfully and having url contains "dashboard"

