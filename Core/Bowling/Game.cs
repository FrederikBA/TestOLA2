using Core.Bowling;

public class Game
{
    private Frame[] frames = new Frame[10];
    private int currentFrameIndex = 0;

    public void Roll(int pins1, int pins2, int pins3 = 0)
    {
        if (frames[currentFrameIndex] == null)
        {
            frames[currentFrameIndex] = new Frame();
        }

        frames[currentFrameIndex].Roll = new Roll { Pins1 = pins1, Pins2 = pins2, Pins3 = pins3 };

        if (currentFrameIndex < 9 && (frames[currentFrameIndex].IsSpare || frames[currentFrameIndex].IsStrike))
        {
            currentFrameIndex++;
        }
        else if (currentFrameIndex == 9 && (frames[currentFrameIndex].IsSpare || frames[currentFrameIndex].IsStrike))
        {
            frames[currentFrameIndex].Roll.Pins2 = pins2;
            currentFrameIndex++;
        }
        else
        {
            frames[currentFrameIndex].Roll.Pins2 = pins2;
            currentFrameIndex++;
        }

        if (currentFrameIndex == 10 && (frames[currentFrameIndex - 1].IsSpare || frames[currentFrameIndex - 1].IsStrike))
        {
            frames[currentFrameIndex - 1].Roll.Pins2 = pins3;
        }
    }


    public int Score()
    {
        int score = 0;
        for (int frameIndex = 0; frameIndex < 10; frameIndex++)
        {
            var currentFrame = frames[frameIndex];
            var nextFrame1 = frameIndex + 1 < 10 ? frames[frameIndex + 1] : null;
            var nextFrame2 = frameIndex + 2 < 10 ? frames[frameIndex + 2] : null;

            if (currentFrame != null)
            {
                score += currentFrame.Score(nextFrame1, nextFrame2);
            }
        }

        return score;
    }
}