using OsuPlayer.Api.Data.API.EntityModels;

namespace OsuPlayer.Api.Data.API.RequestModels.Statistics;

public class BeatmapTimesPlayedModel
{
    public BeatmapModel Beatmap { get; set; }
    public int TimesPlayed { get; set; }
    
    public string GetTitle => ToString();

    public string GetTimesPlayed => $"{TimesPlayed} times played";

    public override string ToString()
    {
        return $"{Beatmap.Artist} - {Beatmap.Title}";
    }
}