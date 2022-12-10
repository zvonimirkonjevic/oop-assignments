using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OOP_ZAD3_ClassLibrary;

public class Season
{
    private int seasonNumber;
    private List<Episode> episodes = new List<Episode>();
    public int Length { get; private set; }

    public Season(int SeasonNumber, Episode[] episodes)
    {
        seasonNumber = SeasonNumber;
        for (int i = 0; i < episodes.Length; i++)
        {
            this.episodes.Add(episodes[i]);
        }

        Length = episodes.Length;
    }

    public int GetTotalViewers()
    {
        int viewerSum = 0;
        for (int i = 0; i < episodes.Count; i++)
        {
            viewerSum += episodes[i].GetViewerCount();
        }

        return viewerSum;
    }

    public TimeSpan GetTotalDuration()
    {
        TimeSpan durationSum = TimeSpan.Zero;
        for (int i = 0; i < episodes.Count; i++)
        {
            durationSum += episodes[i].GetEpisodeDuration();
        }

        return durationSum;
    }

    public DateTime GetBingeEnd()
    {
        return DateTime.Now + GetTotalDuration();
    }

    public Episode this[int index]
    {
        get
        {
            return episodes[index];
        }
        set
        {
            episodes[index] = value;
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append($"Season {seasonNumber}: ").Append(Environment.NewLine);
        builder.Append("=================================================").Append(Environment.NewLine);
        foreach (var episode in episodes)
        {
            builder.Append(episode).Append(Environment.NewLine);
        }
        builder.Append("Report: ").Append(Environment.NewLine);
        builder.Append("=================================================").Append(Environment.NewLine);
        builder.Append($"Total viewers: {GetTotalViewers()}").Append(Environment.NewLine);
        builder.Append($"Total duration: {GetTotalDuration()}").Append(Environment.NewLine);
        builder.Append("=================================================").Append(Environment.NewLine);
        return builder.ToString();
    }
}