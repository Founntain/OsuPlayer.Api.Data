namespace OsuPlayer.Data.API.EntityModels;

public class PartyModel : BaseModel
{
    public Guid HostId { get; set; }
    public DateTime LasteModified { get; set; }
    public double PlaybackSpeed { get; set; }
    public bool IsPaused { get; set; }
    public bool IsPrivate { get; set; }
    
    public BeatmapModel Beatmap { get; set; }
    public HashSet<UserModel> UsersInParty { get; set; }
}