using Core.Bowling;
using FluentAssertions;

namespace SpecFlowTest.Steps;

[Binding]
public class BowlingPerfectGameStep
{
    private readonly Game _bowlingGame = new();
    private int _result;
    
    [Given(@"yet again another new bowling game")]
    public void GivenYetAgainAnotherNewBowlingGame()
    {
        _bowlingGame.Score().Should().Be(0);
    }
    
    [When(@"the player rolls (.*) times and hits (.*) pins each times")]
    public void WhenThePlayerRollsTimesAndHitsPinsEachTimes(int p0, int p1)
    {
        for (int i = 0; i < p0; i++)
        {
            _bowlingGame.Roll(p1);
        }

        _result = _bowlingGame.Score();;
    }
    
    [Then(@"the final bowling game score should be (.*)")]
    public void ThenTheFinalBowlingGameScoreShouldBe(int p0)
    {
        _result.Should().Be(p0);
    }
}