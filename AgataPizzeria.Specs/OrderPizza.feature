Feature: Order Pizza
	In order to get some delicious pizza
	As a hungry customer
	I want to be able to order one or more pizzas

Scenario: Trying to place an order without adding any pizzas
	Given I have not added any pizzas to my order
	When I click to place the order
	Then an error should tell me "please add between 1 to 50 pizzas before place an order"