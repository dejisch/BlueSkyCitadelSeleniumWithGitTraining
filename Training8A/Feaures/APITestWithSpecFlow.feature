Feature: APITestWithSpecFlow
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Api Test
	Given I have my EndPoint
	And I sent a "Method.GET"
	When I execute the reponse
	Then the response is successful
