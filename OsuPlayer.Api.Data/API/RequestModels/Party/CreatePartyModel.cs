namespace OsuPlayer.Api.Data.API.RequestModels.Party;

public class CreatePartyModel
{
    public double PlaybackSpeed { get; set; }
    public bool UsePitch { get; set; }
    public double Timestamp { get; set; }
    public bool IsPaused { get; set; }
    
    public Guid? HostId { get; set; }
    public Guid? BeatmapId { get; set; }
    
    public string BeatmapHash { get; set; }
    public string FullSongname { get; set; }
}