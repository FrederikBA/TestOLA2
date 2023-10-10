Feature: StringReverse

    @ReverseString
    Scenario: Reverse a string
        Given a string is "aBc"
        When reverse the string
        Then the result should be "cBa"