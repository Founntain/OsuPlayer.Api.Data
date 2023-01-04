using OsuPlayer.Api.Data.API.Enums;

namespace OsuPlayer.Api.Data.API.EntityModels;

public class UserOnlineStatusModel
{
    public UserOnlineStatusType StatusType { get; set; }
    public string? Song { get; set; }
    public string? SongChecksum { get; set; }
}