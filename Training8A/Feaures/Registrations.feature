Feature: Registrations
	So that I can use the site
	I need to register

Background: 
#1
	Given I navigate to the site
#2
	When Click on register link

@validRegistration
Scenario: Valid Registration Using Background
#3
	When I enter firstname
#4
	And I enter last name

#5
	And I enter email "test@giftrete.com"
	And I enter mobile number
	And I enter password
	And I confirm password
	And the click on signUp
	And I wait for Element
	Then I should be registered

	@InvalidRegistration
	Scenario: InValid Registration
#3
#4
	When I enter firstname
	And I enter last name
	And I enter email "test@giftrete.com"
	And I enter mobile number
	And I enter password "MyNewPassword"
	And I confirm password "No"

	Then the password is too short error is displayed

