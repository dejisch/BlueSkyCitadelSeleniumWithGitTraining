Feature: FormElementsAutomation1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Form Elements Automation1
	Given I navigate to sie "http://blueskycitadel.com/test-form-for-bluesky-automation-training/"
	When I enter name
	And click submit
	Then the successful form is displayed