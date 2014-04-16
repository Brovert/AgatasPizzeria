Feature: Awesome Calculations
	In order to get the results of something really complicated
	As a math idiot
	I want to use the awesome calculation functions

Scenario: Entering a number great than 100
	Given I have entered a number greater than 100
	When I click the button to run the calculation
	Then the result will be 99

Scenario: Entering a number that is not included in the normal
	Given I have entered a number not found
	When I click the button to run the calculation
	Then the result will be -1






#Verify if I enter a number greater than 100 my result will be 99
#Verify if the number is none of these, the result is -1
#Verify if I enter a number greater than 30 but less than 100 my result will be 80
#Verify if I enter a number less than or to 30 but greater than or equal to zero my result will be 5
#Verify when I press the Get Result button I will receive my result