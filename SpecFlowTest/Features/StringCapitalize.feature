Feature: StringCapitalize

    @CapitalizeString
    Scenario: Reverse a string
        Given an uncapitalized string is "aBc"
        When capitalize the string
        Then the string should be "ABC"