Feature: Web Tests
	In order to demonstrate SpecFlow and Selenium
	As a QA tester
	I want to poke around on the Internet

@googleTests
Scenario: Check the weather
	Given I am on Google
	When I search for weather
	Then the weather should display