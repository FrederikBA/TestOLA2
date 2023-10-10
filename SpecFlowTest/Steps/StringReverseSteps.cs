using Core.Utils;
using FluentAssertions;

namespace SpecFlowTest.Steps;

[Binding]
public class StringReverseSteps
{
    private readonly StringUtil _stringUtil = new();
    private string _result;

    [Given(@"a string is ""(.*)""")]
    public void GivenAStringIs(string aBc)
    {
        _stringUtil.aBc = aBc;
    }

    [When(@"reverse the string")]
    public void WhenReverseTheString()
    {
        _result = _stringUtil.Reverse();
    }

    [Then(@"the result should be ""(.*)""")]
    public void ThenTheResultShouldBe(string cBa)
    {
        _result.Should().Be(cBa);
    }
}