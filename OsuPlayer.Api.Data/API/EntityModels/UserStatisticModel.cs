namespace OsuPlayer.Api.Data.API.EntityModels;

public class UserStatisticModel : BaseModel
{
    public int UserId { get; set; }
    public int BeatmapId { get; set; }
    public int TimesPlayed { get; set; }
    public UserModel User { get; set; }
    public BeatmapModel Beatmap { get; set; }
}