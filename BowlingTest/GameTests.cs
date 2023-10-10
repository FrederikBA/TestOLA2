namespace BowlingTest;

public class GameTests
{
    private readonly Game _bowlingGame;

    public GameTests()
    {
        _bowlingGame = new Game();
    }

    //Helper method
    private void RollMany(int rolls, int pins1, int pin2, int pins3 = 0)
    {
        for (int i = 0; i < rolls; i++)
        {
            _bowlingGame.Roll(pins1, pin2, pins3);
        }
    }
    
    [Fact]
    public void TestGutterGame()
    {
        RollMany(10, 0, 0);
        Assert.Equal(0, _bowlingGame.Score());
    }
}