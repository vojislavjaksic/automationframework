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

Scenario: User should be able to add items on wish list
Given user logs in with 'jaksa14@gmail.com' emailaddress and '12345' password and is on that page
And user clicks on MY WISHLISTS button
And enters random whislist name and creates wishlist
Then user should be able to see 'My wishlists' and items

Scenario: User can change his last name to random
Given user logs in with 'jaksa14@gmail.com' emailaddress and '12345' password and is on that page
And clicks on My personal information button
And fills Last name field with a random name 
And enters '12345' password and clicks on Save button
Then he should have updated last name

