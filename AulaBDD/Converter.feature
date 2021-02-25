Feature: Converter
	I want to convert many different temperature scales
	
@mytag
Scenario: Celsius to Farenheit
	Given A Celsius temperature of 25
	When I get the Farenheit equivalent
	Then the result should be 77
