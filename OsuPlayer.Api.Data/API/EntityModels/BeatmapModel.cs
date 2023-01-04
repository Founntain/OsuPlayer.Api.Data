namespace OsuPlayer.Api.Data.API.EntityModels;

public class BeatmapModel : BaseModel
{
    public int BeatmapSetId { get; set; }
    public int BeatmapId { get; set; }
    public string BeatmapChecksum { get; set; }
    public string Artist { get; set; }
    public string ArtistUnicode { get; set; }
    public string Title { get; set; }
    public string TitleUnicode { get; set; }
    public string Creator { get; set; }
    public int TimesPlayed { get; set; }
    public UserModel LastPlayedBy { get; set; }
}