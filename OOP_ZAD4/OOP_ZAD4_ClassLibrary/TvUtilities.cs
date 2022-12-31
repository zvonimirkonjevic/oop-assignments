namespace OOP_ZAD4_ClassLibrary;

public static class TvUtilities
{

    public static double GenerateRandomScore()
    {
        Random generator = new Random();
        return generator.NextDouble() * (10 - 0) + 0;
    }

    public static List<Episode> LoadEpisodesFromFile(string fileName)
    {
        string[] episodesInputs = File.ReadAllLines(fileName);
        List<Episode> episodes = new List<Episode>();
        for (int i = 0; i < episodesInputs.Length; i++)
        {
            episodes.Add(Parse(episodesInputs[i]));
        }

        return episodes;
    }

    public static Episode Parse(string word)
    {
        string[] subs = word.Split(',');
        int ViewerCount = int.Parse(subs[0]);
        double ScoreSum = double.Parse(subs[1]);
        double MaximumScore = double.Parse(subs[2]);
        int EpisodeCount = int.Parse(subs[3]);
        TimeSpan Duration = TimeSpan.FromMinutes(int.Parse(subs[4]));
        string EpisodeName = subs[5];
        Description newDescription = new Description(EpisodeCount, Duration, EpisodeName);
        Episode newEpisode = new Episode(ViewerCount, ScoreSum, MaximumScore, newDescription);
        return newEpisode;
    }

    public static Episode[] Sort(Episode[] episodes)
    {
        int i, j, minIndex;
        Episode[] sorted = episodes;
        Episode temp;
        for (i = 0; i < sorted.Length; i++)
        {
            minIndex = i;
            for (j = i+1; j < sorted.Length; j++)
            {
                if (sorted[j] > sorted[minIndex])
                {
                    minIndex = j;
                }
            }

            temp = sorted[minIndex];
            sorted[minIndex] = sorted[i];
            sorted[i] = temp;
        }

        return sorted;
    }
}