using Core.Bowling;
using FluentAssertions;

namespace SpecFlowTest.Steps;

[Binding]
public class BowlingSpareStep
{
    private readonly Game _bowlingGame = new();
    private int _result;
    
    [Given(@"another new bowling game")]
    public void GivenAnotherNewBallingGame()
    {
        _bowlingGame.Score().Should().Be(0);
    }

    [When(@"the player rolls the balls twice and hits (.*) pins each time")]
    public void WhenThePlayerRollsTheBallsTwiceAndHitsPinsEachTime(int p0)
    {
        _bowlingGame.Roll(p0);
        _bowlingGame.Roll(p0);
    }

    [When(@"the player then rolls the ball once and hits (.*) pins")]
    public void WhenThePlayerThenRollsTheBallOnceAndHitsPins(int p0)
    {
        _bowlingGame.Roll(p0);
        _result = _bowlingGame.Score();
    }

    [Then(@"the final score should be (.*)")]
    public void ThenTheFinalScoreShouldBe(int p0)
    {
        _result.Should().Be(p0);
    }
}