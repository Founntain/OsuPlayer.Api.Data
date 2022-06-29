namespace OsuPlayer.Data.API.RequestModels.User;

public class UpdateXpModel
{
    public string Username { get; set; }
    public string SongChecksum { get; set; }
    public double ElapsedMilliseconds { get; set; }
    public double ChannelLength { get; set; }
}