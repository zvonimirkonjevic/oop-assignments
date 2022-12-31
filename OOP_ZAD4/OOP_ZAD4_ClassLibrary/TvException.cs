using System.Runtime.Serialization;

namespace OOP_ZAD4_ClassLibrary;

public class TvException : Exception
{
    public string Title { get; }
    public TvException(string episodeTitle, string message) : base(message)
    {
        Title = episodeTitle;
    }
}