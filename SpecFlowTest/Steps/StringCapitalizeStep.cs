using Core.Utils;
using FluentAssertions;

namespace SpecFlowTest.Steps;

[Binding]
public class StringCapitalizeStep
{
    private readonly StringUtil _stringUtil = new();
    private string _result;

    [Given(@"an uncapitalized string is ""(.*)""")]
    public void GivenAnUncapitalizedStringIs(string aBc)
    {
        _stringUtil.aBc = "ABC";
    }

    [When(@"capitalize the string")]
    public void WhenCapitalizeTheString()
    {
        _result = _stringUtil.Capitalize();
    }

    [Then(@"the string should be ""(.*)""")]
    public void ThenTheStringShouldBe(string ABC)
    {
        _result.Should().Be(ABC);
    }
}