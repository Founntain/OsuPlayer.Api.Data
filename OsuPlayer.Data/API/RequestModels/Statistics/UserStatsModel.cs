using OsuPlayer.Data.API.EntityModels;

namespace OsuPlayer.Data.API.RequestModels.Statistics;

public class UserStatsModel
{
    public UserModel User { get; set; }
    public ICollection<BeatmapTimesPlayedModel> Beatmaps { get; set; }
}