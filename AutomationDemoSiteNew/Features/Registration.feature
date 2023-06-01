Feature: Registration

In order to take full advatange of the website,i need to register

@tag1
Scenario: Registration
	Given I navigate to the website
	And I enter my First Name
	And I enter my Last Name
	And I enter my Address
	And I enter my Email address
	And I enter my Phone
	And I enter my Password
	And I enter my confirm Password
	When I click on Submit Button
	#Then I should be able to register sucessfully
