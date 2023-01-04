namespace OsuPlayer.Api.Data.API.EntityModels;

public class UserActivityModel : BaseModel
{
    public ulong SongsPlayed { get; set; }
    public ulong XpGained { get; set; }
    public DateTime Date { get; set; }
}