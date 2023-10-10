using Core;
using FluentAssertions;

namespace SpecFlowTest.Steps;

[Binding]
public class StringLowercaseStep
{
    private readonly StringUtil _stringUtil = new();
    private string _result;
    
    [Given(@"the string ""(.*)""")]
    public void GivenTheString(string aBc)
    {
        _stringUtil.aBc = aBc;
    }

    [When(@"the string is converted to lowercase")]
    public void WhenTheStringIsConvertedToLowercase()
    {
        _result = _stringUtil.LowerCase();
    }
    
    [Then(@"the lowercased result should be ""(.*)""")]
    public void ThenTheLowercasedResultShouldBe(string abc)
    {
        _result.Should().Be(abc);
    }
}