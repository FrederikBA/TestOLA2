using Core.Bowling;
using FluentAssertions;

namespace SpecFlowTest.Steps;

[Binding]
public class BowlingStrikeStep
{
    private readonly Game _bowlingGame = new();
    private int _result;
    
    [Given(@"a new bowling game")]
    public void GivenANewBowlingGame()
    {
        _bowlingGame.Score().Should().Be(0);
    }

    [When(@"the player rolls the ball and hits (.*) pins")]
    public void WhenThePlayerRollsTheBallAndHitsPins(int p0)
    {
        _bowlingGame.Roll(p0);
    }
    
    [When(@"the player then rolls the ball twice and hits (.*) pins and (.*) pins")]
    public void WhenThePlayerThenRollsTheBallTwiceAndHitsPinsAndPins(int p0, int p1)
    {
        _bowlingGame.Roll(p0);
        _bowlingGame.Roll(p1);
        _result = _bowlingGame.Score();
    }
    

    [Then(@"the score should be (.*)")]
    public void ThenTheScoreShouldBe(int p0)
    {
        _result.Should().Be(p0);
    }
}