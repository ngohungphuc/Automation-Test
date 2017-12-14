Feature: SampleFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create new employee with mandatory details
	#Given I have opened my application
	#Then I should see employee details
	When I fill all the mandatory details in form
	 | Name | Age | Phone | Email       |
	 | tony | 23  | 0123  | ngohungphuc@mail.com |
	 | tony1 | 23  | 0123  | ngohungphuc@mail.com |
	 | tony21 | 23  | 0123  | ngohungphuc@mail.com |
	#And I click add
	#Then I should see employee details saved in my app and DB