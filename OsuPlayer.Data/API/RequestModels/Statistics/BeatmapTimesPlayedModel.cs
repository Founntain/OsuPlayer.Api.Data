using OsuPlayer.Data.API.EntityModels;

namespace OsuPlayer.Data.API.RequestModels.Statistics;

public class BeatmapTimesPlayedModel
{
    public BeatmapModel Beatmap { get; set; }
    public int TimesPlayed { get; set; }
}