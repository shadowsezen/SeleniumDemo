Feature: WebTests
	In order to demonstrate SpecFlow and Selenium
	As a QA doing a demo
	I want to poke around the Internet a bit

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
