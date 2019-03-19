Feature: ErrorMessages


	Scenario Outline: InValid Registration
	Given I navigate to the site
	When Click on register link
	And I enter firstname
	And I enter last name
	And I enter email "o.m"

	And I enter mobile number
	And I enter password "Fakeword"
	And I confirm password "No"
	And the click on signUp
	Then the error message "<message>" is displayed for "<test>"

	Examples: 
	| test            | message                                                |
	| PasswordTooShort | Your Password Must Be At Least 5 Characters Long       |
	| Invalidemail     | Please Enter A Valid Email Address                     |
	| MobileTooShort   | Your Mobile Number Must Be At Least 10 Characters Long |



