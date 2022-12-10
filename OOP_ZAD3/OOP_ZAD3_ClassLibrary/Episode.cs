namespace OOP_ZAD3_ClassLibrary;

public class Episode
{
    private int viewerCount;
    private double scoreSum;
    private double maxScore;
    private Description description;

    public Episode(int viewerCount, double scoreSum, double maxScore, Description description)
    {
        this.viewerCount = viewerCount;
        this.scoreSum = scoreSum;
        this.maxScore = maxScore;
        this.description = description;
    }

    public void AddView(double score)
    {
        viewerCount++;
        scoreSum += score;
        if (maxScore < score)
        {
            maxScore = score;
        }
    }

    public double GetMaxScore()
    {
        return this.maxScore;
    }

    public double GetAverageScore()
    {
        return (this.scoreSum / this.viewerCount);
    }

    public int GetViewerCount()
    {
        return this.viewerCount;
    }

    public override string ToString()
    {
        return $"{viewerCount},{scoreSum},{maxScore},{description.ToString()}";
    }
    public TimeSpan GetEpisodeDuration()
    {
        return description.EpisodeDuration;
    }
    
    public static bool operator >(Episode leftSide, Episode rightSide)
    {
        if (leftSide.GetAverageScore() > rightSide.GetAverageScore())
        {
            return true;
        }

        return false;
    }

    public static bool operator <(Episode leftSide, Episode rightSide)
    {
        return !(leftSide > rightSide);
    }

    public static bool operator >=(Episode leftSide, Episode rightSide)
    {
        if (leftSide.GetAverageScore() >= rightSide.GetAverageScore())
        {
            return true;
        }

        return false;
    }

    public static bool operator <=(Episode leftSide, Episode rightSide)
    {
        return !(leftSide >= rightSide);
    }
}