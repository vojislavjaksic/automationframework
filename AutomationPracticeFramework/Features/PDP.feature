Feature: PDP
	In order to buy products 
	As a user
	I want to be albe to interact with product details


@mytag
Scenario: user can add product to cart
	Given user opens 'Dresses' section
	And opens first product from the list
	And increases quantity to '2'
	When user clicks on aad to cart button
	And user proceeds to checkout
	Then 'Your shopping cart' is opened and product is added to cart