using Core.Bowling;
using FluentAssertions;

namespace SpecFlowTest.Steps;

[Binding]
public class BowlingGutterGameStep
{
    private readonly Game _bowlingGame = new();
    private int _result;
    
    [Given(@"yet another new bowling game")]
    public void GivenYetAnotherNewBallingGame()
    {
        _bowlingGame.Score().Should().Be(0);
    }

    [When(@"the player rolls (.*) times and hits (.*) pins each time")]
    public void WhenThePlayerRollsTimesAndHitsPinsEachTime(int p0, int p1)
    {
        for (int i = 0; i < p0; i++)
        {
            _bowlingGame.Roll(p1);
        }

        _result = _bowlingGame.Score();
    }

    [Then(@"the final game score should be (.*)")]
    public void ThenTheFinalGameScoreShouldBe(int p0)
    {
        _result.Should().Be(p0);
    }
}