Feature: WebTests
	In order to demonstrate SpecFlow and Selenium
	As a QA doing a demo
	I want to poke around the Internet a bit

@google
Scenario: Search Google for the weather
	Given I am on Google
	When I search for the weather
	Then I should see the temperature on the screen
