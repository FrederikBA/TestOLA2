namespace Core.Bowling;

public class Game
{
    private int[] Rolls = new int[21];
    private int CurrentRoll;
    
    public void Roll(int pins)
    {
        Rolls[CurrentRoll++] = pins;   
    }

    public int Score()
    {
        int score = 0;
        int roll = 0;

        for (int frame = 0; frame < 10; frame++)
        {
            if (Rolls[roll] == 10) //strike
            {
                score += 10 + StrikeBonus(roll);
                roll++;
            }
            else if (IsSpare(roll))
            {
                score += 10 + SpareBonus(roll);
                roll += 2;
            }
            else
            {
                score += SumOfBallsInFrame(roll);
                roll += 2;
            }
        }
        
        return score;
    }

    private bool IsSpare(int roll)
    {
        return Rolls[roll] + Rolls[roll + 1] == 10;
    }

    private int SumOfBallsInFrame(int roll)
    {
        return Rolls[roll] + Rolls[roll + 1];
    }

    private int SpareBonus(int roll)
    {
        return Rolls[roll + 2];
    }
    
    private int StrikeBonus(int roll)
    {
        return Rolls[roll + 1] + Rolls[roll + 2];
    }
}