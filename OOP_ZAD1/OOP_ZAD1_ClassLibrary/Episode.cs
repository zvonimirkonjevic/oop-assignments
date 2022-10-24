namespace OOP_ZAD1_ClassLibrary;

public class Episode
{
    private int viewerCount;
    private double scoreSum;
    private double maxScore;

    public Episode()
    {
        this.viewerCount = 0;
        this.scoreSum = 0.0;
        this.maxScore = 0.0;
    }

    public Episode(int viewerCount, double scoreSum, double maxScore)
    {
        this.viewerCount = viewerCount;
        this.scoreSum = scoreSum;
        this.maxScore = maxScore;
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
}