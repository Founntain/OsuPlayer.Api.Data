namespace OsuPlayer.Api.Data.API.RequestModels.Statistics;

public class PostUserStatisticModel
{
    public Guid UserId { get; set; }
    public Guid BeatmapId { get; set; }
}