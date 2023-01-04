using OsuPlayer.Api.Data.API.EntityModels;

namespace OsuPlayer.Api.Data.API.RequestModels.Statistics;

public class UserStatsModel
{
    public UserModel User { get; set; }
    public ICollection<BeatmapTimesPlayedModel> Beatmaps { get; set; }
}