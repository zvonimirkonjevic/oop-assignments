using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Text;

namespace OOP_ZAD4_ClassLibrary;

public class Season : IEnumerable<Episode>
{
    private int seasonNumber;
    private List<Episode> episodes;
    public Season(int SeasonNumber, List<Episode> Episodes)
    {
        this.seasonNumber = SeasonNumber;
        this.episodes = Episodes;
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
            return this.episodes[index];
        }
        set
        {
            this.episodes[index] = value;
        }
    }
    
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append($"Season {this.seasonNumber}: ").Append(Environment.NewLine);
        builder.Append("=================================================").Append(Environment.NewLine);
        foreach (var episode in this.episodes)
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

    public Season(Season other)
    {
        this.seasonNumber = other.seasonNumber;
        this.episodes = new List<Episode>();
        foreach (var episode in other)
        {
            episodes.Add(new Episode(episode));
        }
    }

    public void Add(Episode episode)
    {
        episodes.Add(episode);
    }

    public void Remove(string episodeTitle)
    {
        bool existanceChecker = false;
        for (int i = 0; i < episodes.Count(); i++)
        {
            if (episodeTitle == episodes[i].GetTitle())
            {
                episodes.Remove(episodes[i]);
                existanceChecker = true;
            }
        }

        if (!existanceChecker)
        {
            throw new TvException(episodeTitle, "No such episode found.");
        }
    }
    
    public IEnumerator<Episode> GetEnumerator()
    {
        return ((IEnumerable<Episode>)episodes).GetEnumerator();
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}