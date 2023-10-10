namespace Core.Bowling;

public class Frame
{
    public Roll Roll { get; set; }

    public bool IsSpare => Roll.Pins1 + Roll.Pins2 == 10;
    public bool IsStrike => Roll.Pins1 == 10;

    public int Score(Frame nextFrame1, Frame nextFrame2)
    {
        int score = Roll.Pins1 + Roll.Pins2 + Roll.Pins3; // Update score calculation

        if (IsSpare)
        {
            score += nextFrame1?.Roll.Pins1 ?? 0;
        }
        else if (IsStrike)
        {
            score += (nextFrame1?.Roll.Pins1 ?? 0) + (nextFrame2?.Roll.Pins1 ?? 0);

            if (nextFrame1?.IsStrike ?? false)
            {
                score += nextFrame2?.Roll.Pins1 ?? 0;
            }
        }

        return score;
    }
}