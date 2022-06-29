namespace OsuPlayer.Data.API.RequestModels.Party;

public class CreatePartyModel
{
    public double PlaybackSpeed { get; set; }
    public double Timestamp { get; set; }
    public bool IsPaused { get; set; }
    
    public Guid? HostId { get; set; }
    public Guid? BeatmapId { get; set; }
}