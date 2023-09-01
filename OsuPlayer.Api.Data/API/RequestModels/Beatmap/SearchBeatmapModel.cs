using OsuPlayer.Api.Data.API.EntityModels;

namespace OsuPlayer.Api.Data.API.RequestModels.Beatmap;

public class SearchBeatmapModel
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 64;
    public Func<BeatmapModel, bool>? Filter { get; set; } = null;
}