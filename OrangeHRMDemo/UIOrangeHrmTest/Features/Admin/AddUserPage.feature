Feature: AddUserPage
verifying the funcationality of the add user in admin page

Background: Navigation to dashboard page
	Given : I Navigated to the Dashboard page
	When : I clicked on the Admin tab in menu
	And Clicked on the Add button

@addUserpage
Scenario: Verifying the user added in the records
	When : I select the user role
	And : Enter the Name 
	And : Select status
	And : Entered Username
	And : Enter password
	And : Confirm password
	And : Click on save button
	
	
	
	

	
