using OsuPlayer.Api.Data.API.EntityModels;

namespace OsuPlayer.Api.Data.API.ResponseModels;

public class BeatmapSearchResponse
{
    public int TotalBeatmaps { get; set; }
    public int CurrentPage  { get; set; }
    public int TotalPages   { get; set; }
    
    public ICollection<BeatmapModel> Beatmaps { get; set; }
}