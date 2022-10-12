Feature: MyAccount 

Background: 
Given user clicks on Sign in section

@smoke,@sanity
Scenario: User can access My Account section

When user fills the fields 'jaksa14@gmail.com' emailaddress and '12345' password
And submits the form
Then then the correct 'My account' is displayed

Scenario: User should be able to create an account
And types in the email address
And clicks 'Create an account' button
When fiils the all required fields
Then the he should be able to create an account 