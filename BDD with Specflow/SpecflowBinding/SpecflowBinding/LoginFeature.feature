Feature: Customer_Login
	Simple feature to demonstrate customer login feature

@customer
Scenario: Login for customer portal
	Given I have opened the application
	And I login to application
	Then I see customer portal
