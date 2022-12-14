Feature: Testing on the SignInpage 

verifying that for a successul aeach on the diffrent browser

Scenario: searching on the chrome browser
	Given User should launched the browser sucessfully
	And Sign in button should be displayed
	When I Click on the sign in button
	And The Title of the page should be"Sign in - Google Accounts"
	When i provide the invalid email in the mail box
	And Click on the Next Button
	Then It should show display is "Couldn’t find your Google Account"
    
