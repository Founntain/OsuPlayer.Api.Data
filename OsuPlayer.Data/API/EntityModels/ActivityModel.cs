namespace OsuPlayer.Data.API.EntityModels;

public class ActivityModel : BaseModel
{
    public int Month { get; set; }
    public int Year { get; set; }
    public int SongsPlayed { get; set; }
    public int XpGained { get; set; }
}