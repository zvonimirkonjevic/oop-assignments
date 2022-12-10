namespace OOP_ZAD3_ClassLibrary;

public class Description
{
    private int episodeCount;
    private TimeSpan episodeDuration;
    private string episodeName;

    public Description(int count, TimeSpan duration, string name)
    {
        episodeCount = count;
        episodeDuration = duration;
        episodeName = name;
    }

    public int EpisodeCount
    {
        get => episodeCount;
        set => episodeCount = value;
    }

    public TimeSpan EpisodeDuration
    {
        get => episodeDuration;
        set => episodeDuration = value;
    }

    public string EpisodeName
    {
        get => episodeName;
        set => episodeName = value;
    }

    public override string ToString()
    {
        return $"{episodeCount},{episodeDuration},{episodeName}";
    }
}