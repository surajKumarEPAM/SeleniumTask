Feature: LogIn on Saucedemo

Veryfy the login functionality on saucedemo website
Background: Navigation to Saucedemo website login page
Given I Navigated to the login page

@ValidLogin
Scenario: Veryfy Login with valid credential
	When I enter the '<Username>'
	And Entered the password "secret_sauce"
	And Click on the Login Button
	Then I should got url contain keyword "inventory";

Examples: 
| Username                |
| standard_user           |
| problem_user            |
| locked_out_user         |
| performance_glitch_user |
