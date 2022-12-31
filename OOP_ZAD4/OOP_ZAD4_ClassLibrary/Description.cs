namespace OOP_ZAD4_ClassLibrary;

public class Description
{
    public int episodeCount;
    public TimeSpan episodeDuration;
    public string episodeName;

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

    public Description(Description other)
    {
        this.episodeCount = other.episodeCount;
        this.episodeDuration = other.EpisodeDuration;
        this.episodeName = other.episodeName;
    }
}