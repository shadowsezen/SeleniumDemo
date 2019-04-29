Feature: WebTests
	In order to demonstrate SpecFlow and Selenium
	As a QA presenter
	I want to poke around on the Internet

@googleTests
Scenario: Get the weather from Google
	Given I am on Google
	When I search for the weather
	Then the weather should display
