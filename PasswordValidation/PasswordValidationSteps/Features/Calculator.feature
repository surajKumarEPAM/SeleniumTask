Feature: Password Validation
		here i am validating the password which is of the type of string
		i,e length of the password should not be less than 8 and greater than 12

@WithValidPassword
Scenario: By providing vaild password
		here password is in the string formate and it's length is in the range [8,12]
	Given the password is "Suraj12334"
	When i validate the password
	Then should show "This is a valid password"

@ShorterPassword
Scenario: By providing too short password
		here password length is always be less than 8 characters.
	Given the password is "Suraj"
	When i validate the password
	Then should show "This is a invalid password"

@LongerPassword
Scenario: By providing too long password
		here password length is always be greater than 12 characters.
	Given the password is "Suraj123456789"
	When i validate the password
	Then should show "This is a invalid password"

@PasswordOtherThanString
Scenario: By providing password which is not as a string
		here password is not as a string type i,e it may be int,float,bool etc...
	Given the password is 1234
	When i validate the password
	Then should show "This is a invalid password"