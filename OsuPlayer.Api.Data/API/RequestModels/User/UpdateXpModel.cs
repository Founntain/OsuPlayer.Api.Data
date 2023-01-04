namespace OsuPlayer.Api.Data.API.RequestModels.User;

public class UpdateXpModel
{
    public required string SongChecksum { get; set; }
    public required double ElapsedMilliseconds { get; set; }
    public required double ChannelLength { get; set; }
}