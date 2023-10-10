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
    
    //Helper method
    private void RollSpare()
    {
        _bowlingGame.Roll(6,4);
    }
    
    [Fact]
    public void TestGutterGame()
    {
        RollMany(10, 0, 0);
        Assert.Equal(0, _bowlingGame.Score());
    }
    
    [Fact]
    public void TestAllOnes()
    {
        RollMany(10, 1, 0);
        Assert.Equal(10, _bowlingGame.Score());
    }
    
    [Fact]
    public void TestOneSpare()
    {
        RollSpare();
        _bowlingGame.Roll(3, 0);
        RollMany(8, 0, 0);
        Assert.Equal(16, _bowlingGame.Score());
    }
    
    [Fact]
    public void TestOneStrike()
    {
        _bowlingGame.Roll(10, 0);
        _bowlingGame.Roll(4, 0);
        _bowlingGame.Roll(5, 0);
        RollMany(7, 1, 0);
        Assert.Equal(30, _bowlingGame.Score());
    }
}