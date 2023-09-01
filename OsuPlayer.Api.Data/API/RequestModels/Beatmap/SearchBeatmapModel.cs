using OsuPlayer.Api.Data.API.EntityModels;

namespace OsuPlayer.Api.Data.API.RequestModels.Beatmap;

public class SearchBeatmapModel
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public Func<BeatmapModel, bool>? Filter { get; set; } = null;
}