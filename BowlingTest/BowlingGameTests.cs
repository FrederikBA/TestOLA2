using Core.Bowling;

namespace BowlingTest;

public class BowlingGameTests
{
    private readonly Game _bowlingGame;

    public BowlingGameTests()
    {
        _bowlingGame = new Game();
    }
    
    
    [Fact]
    public void TestGutterGame()
    {
        RollMany(20, 0);

        
        Assert.Equal(0, _bowlingGame.Score());
    }

    [Fact]
    public void TestAllOnes()
    {
        RollMany(20, 1);
        
        Assert.Equal(20, _bowlingGame.Score());
    }
    
    [Fact]
    public void TestOneSpare()
    {
        RollSpare();
        _bowlingGame.Roll(3);
        RollMany(17, 0);
        
        Assert.Equal(16, _bowlingGame.Score());
    }
    
    [Fact]
    public void TestOneStrike()
    {
        RollStrike();
        _bowlingGame.Roll(3);
        _bowlingGame.Roll(4);
        RollMany(16, 0);
        
        Assert.Equal(24, _bowlingGame.Score());
    }
    
    [Fact]
    public void TestPerfectGame()
    {
        RollMany(12, 10);
        
        Assert.Equal(300, _bowlingGame.Score());
    }
    
    //Helper method
    private void RollMany(int rolls, int pins)
    {
        for (int i = 0; i < rolls; i++)
        {
            _bowlingGame.Roll(pins);
        }
    }
    
    //Helper method
    private void RollSpare()
    {
        _bowlingGame.Roll(5);
        _bowlingGame.Roll(5);
    }
    
    //Helper method
    private void RollStrike()
    {
        _bowlingGame.Roll(10);
    }
}