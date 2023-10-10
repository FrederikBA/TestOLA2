Feature: StringLowercase

@StringLowercase
Scenario: Add two numbers
	Given the string "aBc"
	When the string is converted to lowercase
	Then the lowercased result should be "abc"
