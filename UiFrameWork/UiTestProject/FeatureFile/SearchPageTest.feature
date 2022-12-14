Feature: Testing on the Search page

verifying that for a successul aeach on the diffrent browser

Scenario: searching on the chrome browser
	Given User should launched the browser sucessfully
	And Search box and seach icon should be visible
	When I provide the search text 
	And click on the search icon
	Then I should get title is "iphone - Google Search"
    
