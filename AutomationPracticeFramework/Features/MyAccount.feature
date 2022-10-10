Feature: MyAccount
	As a user
	When I enter my credientials
	I want to be able to access my account

@smoke,@sanity
Scenario: User can access My Account section
Given user clicks on Sign in section
When user fills the fields 'jaksa14@gmail.com' emailaddress and '12345' password
And submits the form
Then then the correct 'My account' is displayed

Scenario: 