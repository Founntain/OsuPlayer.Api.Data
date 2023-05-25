namespace OsuPlayer.Api.Data.API.EntityModels;

public class PartyModel : BaseModel
{
    public Guid HostId { get; set; }
    public DateTime LasteModified { get; set; }
    public double PlaybackSpeed { get; set; }
    public bool IsPaused { get; set; }
    public bool IsPrivate { get; set; }
    
    // Data we need for displaying purpose and if the beatmap doesn't exist on the api
    public string BeatmapHash { get; set; }
    public string FullSongname { get; set; }
    
    // In case we need it in the future
    public BeatmapModel Beatmap { get; set; }
    
    public HashSet<UserModel> UsersInParty { get; set; }
}