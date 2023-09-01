namespace OsuPlayer.Api.Data.API.RequestModels.Beatmap;

public class SearchBeatmapModel
{
    public string? Artist { get; set; }
    public string? Title { get; set; }
    public string? BeatmapSetId { get; set; }
    public string? BeatmapId { get; set; }
}